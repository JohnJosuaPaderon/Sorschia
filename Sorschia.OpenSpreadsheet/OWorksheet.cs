namespace Sorschia.OpenSpreadsheet
{
    public sealed class OWorksheet
    {
        internal OWorksheet(OWorkbook workbook)
        {
            Workbook = workbook;
            Ranges = new ORangeCollection(this);
        }

        private OWorkbook Workbook { get; }
        public ORangeCollection Ranges { get; }
    }
}
