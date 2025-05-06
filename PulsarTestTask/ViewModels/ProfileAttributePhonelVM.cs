using ReactiveUI.Validation.Extensions;
using System.Text.RegularExpressions;

namespace PulsarTestTask.ViewModels
{
    public class ProfileAttributePhonelVM : ProfileAttributeVM
    {
        #region Constructors
        public ProfileAttributePhonelVM() : base() { }
        public ProfileAttributePhonelVM(string name, string value) : base(name, value) { }
        #endregion Constructors

        #region Bindings
        public override string Watermark { get; } = "8-123-444-55-66";
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
            return Regex.IsMatch(field, @"^[\+\d\s\(\)-]{6,20}$");
        }
        #endregion Methods

        #region Fields
        private static string _errorMessage = "Номер некорректный!";
        #endregion Fields
    }
}
