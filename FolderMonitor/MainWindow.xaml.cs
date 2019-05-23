using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FolderMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var vm = new MainViewModel();

            var pl = new ProfileLoader();
            pl.LoadProfiles().ToViewModels().ToList().ForEach(x => vm.Profiles.Add(x));

            //var folders = new List<Folder>();
            //folders.Add(new Folder("Watch", @"C:\Rexson\BusinessLink\Watch", ErrorState.None));
            //folders.Add(new Folder("Error", @"C:\Rexson\BusinessLink\Error", ErrorState.Any));
            //folders.Add(new Folder("Processed", @"C:\Rexson\BusinessLink\Processed", ErrorState.None));

            //vm.Profiles.Add(new ProfileViewModel { ProfileName = "BusinessLink", Folders = new System.Collections.ObjectModel.ObservableCollection<Folder>(folders) });
            //vm.Profiles.Add(new ProfileViewModel { ProfileName = "BusinessLink1", Folders = new System.Collections.ObjectModel.ObservableCollection<Folder>(folders) });

            this.DataContext = vm;
        }
    }
}
