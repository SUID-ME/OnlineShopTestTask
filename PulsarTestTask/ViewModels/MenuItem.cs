using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace PulsarTestTask.ViewModels
{
    public class MenuItem : ReactiveObject
    {
        [Reactive]
        public string Title { get; set; }
        [Reactive]
        public string IconPath { get; set; }
    }
}
