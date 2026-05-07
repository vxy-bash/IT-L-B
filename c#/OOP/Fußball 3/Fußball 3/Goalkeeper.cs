using System;

namespace FootballGame
{
  public class Goalkeeper : Player
  {
    public int Reaction { get; set; } // Eigenschaft Reaktionsvermögen wird hinzugefügt

    // Methode: Versuch den Ball zu halten
    public int Parry()
    {
      // Berechnung: Reaktion + Zufallsfaktor (-1, 0 oder 1)
      return Reaction + Random.Shared.Next(-1, 2);
    }
  }
}