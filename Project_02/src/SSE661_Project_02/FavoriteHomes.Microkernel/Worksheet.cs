using FavoriteHomes.Microkernel.InternalServers;

namespace FavoriteHomes.Microkernel
{
    public class Worksheet
    {
        public Range Cells { get; private set; }

        internal Worksheet(WorksheetWrapperFacade worksheet)
        {
            Cells = new Range(worksheet);
        }
    }
}