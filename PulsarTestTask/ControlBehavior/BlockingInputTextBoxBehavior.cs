using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Xaml.Interactivity;

namespace PulsarTestTask.ControlBehavior
{
    public class BlockingInputTextBoxBehavior : Behavior<TextBox>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.PointerPressed  += OnPointerPressed;
        }

        private void OnPointerPressed(object sender, PointerPressedEventArgs e)
        {
            if (e.GetCurrentPoint(AssociatedObject).Properties.IsRightButtonPressed)
            {
                AssociatedObject.IsReadOnly = !AssociatedObject.IsReadOnly;
                e.Handled = true;
            }
        }

        protected override void OnDetaching()
        {
            AssociatedObject.PointerPressed -= OnPointerPressed;
            base.OnDetaching();
        }
    }
}
