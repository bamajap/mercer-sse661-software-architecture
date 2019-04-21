using Excel = Microsoft.Office.Interop.Excel;

namespace FavoriteHomes.Microkernel.InternalServers
{
    public class RangeWrapperFacade
    {
        private readonly Excel.Worksheet _worksheet;

        private string value;

        internal RangeWrapperFacade(Excel.Worksheet worksheet)
        {
            _worksheet = worksheet;
        }

        public object this[int row = 0, int col = 0]
        {
            get { return _worksheet.Cells[row, col]; }
            set { _worksheet.Cells[row, col] = value; }
        }
    }
}