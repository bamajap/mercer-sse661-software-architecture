using FavoriteHomes.Microkernel.InternalServers;

namespace FavoriteHomes.Microkernel
{
    public class Range
    {
        private readonly WorksheetWrapperFacade _worksheet;

        private string value;

        internal Range(WorksheetWrapperFacade worksheet)
        {
            _worksheet = worksheet;
        }

        /// <summary>
        /// Provides access to a range of cells.
        /// </summary>
        /// <param name="row">The row of the cell(s).</param>
        /// <param name="col">The column of the cell(s).</param>
        /// <returns>The range of the cell(s).</returns>
        public object this[int row = 0, int col = 0]
        {
            get { return _worksheet.Cells[row, col]; }
            set { _worksheet.Cells[row, col] = value; }
        }
    }
}