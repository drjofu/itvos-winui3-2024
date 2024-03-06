﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMMini
{
  public class ViewModel : INotifyPropertyChanged
  {
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private int zahl1;

    public int Zahl1
    {
      get { return zahl1; }
      set { zahl1 = value; }
    }

    private int zahl2;

    public int Zahl2
    {
      get { return zahl2; }
      set { zahl2 = value; }
    }

    private int ergebnis;

    public int Ergebnis
    {
      get { return ergebnis; }
      set { ergebnis = value; OnPropertyChanged(); }
    }

    public ActionCommand PlusCommand { get; set; }
    public ActionCommand MinusCommand { get; set; }

    public ViewModel()
    {
      PlusCommand = new ActionCommand(Plus);
      MinusCommand = new ActionCommand(Minus);
    }
    
    private void Plus()
    {
      // hier würde das Model aufgerufen werden
      Ergebnis = Zahl1 + Zahl2;
    }

    private void Minus()
    {
      Ergebnis = Zahl1 - Zahl2;
    }

  }
}
