using System;
using System.Collections.Generic;
using System.Windows;

namespace BlackJack_WPF1
{
    public partial class MainWindow : Window
    {
        BlackjackGame spiel;

        public MainWindow()
        {
            InitializeComponent();  
            spiel = new BlackjackGame();

        }

        private void zieh_click(object sender, RoutedEventArgs e)
        {
            spiel.SpielerZieht();

            // Anzeigen aktualisieren
            du.Content = spiel.Spieler.Punkte.ToString();
            geg.Content = spiel.Dealer.Punkte.ToString();

            if (spiel.IstSpielVorbei == true)
            {
                MessageBox.Show(spiel.ErgebnisText);   // Ergebnis anzeigen
                reset_click(null, null); // Einfach Reset aufrufen
            }
        }

        private void passen_Click(object sender, RoutedEventArgs e)
        {
            spiel.SpielerPasst();

            du.Content = spiel.Spieler.Punkte.ToString();
             geg.Content = spiel.Dealer.Punkte.ToString();

            MessageBox.Show(spiel.ErgebnisText);
            reset_click(null, null);
        }

        private void reset_click(object sender, RoutedEventArgs e)
        {
            spiel = new BlackjackGame(); // Einfach alles neu machen
            du.Content = "";
            geg.Content = "";
        }

        private void exit_click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Einfacher Befehl zum Schließen
        }
    }

    // Hauptklasse für das Spiel
    public class BlackjackGame
    {
        public Deck MeinDeck;
        public Spieler Spieler;
        public Spieler Dealer;
        public bool IstSpielVorbei;
        public string ErgebnisText;

        public BlackjackGame()
        {
            MeinDeck = new Deck();
            Spieler = new Spieler();
            Dealer = new Spieler();
            IstSpielVorbei = false;
            ErgebnisText = "";
        }

        public void SpielerZieht()
        {
            Karte k = MeinDeck.KarteZiehen();
            Spieler.KarteNehmen(k);

            if (Spieler.Punkte > 21)
            {
                IstSpielVorbei = true;
                ErgebnisText = "Verloren! Über 21.";
            }
        }

        public void SpielerPasst()
        {
            // Dealer zieht bis er 17 hat
            while (Dealer.Punkte < 17)
            {
                Karte k = MeinDeck.KarteZiehen();
                Dealer.KarteNehmen(k);
            }

            IstSpielVorbei = true;
            GewinnerErmitteln();
        }

        public void GewinnerErmitteln()
        {
            if (Dealer.Punkte > 21)
            {
                ErgebnisText = "Gewonnen! Dealer hat überzogen.";
            }
            else if (Spieler.Punkte > Dealer.Punkte)
            {
                ErgebnisText = "Gewonnen!";
            }
            else if (Spieler.Punkte == Dealer.Punkte)
            {
                ErgebnisText = "Unentschieden.";
            }
            else
            {
                ErgebnisText = "Verloren!";
            }
        }
    }

    // Klasse für den Spieler (und Dealer)
    public class Spieler
    {
        public int Punkte; // Einfache Variable, öffentlich

        public Spieler()
        {
            Punkte = 0;
        }

        public void KarteNehmen(Karte k)
        {
            int wert = k.Wert;

            // Ass-Behandlung (Anfänger-freundlich geschrieben)
            if (wert == 11)
            {
                if ((Punkte + 11) > 21)
                {
                    wert = 1; // Als 1 zählen
                }
                else
                {
                    wert = 11; // Als 11 zählen
                }
            }

            Punkte = Punkte + wert;
        }
    }

    // Klasse für das Deck
    public class Deck
    {
        public List<Karte> KartenListe;
        Random zufall = new Random();

        public Deck()
        {
            KartenListe = new List<Karte>();

            // 52 Karten erstellen (einfache Schleife)
            for (int i = 0; i < 52; i++)
            {
                // Zufallswert zwischen 2 und 11 
                int wert = zufall.Next(2, 12);

                Karte k = new Karte();
                k.Wert = wert;
                KartenListe.Add(k);
            }
        }

        public Karte KarteZiehen()
        {
            // Prüfen ob leer
            if (KartenListe.Count == 0)
            {
                MessageBox.Show("Deck ist leer! (Sollte nicht passieren)");
                return new Karte(); // Leere Karte zurückgeben
            }

            // Erste Karte nehmen
            Karte gezogeneKarte = KartenListe[0];
            KartenListe.RemoveAt(0); // Aus Liste entfernen

            return gezogeneKarte;
        }
    }

    // Klasse Karte
    public class Karte
    {
        public int Wert;
    }
}