namespace PDFSplit
{
    public class PageLabelWrapper
    {
        #region Constructors

        public PageLabelWrapper(int physicalPageNumber, string logicalPageNumber)
        {
            PysicalPageNumber = physicalPageNumber;
            LogicalPageNumber = logicalPageNumber;
        }

        #endregion

        #region Properties

        public int PysicalPageNumber { get;  }

        public string LogicalPageNumber { get; }

        #endregion
    }
}