using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Data;

namespace DapperToolkitSamples.UILogic.Converters
{
    public class CaseConverter : IValueConverter
    {
        public CharacterCasing Case { get; set; }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var text = value as string;
            if (null == text) return string.Empty;
            switch (Case)
            {
                case CharacterCasing.Upper:
                    return text.ToUpper();
                case CharacterCasing.Lower:
                    return text.ToLower();
                default:
                    return text;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public enum CharacterCasing
    {
        Upper,
        Lower
    }
}
