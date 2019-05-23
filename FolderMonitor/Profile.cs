using System.Collections.Generic;

namespace FolderMonitor
{
    public class Profile
    {
        public string Name { get; set; }
        public List<FolderSpecification> Folders { get; set; }
    }
}