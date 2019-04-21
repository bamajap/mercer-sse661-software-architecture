using FavoriteHomes.Microkernel.InternalServers;

namespace FavoriteHomes.Microkernel
{
    public class SpreadsheetApp
    {
        private readonly SpreadsheetWrapperFacade _app;

        public Workbook Workbook { get; private set; }

        private SpreadsheetApp()
        {
        }

        public SpreadsheetApp(int sheetsInNewWorkbook)
            : this()
        {
            _app = new SpreadsheetWrapperFacade(sheetsInNewWorkbook);
            Workbook = new Workbook(_app.Workbook);
        }

        public void Quit()
        {
            foreach (WorksheetWrapperFacade worksheet in _app.Workbook.Worksheets)
            {
                worksheet.AutoFitColumns();
            }
            _app.Quit();
        }
    }
}