public class Zug
{
    public string Destination { get; }
    public int AnzahlWagen { get; }

    public Zug(string destination, int anzahlWagen)
    {
        Destination = destination;
        AnzahlWagen = anzahlWagen;
    }

    public int GetAnzahlWagen() //get Funktion Wagen
    {
        return AnzahlWagen;
    }
}
