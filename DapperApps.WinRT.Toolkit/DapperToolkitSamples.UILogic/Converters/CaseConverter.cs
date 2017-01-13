/*
 * Copyright (c) Dapper Apps.  All rights reserved.
 * Use of this sample source code is subject to the terms of the Dapper Apps license 
 * agreement under which you licensed this sample source code and is provided AS-IS.
 * If you did not accept the terms of the license agreement, you are not authorized 
 * to use this sample source code.  For the terms of the license, please see the 
 * license agreement between you and Dapper Apps.
 *
 * To see the article about this app, visit http://www.dapper-apps.com/DapperToolkit
 */

using System;
using Windows.UI.Xaml.Data;

namespace DapperToolkitSamples.Converters
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
