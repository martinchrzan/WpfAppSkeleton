using System.ComponentModel.Composition;
using System.Windows.Input;
using WpfAppSkeleton.Common;
using WpfAppSkeleton.ViewModelContracts;

namespace WpfAppSkeleton.ViewModels
{
    // Export tells others that this class implements IChildViewModel - if they request it using Import/ImportingConstructor they will get an instance of this class
    [Export(typeof(IChildViewModel))]
    internal class ChildViewModel : ViewModelBase, IChildViewModel
    {
        private int _count;

        [ImportingConstructor]
        public ChildViewModel()
        {
            IncreaseCountCommand = new RelayCommand(() => { Count++; });
        }

        // we need to use private variable _count because we want to notify view, that this property has changed when we set it - we cannot do that with auto-property
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                // defined in ViewModelBase
                OnPropertyChanged();
            }
        }

        public ICommand IncreaseCountCommand { get; }
    }
}
