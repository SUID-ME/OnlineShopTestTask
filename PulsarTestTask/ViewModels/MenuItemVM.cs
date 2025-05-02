using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace PulsarTestTask.ViewModels
{
    public class MenuItemVM : ReactiveObject
    {
        [Reactive]
        public string Title { get; set; }
        [Reactive]
        public string IconPath { get; set; }
    }
}
