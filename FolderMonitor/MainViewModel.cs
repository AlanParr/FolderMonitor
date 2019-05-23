using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor
{
    public class MainViewModel
    {
        public ObservableCollection<ProfileViewModel> Profiles { get; set; } = new ObservableCollection<ProfileViewModel>();
    }

    public class ProfileViewModel
    {
        public string ProfileName { get; set; }
        public ObservableCollection<Folder> Folders { get; set; }
    }

    public class Folder: INotifyPropertyChanged
    {
        private FileSystemWatcher _watcher;

        public Folder(string name, string path, ErrorState errorState)
        {
            Name = name;
            Path = path;
            ErrorState = errorState;

            Contents.Clear();
            System.IO.Directory.GetFiles(Path).ToList().ForEach(x => Contents.Add(System.IO.Path.GetFileName(x)));
            _watcher = new System.IO.FileSystemWatcher(Path);
            _watcher.Created += (sender, e) =>
            {
                App.Current.Dispatcher.Invoke(delegate
                {
                    Contents.Add(e.Name);
                });
            };

            _watcher.Deleted += (sender, e) =>
            {
                if (!Contents.Any(x => x == e.Name)) return;

                App.Current.Dispatcher.Invoke(delegate
                {
                    Contents.Remove(e.Name);
                });
            };
            _watcher.EnableRaisingEvents = true;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public ErrorState ErrorState { get; }
        public ObservableCollection<string> Contents { get; set; } = new ObservableCollection<string>();

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                ((INotifyPropertyChanged)Contents).PropertyChanged += value;
            }

            remove
            {
                ((INotifyPropertyChanged)Contents).PropertyChanged -= value;
            }
        }
    }
}
