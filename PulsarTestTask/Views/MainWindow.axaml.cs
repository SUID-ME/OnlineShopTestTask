using Avalonia.Controls;
using Avalonia.ReactiveUI;
using PulsarTestTask.ViewModels;

namespace PulsarTestTask.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}