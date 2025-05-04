using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using PulsarTestTask.Models;
using PulsarTestTask.ViewModels;
using PulsarTestTask.Views;
using System.Collections.ObjectModel;

namespace PulsarTestTask
{
    public partial class App : Application
    {
        public static ShopContent ShopContent { get; set; } = new();
        public static ObservableCollection<CartContent> CartList { get; set; } = [];

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}