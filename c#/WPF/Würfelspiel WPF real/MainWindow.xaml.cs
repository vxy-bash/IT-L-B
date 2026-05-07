using System;
using System.Windows;

namespace Würfelspiel_WPF
{
    public partial class MainWindow : Window
    {
        public bool dran = true; // Prüft, wer dran ist
        Spieler du;
        Spieler gegner;
        Würfel w1;
        Würfel w2;

        public string[] ico = new string[] { "⚀", "⚁", "⚂", "⚃", "⚄", "⚅" };

        public MainWindow()
        {
            InitializeComponent();
            du = new Spieler(0);
            gegner = new Spieler(0);
            w1 = new Würfel();
            w2 = new Würfel();
        }

        private void Würfeln_Click(object sender, RoutedEventArgs e)
        {
            int wurf1 = w1.Würfeln();
            Würfel1.Text = ico[wurf1 - 1];

            int wurf2 = w2.Würfeln();
            Würfel2.Text = ico[wurf2 - 1];

            int summe = wurf1 + wurf2;

            if (wurf1 == wurf2) // Pasch
            {
                if (dran)
                {
                    du.punkteStand = 0;
                    Nachricht.Text = "Pasch! Du verlierst alle deine Punkte!";
                }
                else
                {
                    gegner.punkteStand = 0;
                    Nachricht.Text = "Pasch! Der Gegner verliert alle seine Punkte!";
                }
            }
            else if (summe > 5) // Summe größer als 5
            {
                if (dran)
                {
                    du.punkteStand += summe;
                    Nachricht.Text = $"+{summe} für dich!";
                }
                else
                {
                    gegner.punkteStand += summe;
                    Nachricht.Text = $"+{summe} für den Gegner!";
                }
            }
            else // Summe <= 5
            {
                if (dran)
                {
                    du.punkteStand -= summe;
                    Nachricht.Text = $"-{summe} für dich!";
                }
                else
                {
                    gegner.punkteStand -= summe;
                    Nachricht.Text = $"-{summe} für den Gegner!";
                }
            }

            dran = !dran; // Spieler wechseln

            UpdateUI();

            // Gewinn prüfen
            if (du.punkteStand >= 10)
            {
                Würfeln.IsEnabled = false;
                MessageBox.Show("Du hast gewonnen, Glückwunsch!");
                Environment.Exit(0);
            }

            if (gegner.punkteStand >= 10)
            {
                Würfeln.IsEnabled = false;
                MessageBox.Show("Du hast verloren!");
                Environment.Exit(0);
            }
        }

        private void UpdateUI() //updated ui
        {
            SpielerPunkte.Text = du.punkteStand.ToString();
            GegnerPunkte.Text = gegner.punkteStand.ToString(); 
        }
    }

    public class Spieler
    {
        public int punkteStand { get; set; }

        public Spieler(int punkteStand)
        {
            this.punkteStand = punkteStand;
        }
    }

    public class Würfel
    {
        private static Random rnd = new();
        public int Wert { get; private set; }

        public int Würfeln()
        {
            Wert = rnd.Next(1, 7);
            return Wert;
        }
    }
}