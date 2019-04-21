using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteHomes.Microkernel.Interfaces
{
    public interface IFileSystem
    {
        string DefaultSavePath { get; }

        bool FileExists(string filePath);

        bool DirectoryExists(string directoryPath);

        string GetDirectoryName(string path);

        void CreateDirectory(string directoryPath);

        string CombinePaths(string path1, string path2);

        string[] GetDirectoryFiles(string directoryPath, string searchPattern);

        string GetFileName(string filePath);

        void Delete(string connectString);

        void WriteBinaryFile(string filePath, byte[] buffer);
    }
}
