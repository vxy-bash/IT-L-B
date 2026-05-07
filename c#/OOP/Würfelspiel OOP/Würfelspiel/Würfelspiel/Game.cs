using System;
using System.Threading;

namespace Würfelspiel
{
    internal class Game
    {
        Wuerfel w1 = new Wuerfel(); // Würfel-Objekt
        bool running = true;       // Spielstatus

        public void Start()
        {
            // Spieleranzahl abfragen
            Console.WriteLine("Hello, how many persons are playing? (1-4)");
            int p = int.Parse(Console.ReadLine());

            // Namen eingeben und Spieler erstellen
            for (int i = 0; i < p; i++)
            {
                Console.Clear();
                Console.WriteLine($"Whats the name of player {i + 1}?");
                string name = Console.ReadLine() ?? "Unknown";
                new Spieler(name);
            }

            Console.Clear();
            Console.WriteLine("Game starting...");
            Thread.Sleep(1500);

            // Spielrunde
            while (running)
            {
                foreach (var s in Spieler.SpielerListe)
                {
                    Console.WriteLine($"{s.Name}, press Enter to roll...");
                    Console.ReadLine();

                    // Würfeln und Punkte addieren
                    w1.Werfen();
                    int wurf = w1.GetZahl();
                    s.Punkte += wurf;

                    Console.WriteLine($"Rolled: {wurf} | Total: {s.Punkte}");

                    // Siegprüfung
                    if (s.Punkte >= 12)
                    {
                        Console.WriteLine($"{s.Name} wins!");
                        running = false;
                        break;
                    }
                }
            }
            Console.WriteLine("Game Over. Press any key to exit.");
            Console.ReadKey();
        }
    }
}