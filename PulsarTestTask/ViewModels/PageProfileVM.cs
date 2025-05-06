using PulsarTestTask.Converters;

namespace PulsarTestTask.ViewModels
{
    public class PageProfileVM : ViewModelBase
    {
        public PageProfileVM()
        {
            _bitmapLoader.LoadBitmap(UserInfo);
        }

        public UserInfo UserInfo { get; set; } = new();
        private BitmapLoader<UserInfo> _bitmapLoader = new();
    }
}
