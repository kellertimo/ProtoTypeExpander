
using System;
using System.Globalization;

namespace ProtoType_Expander.Converters
{
	public class ExpandButtonImageSourceConverter : IValueConverter
    {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((Boolean)value)
            {
                return ImageSource.FromFile("expand_less.png");
            }
            else
            {
                return ImageSource.FromFile("expand_more.png");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

