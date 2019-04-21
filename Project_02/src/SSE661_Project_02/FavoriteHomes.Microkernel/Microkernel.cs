using System;
using System.Reflection;
using FavoriteHomes.Microkernel.Interfaces;
using FavoriteHomes.Microkernel.InternalServers;

namespace FavoriteHomes.Microkernel
{
    public class Microkernel
    {
        // Initialize the singleton instance
        private static readonly Microkernel _microkernel = new Microkernel();
        private IFileSystem _fileSystem;

        public static Microkernel Instance
        {
            get { return _microkernel; }
        }

        private Microkernel()
        {
            // Prevent new instances of the Microkernel class from being created.
        }

        public IFileSystem FileSystem
        {
            get { return _fileSystem = _fileSystem ?? new FileSystem(); }
        }

        public dynamic GetGpsDevice(string gpsId)
        {
            var gpsTypeName =
                string.Format("FavoriteHomes.Microkernel.ExternalServers.{0}.Gps", gpsId);

            var currentDirectory =
                FileSystem.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            var binPath = FileSystem.CombinePaths(currentDirectory, @"..\..\..\bin\");

            var gpsAssemblyPath =
                string.Format(@"{0}FavoriteHomes.Microkernel.ExternalServers.{1}.dll",
                              binPath, gpsId);

            var result = Assembly.UnsafeLoadFrom(gpsAssemblyPath);

            var type = result.GetType(gpsTypeName);
            return Activator.CreateInstance(type);
        }
    }
}