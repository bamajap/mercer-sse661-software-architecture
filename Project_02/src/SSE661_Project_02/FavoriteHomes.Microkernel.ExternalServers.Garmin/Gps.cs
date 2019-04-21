using System;
using System.Data;
using System.Linq;
using System.Text;
using FavoriteHomes.Garmin.Interfaces;
using FavoriteHomes.Microkernel.Interfaces;

namespace FavoriteHomes.Microkernel.ExternalServers.Garmin
{
    public class Gps : IGarminGps
    {
        private static IFileSystem FileSystem
        {
            get { return Microkernel.Instance.FileSystem; }
        }

        public bool SaveFhpFile(string filename, DataTable data)
        {
            var recordSize = 26 + // Street (26 characters)
                             2 + // formatting
                             26 + // City (26 characters)
                             2 + // formatting
                             2 + // State (2 characters)
                             2 + // formatting
                             5 + // Zip (5 characters)
                             1 + // Bedrooms (1 character)
                             1 + // Bathrooms (1 character)
                             4 + // Size (4 characters)
                             4 + // Year Built (4 characters)
                             7 // Price (7 characters)
                ;
            var homes = data.AsEnumerable().ToList();
            var buffer = new byte[1 + (recordSize * homes.Count)];
            buffer[0] = Convert.ToByte(homes.Count);
            var filePath = String.Format(@"{0}\{1}", FileSystem.DefaultSavePath, filename);
            
            //var fileInfo = new FileInfo(filePath);

            //if (!Directory.Exists(fileInfo.DirectoryName))
            //    Directory.CreateDirectory(fileInfo.DirectoryName);
            var directoryPath = FileSystem.GetDirectoryName(filePath);
            if(!FileSystem.DirectoryExists(directoryPath))
                FileSystem.CreateDirectory(directoryPath);

            var index = 1;

            for (var i = 0; i < homes.Count; i++)
            {
                var address = homes[0].Field<string>("Address");
                var bedrooms = homes[0].Field<int>("Bedrooms");
                var bathrooms = homes[0].Field<int>("Bathrooms");
                var size = homes[0].Field<int>("Size");
                var yearBuilt = homes[0].Field<int>("Year Built");
                var price = homes[0].Field<string>("Price");

                Buffer.BlockCopy(Encoding.ASCII.GetBytes(address), 0,
                                 buffer, index, address.Length);
                index += 65;
                Buffer.BlockCopy(Encoding.ASCII.GetBytes(bedrooms.ToString()), 0,
                                 buffer, index, 1);

                index += 1;
                Buffer.BlockCopy(Encoding.ASCII.GetBytes(bathrooms.ToString()), 0,
                                 buffer, index, 1);

                index += 1;
                Buffer.BlockCopy(Encoding.ASCII.GetBytes(size.ToString()), 0,
                                 buffer, index, 4);

                index += 4;
                Buffer.BlockCopy(Encoding.ASCII.GetBytes(yearBuilt.ToString()),
                                 0, buffer, index, 4);

                index += 4;
                Buffer.BlockCopy(Encoding.ASCII.GetBytes(price), 0,
                                 buffer, index, price.Length);

                index += 7;
            }

            //File.WriteAllBytes(filePath, buffer);
            FileSystem.WriteBinaryFile(filePath, buffer);
            
            return true;
        }

        public void ExportToSpreadSheet(DataTable data)
        {
            var homes = data.AsEnumerable().ToList();

            var app = new SpreadsheetApp(1);
            var worksheet = app.Workbook.ActiveSheet;

            worksheet.Cells[1, 1] = "Address";
            worksheet.Cells[1, 2] = "Bedrooms";
            worksheet.Cells[1, 3] = "Bathrooms";
            worksheet.Cells[1, 4] = "Size";
            worksheet.Cells[1, 5] = "Year Built";
            worksheet.Cells[1, 6] = "Price";
            worksheet.Cells[1, 7] = @"$ / sq. ft.";

            for (int i = 0; i < homes.Count; i++)
            {
                var row = i + 2;

                worksheet.Cells[row, 1] = homes[0].Field<string>("Address");
                worksheet.Cells[row, 2] = homes[0].Field<int>("Bedrooms");
                worksheet.Cells[row, 3] = homes[0].Field<int>("Bathrooms");
                worksheet.Cells[row, 4] = homes[0].Field<int>("Size");
                worksheet.Cells[row, 5] = homes[0].Field<int>("Year Built");
                worksheet.Cells[row, 6] = homes[0].Field<string>("Price");
                worksheet.Cells[row, 7] = homes[0].Field<string>("PricePerSqFt");
            }

            app.Quit();
        }
    }
}