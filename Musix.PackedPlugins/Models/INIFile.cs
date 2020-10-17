using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Musix.PackedPlugins.Models
{
    public class INIFile
    {
        public Dictionary<string, string> Contents = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

        public INIFile(Stream LoadFrom = null)
        {
            if (LoadFrom == null) return;
            StreamReader reader = new StreamReader(LoadFrom);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Contains("="))
                {
                    Contents.Add(WebUtility.UrlDecode(line.Substring(0, line.IndexOf('='))), WebUtility.UrlDecode(line.Substring(line.IndexOf('=') + 1)));
                }
                else Contents.Add(line, "");
            }
        }

        public void SaveToStream(Stream stream)
        {
            StreamWriter writer = new StreamWriter(stream);
            foreach (var e in Contents)
            {
                Console.WriteLine(e.Key);
                writer.WriteLine(WebUtility.UrlEncode(e.Key) + '=' + WebUtility.UrlEncode(e.Value));
            }
            writer.Flush();
        }

        public string this[string key]
        {
            get => (Contents.ContainsKey(key) ? Contents[key] : "");
            set => Contents[key] = value;
        }
    }
}