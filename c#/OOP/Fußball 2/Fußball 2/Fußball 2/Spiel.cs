using System;
using System.Collections.Generic;

namespace Fußball_2
{
    public class Spiel
    {
        Mannschaft heim, gast;   // Referenzen auf die beiden Teams (Heim und Gast)
        Random rnd = new Random();  // Zufalls-Generator für die Simulation

        // Konstruktor für das Spiel, nimmt die beiden Mannschaften als Parameter
        public Spiel(Mannschaft heim, Mannschaft gast)
        {
            this.heim = heim;   // Heim-Mannschaft
            this.gast = gast;   // Gast-Mannschaft
        }

        public void Simuliere()
        {
            Console.WriteLine($"{heim.Name} vs {gast.Name}");  // Anzeige des Spiels (Heim vs Gast)
            double staerkeHeim = heim.Teamstaerke();  // Berechnung der Teamstärke der Heim-Mannschaft
            double staerkeGast = gast.Teamstaerke();  // Berechnung der Teamstärke der Gast-Mannschaft

            // Simuliert 90 Minuten des Spiels
            for (int i = 0; i < 90; i++) // 90 Minuten
            {
                // 5% Chance auf einen Angriff pro Minute
                if (rnd.NextDouble() < 0.05)
                {
                    // Entscheidet zufällig, welches Team den Angriff startet
                    Mannschaft ang = rnd.NextDouble() < staerkeHeim / (staerkeHeim + staerkeGast) ? heim : gast;
                    Mannschaft def = ang == heim ? gast : heim;  // Defensiv-Team ist das gegnerische Team

                    // Zufälliger Spieler des angreifenden Teams wird ausgewählt
                    Spieler schuetze = ang.Spieler[rnd.Next(ang.Spieler.Count)];

                    // Torwart des verteidigenden Teams finden
                    Torwart torwart = null;
                    foreach (Spieler s in def.Spieler)
                    {
                        if (s is Torwart)
                        {
                            torwart = (Torwart)s;  // Wenn ein Torwart gefunden wird, wird er zugewiesen
                            break;
                        }
                    }

                    // Berechnung der Torschuss-Wahrscheinlichkeit
                    double chance = (schuetze.TorschussQualitaet / 100) * (1 - (torwart != null ? torwart.Reaktionsvermoegen : 50) / 150.0);
                    
                    // Wenn die Zufallszahl kleiner ist als die berechnete Chance, wird ein Tor geschossen
                    if (rnd.NextDouble() < chance)
                    {
                        schuetze.Tore++;  // Tor für den Spieler
                        Console.WriteLine($"Tor wurde geschossen von: {schuetze.Name}"); // Ausgabe des Torschützen
                    }
                }
                else
                {
                    Console.WriteLine("Kein Tor wurde geschossen.");
                }
            }

            // Tore zählen für das Heim-Team
            int toreHeim = 0;
            foreach (Spieler s in heim.Spieler)
                toreHeim += s.Tore;  // Tore des Heim-Teams summieren

            // Tore zählen für das Gast-Team
            int toreGast = 0;
            foreach (Spieler s in gast.Spieler)
                toreGast += s.Tore;  // Tore des Gast-Teams summieren

            // Endstand ausgeben
            Console.WriteLine($"Endstand: {heim.Name} {toreHeim} : {toreGast} {gast.Name}");
        }
    }
}
