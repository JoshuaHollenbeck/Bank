using System.Reflection.Emit;
using Microsoft.VisualBasic.CompilerServices;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Bank.Utilities
{
    public class BoolToValueConverter<T> : IValueConverter
    {
        public T FalseValue { get; set; }
        public T TrueValue { get; set; }

        public object Convert(
            object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture
        )
        {
            if (value == null)
                return FalseValue;
            else
                return (bool)value ? TrueValue : FalseValue;
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture
        )
        {
            return value != null ? value.Equals(TrueValue) : false;
        }
    }
    public class BoolToStringConverter : BoolToValueConverter<String> { }
    public class BoolToBrushConverter : BoolToValueConverter<Brush> { }
    public class BoolToFontWeightConverter : BoolToValueConverter<FontWeight> { }

}
