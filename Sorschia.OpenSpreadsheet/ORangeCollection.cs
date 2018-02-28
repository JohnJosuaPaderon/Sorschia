using System.Collections;
using System.Collections.Generic;

namespace Sorschia.OpenSpreadsheet
{
    public sealed class ORangeCollection : IEnumerable<ORange>
    {
        internal ORangeCollection(OWorksheet worksheet)
        {
            Worksheet = worksheet;
            Ranges = new List<ORange>();
        }

        private OWorksheet Worksheet { get; }
        private List<ORange> Ranges { get; }

        public IEnumerator<ORange> GetEnumerator()
        {
            return Ranges.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
