using System;
using System.Net;

namespace Musix.PackedPlugins.Models
{
    public class Platform
    {
        public Platform(string Platform, Version version = null)
        {
            if (version == null) version = Version.Parse("0.0.0.1");
            PlatformName = Platform;
            MinVersion = version;
        }

        public static bool TryParse(string str, out Platform platform)
        {
            platform = null;
            str = str.Trim(' ');
           str = str.Replace("]", "");
            if (str.Contains("["))
            {
                string p = str.Split('[')[0];
                string v = str.Split('[')[1];
                if (Version.TryParse(v, out Version vs))
                {
                    platform = new Platform(WebUtility.UrlDecode(p), vs);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string PlatformName;
        public Version MinVersion;
    }
}