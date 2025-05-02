namespace PulsarTestTask.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            NavigationVM = new();
        }

        public NavigationMenuVM NavigationVM { get; set; }
    }
}
