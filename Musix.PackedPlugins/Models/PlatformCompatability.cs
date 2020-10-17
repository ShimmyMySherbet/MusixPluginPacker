using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Musix.PackedPlugins.Models
{
    public class PlatformCompatability
    {
        public List<Platform> Platforms = new List<Platform>();

        public PlatformCompatability WithPlatform(Platform platform)
        {
            TryAddPlatform(platform);
            return this;
        }

        public bool TryAddPlatform(Platform platform)
        {
            foreach (Platform existing in Platforms.Where(x => string.Equals(x.PlatformName, platform.PlatformName, System.StringComparison.InvariantCultureIgnoreCase))) {
                if (existing.MinVersion > platform.MinVersion)
                {
                    Platforms.Remove(existing);
                    Platforms.Add(platform);
                    return true;
                }
                else if (existing.MinVersion < platform.MinVersion)
                {
                    return false;
                }
            }
            Platforms.Add(platform);
            return true;
        }

        public override string ToString()
        {
            List<string> ents = new List<string>();
            foreach (Platform platform in Platforms)
                ents.Add($"{WebUtility.UrlEncode(platform.PlatformName)}[{platform.MinVersion}]");
            return string.Join(", ", ents);
        }
        public static PlatformCompatability LoadFrom(string str)
        {
            PlatformCompatability platformCompatability = new PlatformCompatability();
            foreach(string prt in str.Split(','))
            {
                if (Platform.TryParse(prt, out Platform platform))
                {
                    platformCompatability.Platforms.Add(platform);
                }
            }
            return platformCompatability;
        }
    }
}