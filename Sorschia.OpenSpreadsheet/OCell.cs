namespace Sorschia.OpenSpreadsheet
{
    public sealed class OCell
    {
        internal OCell(ORange range)
        {
            Range = range;
            Address = new OCellAddress();
        }

        private ORange Range { get; }
        public bool IsMerged { get; internal set; }
        public OCellAddress Address { get; }
        public object Value { get; }
    }

    public sealed class OCellAddress
    {

    }
}
