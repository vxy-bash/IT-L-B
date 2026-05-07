using System;

class Program
{
    static void Main()
    {
        // 2x2 Matrix erstellen
        double[,] m2 = new double[2, 2];

        Console.WriteLine("Gib die Werte für die 2x2 Matrix ein:");
        // Werte für die 2x2 Matrix eingeben
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                m2[i, j] = double.Parse(Console.ReadLine());

        // Determinante der 2x2 Matrix berechnen
        double det2 = m2[0, 0] * m2[1, 1] - m2[0, 1] * m2[1, 0];

        // Inverse 2x2 Matrix erstellen
        double[,] inv2 = new double[2, 2];

        // Formel für die Inverse einer 2x2 Matrix:
        inv2[0, 0] = m2[1, 1] / det2;
        inv2[0, 1] = -m2[0, 1] / det2;
        inv2[1, 0] = -m2[1, 0] / det2;
        inv2[1, 1] = m2[0, 0] / det2;

        // Inverse 2x2 Matrix ausgeben
        Console.WriteLine("\nInverse 2x2 Matrix:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write($"{inv2[i, j],8:F2} "); // Formatierung auf 2 Nachkommastellen
            Console.WriteLine();
        }

        // 4x4 Matrix erstellen
        double[,] m4 = new double[4, 4];
        Console.WriteLine("\nGib die Werte für die 4x4 Matrix ein:");
        // Werte für die 4x4 Matrix vom Benutzer geben lassen
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                m4[i, j] = double.Parse(Console.ReadLine());

        // Arrays für die Inverse und eine Kopie der Originalmatrix erstellen
        double[,] inv4 = new double[4, 4];
        double[,] copy = new double[4, 4];
        
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
            {
                copy[i, j] = m4[i, j];
                inv4[i, j] = (i == j) ? 1 : 0; // Diagonale = 1, Rest = 0
            }

  
        for (int i = 0; i < 4; i++)
        {
            // Diagonalwert
            double diag = copy[i, i];

            // Diagonalzeile auf 1 normieren
            for (int j = 0; j < 4; j++)
            {
                copy[i, j] /= diag; // Matrix wird geteilt
                inv4[i, j] /= diag; // Inverse wird entsprechend geteilt
            }

            // Alle anderen Zeilen Null in der Spalte i setzen
            for (int k = 0; k < 4; k++)
            {
                if (k == i) continue; // Diagonalzeile überspringen
                double factor = copy[k, i];
                for (int j = 0; j < 4; j++)
                {
                    copy[k, j] -= factor * copy[i, j]; // Eliminieren der Spalte i
                    inv4[k, j] -= factor * inv4[i, j]; // Gleiche Operation auf Inverse anwenden
                }
            }
        }

        // Inverse 4x4 Matrix ausgeben
        Console.WriteLine("\nInverse 4x4 Matrix:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write($"{inv4[i, j],8:F2} "); 
            Console.WriteLine();
        }
    }
}
