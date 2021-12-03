using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Laboratory_Work_7._1
{
    class DateConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            int day = 0;
            int month = 0;
            int year = 0;

            if (!int.TryParse(values[0].ToString(), out day))
            {
                return "Incorrect value - day";
            }
            if (!int.TryParse(values[1].ToString(), out month))
            {
                return "Incorrect value - month";
            }
            if (!int.TryParse(values[2].ToString(), out year))
            {
                return "Incorrect value - year";
            }

            return new DateTime(year, month, day);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return value.ToString().Split('.');
        }
    }
}
