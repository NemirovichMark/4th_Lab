using System;
using System.Runtime.InteropServices;
using static System.Math;
{
    Console.WriteLine("N3.1:");
    const int GS1 = 6;
    const int GS2 = 2;
    double zere;
    double[,] ember = new double[GS1, GS2];
    double[,] spirit = new double[GS1, GS2];
    for (int i = 0; i < GS1; i++)
    {
        string[] dad = Console.ReadLine().Split();
        for (int j = 0; j < dad.Length; j++)
        {
            if (dad.Length == GS2)
            {
                bool rjoker = double.TryParse(dad[j], out zere);
                if (rjoker == true)
                {
                    ember[i, j] = zere;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }

    double[] hran = new double[GS1];
    int[] ihran = new int[GS1];
    int wed = 0;
    for (int i = 0; i < GS1; i++)
    {
        double min = 10000;
        int imin = 0;
        for (int j=0; j < GS2; j++)
        {
            if (ember[i, j] < min)
            {
                min = ember[i, j];
                imin = i;
            }
        }
        hran[wed] = min;
        ihran[wed] = imin;
        wed++;
    }
    for (int t = 1; t < hran.Length; t++)
    {
        for (int i = 0; i < hran.Length-1; i++)
        {
            if (hran[i] > hran[i + 1])
            {
                double x = 0;
                int y = 0;
                x = hran[i];
                hran[i] = hran[i + 1];
                hran[i + 1] = x;
                y = ihran[i];
                ihran[i] = ihran[i + 1];
                ihran[i + 1] = y;
            }
        }
    }
    int ywa = 0;
    for (int i = 0; i < ihran.Length; i++)
    {
        for (int j = 0; j < GS2; j++)
        {
            spirit[ywa, j] = ember[ihran[i], j];
        }
        ywa++;
    }
    Console.WriteLine();
    for (int a = 0; a < GS1; a++)
    {
        for (int b = 0; b < GS2; b++)
        {
            Console.Write($"{spirit[a, b]} ");
        }
        Console.WriteLine();
    }
}