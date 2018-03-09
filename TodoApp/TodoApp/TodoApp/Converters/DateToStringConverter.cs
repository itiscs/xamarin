using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TodoApp.Converters
{
    public class StringToDateConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime dt;
            if (DateTime.TryParse(value.ToString(), out dt))
                return dt;
            else
                return DateTime.Now;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((DateTime)value).ToString("MM/dd/yyyy");
        }
    }
}
