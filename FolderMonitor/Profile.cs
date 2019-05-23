using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor
{
    public class Profile
    {
        public string Name { get; set; }
        public List<FolderSpecification> Folders { get; set; }
    }
}
