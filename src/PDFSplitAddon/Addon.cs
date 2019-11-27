using Infragistics.Win.UltraWinToolbars;
using SwissAcademic.Citavi.Controls.Wpf;
using SwissAcademic.Citavi.Shell;
using SwissAcademic.Citavi.Shell.Controls.Preview;
using SwissAcademic.Controls;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PDFSplit
{
    public class Addon : CitaviAddOn<MainForm>
    {
        #region Constants

        const string Keys_Button_ShowPdfSplitDialog = "PDFSplit.Button_ShowPdfSplitDialog";

        #endregion

        #region Fields

        CommandbarButton _button;

        #endregion

        #region Methods

        public override void OnApplicationIdle(MainForm mainForm)
        {
            if (_button != null)
            {
                var selectedElectronicLocations = mainForm.GetSelectedElectronicLocations();
                var selectedReferences = mainForm.GetSelectedReferences();
                var reference = mainForm.ActiveReference;

                if (selectedElectronicLocations.Count == 1 && selectedReferences.Count == 1 && reference != null)
                {
                    var location = selectedElectronicLocations.FirstOrDefault();

                    if (location != null)
                    {
                        var path = location.Address.Resolve().GetLocalPathSafe();

                        if (!string.IsNullOrEmpty(path))
                        {
                            _button.Visible = path.EndsWith("pdf") && reference.ChildReferences.Count != 0;

                            base.OnApplicationIdle(mainForm);
                            return;
                        }
                    }
                }

                _button.Visible = false;
            }

            base.OnApplicationIdle(mainForm);
        }

        public override void OnHostingFormLoaded(MainForm mainForm)
        {
            if (!mainForm.IsPreviewFullScreenForm && mainForm.Project.ProjectType == SwissAcademic.Citavi.ProjectType.DesktopSQLite)
            {
                if (mainForm.ReferenceEditorElectronicLocationsToolbarsManager?.Tools.Cast<ToolBase>().FirstOrDefault(tool => tool.Key.Equals("ReferenceEditorUriLocationsContextMenu")) is PopupMenuTool popupMenu)
                {
                    var menu = CommandbarMenu.Create(popupMenu);
                    _button = menu.InsertCommandbarButton(3, Keys_Button_ShowPdfSplitDialog, Properties.Resources.Addon_Command_Caption, image: Properties.Resources.CommandIcon);
                }
            }
            base.OnHostingFormLoaded(mainForm);
        }

        public override void OnBeforePerformingCommand(MainForm mainForm, BeforePerformingCommandEventArgs e)
        {
            if (e.Key.Equals(Keys_Button_ShowPdfSplitDialog, StringComparison.OrdinalIgnoreCase))
            {
                var locations = mainForm.GetSelectedElectronicLocations();

                if (locations.Count == 1)
                {
                    var pdfViewControl = mainForm.PreviewControl.GetProperty<PreviewControl, PdfViewControl>(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public, "PdfViewControl");

                    if (pdfViewControl.Location == locations.First())
                    {
                        var document = pdfViewControl.Document;

                        if (document.PermissionExtractContent)
                        {
                            using (var form = new PDFSplitForm(mainForm, mainForm.ActiveReference, document)) form.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(mainForm, Properties.Resources.Message_ExtractPermissionError, Properties.Resources.MessageBox_Title_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(mainForm, Properties.Resources.Message_OpenInPreview, Properties.Resources.MessageBox_Title_Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                e.Handled = true;
            }

            base.OnBeforePerformingCommand(mainForm, e);
        }

        public override void OnLocalizing(MainForm form)
        {
            if (_button != null) _button.Text = Properties.Resources.Addon_Command_Caption;

            base.OnLocalizing(form);
        }

        #endregion
    }
}
