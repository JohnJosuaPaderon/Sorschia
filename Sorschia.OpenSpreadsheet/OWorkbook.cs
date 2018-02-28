namespace Sorschia.OpenSpreadsheet
{
    public sealed class OWorkbook
    {
        internal OWorkbook(OSpreadsheet spreadsheet)
        {
            Spreadsheet = spreadsheet;
            Worksheets = new OWorksheetCollection(this);
        }

        private OSpreadsheet Spreadsheet { get; }
        public OWorksheetCollection Worksheets { get; }
    }
}
