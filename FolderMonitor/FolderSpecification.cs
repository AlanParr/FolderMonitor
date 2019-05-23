using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor
{
    public class FolderSpecification
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public ErrorState ErrorState { get; set; }
        public int? MaxFileAgeInDays { get; set; }
    }
}
