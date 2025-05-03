namespace PulsarTestTask.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            NavigationVM = new();
        }

        public NavigationVM NavigationVM { get; set; }
    }
}
