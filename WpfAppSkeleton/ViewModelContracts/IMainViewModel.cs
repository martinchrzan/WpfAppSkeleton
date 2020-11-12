namespace WpfAppSkeleton.ViewModelContracts
{
    public interface IMainViewModel
    {
        string Title { get; }

        IChildViewModel ChildViewModel { get; }
    }
}
