using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;

namespace PulsarTestTask.ViewModels
{
    public class PageContentVM : ViewModelBase
    {
        public PageContentVM()
        {
            CurrentVM = new PageShopVM();
        }

        public PageContentVM(NavigationMenuVM menuVM)
        {
            if (menuVM.SelectedItem != null)
            {
                CurrentVM = menuVM.SelectedItem.ViewModel;
            }

            menuVM.WhenAnyValue(x => x.SelectedItem)
                .Subscribe(item => CurrentVM = item.ViewModel);
        }

        [Reactive]
        public ViewModelBase CurrentVM { get; set; }
    }
}
