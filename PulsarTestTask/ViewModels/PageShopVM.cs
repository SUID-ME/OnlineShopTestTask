using DynamicData;
using PulsarTestTask.Converters;
using PulsarTestTask.Models;
using ReactiveUI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;

namespace PulsarTestTask.ViewModels
{
    public class PageShopVM : ViewModelBase
    {
        #region Constructor
        public PageShopVM()
        {
            BuyCommand = ReactiveCommand.Create<ShopItem>(BuyLogic);

            ShopItems.AddRange(App.ShopContent.GetContent());

            _bitmapLoader.LoadBitmaps(ShopItems.ToList());
        }
        #endregion Constructor

        #region Bindings
        public ObservableCollection<ShopItem> ShopItems { get; } = [];

        public ReactiveCommand<ShopItem, Unit> BuyCommand { get; set; }
        #endregion Bindings

        #region Methods
        public void BuyLogic(ShopItem item)
        {
            CartContent? content = App.CartList.FirstOrDefault(x => x.Name == item.Name);
            if (content != null)
            {
                content.Count++;
            }
            else
            {
                content = new CartContent(item);
                App.CartList.Add(content);
            }

        }
        #endregion Methods

        #region Fields
        private BitmapLoader<ShopItem> _bitmapLoader = new();
        #endregion Fields
    }
}
