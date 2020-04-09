using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows;
namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Converts an enum to boolean for radio button data binding
    /// </summary>
    public class EnumBooleanConverter: IValueConverter
    {
        /// <summary>
        /// Converts an enum value into a boolean
        /// </summary>
        /// <param name="value">Enum to convert</param>
        /// <param name="targetType">Type to convert to</param>
        /// <param name="param">The enum value to compare to</param>
        /// <param name="culture">The culture info</param>
        /// <returns>True if the value matches param, false otherwise</returns>
        public object Convert(object value, Type targetType, object param, CultureInfo culture)
        {
            return value.Equals(param);
        }

        /// <summary>
        /// Converts a boolean into an enum
        /// </summary>
        /// <param name="value">Boolean to convert</param>
        /// <param name="targetType">Type to convert to</param>
        /// <param name="param">The enum value to check</param>
        /// <param name="culture">The culture info</param>
        /// <returns>The original enum</returns>
        public object ConvertBack(object value, Type targetType, object param, CultureInfo culture)
        {
            if ((bool)value) return param;
            else return DependencyProperty.UnsetValue;
        }
    }
}
