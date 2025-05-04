using ReactiveUI.Fody.Helpers;

namespace PulsarTestTask.ViewModels
{
    public class CartContent : ViewModelBase
    {
        public CartContent() { }

        public required string Name { get; set; }
        [Reactive]
        public int Count { get; set; }
    }
}
