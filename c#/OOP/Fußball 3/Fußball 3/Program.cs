using System;

namespace FootballGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Team t1 = new Team { Name = "Bayern" };
      Team t2 = new Team { Name = "BVB" };
      t1.MakeTeam();
      t2.MakeTeam();


      // Match-Info ausgeben
      Console.WriteLine("Welche zwei Mannschaften spielen: " + t1.Name + " vs " + t2.Name);

      // Abfrage: Wer greift an?
      Console.WriteLine("Welche Mannschaft schießen soll:");
      string input = Console.ReadLine(); // Eingabe speichern

      // Standard: BVB greift an
      Team attacker = t2;
      Team defender = t1;;


      // Falls Eingabe "Bayern" ist, Rollen tauschen
      if (input == t1.Name)
      {
        attacker = t1;
        defender = t2;
      }

      Console.WriteLine("Liste der Spieler (ohne Ersatzbank) mit Nummern:");
      // Liste der Angreifer ausgeben
      foreach (FieldPlayer p in attacker.FieldPlayers)
      {
        Console.WriteLine(p.Number + ": " + p.Name);
      }

      // Abfrage: Welcher Spieler schießt?
      Console.WriteLine("Nummer des Spielers der schießen Soll:");
      int num = int.Parse(Console.ReadLine()); // Nummer einlesen

      FieldPlayer shooter = null;

      // Passenden Spieler anhand der Nummer suchen
      foreach (FieldPlayer player in attacker.FieldPlayers)
      {
        if (player.Number == num)
        {
          shooter = player;
        }
      }

      // Schuss und Parade berechnen 
      int shot = shooter.Shoot();
      int parry = defender.Goalkeeper.Parry();

      // Ergebnisse anzeigen
      Console.WriteLine("Name des Spielers: " + shooter.Name + ", Schussstärke: " + shot);
      Console.WriteLine("Name des Torwartes: " + defender.Goalkeeper.Name + ", Parade: " + parry);

      // Vergleich: Wer gewinnt das Duell?
      if (shot > parry)
      {
        Console.WriteLine("Wer hat gewonnen: " + shooter.Name); // Schütze gewinnt
      }
      else
      {
        Console.WriteLine("Wer hat gewonnen: " + defender.Goalkeeper.Name); // Torwart gewinnt
      }
      Console.ReadKey();
    }
  }
}