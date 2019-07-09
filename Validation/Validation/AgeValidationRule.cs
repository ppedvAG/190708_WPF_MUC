using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Validation
{
    class AgeValidationRule : ValidationRule
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if(Int32.TryParse(value.ToString(),out int age))
            {
                if(age >= Minimum && age <= Maximum)
                    return new ValidationResult(true, null);
                else
                    return new ValidationResult(false, $"Das Alter darf nur in einem Bereich zwische {Minimum} und {Maximum} sein");
            }
            else
                return new ValidationResult(false, "Ungültiger Wert: Bitte geben Sie nur ganze Int32-Zahlen ein");
        }
    }
}
