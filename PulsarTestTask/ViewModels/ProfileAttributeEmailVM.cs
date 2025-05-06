using ReactiveUI.Validation.Extensions;
using System.Text.RegularExpressions;

namespace PulsarTestTask.ViewModels
{
    public class ProfileAttributeEmailVM : ProfileAttributeVM
    {
        #region Constructors
        public ProfileAttributeEmailVM() : base() { }
        public ProfileAttributeEmailVM(string name, string value) : base(name, value) { }
        #endregion Constructors

        #region Bindings
        public override string Watermark { get; } = "example@mail.com";
        #endregion Bindings

        #region Methods
        protected override void InitValidations()
        {
            base.InitValidations();
            this.ValidationRule(
                x => x.AttributeValue,
                text => ValidationMethod(text),
                _errorMessage
            );
        }

        private bool ValidationMethod(string field)
        {
            return Regex.IsMatch(field, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }
        #endregion Methods

        #region Fields
        private static string _errorMessage = "Email некорректный!";
        #endregion Fields
    }
}
