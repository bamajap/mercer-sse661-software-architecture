using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace FavoriteHomes.Microkernel.InternalServers
{
    public class WorkbookWrapperFacade
    {
        private readonly Excel.Workbook _workbook;

        public IEnumerable<WorksheetWrapperFacade> Worksheets { get; private set; }

        public WorksheetWrapperFacade ActiveSheet
        {
            get { return new WorksheetWrapperFacade(_workbook.ActiveSheet); }
        }

        internal WorkbookWrapperFacade(Excel.Workbook workbook)
        {
            _workbook = workbook;

            var list = new List<WorksheetWrapperFacade>(workbook.Worksheets.Count);
            list.AddRange(from Excel.Worksheet worksheet in workbook.Worksheets
                          select new WorksheetWrapperFacade(worksheet));
            Worksheets = list;
        }
    }
}