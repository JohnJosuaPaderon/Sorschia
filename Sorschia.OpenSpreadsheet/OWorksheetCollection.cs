using System.Collections;
using System.Collections.Generic;

namespace Sorschia.OpenSpreadsheet
{
    public sealed class OWorksheetCollection : IEnumerable<OWorksheet>
    {
        internal OWorksheetCollection(OWorkbook workbook)
        {
            Workbook = workbook;
            Worksheets = new List<OWorksheet>();
        }

        private OWorkbook Workbook { get; }
        private List<OWorksheet> Worksheets { get; }

        public IEnumerator<OWorksheet> GetEnumerator()
        {
            return Worksheets.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
