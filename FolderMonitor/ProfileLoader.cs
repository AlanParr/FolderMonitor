using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderMonitor
{
    public class ProfileLoader
    {
        private readonly string _profilePath;

        public ProfileLoader()
        {
            _profilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "FolderMonitor", "Profiles");
        }

        public IEnumerable<Profile> LoadProfiles()
        {
            if (!Directory.Exists(_profilePath)) return Enumerable.Empty<Profile>();

            var files = Directory.GetFiles(_profilePath, "*.json");
            var result = new List<Profile>();
            foreach (var file in files)
            {
                var deserialized = Newtonsoft.Json.JsonConvert.DeserializeObject<Profile>(File.ReadAllText(file));
                if (deserialized != null)
                    result.Add(deserialized);
            }
            return result;
        }
    }
}