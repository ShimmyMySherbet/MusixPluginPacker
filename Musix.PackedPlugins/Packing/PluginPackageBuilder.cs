using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Musix.PackedPlugins.Models;

namespace Musix.PackedPlugins.Packing
{
    public class PluginPackageBuilder
    {
        public byte[] PluginAssembly;
        public List<PackageBuilderDependancy> Dependancies = new List<PackageBuilderDependancy>();
        public readonly PlatformCompatability PlatformCompatability = new PlatformCompatability();
        public string PluginName;
        public string AuthorName;
        public string PluginDescription;
        public string WebsiteURL;
        public List<string> PluginTags = new List<string>();
        public byte[] PluginIcon;

        public void Build(Stream OutputStream)
        {
            using(ZipArchive archive = new ZipArchive(OutputStream, ZipArchiveMode.Create))
            {
                PackPlugin(archive);
                PackDependancies(archive);
                PackMeta(archive);
            }
        }


        private void PackPlugin(ZipArchive archive)
        {
            ZipArchiveEntry entry = archive.CreateEntry("Plugin.dll");
            Stream wr = entry.Open();
            wr.Write(PluginAssembly, 0, PluginAssembly.Length);
            wr.Flush();
            wr.Close();
        }

        private void PackMeta(ZipArchive archive)
        {
            INIFile INI = new INIFile();
            INI["Name"] = PluginName;
            INI["Author"] = AuthorName;
            INI["Description"] = PluginDescription;
            INI["Website"] = WebsiteURL;
            INI["Tags"] = string.Join(" ", PluginTags);
            INI["Platforms"] = PlatformCompatability.ToString();
            ZipArchiveEntry entry = archive.CreateEntry("meta");
            Console.WriteLine("saving meta");
            using(Stream st = entry.Open())
            {
                INI.SaveToStream(st);
                st.Flush();
                st.Close();
            }
            if (PluginIcon != null && PluginIcon.Length > 0)
            {
                ZipArchiveEntry icentry = archive.CreateEntry("icon");
                using (Stream st = icentry.Open())
                {
                    st.Write(PluginIcon, 0, PluginIcon.Length);
                    st.Flush();
                    st.Close();
                }
            }
        }

        private void PackDependancies(ZipArchive archive)
        {
            foreach(PackageBuilderDependancy dependancy in Dependancies)
            {
                ZipArchiveEntry entry = archive.CreateEntry(Path.Combine("Dependencies", dependancy.FileName));
                using(Stream write = entry.Open())
                {
                    write.Write(dependancy.AssemblyBytes, 0, dependancy.AssemblyBytes.Length);
                    write.Flush();
                    write.Close();
                }
            }
        }


    }
}
