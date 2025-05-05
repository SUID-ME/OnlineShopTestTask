using Avalonia.Media.Imaging;

namespace PulsarTestTask.Converters
{
    public interface IUrl
    {
        public string Url { get; set; }
        public Bitmap? Bitmap { get; set; }
    }
}
