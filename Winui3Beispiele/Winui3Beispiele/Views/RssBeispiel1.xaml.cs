using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System.ServiceModel.Syndication;
using System.Xml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Winui3Beispiele.Views
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class RssBeispiel1 : Page
  {
    public SyndicationFeed Feed { get; set; }

    public RssBeispiel1()
    {
      this.InitializeComponent();

      var reader = XmlReader.Create("https://www.n-tv.de/rss");
      var feed =SyndicationFeed.Load(reader);
      Feed = feed;
    }
  }
}
