using ReactiveUI.Fody.Helpers;

namespace PulsarTestTask.ViewModels
{
    public class PageProfileVM : ViewModelBase
    {
        public ProfileAttributeVM UserFirstName { get; set; } = new ProfileAttributeVM("Имя", "Иван");
        public ProfileAttributeVM UserSecondName { get; set; } = new ProfileAttributeVM("Фамилия", "Иванов");
        public ProfileAttributeVM UserSurname { get; set; } = new ProfileAttributeVM("Отчество", "Иванович");

        public ProfileAttributeVM UserPhoneNumber { get; set; } = new ProfileAttributeVM("Телефон", "8-123-444-55-66");
        public ProfileAttributeVM UserEmail { get; set; } = new ProfileAttributeVM("email", "ivan@test.com");

        public ProfileAttributeVM UserAge { get; set; } = new ProfileAttributeVM("Возраст", "28 лет");
        public ProfileAttributeVM UserBalance { get; set; } = new ProfileAttributeVM("Баланс", "4000р");
    }
}
