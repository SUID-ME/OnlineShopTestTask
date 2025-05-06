using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Extensions;
using ReactiveUI.Validation.Helpers;
using System.Reactive;

namespace PulsarTestTask.ViewModels
{
    public class ProfileAttributeVM : ReactiveValidationObject
    {
        #region Constructors
        public ProfileAttributeVM()
        {
            AttributeName = string.Empty;
            AttributeValue = string.Empty;
            InitButton();
            InitValidations();
        }
        public ProfileAttributeVM(string name, string value)
        {
            AttributeName = name;
            AttributeValue = value;
            InitButton();
            InitValidations();
        }

        private void InitButton()
        {
            ToggleTextBoxCommand = ReactiveCommand.Create(SwitchActive);
        }

        protected virtual void InitValidations()
        {
            this.ValidationRule(
                x => x.AttributeValue,
                text => ValidationMethod(text),
                _errorMessage
            );
        }
        #endregion Constructors

        #region Bindings
        [Reactive]
        public string AttributeName { get; set; }

        [Reactive]
        public string AttributeValue { get; set; }

        public string AttributePresent
        {
            get
            {
                return AttributeName + ":";
            }
        }

        public virtual string Watermark { get; } = "";

        [Reactive]
        public bool IsEnabled { get; private set; } = false;

        public ReactiveCommand<Unit, Unit> ToggleTextBoxCommand { get; private set; }
        #endregion Bindings

        #region Methods
        private void SwitchActive()
        {
            IsEnabled = !IsEnabled;
        }

        private bool ValidationMethod(string field)
        {
            return !string.IsNullOrWhiteSpace(field);
        }
        #endregion Methods

        #region Fields
        private const string _errorMessage = "Поле не может быть пустым!";
        #endregion Fields
    }
}
