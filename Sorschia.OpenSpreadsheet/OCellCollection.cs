using System.Collections;
using System.Collections.Generic;

namespace Sorschia.OpenSpreadsheet
{
    public sealed class OCellCollection : IEnumerable<OCell>
    {
        internal OCellCollection(ORange range)
        {
            Range = range;
            Cells = new List<OCell>();
        }

        private ORange Range { get; }
        private List<OCell> Cells { get; }

        public IEnumerator<OCell> GetEnumerator()
        {
            return Cells.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
