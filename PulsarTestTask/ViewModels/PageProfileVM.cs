using Avalonia.Media.Imaging;
using PulsarTestTask.Converters;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

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

    public class UserInfo() : ReactiveObject, IUrl
    {
        public ProfileAttributeVM UserFirstName { get; set; } = new ("Имя", "Иван");
        public ProfileAttributeVM UserSecondName { get; set; } = new ("Фамилия", "Иванов");
        public ProfileAttributeVM UserSurname { get; set; } = new ("Отчество", "Иванович");

        public ProfileAttributePhonelVM UserPhoneNumber { get; set; } = new ("Телефон", "8-123-444-55-66");
        public ProfileAttributeEmailVM UserEmail { get; set; } = new ("email", "ivan@test.com");

        public ProfileAttributeVM UserAge { get; set; } = new ("Возраст", "28 лет");
        public ProfileAttributeVM UserBalance { get; set; } = new ("Баланс", "4000р");

        [Reactive]
        public Bitmap? Bitmap { get; set; }
        public string Url { get; set; } = "https://i.pinimg.com/736x/2f/90/c1/2f90c1e9fc45169c0f2cc0dfe88e73a5.jpg";
    }
}
