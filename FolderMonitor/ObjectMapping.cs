using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor
{
    public static class ObjectMapping
    {
        public static IEnumerable<ProfileViewModel> ToViewModels(this IEnumerable<Profile> profiles)
            => profiles.Select(x => x.ToViewModel()).ToList();

        public static ProfileViewModel ToViewModel(this Profile profile)
        {
            return new ProfileViewModel
            {
                ProfileName = profile.Name,
                Folders = new ObservableCollection<Folder>(profile.Folders.Select(x => new Folder(x.Name, x.Path, x.ErrorState)))
            };
        }
    }
}
