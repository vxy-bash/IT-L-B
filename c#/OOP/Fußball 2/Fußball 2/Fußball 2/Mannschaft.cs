using System.Collections.Generic;
using System.Linq;

namespace Fußball_2
{
    public class Mannschaft
    {
        public string Name;
        public Trainer Trainer;
        public List<Spieler> Spieler = new List<Spieler>();

        // Konstruktor
        public Mannschaft(string name, Trainer trainer)
        {
            Name = name;
            Trainer = trainer;
        }

        public void AddSpieler(Spieler s) => Spieler.Add(s);

        
        // berechnet durchschnitte
        public double Teamstaerke()
        {
            double avgStaerke = Spieler.Average(s => s.Spielstaerke);
            double avgMotivation = Spieler.Average(s => s.Motivation);
            return avgStaerke * 0.8 + avgMotivation * 0.15 + Trainer.Erfahrung * 0.05;
        }
    }
}