using Avalonia.Media.Imaging;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;


namespace PulsarTestTask.Models
{
    public class ShopItem : ReactiveObject
    {
        public required string Name { get; set; }
        public int Count { get; set; }
        public string URL { get; set; }
        [Reactive]
        public Bitmap Bitmap { get; set; }
    }
}
