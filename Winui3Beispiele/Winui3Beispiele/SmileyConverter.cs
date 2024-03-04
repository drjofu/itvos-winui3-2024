using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winui3Beispiele
{
  public class SmileyConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, string language)
    {
      double wert =(double)value;
      if (wert < 50) return "😊";
      if (wert < 80) return "😉";
      return "😒";
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
      throw new NotImplementedException();
    }
  }
}
