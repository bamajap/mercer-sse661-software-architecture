using Excel = Microsoft.Office.Interop.Excel;

namespace FavoriteHomes.Microkernel.InternalServers
{
    public class SpreadsheetWrapperFacade
    {
        private readonly Excel.Application _app;

        public WorkbookWrapperFacade Workbook { get; private set; }

        public SpreadsheetWrapperFacade(int sheetsInNewWorkbook)
        {
            _app = new Excel.Application
                   {
                       Visible = true,
                       SheetsInNewWorkbook = sheetsInNewWorkbook
                   };

            Workbook = new WorkbookWrapperFacade(_app.Workbooks.Add());

            var activeSheet = (Excel.Worksheet)_app.ActiveSheet;
            var headerRow = (Excel.Range)activeSheet.Rows[1];
            headerRow.Font.Bold = true;
        }

        public WorkbookWrapperFacade AddNewWorkbook()
        {
            return new WorkbookWrapperFacade(_app.Workbooks.Add());
        }

        public void Quit()
        {
            _app.Quit();
        }
    }


    internal class OfficeExcel
    {
    }

    internal class OpenOfficeCalc { }

    internal class FreeOfficePlanMaker { }
}
