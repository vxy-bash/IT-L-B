using System;
using System.Collections.Generic;

namespace FootballGame
{
  public class Team
  {

    List<string> Names = new List<string>
{
    "Schmidt",
    "Müller",
    "Fischer",
    "Weber",
    "Meyer",
    "Wagner",
    "Becker",
    "Schulz",
    "Hoffmann",
    "Schäfer",
    "Koch",
    "Bauer",
    "Richter",
    "Klein",
    "Wolf",
    "Schröder",
    "Neumann",
    "Schwarz",
    "Zimmermann",
    "Braun",
    "Krüger",
    "Bergmann",
    "Hartmann",
    "Franke",
    "Jäger",
    "Seidel",
    "Peters",
    "Krause",
    "Lehmann",
    "Hahn",
    "Schubert",
    "Vogel",
    "Friedrich",
    "Keller",
    "Lange",
    "Maurer",
    "Pohl",
    "Thiel",
    "Wendel",
    "Groß"
};

    Random randomshoot = new Random();  
    Random random = new Random();
    public string Name { get; set; }
    public Goalkeeper Goalkeeper { get; set; }
    // Field Players Liste wird erstellt
    public List<FieldPlayer> FieldPlayers { get; set; }

    public Team()
    {
      FieldPlayers = new List<FieldPlayer>();
    }





    public void MakeTeam()
    {
      // Feldspieler erstellen
      // Erstellt 12 FieldPlayer-Objekte
      for (int i = 0; i <= 11; i++)
      {
        string newname = Names[random.Next(Names.Count)];
        int shootq = randomshoot.Next(0, 10);

        FieldPlayer player = new FieldPlayer { Name = newname, Number = i, ShootingQuality = shootq };

        FieldPlayers.Add(player); // Fügt Spieler dem Team hinzu
      }

      // Torwart erstellen und zuweisen

      Random goalier = new Random();
      Random parryq = new Random();

      int parryw = parryq.Next(0, 10);
      string newgname = Names[goalier.Next(Names.Count)];

      // Erstellt das Goalkeeper-Objekt
      Goalkeeper goalie = new Goalkeeper { Name = newgname, Reaction = parryw };

      // Weist den Torwart dem Team zu
      this.Goalkeeper = goalie;
    }
  }
}