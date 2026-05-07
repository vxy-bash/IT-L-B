namespace Fußball_2
{
    public class Spieler
    {
        // Attribute von Spielern
        public string Name;
        public int Alter;
        public double Spielstaerke;
        public double TorschussQualitaet;
        public double Motivation;
        public int Tore = 0;
        
        public Spieler(string name, int alter, double staerke, double torschuss, double motivation)
        {
            Name = name;
            Alter = alter;
            Spielstaerke = staerke;
            TorschussQualitaet = torschuss;
            Motivation = motivation;
        }
    }
}