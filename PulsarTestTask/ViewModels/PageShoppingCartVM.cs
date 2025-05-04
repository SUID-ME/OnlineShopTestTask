using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.ObjectModel;

namespace PulsarTestTask.ViewModels
{
    public class PageShoppingCartVM : ViewModelBase
    {
        #region Constructor
        public PageShoppingCartVM() {
            CartContent = App.CartList;
            CartListCount = CartContent.Count;

            this.WhenAnyValue(x => x.CartContent.Count)
                .Subscribe(count =>
                {
                    CartListCount = count;
                });
        }
        #endregion Constructor

        #region Bindings
        public ObservableCollection<CartContent> CartContent { get; }

        [Reactive]
        public int CartListCount { get; set; }
        #endregion Bindings
    }
}
