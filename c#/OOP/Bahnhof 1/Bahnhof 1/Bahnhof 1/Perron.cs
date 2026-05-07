using System;
using System.Collections.Generic;

public class Perron
{
    private List<Zug> zuege = new List<Zug>();

    public void AddZug(Zug zug) // Zug hinzufügen Methode
    {
        zuege.Add(zug);
    }

    public int AnzahlZuege()    //anzahl Züge anzahl
    {
        return zuege.Count;
    }

    public int AnzahlWagen()    //anzahl Wagen anzahl ausgeben
    {
        int summe = 0;
        foreach (var zug in zuege)
        {
            summe += zug.GetAnzahlWagen();
        }
        return summe;
    }

    public void DestinationsListeDrucken()  //Destinationen ausgeben
    {
        foreach (var zug in zuege)
        {
            Console.WriteLine(zug.Destination);
        }
    }

    public List<Zug> GetZuege() //get funktion für Züge
    {
        return zuege;
    }
}
