using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winui3Beispiele.Views
{
  public class ArtikelTemplateSelector : DataTemplateSelector
  {
    public List<DataTemplate> Templates { get; set; } = new List<DataTemplate>();

    protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
    {
      // Prüfungen einbauen (item is null, Templates.Count <2 etc.)
      var artikel = item as Artikel;
      if (artikel.Preis <= 50)
        return Templates[0];
      return Templates[1];
    }
  }
}
