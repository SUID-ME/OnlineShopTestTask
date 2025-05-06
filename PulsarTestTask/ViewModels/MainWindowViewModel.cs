namespace PulsarTestTask.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            NavigationMenuVM = new();
            NavigationTitleVM = new(NavigationMenuVM);
            PageContentVM = new(NavigationMenuVM);
        }

        public NavigationMenuVM NavigationMenuVM { get; }
        public PageContentVM PageContentVM { get; }
        public NavigationTitleVM NavigationTitleVM { get; }
    }
}
