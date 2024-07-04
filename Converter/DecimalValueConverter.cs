using System;
using System.Globalization;
using System.Windows.Data;

namespace Minimal_injection;

public class DecimalValueConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is decimal decimalValue)
        {
            return decimalValue.ToString(culture);
        }
        return value?.ToString();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (decimal.TryParse(value as string, NumberStyles.Any, culture, out decimal decimalValue))
        {
            return decimalValue;
        }
        return 0m;
    }
}
