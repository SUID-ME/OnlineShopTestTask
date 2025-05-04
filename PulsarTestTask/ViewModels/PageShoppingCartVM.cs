using System.Collections.ObjectModel;

namespace PulsarTestTask.ViewModels
{
    public class PageShoppingCartVM : ViewModelBase
    {
        public ObservableCollection<CartContent> CartContent { get; set; } = App.CartList;
    }
}
