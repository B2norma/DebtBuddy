using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DebtBuddy.Forms.Converters
{
    class DoubleToInterestRateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string.Format("{0:0.00}", value) + "%");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return string.Format("{0:0.00}", ((string)value).Trim().Replace("%", ""));
            }
            catch
            {
                return 00.00;
            }
        }
    }
}
