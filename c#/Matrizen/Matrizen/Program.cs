using System;

class Program
{
    static void Main()
    {
        int[,] A1 = new int[2, 2];
        int[,] B1 = new int[2, 2];
        Console.WriteLine("Matrix A1 (2x2) eingeben:");
        for (int i = 0; i < 2; i++)
        for (int j = 0; j < 2; j++)
            A1[i, j] = int.Parse(Console.ReadLine());

        Console.WriteLine("Matrix B1 (2x2) eingeben:");
        for (int i = 0; i < 2; i++)
        for (int j = 0; j < 2; j++)
            B1[i, j] = int.Parse(Console.ReadLine());

        Console.WriteLine("A1 + B1:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write((A1[i, j] + B1[i, j]) + " ");
            Console.WriteLine();
        }

        int[,] A2 = new int[3, 3];
        int[,] B2 = new int[3, 3];
        Console.WriteLine("Matrix A2 (3x3) eingeben:");
        for (int i = 0; i < 3; i++)
        for (int j = 0; j < 3; j++)
            A2[i, j] = int.Parse(Console.ReadLine());

        Console.WriteLine("Matrix B2 (3x3) eingeben:");
        for (int i = 0; i < 3; i++)
        for (int j = 0; j < 3; j++)
            B2[i, j] = int.Parse(Console.ReadLine());

        Console.WriteLine("A2 + B2:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write((A2[i, j] + B2[i, j]) + " ");
            Console.WriteLine();
        }

        int[,] A3 = new int[2, 3];
        int[,] B3 = new int[3, 2];
        int[,] C3 = new int[2, 2];

        Console.WriteLine("Matrix A3 (2x3) eingeben:");
        for (int i = 0; i < 2; i++)
        for (int j = 0; j < 3; j++)
            A3[i, j] = int.Parse(Console.ReadLine());

        Console.WriteLine("Matrix B3 (3x2) eingeben:");
        for (int i = 0; i < 3; i++)
        for (int j = 0; j < 2; j++)
            B3[i, j] = int.Parse(Console.ReadLine());

        for (int i = 0; i < 2; i++)
        for (int j = 0; j < 2; j++)
        for (int k = 0; k < 3; k++)
            C3[i, j] += A3[i, k] * B3[k, j];

        Console.WriteLine("A3 * B3:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write(C3[i, j] + " ");
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}