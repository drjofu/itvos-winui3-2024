using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Winui3Beispiele
{
  public class Artikel : INotifyPropertyChanged
  {
    public int Artikelnummer { get; set; }
    public string Bezeichnung { get; set; }
    //public double Preis { get; set; }
    private double preis;

    public double Preis
    {
      get { return preis; }
      set
      {
        if (preis == value) return;
        preis = value;
        //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Preis)));
        OnPropertyChanged();
      }
    }

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public event PropertyChangedEventHandler PropertyChanged;
  }

  public class Laden
  {
    public string Name { get; set; } = "Hinz & Kunz";
    public ObservableCollection<Artikel> Artikel { get; set; } = new()
    {
      new Artikel { Artikelnummer=1, Bezeichnung="Taucherbrille", Preis=50 },
      new Artikel { Artikelnummer=34, Bezeichnung="Haiattrappe", Preis=70 },
      new Artikel { Artikelnummer=14, Bezeichnung="Schnorchel", Preis=6 },
      new Artikel { Artikelnummer=17, Bezeichnung="Badehose", Preis=22 },
      new Artikel { Artikelnummer=19, Bezeichnung="Flossen", Preis=60 }
    };

    public void ArtikelHinzufuegen()
    {
      Artikel.Add(new Artikel { Artikelnummer = 1000, Bezeichnung = "was ganz neues", Preis = 1000 });
    }
    public void PreiseErhoehen()
    {
      foreach(var item in Artikel)
      {
        item.Preis *= 1.1;
      }
    }
  }
}

