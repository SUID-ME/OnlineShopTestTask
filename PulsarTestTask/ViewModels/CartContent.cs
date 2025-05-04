using PulsarTestTask.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive.Linq;

namespace PulsarTestTask.ViewModels
{
    public class CartContent : ViewModelBase
    {
        public CartContent(ShopItem item, int count = 1) { 
            Name = item.Name;
            MaxCount = item.Count;
            Count = count;

            this.WhenAnyValue(x => x.Count, x => x.MaxCount)
                .Select(t => t.Item1 <= t.Item2)
                .ToProperty(this, x => x.IsAvailable, out _isAvailable);
        }

        public string Name { get; }
        [Reactive]
        public int Count { get; set; }

        public bool IsAvailable => _isAvailable.Value;
        private ObservableAsPropertyHelper<bool> _isAvailable;
        [Reactive]
        public int MaxCount { get; set; }
    }
}
