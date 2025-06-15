using System.Globalization;

namespace MissingChildrenSA.Utilities;

public class DictionaryValueConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var key = parameter?.ToString();

        if (value is Dictionary<string, string> dict && key != null && dict.TryGetValue(key, out var error))
        {
            return error;
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
