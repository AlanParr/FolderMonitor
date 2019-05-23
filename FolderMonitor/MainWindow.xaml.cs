using System.Linq;
using System.Windows;

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

            DataContext = vm;
        }
    }
}