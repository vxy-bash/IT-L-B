using System;

class Program
{
    static void Main(string[] args)
    {
        // Züge
        var zug1 = new Zug("Bern", 8);
        var zug2 = new Zug("Paris", 6);
        var zug3 = new Zug("Rom", 10);
        var zug4 = new Zug("Wien", 12);

        // Perrons
        var perron1 = new Perron();
        perron1.AddZug(zug4);

        var perron2 = new Perron();
        perron2.AddZug(zug3);

        var perron3 = new Perron(); 
        perron3.AddZug(zug1);
        perron3.AddZug(zug2);

        // Bahnhof
        var bahnhof1 = new Bahnhof();
        bahnhof1.AddPerron(perron1);
        bahnhof1.AddPerron(perron2);
        bahnhof1.AddPerron(perron3);

        // Ausgabe
        Console.WriteLine("1. Destinationen vom Bahnhof:");
        bahnhof1.DestinationsListeDrucken();

        Console.WriteLine("\n2. Anzahl Züge im Bahnhof:");
        Console.WriteLine(bahnhof1.AnzahlZuege());

        Console.WriteLine("\n3. Anzahl Wagen pro Perron:");
        int i = 1;
        foreach (var perron in bahnhof1.GetPerrons())
        {
            Console.WriteLine($"Perron {i}: {perron.AnzahlWagen()} Wagen");
            i++;
        }

        Console.WriteLine("\n4. Gesamtanzahl Wagen im Bahnhof:");
        Console.WriteLine(bahnhof1.AnzahlWagen());

    }
}
