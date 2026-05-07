using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fußball_1
{
    internal class Ersatzbank : Sportchef
    {
        public List<string> ersatzbank = new List<string>(); // erstellt Ersatzbank Liste
        
        public void SpielerHinzufügen(string name)   // Methode für Spieler Hinzufügen
        {
        ersatzbank.Add(name);
        }

        public void SpielerAusgeben()   //ausgabe Methode
        {
        foreach (string s in ersatzbank)
            {
                Console.WriteLine(s);
            }
        }
    }
}
