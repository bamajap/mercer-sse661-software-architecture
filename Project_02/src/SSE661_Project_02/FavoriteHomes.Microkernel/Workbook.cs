using System.Collections.Generic;
using System.Linq;
using FavoriteHomes.Microkernel.InternalServers;

namespace FavoriteHomes.Microkernel
{
    public class Workbook
    {
        private readonly WorkbookWrapperFacade _workbook;

        public IEnumerable<Worksheet> Worksheets { get; private set; }

        /// <summary>
        /// Provides access to the active worksheet of the workbook.
        /// </summary>
        public Worksheet ActiveSheet
        {
            get { return new Worksheet(_workbook.ActiveSheet); }
        }

        /// <summary>
        /// Creates a workbook and its collection of worksheets.
        /// </summary>
        /// <param name="workbook">The workbook source.</param>
        internal Workbook(WorkbookWrapperFacade workbook)
        {
            _workbook = workbook;

            var list = new List<Worksheet>(workbook.Worksheets.Count());
            list.AddRange(from WorksheetWrapperFacade worksheet in workbook.Worksheets
                          select new Worksheet(worksheet));
        }
    }
}