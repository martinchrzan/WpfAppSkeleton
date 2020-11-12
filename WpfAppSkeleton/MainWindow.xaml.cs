using System.ComponentModel.Composition;
using System.Windows;
using WpfAppSkeleton.Common;
using WpfAppSkeleton.ViewModelContracts;

namespace WpfAppSkeleton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Closing += MainWindow_Closing;

            // Calling this, we will resolve MainViewModel property below and trigger the whole composition of classes
            CompositionBootstrapper.InitializeContainer(this);
            InitializeComponent();
            DataContext = this;
        }

        [Import]
        public IMainViewModel MainViewModel { get; set; }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Closing -= MainWindow_Closing;
            CompositionBootstrapper.Dispose();
        }
    }
}
