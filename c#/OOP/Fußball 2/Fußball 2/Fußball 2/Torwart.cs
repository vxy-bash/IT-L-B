namespace Fußball_2
{
    public class Torwart : Spieler // Fügt alle Attribute von Spielern hinzu (erbt von Spieler)
    {
        // fügt extra Attribut hinzu
        public double Reaktionsvermoegen;

        // Konstruktor
        public Torwart(string name, int alter, double staerke, double torschuss, double motivation, double reaktion)
            : base(name, alter, staerke, torschuss, motivation)
        {
            Reaktionsvermoegen = reaktion;
        }
    }
}