using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;

namespace Musix.PackedPlugins.Models
{
    public class PackedPlugin : IDisposable
    {
        public PlatformCompatability PlatformCompatability { get; protected set; } = new PlatformCompatability();
        public string PluginName;
        public string AuthorName;
        public string PluginDescription;
        public string WebsiteURL;
        public List<string> PluginTags = new List<string>();
        private ZipArchive archive;

        public bool HasIcon
        {
            get => archive.GetEntry("icon") != null;
        }

        public Stream OpenReadIcon() => archive.GetEntry("icon").Open();

        protected PackedPlugin()
        {
        }

        public static PackedPlugin LoadFrom(Stream stream)
        {
            PackedPlugin plugin = new PackedPlugin();
            ZipArchive archive = new ZipArchive(stream);
            plugin.archive = archive;
            plugin.UnpackMeta(archive);
            return plugin;
        }

        private void UnpackMeta(ZipArchive archive)
        {
            Stream RS = archive.GetEntry("meta").Open();
            INIFile file = new INIFile(RS);
            PluginName = file["Name"];
            AuthorName = file["Author"];
            PluginDescription = file["Description"];
            WebsiteURL = file["Website"];
            PluginTags = file["Tags"].Split(' ').ToList();
            PlatformCompatability = PlatformCompatability.LoadFrom(file["Platforms"]);
        }

        public Assembly LoadPlugin()
        {
            using (MemoryStream DepLoadStream = new MemoryStream())
            using (Stream DepReadStream = archive.GetEntry("plugin.dll").Open())
            {
                DepReadStream.CopyTo(DepLoadStream);
                Assembly LoadedAssembly = AppDomain.CurrentDomain.Load(DepLoadStream.ToArray());
                return LoadedAssembly;
            }
        }

        public Assembly[] LoadDependancies()
        {
            List<Assembly> asm = new List<Assembly>();
            foreach (var e in archive.Entries.Where(x => x.FullName.ToLower().StartsWith("dependencies\\") && x.FullName.ToLower().EndsWith(".dll")))
            {
                using (MemoryStream DepLoadStream = new MemoryStream())
                using (Stream DepReadStream = e.Open())
                {
                    DepReadStream.CopyTo(DepLoadStream);
                    Assembly LoadedAssembly = AppDomain.CurrentDomain.Load(DepLoadStream.ToArray());
                    asm.Add(LoadedAssembly);
                }
            }
            return asm.ToArray();
        }

        protected virtual void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                ((IDisposable)archive).Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}