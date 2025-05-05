using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace PulsarTestTask.ViewModels
{
    public class ProfileAttributeVM : ViewModelBase
    {
        #region Constructors
        public ProfileAttributeVM()
        {
            _attributeName = string.Empty;
            AttributeValue = string.Empty;
        }
        public ProfileAttributeVM(string name, string value)
        {
            _attributeName = name;
            AttributeValue = value;
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
        #endregion Bindings
    }
}
