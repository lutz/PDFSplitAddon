using SwissAcademic;
using SwissAcademic.Citavi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwissAcademic.Pdf;
using SwissAcademic.Controls;

namespace PDFSplit
{
    public partial class PDFSplitForm : FormBase
    {
        #region Fields

        Reference _reference;
        Document _document;

        Bitmap _bigViewImage;
        Bitmap _currentImage;
        int _currentPage;
        int _pageCount;

        List<PageLabelWrapper> _pageLabels = new List<PageLabelWrapper>();

        #endregion

        #region Constructors

        public PDFSplitForm(Form form, Reference reference, Document document)
        {
            InitializeComponent();
            Icon = form.Icon;

            _reference = reference;
            _document = document;
            tbStart.Minimum = 1;
            tbEnd.Minimum = 1;
            _pageCount = _document.GetPageCount();
            tbStart.Maximum = _document.GetPageCount();
            tbEnd.Maximum = _document.GetPageCount();
            tbPages.Minimum = 1;
            tbPages.Maximum = _pageCount;
            _currentPage = 1;
            tbControl.SelectedTab = tbMain;

            Localize();

            InitializePageLabels();
            InitializeReferences();
            UpdateButtonState();
            UpdatePreviewBox();
            UpdatePageCounter();

        }

        #endregion

        #region Eventhandler

        protected override void OnApplicationIdle()
        {

            btnOk.Enabled = lbReferences.CheckedItems.Count > 0;
            base.OnApplicationIdle();
        }


        void Window_Closed(object sender, FormClosedEventArgs e)
        {
            if (_currentImage != null) _currentImage.Dispose();

            if (_bigViewImage != null) _bigViewImage.Dispose();
        }

        void BtnPrevPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;

                UpdatePreviewBox();
                UpdateButtonState();
                UpdatePageCounter();
                UpdateTrackbar();
            }
        }

        void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage < _pageCount)
            {
                _currentPage++;

                UpdatePreviewBox();
                UpdateButtonState();
                UpdatePageCounter();
                UpdateTrackbar();
            }
        }

        void BtnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

        void BtnSetAsStart_Click(object sender, EventArgs e) => tbStart.Value = _currentPage;

        void BtnSetAsEnd_Click(object sender, EventArgs e) => tbEnd.Value = _currentPage;

        void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var wrapper in lbReferences.CheckedItems.Cast<ReferenceWrapper>())
                {
                    var tempPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetRandomFileName() + ".pdf");

                    var minPage = Math.Min(wrapper.StartPage, wrapper.EndPage);
                    var maxPage = Math.Max(wrapper.StartPage, wrapper.EndPage);

                    using (var newDoc = new pdftron.PDF.PDFDoc())
                    {
                        using (var sdfDoc = newDoc.GetSDFDoc())
                        {
                            newDoc.InsertPages(0, _document, minPage, maxPage, pdftron.PDF.PDFDoc.InsertFlag.e_insert_bookmark);

                            var index = minPage - 1;

                            for (int i = minPage; i <= maxPage; i++)
                            {
                                var pos = i - index;

                                var currentLabel = _document.GetPageLabel(i);

                                if (!currentLabel.IsValid()) continue;

                                var newPageLabel = pdftron.PDF.PageLabel.Create(sdfDoc, currentLabel.GetStyle(), currentLabel.GetPrefix(), i);

                                newDoc.SetPageLabel(pos, newPageLabel);
                            }
                        }

                        newDoc.Save(tempPath, pdftron.SDF.SDFDoc.SaveOptions.e_linearized);
                    }

                    var proposeLocalFilePath = wrapper.Reference.ProposeLocalFilePath(tempPath);
                    System.IO.File.Move(tempPath, proposeLocalFilePath);

                    wrapper.Reference.Locations.Add(LocationType.ElectronicAddress, proposeLocalFilePath);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(this, exp.ToString(), Properties.Resources.MessageBox_Title_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult = DialogResult.OK;
        }

        void LbReferences_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbReferences.SelectedItem is ReferenceWrapper current_reference)
            {
                tbStart.Value = current_reference.StartPage;
                tbEnd.Value = current_reference.EndPage;
            }
        }

        void tbStart_ValueChanged(object sender, EventArgs e)
        {
            var current_reference = lbReferences.SelectedItem as ReferenceWrapper;

            if (current_reference != null)
            {
                current_reference.StartPage = System.Convert.ToInt32(tbStart.Value);
            }
        }

        void TbEnd_ValueChanged(object sender, EventArgs e)
        {

            if (lbReferences.SelectedItem is ReferenceWrapper current_reference)
            {
                current_reference.EndPage = System.Convert.ToInt32(tbEnd.Value);
            }
        }

        void TbPages_ValueChanged(object sender, EventArgs e)
        {
            _currentPage = tbPages.Value;

            UpdateButtonState();
            UpdatePageCounter();
            UpdatePreviewBox();
        }

        void PbShowBigBox_Click(object sender, EventArgs e)
        {
            Location = new Point(this.Location.X - 4, this.Location.Y - 55);
            Size = new Size(501, 700);

            tbControl.SelectedTab = tbView;

            _bigViewImage = _document.GetImage(_currentPage);

            pbBigView.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBigView.Image = _bigViewImage;


        }

        void PbHideBox_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X + 4, Location.Y + 55);
            Size = new Size(558, 590);

            tbControl.SelectedTab = tbMain;

            if (_bigViewImage != null)
            {
                _bigViewImage.Dispose();
                _bigViewImage = null;
            }
        }

        #endregion

        #region Methods

        public override void Localize()
        {
            base.Localize();

            Text = Properties.Resources.Window_Text;
            label1.Text = Properties.Resources.Label_Text_From;
            label2.Text = Properties.Resources.Label_Text_To;
            btnOk.Text = Properties.Resources.Button_Text_Ok;
            btnCancel.Text = Properties.Resources.Button_Text_Cancel;
        }

        void InitializeReferences()
        {
            foreach (var reference in _reference.ChildReferences.ToList().OrderBy(r => GetPageNumber(r.PageRange)))
            {
                var wrapper = new ReferenceWrapper(reference);
                UpdateWrapper(wrapper);
                lbReferences.Items.Add(wrapper);
            }

            lbReferences.SelectedItem = lbReferences.Items.Cast<ReferenceWrapper>().FirstOrDefault();
        }

        void InitializePageLabels()
        {
            for (int i = 1; i <= _pageCount; i++)
            {
                var label = _document.GetPageLabel(i);
                if (label.IsValid())
                {
                    var text = label.GetLabelTitle(i);
                    _pageLabels.Add(new PageLabelWrapper(i, string.IsNullOrEmpty(text) ? string.Empty : text));
                }
                else
                {
                    _pageLabels.Add(new PageLabelWrapper(i, string.Empty));
                }
            }
        }

        int GetPageNumber(PageRange pageRange)
        {
            if (pageRange == null) return 1;
            if (pageRange.StartPage == null) return 1;
            if (pageRange.StartPage.Number == null) return 1;

            return pageRange.StartPage.Number.GetValueOrDefault(1);
        }

        void UpdatePreviewBox()
        {
            if (_currentImage != null) _currentImage.Dispose();

            _currentImage = _document.GetImage(_currentPage);

            previewBox.SizeMode = PictureBoxSizeMode.StretchImage;
            previewBox.Image = _currentImage;
        }

        void UpdateButtonState()
        {
            if (_currentPage == 1) btnPrevPage.Enabled = false;
            else btnPrevPage.Enabled = true;

            if (_currentPage == _pageCount) btnNextPage.Enabled = false;
            else btnNextPage.Enabled = true;
        }

        void UpdatePageCounter()
        {
            var logicStartNumber = _document.GetPageLabelTextOrDefault(_currentPage, string.Empty).AddSuffix(")").AddPräfix("(");
            var logicEndNumber = _document.GetPageLabelTextOrDefault(_pageCount, string.Empty).AddSuffix(")").AddPräfix("(");

            lblPageCounter.Text = string.Format(Properties.Resources.Label_Text_PageFromTo, _currentPage, logicStartNumber, _pageCount, logicEndNumber);
        }

        void UpdateTrackbar()
        {
            tbPages.Value = _currentPage;
        }

        void UpdateWrapper(ReferenceWrapper pageWrapper)
        {
            var startPageLabelWrapper = _pageLabels.FirstOrDefault(x => x.LogicalPageNumber.Equals(pageWrapper.StartPage.ToString(), StringComparison.Ordinal));
            var endPageLabelWrapper = _pageLabels.FirstOrDefault(x => x.LogicalPageNumber.Equals(pageWrapper.EndPage.ToString(), StringComparison.Ordinal));

            if (startPageLabelWrapper != null && endPageLabelWrapper != null)
            {
                pageWrapper.StartPage = startPageLabelWrapper.PysicalPageNumber;
                pageWrapper.EndPage = endPageLabelWrapper.PysicalPageNumber;
            }
            else if (startPageLabelWrapper != null && endPageLabelWrapper == null)
            {
                pageWrapper.StartPage = startPageLabelWrapper.PysicalPageNumber;
            }
            else if (startPageLabelWrapper == null && endPageLabelWrapper != null)
            {
                pageWrapper.EndPage = endPageLabelWrapper.PysicalPageNumber;
            }

            if (pageWrapper.StartPage < 1) pageWrapper.StartPage = 1;
            if (pageWrapper.StartPage > _pageCount) pageWrapper.StartPage = _pageCount;
            if (pageWrapper.EndPage < 1) pageWrapper.EndPage = 1;
            if (pageWrapper.EndPage > _pageCount) pageWrapper.EndPage = _pageCount;
        }

        #endregion
    }
}
