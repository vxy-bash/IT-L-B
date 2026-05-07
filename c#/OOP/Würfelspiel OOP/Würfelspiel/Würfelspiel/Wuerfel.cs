using System;
using System.Collections.Generic;
using System.Text;

namespace Würfelspiel
{
    internal class Wuerfel
    {
        public int zahl; // Aktuelle Augenzahl

        public Wuerfel()
        {
            // Konstruktor
        }

        public int GetZahl()
        {
            return zahl; // Gibt Zahl zurück
        }

        public void Werfen()
        {
            // Zufallszahl zwischen 1 und 6 generieren
            this.zahl = new Random().Next(1, 7);
        }
    }
}