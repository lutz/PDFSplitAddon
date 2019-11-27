using SwissAcademic;
using SwissAcademic.Citavi;

namespace PDFSplit
{
    public class ReferenceWrapper
    {
        #region Constructors

        public ReferenceWrapper(Reference reference)
        {
            Reference = reference;
            StartPage = ReadNumber(Reference.PageRange, true);
            EndPage = ReadNumber(Reference.PageRange, false);
        }

        #endregion

        #region Properties

        public int StartPage { get; set; }

        public int EndPage { get; set; }

        public Reference Reference { get; }

        #endregion

        #region Methods

        int ReadNumber(PageRange pageRange, bool isStartPage)
        {
            if (pageRange == null) return 1;

            if (isStartPage)
            {
                if (pageRange.StartPage == null) return 1;
                if (pageRange.StartPage.Number == null) return 1;
                return pageRange.StartPage.Number.GetValueOrDefault(1);
            }
            else
            {
                if (pageRange.EndPage == null) return 1;
                if (pageRange.EndPage.Number == null) return 1;
                return pageRange.EndPage.Number.GetValueOrDefault(1);
            }
        }

        public override string ToString()
        {
            return Reference.ToString();
        }

        #endregion
    }
}