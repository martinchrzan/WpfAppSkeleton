using System.Windows.Input;

namespace WpfAppSkeleton.ViewModelContracts
{
    public interface IChildViewModel
    {
        int Count { get; }

        ICommand IncreaseCountCommand { get; }
    }
}
