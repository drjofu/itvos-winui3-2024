using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.Windows.AppLifecycle;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AppStartBeispiel
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

    private void myButton_Click(object sender, RoutedEventArgs e)
    {
      AppActivationArguments args = AppInstance.GetCurrent().GetActivatedEventArgs();
      ExtendedActivationKind kind = args.Kind;  
      myButton.Content = kind.ToString();
      if(kind== ExtendedActivationKind.Protocol)
      {
        if(args.Data is IProtocolActivatedEventArgs eventArgs)
        {
          Uri uri= eventArgs.Uri;
          myButton.Content = $"{kind.ToString()} - Uri: {uri.AbsoluteUri}, Query: {uri.Query}";
        }
      }
    }
  }
}
