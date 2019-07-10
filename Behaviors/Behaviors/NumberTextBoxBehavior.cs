using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace Behaviors
{
    enum NumberType { Integer,Double,Decimal}
    class NumberTextBoxBehavior : Behavior<TextBox>
    {
        // override OnAttached
        // override OnDetaching
        public NumberType NumberType { get; set; }

        private string oldText = string.Empty;
        private int oldCarretIndex = 0;
        private bool originalEvent = true;

        protected override void OnAttached()
        {
            // base.OnAttached();
            AssociatedObject.TextChanged += CheckIfOnlyNumbers;
        }
        protected override void OnDetaching()
        {
            // base.OnDetaching();
            AssociatedObject.TextChanged -= CheckIfOnlyNumbers;
        }



        private void CheckIfOnlyNumbers(object sender, TextChangedEventArgs e)
        {
            if(originalEvent)
                oldCarretIndex = AssociatedObject.CaretIndex;
            if (Int32.TryParse(AssociatedObject.Text, out _) == false)
            {
                originalEvent = false;
                AssociatedObject.Text = oldText;
                AssociatedObject.CaretIndex = oldCarretIndex -1;
            }
            else
            {
                oldText = AssociatedObject.Text;
            }
            originalEvent = true;
        }




    }
}
