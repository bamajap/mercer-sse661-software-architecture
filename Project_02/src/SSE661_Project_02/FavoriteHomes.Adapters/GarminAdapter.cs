using System.Data;
using FavoriteHomes.Garmin.Interfaces;

namespace FavoriteHomes.Adapters
{
    using Microkernel = Microkernel.Microkernel;

    public class GarminAdapter : IGarminGps
    {
        /// <summary>
        /// The Garmin GPS device returned by the microkernel.
        /// </summary>
        private IGarminGps Gps { get; set; }

        public GarminAdapter()
        {
            // Establish communications with the Garmin device.
            Gps = Microkernel.Instance.GetGpsDevice("Garmin");
        }

        /// <summary>
        /// Sends a service request to the GPS device for it to initiate the saving process.
        /// </summary>
        /// <param name="filename">The name of the file to be saved.</param>
        /// <param name="data">The list of homes.</param>
        /// <returns>True if the save was successful, otherwise false.</returns>
        public bool SaveFhpFile(string filename, DataTable data)
        {
            return Gps.SaveFhpFile(filename, data);
        }

        /// <summary>
        /// Sends a service request to the GPS device for it to initiate the export process.
        /// </summary>
        /// <param name="data">The list of homes.</param>
        public void ExportToSpreadSheet(DataTable data)
        {
            Gps.ExportToSpreadSheet(data);
        }
    }
}
