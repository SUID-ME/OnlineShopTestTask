using Avalonia.Media.Imaging;
using PulsarTestTask.Converters;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;


namespace PulsarTestTask.Models
{
    public class ShopItem : ReactiveObject, IUrl
    {
        public required string Name { get; set; }
        public int Count { get; set; }
        public string Url { get; set; }
        [Reactive]
        public Bitmap? Bitmap { get; set; }
    }
}
