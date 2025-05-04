using DynamicData;
using PulsarTestTask.Models;
using ReactiveUI.Fody.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;

namespace PulsarTestTask.ViewModels
{
    public class PageShoppingCartVM : ViewModelBase
    {
        public ObservableCollection<CartContent> CartContent { get; set; } = App.CartList;
    }

    public class CartContent : ViewModelBase
    {
        public required string Name { get; set; }
        [Reactive]
        public int Count { get; set; }
    }
}
