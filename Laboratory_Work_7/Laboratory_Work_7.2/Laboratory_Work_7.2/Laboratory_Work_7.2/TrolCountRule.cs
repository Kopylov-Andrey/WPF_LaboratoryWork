
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Laboratory_Work_7._2
{
    public class TrolCountRule : ValidationRule
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int total = 0;
            try
            {
                if (value.ToString().Length > 0)
                {
                    total = int.Parse(value.ToString());
                }
            }
            catch
            {
                return new ValidationResult(false, "Некорректный ввод");
            }
            if (total <= Min || total >= Max)
            {
                return new ValidationResult(false, "Общее число вышло за пределы диапазона");
            }
            return ValidationResult.ValidResult;
        }
    }
}
