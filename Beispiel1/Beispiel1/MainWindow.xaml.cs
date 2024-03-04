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
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Beispiel1
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

    private async void MeinButtonClickAsync(object sender, RoutedEventArgs e)
    {
      TB_Ausgabe.Text = $"Jetzt ist es {DateTime.Now.ToLongTimeString()}";

      ContentDialog dialog = new ContentDialog();

      // XamlRoot must be set in the case of a ContentDialog running in a Desktop app
      dialog.XamlRoot= TB_Ausgabe.XamlRoot;
      dialog.Style = Application.Current.Resources["DefaultContentDialogStyle"] as Style;
      dialog.Title = "Ohh - Der Button wurde gedrückt...";
      dialog.Content= $"Jetzt ist es {DateTime.Now.ToLongTimeString()}";
      dialog.PrimaryButtonText = "OK";
      dialog.DefaultButton = ContentDialogButton.Primary;
     

      var result = await dialog.ShowAsync();

    }

    private void DerErsteButtonClick(object sender, RoutedEventArgs e)
    {
      ((Button)sender).Content = DateTime.Now.ToLongTimeString();
    }
  }
}
