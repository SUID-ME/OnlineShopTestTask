﻿using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;

namespace PulsarTestTask.ViewModels
{
    public class NavigationTitleVM : ViewModelBase
    {
        [Reactive]
        public string Title { get; set; } = "Home";

        public NavigationTitleVM() { }

        public NavigationTitleVM(NavigationMenuVM menuVM)
        {
            if (menuVM.SelectedItem != null)
            {
                Title = menuVM.SelectedItem.Title;
            }

            menuVM.WhenAnyValue(x => x.SelectedItem)
                .Subscribe(item => Title = item.Title);
        }
    }
}
