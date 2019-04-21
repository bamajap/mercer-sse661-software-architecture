using Excel = Microsoft.Office.Interop.Excel;

namespace FavoriteHomes.Microkernel.InternalServers
{
    public class WorksheetWrapperFacade
    {
        private Excel.Worksheet _worksheet;
        public RangeWrapperFacade Cells { get; private set; }

        internal WorksheetWrapperFacade(Excel.Worksheet worksheet)
        {
            _worksheet = worksheet;
            Cells = new RangeWrapperFacade(worksheet);
        }

        public void AutoFitColumns()
        {
            _worksheet.Columns.AutoFit();
        }
    }
}