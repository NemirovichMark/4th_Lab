using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
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
    double[] ihran = new double[GS1];
    int zeq = 0;
    for (int i = 0; i < GS1; i++)
    {
        double minsk = 100000000;
        for (int j = 0; j < GS2; j++)
        {
            if (ember[i, j] < minsk)
            {
                minsk = ember[i, j];
            }
        }
        hran[zeq] = minsk;
        if (minsk < 0)
        {
            ihran[zeq] = -1 * (Abs(minsk) * 10 + i);
        }
        else
        {
            ihran[zeq] = minsk * 10 + i;
        }
        zeq++;
    }
    Array.Sort(hran);
    Array.Sort(ihran);
    for(int i = 0; i < hran.Length; i++)
    {
        Console.Write($"{hran[i]} ");
    }
    Console.WriteLine();
    for (int i = 0; i < ihran.Length; i++)
    {
        Console.Write($"{ihran[i]} ");
    }
    Console.WriteLine();
    int[] fina = new int[GS1];
    int qur = 0;
    for (int i = 0; i < hran.Length; i++)
    {
        for (int j = 0; j < ihran.Length; j++)
        {
            if (hran[i] >= 0)
            {
                if (hran[i] == (ihran[j] - ihran[j] % 10) / 10)
                {
                    fina[qur] = Convert.ToInt32(ihran[j] % 10);
                    qur++;
                    ihran[j] = Pow(10, 9);
                    break;
                }
            }
            else
            {
                if (hran[i] == (-1) * ((Abs(ihran[j]) - Abs(ihran[j]) % 10) / 10))
                {
                    fina[qur] = Convert.ToInt32(Abs(ihran[j]) % 10);
                    qur++;
                    ihran[j] = Pow(10, 9);
                    break;
                }
            }

        }
    }
    for (int i = 0; i < fina.Length; i++)
    {
        Console.Write($"{fina[i]} ");
    }
    Console.WriteLine();
    int ywa = 0;
    for (int i = 0; i < fina.Length; i++)
    {
        for (int j = 0; j < GS2; j++)
        {
            spirit[ywa, j] = ember[fina[i], j];
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

