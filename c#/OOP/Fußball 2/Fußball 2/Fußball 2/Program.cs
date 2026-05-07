using System;
using Fußball_2; 

namespace Fussball_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Trainer erstellen 
            var trainerA = new Trainer("M. Berger", 45, 70); 
            var trainerB = new Trainer("L. Novak", 50, 60);

            //  Teams (Mannschaften) anlegen 
            var teamA = new Mannschaft("SV Alpen", trainerA);
            var teamB = new Mannschaft("FC Donau", trainerB);

            //  Torwarte hinzufügen 
            teamA.AddSpieler(new Torwart("K. Müller", 29, 65, 10, 60, 75));
            teamB.AddSpieler(new Torwart("A. Novak", 31, 63, 8, 65, 70));

            //  Feldspieler für Team A 
            teamA.AddSpieler(new Spieler("A. Huber", 24, 72, 78, 80));
            teamA.AddSpieler(new Spieler("B. Schmidt", 27, 68, 70, 75));
            teamA.AddSpieler(new Spieler("C. Meier", 22, 74, 65, 85));
            teamA.AddSpieler(new Spieler("D. Köhler", 30, 66, 60, 70));
            teamA.AddSpieler(new Spieler("E. Weber", 26, 70, 72, 77));

            //  Feldspieler für Team B 
            teamB.AddSpieler(new Spieler("F. Brandt", 25, 69, 75, 78));
            teamB.AddSpieler(new Spieler("G. Richter", 28, 67, 68, 72));
            teamB.AddSpieler(new Spieler("H. Lang", 23, 71, 66, 80));
            teamB.AddSpieler(new Spieler("I. Kraus", 29, 65, 62, 68));
            teamB.AddSpieler(new Spieler("J. Vogel", 27, 73, 74, 82));

            //  Spiel anlegen und simulieren 
            var spiel = new Spiel(teamA, teamB);
            spiel.Simuliere(); // Hier läuft die eigentliche Logik des Spiels ab

            // Programm wird beendet
            Console.WriteLine("\nSpiel beendet. Taste drücken zum Beenden..."); 
            Console.ReadKey(); // Hält das Fenster offen, bis der Benutzer eine Taste drückt
        }
    }
}
