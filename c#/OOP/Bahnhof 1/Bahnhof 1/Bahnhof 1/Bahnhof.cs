using System;
using System.Collections.Generic;
using System.Linq;

public class Bahnhof
{
    private List<Perron> perrons = new List<Perron>();

    public void AddPerron(Perron perron) // Perron Hinzufügen
    {
        perrons.Add(perron);
    }

    public int AnzahlZuege()    //Anzahl Züge
    {
        return perrons.Sum(p => p.AnzahlZuege());
    }

    public int AnzahlWagen()    //Anzahl Wagen
    {
        return perrons.Sum(p => p.AnzahlWagen());
    }

    public void DestinationsListeDrucken() //Destinatuins Liste Ausgeben
    {
        var destinations = new HashSet<string>();
        foreach (var perron in perrons)
        {
            foreach (var zug in perron.GetZuege())
            {
                destinations.Add(zug.Destination);
            }
        }

        foreach (var dest in destinations)
        {
            Console.WriteLine(dest);
        }
    }

    public List<Perron> GetPerrons()    //get funktions für Bahnsteige
    {
        return perrons; 
    }
}
