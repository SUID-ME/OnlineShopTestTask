using ReactiveUI.Fody.Helpers;

namespace PulsarTestTask.ViewModels
{
    public class MenuItemVM : ViewModelBase
    {
        [Reactive]
        public string Title { get; set; }
        [Reactive]
        public string IconPath { get; set; }
        public required ViewModelBase ViewModel { get; init; }
    }
}
