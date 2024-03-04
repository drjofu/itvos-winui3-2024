using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Winui3Beispiele
{
  /// <summary>
  /// An empty window that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainWindow : Window
  {
    public MainWindow()
    {
      this.InitializeComponent();
    }

    private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
    {
      string typname = args.InvokedItemContainer.Tag as string;
      typname = $"{nameof(Winui3Beispiele)}.{typname}";
      var type = Assembly.GetExecutingAssembly().GetType(typname);
      contentFrame.Navigate(type);
    }
  }
}
