using Avalonia.Controls;
using Avalonia;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Xaml.Interactivity;
using System.Reactive.Linq;
using System.Windows.Input;

namespace PulsarTestTask.Behaviors;

public class RightClickBehavior : Behavior<Control>
{
    public static readonly AvaloniaProperty<ICommand> CommandProperty =
        AvaloniaProperty.Register<RightClickBehavior, ICommand>(nameof(Command));

    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    protected override void OnAttached()
    {
        AssociatedObject?.AddHandler(
            InputElement.PointerPressedEvent,
            OnPointerPressed,
            RoutingStrategies.Tunnel);
    }

    private void OnPointerPressed(object sender, PointerPressedEventArgs e)
    {
        if (e.GetCurrentPoint(AssociatedObject).Properties.IsRightButtonPressed)
        {
            Command?.Execute(null);
        }
    }
}