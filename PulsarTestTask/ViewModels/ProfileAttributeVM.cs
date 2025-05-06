using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive;

namespace PulsarTestTask.ViewModels
{
    public class ProfileAttributeVM : ViewModelBase
    {
        #region Constructors
        public ProfileAttributeVM()
        {
            _attributeName = string.Empty;
            AttributeValue = string.Empty;
            InitButton();

        }
        public ProfileAttributeVM(string name, string value)
        {
            _attributeName = name;
            AttributeValue = value;
            InitButton();
        }

        private void InitButton()
        {
            ToggleTextBoxCommand = ReactiveCommand.Create(SwitchActive);
        }
        #endregion Constructors

        #region Bindings
        private string _attributeName;
        public string AttributeName
        {
            get
            {
                return _attributeName + ":";
            }
            private set
            {
                this.RaiseAndSetIfChanged(ref _attributeName, value);
            }
        }
        [Reactive]
        public string AttributeValue { get; set; }

        [Reactive]
        public bool IsEnabled { get; private set; } = false;

        [Reactive]
        public bool IsReadOnly { get; private set; } = true;

        public ReactiveCommand<Unit, Unit> ToggleTextBoxCommand { get; private set; }
        #endregion Bindings

        private void SwitchActive()
        {
            IsEnabled = !IsEnabled;
        }
    }
}
