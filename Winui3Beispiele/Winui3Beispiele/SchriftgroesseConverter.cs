using Microsoft.UI.Xaml.Data;
using System;

namespace Winui3Beispiele
{
  public class SchriftgroesseConverter : IValueConverter
  {
    public double Offset { get; set; } = 20;
    public double Faktor { get; set; } = 2;

    public object Convert(object value, Type targetType, object parameter, string language)
    {
      double wert = (double)value;
      return Offset + wert * Faktor;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
      throw new NotImplementedException();
    }
  }
}
