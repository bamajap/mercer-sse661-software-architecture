using System;
using System.IO;
using FavoriteHomes.Microkernel.Interfaces;

namespace FavoriteHomes.Microkernel.InternalServers
{
    public class FileSystem : IFileSystem
    {
        public string DefaultSavePath { get; private set; }

        public FileSystem()
        {
            DefaultSavePath =
                string.Format(@"{0}\{1}",
                              Environment.GetFolderPath(
                                  Environment.SpecialFolder.CommonApplicationData),
                              "My Favorite Homes");
        }

        /// <summary>
        /// Checks for the existence of a file.
        /// </summary>
        /// <param name="filePath">The file path of the file.</param>
        /// <returns>True if the file exists, otherwise false.</returns>
        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        /// <summary>
        /// Check to see if a directory exists
        /// </summary>
        /// <param name="directoryPath">The file path of the directory.</param>
        /// <returns></returns>
        public bool DirectoryExists(string directoryPath)
        {
            return Directory.Exists(directoryPath);
        }

        public string GetDirectoryName(string path)
        {
            return Path.GetDirectoryName(path);
        }

        public string CombinePaths(string path1, string path2)
        {
            return Path.Combine(path1, path2);
        }

        public void CreateDirectory(string directoryPath)
        {
            Directory.CreateDirectory(directoryPath);
        }

        /// <summary>
        /// Returns the names of files (including their paths) that match the specified search
        /// pattern in the specified directory.
        /// </summary>
        /// <param name="directoryPath">The directory to search.</param>
        /// <param name="searchPattern">The search string to match against the names of files
        /// in path. The parameter cannot end in two periods ("..") or contain two periods
        /// ("..") followed by System.IO.Path.DirectorySeparatorChar or
        /// System.IO.Path.AltDirectorySeparatorChar, nor can it contain any of the characters
        /// in System.IO.Path.InvalidPathChars.</param>
        public string[] GetDirectoryFiles(string directoryPath, string searchPattern)
        {
            return Directory.GetFiles(directoryPath, searchPattern);
        }

        /// <summary>
        /// Gets the file name for the given connection string.
        /// </summary>
        /// <param name="filePath">The connection string with the file name.</param>
        /// <returns>The file name for the given connect string.</returns>
        public string GetFileName(string filePath)
        {
            return Path.GetFileName(filePath);
        }

        /// <summary>
        /// Deletes the file from the file system.
        /// </summary>
        /// <param name="connectString">The file to delete.</param>
        /// <exception cref="InvalidOperationException">Thrown if an error occurs while
        /// deleting the file.</exception>
        public void Delete(string connectString)
        {
            try
            {
                File.Delete(connectString);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(
                    "A problem occurred trying to delete the file.", e);
            }
        }

        /// <summary>
        /// Writes the binary data buffer to the specified file.
        /// </summary>
        /// <param name="filePath">The file to create (or overwrite, if it exists).</param>
        /// <param name="buffer">The binary data buffer to be written to the file.</param>
        public void WriteBinaryFile(string filePath, byte[] buffer)
        {
            File.WriteAllBytes(filePath, buffer);
        }
    }
}