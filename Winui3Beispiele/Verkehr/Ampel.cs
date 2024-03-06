using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Shapes;
using System.ComponentModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Verkehr
{
  [TemplatePart(Name = "PART_LampeRot", Type = typeof(Shape))]
  [TemplatePart(Name = "PART_LampeGruen", Type = typeof(Shape))]
  public sealed class Ampel : Control
  {
    public Ampel()
    {
      this.DefaultStyleKey = typeof(Ampel);
    }

    private Shape lampeRot;
    private Shape lampeGruen;

    //propdp
    [Category("verkehr")]
    [Description("tolle Ampel...")]
    public bool? IstGruen
    {
      get { return (bool?)GetValue(IstGruenProperty); }
      set { SetValue(IstGruenProperty, value); }
    }

    // Using a DependencyProperty as the backing store for IstGruen.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty IstGruenProperty =
        DependencyProperty.Register(nameof(IstGruen), typeof(bool?), typeof(Ampel), 
          new PropertyMetadata(false,OnIstGruenChanged));

    private static void OnIstGruenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      var ampel = (Ampel)d;
      ampel.Schalten();
    }

    protected override void OnApplyTemplate()
    {
      base.OnApplyTemplate();
      lampeRot = (Shape) GetTemplateChild("PART_LampeRot");
      lampeGruen = (Shape)GetTemplateChild("PART_LampeGruen");
      Schalten();
    }

    private void Schalten()
    {
      // Template schon da?
      if(lampeRot is null) return;

      if (IstGruen.GetValueOrDefault(false))
      {
        lampeGruen.Opacity = 1;
        lampeRot.Opacity = 0.2;
      }
      else
      {
        lampeGruen.Opacity = 0.2;
        lampeRot.Opacity = 1;
      }
    }
  }
}
