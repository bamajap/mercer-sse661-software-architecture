using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteHomes.Garmin.Interfaces
{
    public interface IGarminGps
    {
        bool SaveFhpFile(string filename, DataTable data);
        void ExportToSpreadSheet(DataTable data);
    }
}