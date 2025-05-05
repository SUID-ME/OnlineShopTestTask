using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Styling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulsarTestTask.ControlBehavior
{
    public class CustomTextBox : TextBox, IStyleable
    {
        public Type StyleKey => typeof(TextBox);

        protected override void OnPointerPressed(PointerPressedEventArgs e)
        {
            SwitchActive(e);
            base.OnPointerPressed(e);
        }

        private void SwitchActive(PointerPressedEventArgs e)
        {
            if (e.GetCurrentPoint(this).Properties.IsRightButtonPressed)
            {
                this.IsReadOnly = !this.IsReadOnly;
            }
        }
    }
}
