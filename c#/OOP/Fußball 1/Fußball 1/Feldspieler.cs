using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fußball_1
{
    internal class Feldspieler : Sportchef
    {
        public List<string> spieler = new List<string>(); //Erstellt Liste  

        public void SpielerHinzufügen(string name)       // Methode zum Spieler hinzufügen
        {
            spieler.Add(name);
        }

        public void SpielerAusgeben()       //Methode Spieler ausgeben
        {
            foreach (string s in spieler)
            {
                Console.WriteLine(s);
            }
        }
    }
}
