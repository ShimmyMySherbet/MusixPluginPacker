using System;
using System.IO;
using System.Windows.Forms;
using Musix.PackedPlugins.Models;

namespace MusixPluginPacker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Musix Plugins|*.MusixPlugin" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PackedPlugin pl = PackedPlugin.LoadFrom(File.OpenRead(ofd.FileName));
                Console.WriteLine($"Name: {pl.PluginName}");
                Console.WriteLine($"Author: {pl.AuthorName}");
                Console.WriteLine($"Desc: {pl.PluginDescription}");
                Console.WriteLine($"Desc: {string.Join(", ", pl.PluginTags)}");
                Console.WriteLine($"Website: {pl.WebsiteURL}");
                Console.WriteLine($"Plats: {pl.PlatformCompatability.Platforms.Count}");
                pl.PlatformCompatability.Platforms.ForEach(x => Console.WriteLine($"Plat: {x.PlatformName} [{x.MinVersion}]"));
                pl.LoadDependancies();
            }

            Application.Run(new Packer());
        }
    }
}