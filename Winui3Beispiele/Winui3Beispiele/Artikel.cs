using System.Collections.Generic;

namespace Winui3Beispiele
{
  public class Artikel
  {
    public int Artikelnummer { get; set; }
    public string Bezeichnung { get; set; }
    public double Preis { get; set; }
  }

  public class Laden
  {
    public string Name { get; set; } = "Hinz & Kunz";
    public List<Artikel> Artikel { get; set; } = new()
    {
      new Artikel { Artikelnummer=1, Bezeichnung="Taucherbrille", Preis=50 },
      new Artikel { Artikelnummer=34, Bezeichnung="Haiattrappe", Preis=70 },
      new Artikel { Artikelnummer=14, Bezeichnung="Schnorchel", Preis=6 },
      new Artikel { Artikelnummer=17, Bezeichnung="Badehose", Preis=22 },
      new Artikel { Artikelnummer=19, Bezeichnung="Flossen", Preis=60 }
    };
  }
}

