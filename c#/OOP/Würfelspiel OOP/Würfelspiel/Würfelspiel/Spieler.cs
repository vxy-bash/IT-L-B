using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Würfelspiel
{
    internal class Spieler
    {
        // Eigenschaften für Name und Punktestand
        public string Name { get; set; } = "";
        public int Punkte { get; set; } = 0;

        // Zentrale Liste aller Spieler
        public static List<Spieler> SpielerListe = new List<Spieler>();

        // Leerer Konstruktor
        public Spieler() { }

        // Konstruktor: Setzt Werte und fügt Spieler der Liste hinzu
        public Spieler(string name, int punkte = 0)
        {
            Name = name;
            Punkte = punkte;
            SpielerListe.Add(this);
        }
    }
}