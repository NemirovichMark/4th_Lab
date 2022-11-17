using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using static System.Math;
{
    /*
    Console.WriteLine("N1.12");
    double v;
    const int a1 = 3;
    const int a2 = 3;
    double[,] m = new double[a1, a2];
    double[,] ma = new double[a1 - 1, a2 - 1];
    for (int i = 0; i < a1; i++)
    {
        string[] ut = Console.ReadLine().Split();
        for (int j = 0; j < ut.Length; j++)
        {
            if (ut.Length == a2)
            {
                bool t = double.TryParse(ut[j], out v);
                if (t == true)
                {
                    m[i, j] = v;
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
    double maxx = 0;
    int inmax = 0;
    int jmax = 0;
    for (int i = 0; i < a1; i++)
    {
        for (int j = 0; j < a2; j++)
        {
            if (m[i, j] > maxx)
            {
                maxx = m[i, j];
                inmax = i;
                jmax = j;
            }

        }
    }
    int wdr1 = 0;
    int wdr2 = 0;
    for (int i = 0; i < a1; i++)
    {
        for (int j = 0; j < a2; j++)
        {
            if (i == inmax)
            {
                wdr1 = i - 1;
                break;
            }
            if (j != jmax)
            {
                ma[wdr1, wdr2] = m[i, j];
                wdr2++;
            }
        }
        wdr2 = 0;
        wdr1++;
    }
    for (int i = 0; i < a1 - 1; i++)
    {
        for (int j = 0; j < a2 - 1; j++)
        {
            Console.Write($"{ma[i, j]} ");
        }
        Console.WriteLine();
    }
    
    Console.WriteLine("N2.7:");
    const int RE1 = 4;
    const int RE2 = 4;
    double EXO;
    double[,] wex = new double[RE1, RE2];
    for (int i = 0; i < RE1; i++)
    {
        string[] zil = Console.ReadLine().Split();
        for (int j = 0; j < zil.Length; j++)
        {
            if (zil.Length == RE2)
            {
                bool joke = double.TryParse(zil[j], out EXO);
                if (joke == true)
                {
                    wex[i, j] = EXO;
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
    double maxq = 0;
    int indexm = 0;
    for (int i = 0; i < RE1; i++)
    {
        if (wex[i, i] > maxq)
        {
            maxq = wex[i, i];
            indexm = i;
        }
    }
    double key = 0;
    for (int i = 0; i < RE1; i++)
    {
        if (key != 1)
        {
            for (int j = 0; j < RE2; j++)
            {
                if (i != indexm)
                {
                    if (j > i)
                    {
                        wex[i, j] = 0;
                    }
                }
                else
                {
                    key = 1;
                    break;
                }
            }
        }
        else
        {
            break;
        }
    }
    for (int a = 0; a < RE1; a++)
    {
        for (int b = 0; b < RE2; b++)
        {
            Console.Write($"{wex[a, b]} ");
        }
        Console.WriteLine();
    }
    

    Console.WriteLine("N2.8:");
    const int RT1 = 6;
    const int RT2 = 6;
    double invo;
    double[,] qvas = new double[RT1, RT2];
    for (int i = 0; i < RT1; i++)
    {
        string[] zis = Console.ReadLine().Split();
        for (int j = 0; j < zis.Length; j++)
        {
            if (zis.Length == RT2)
            {
                bool joke = double.TryParse(zis[j], out invo);
                if (joke == true)
                {
                    qvas[i, j] = invo;
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
    double fmax = 0;
    double smax = 0;
    int ifmax = 0;
    int sfmax = 0;
    double promas = 0;
    for(int i = 0; i < RT1; i++)
    {
        for(int j = 0; j < RT2; j++)
        {
            if (qvas[i,j]>fmax)
            {
                smax = qvas[i,j];
                sfmax = j;
            }
        }
        if(i%2==0)
        {
            fmax = smax;
            ifmax = sfmax;
        }
        else
        {
            qvas[i - 1, ifmax] = smax;
            qvas[i, sfmax] = fmax;
            fmax = 0;
            smax = 0;
        }
    }
    Console.WriteLine();
    for (int a = 0; a < RT1; a++)
    {
        for (int b = 0; b < RT2; b++)
        {
            Console.Write($"{qvas[a, b]} ");
        }
        Console.WriteLine();
    }
    */
    Console.WriteLine("N3.1:");
    const int GS1 = 4;
    const int GS2 = 3;
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
        ihran[zeq] = minsk * 10 + i;
        zeq++;
    }
    Array.Sort(hran);
    int[] fina = new int[GS1];
    int qur = 0;
    for (int i = 0; i < hran.Length; i++)
    {
        for (int j = 0; j < ihran.Length; j++)
        {
            if (hran[i] == (ihran[j] - ihran[j] % 10) / 10)
            {
                fina[qur] = Convert.ToInt32(ihran[j] % 10);
                qur++;
                ihran[j] = Pow(10, 9);
                break;
            }
        }
    }
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
