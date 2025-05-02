using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;

namespace PulsarTestTask.ViewModels
{
    public class NavigationMenuVM : ViewModelBase
    {
        #region BindingItems
        [Reactive] public bool IsExpanded { get; private set; }
        [Reactive] public Avalonia.Layout.HorizontalAlignment HorizontalAlignment { get; private set; } = Avalonia.Layout.HorizontalAlignment.Center;
        [Reactive] public MenuItemVM SelectedItem { get; set; }

        public ReactiveCommand<Unit, Unit> ToggleMenuCommand { get; }

        public ObservableCollection<MenuItemVM> MenuItems { get; private set; }
        #endregion BindingItems

        #region Constructor
        public NavigationMenuVM()
        {
            ToggleMenuCommand = ReactiveCommand.Create(() =>
                {
                    IsExpanded = !IsExpanded;
                    if (IsExpanded == true)
                    {
                        HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Left;
                    }
                    else
                    {
                        HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center;
                    }
                });

            CreateMenuItems();
            SelectedItem = MenuItems.First();
        }

        private void CreateMenuItems()
        {
            MenuItems =
            [
                new()
                {
                    Title = "Магазин",
                    IconPath = "M12,3L2,12H5V20H19V12H22L12,3Z"
                },

                new ()
                {
                    Title = "Корзина",
                    IconPath = "M10,2H14A1,1 0 0,1 15,3V6H13V4H11V6H9V3A1,1 0 0,1 10,2M7,7H17V21A2,2 0 0,1 15,23H9A2,2 0 0,1 7,21V7Z"
                },

                new ()
                {
                    Title = "Профиль",
                    IconPath = "M12,4A4,4 0 0,1 16,8A4,4 0 0,1 12,12A4,4 0 0,1 8,8A4,4 0 0,1 12,4M12,14C16.42,14 20,15.79 20,18V20H4V18C4,15.79 7.58,14 12,14Z"
                }
            ];
        }
        #endregion Constructor
    }
}
