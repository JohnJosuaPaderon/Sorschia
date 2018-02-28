namespace Sorschia.OpenSpreadsheet
{
    public sealed class ORange
    {
        internal ORange(OWorksheet worksheet)
        {
            Worksheet = worksheet;
            Cells = new OCellCollection(this);
        }

        private OWorksheet Worksheet { get; }
        public OCellCollection Cells { get; }
    }
}
