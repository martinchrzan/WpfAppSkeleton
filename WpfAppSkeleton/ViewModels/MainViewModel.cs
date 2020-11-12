using System.ComponentModel.Composition;
using WpfAppSkeleton.Common;
using WpfAppSkeleton.ViewModelContracts;

namespace WpfAppSkeleton.ViewModels
{
    [Export(typeof(IMainViewModel))]
    internal class MainViewModel : ViewModelBase, IMainViewModel
    {
        // Importing constructor tells us that we want to get instance items provided in the constructor
        [ImportingConstructor]
        public MainViewModel(IChildViewModel childViewModel)
        {
            ChildViewModel = childViewModel;

            //This text will be set only once from the constructor
            Title = "This text bind from the view model";
        }

        public string Title { get; }

        public IChildViewModel ChildViewModel { get; }
    }
}
