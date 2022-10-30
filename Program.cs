using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Transactions;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Level1_3()
        {
            Console.WriteLine("Level1_3");
            double[,] mas = new double[4, 4];
            double sum = 0;
            Console.WriteLine("Write elements in mas");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                }
                sum += mas[i, i];
            }
            Console.WriteLine("Answer");
            Console.WriteLine(sum);
        }
        static void Level1_6()
        {
            Console.WriteLine("Level1_6");
            double[,] mas = new double[4, 7];
            List<int> Minel = new List<int>();
            Console.WriteLine("Write elements in mas");
            for (int i = 0; i < 4; i++)
            {
                double min = double.MaxValue;
                int minind = 0;
                for (int j = 0; j < 7; j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                        minind = j;
                    }
                }
                Minel.Add(minind);
            }
            Console.WriteLine("Answer");
            Console.WriteLine(string.Join(", ", Minel));
        }
        static void Level1_12()
        {
            Console.WriteLine("Level1_12");
            double[,] mas = new double[6, 7];
            double max = double.MinValue;
            int MaxinI = 0;
            int MaxinJ = 0;
            Console.WriteLine("Write elements in mas");
            for (int i = 0; i < 6; i++)
            {

                for (int j = 0; j < 7; j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                    if (s > max)
                    {
                        max = s;
                        MaxinI = i;
                        MaxinJ = j;
                    }
                }
            }
                int i1,j1;
                for (int i=0;i<5;i++)
                {
                    if (i>=MaxinI)
                    {
                        i1 = i + 1;
                    }
                    else
                    {
                        i1 = i;
                    }
                    for (int j=0;j<6; j++)
                    {
                        if (j>=MaxinJ)
                        {
                            j1 = j + 1;
                        }
                        else
                        {
                            j1 = j;
                        }
                        mas[i, j] = mas[i1, j1];
                    }
                }
            Console.WriteLine("Answer");
                for (int i = 0;i<5;i++)
                {
                    for (int j=0;j<6;j++)
                    {
                        Console.WriteLine($"{mas[i,j], 5}");
                    }
                }
            
        }
        static void Level1_13()
        {
            Console.WriteLine("Level1_13");
            double[,] mas = new double[5,5];
            int k = 4;
            double max = double.MinValue;
            int MaxinJ = 0;
            int j = 0;
            Console.WriteLine("Write elements in mas");
            for (int i=0;i<5;i++)
            {
                for (j=0;j<5;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                }
                if (mas[i,i]>max)
                {
                    max = mas[i, i];
                    MaxinJ = i;
                }
            }
            double swap;
            for (int i = 0; i<5;i++)
            {
                swap = mas[i, k];
                mas[i, k] = mas[i, MaxinJ];
                mas[i, MaxinJ] = swap;
            }
            Console.WriteLine("Answer");
            for (int i = 0; i<5;i++)
            {
                for(j=0;j<5;j++)
                {
                    Console.WriteLine($"{mas[i, j],5}");
                }
            }
        }
        static void Level1_17()
        {
            Console.WriteLine("Level1_17");
            int n, m;
            Console.WriteLine("Write amount of lines");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Write amount of columns");
            int.TryParse(Console.ReadLine(), out m);
            double[,] mas = new double [n, m];
            double swap;
            Console.WriteLine("Write elements in mas");
            for (int i=0; i<n;i++)
            {
                double min = double.MaxValue;
                int minin = 0;
                for (int j=0; j<m;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                    if (s < min)
                    {
                        min = s;
                        minin = j;
                    }
                }
                swap = mas[i, 0];
                mas[i, 0] = mas[i, minin];
                mas[i, minin] = swap;
            }
            Console.WriteLine("Answer");
            for (int i=0; i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    Console.WriteLine($"{mas[i, j],5}");
                }
            }
        }
        static void Level1_29()
        {
            Console.WriteLine("Level1_29");
            double min = double.MaxValue;
            int minin = 0;
            double[,] mas = new double[5, 7];
            Console.WriteLine("Write elements in mas");
            for (int i = 0; i < 5; i++)
            {
                for (int j=0;j<7;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                    if (i==2)
                    {
                        if (Math.Abs(mas[i,j]) < min)
                        {
                            min = mas[i, j];
                            minin = j;
                        }
                    }
                }
            }
            int del = minin + 1;
            int j1;
            for (int i=0;i<5;i++)
            {
                for(int j = 0; j<6;j++)
                {
                    if (j >= del) j1 = j + 1;
                    else j1 = j;
                    mas[i, j] = mas[i, j1];
                }
            }
            Console.WriteLine("Answer");
            for (int i=0;i<5;i++)
            {
                for(int j=0;j<6;j++)
                {
                    Console.WriteLine($"{mas[i, j],5}");
                }
            }
        }
        static void Level1_31()
        {
            Console.WriteLine("Level1_31");
            double[,] mas = new double[5, 8];
            double min = double.MaxValue;
            double[] B = new double[5];
            int minin = 0;
            Console.WriteLine("Write elements in vector");
            for (int i=0;i<5;i++)
            {
                double x;
                double.TryParse(Console.ReadLine(), out x);
                B[i] = x;
            }
            Console.WriteLine("Write elements in matrix");
            for (int i=0; i<5;i++)
            {
                for (int j=0;j<7;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                    if (s < min && i==4)
                    {
                        min = s;
                        minin = j;
                    }
                }
            }
            int k = 0;
            for(int i=0;i<5;i++)
            {
                for (int j=7;j>=minin+1;j--)
                {
                    if  (j>minin+1)
                    {
                        mas[i, j] = mas[i, j - 1];
                    }
                    else if (j==minin+1)
                    {
                        mas[i, j] = B[k];
                        k++;
                    }
                }
            }
            Console.WriteLine("Answer");
            for (int i=0;i<5;i++)
            {
                for (int j=0;j<8;j++)
                {
                    Console.WriteLine($"{mas[i, j],5}");
                }
            }    
            

        }
        static void Level2_7()
        {
            Console.WriteLine("Level2_7");
            int n = 6;
            double[,] mas = new double[n,n];
            double max = double.MinValue;
            int maxind = 0;
            Console.WriteLine("Write elements in  matrix");
            for (int i=0; i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                }
                if (mas[i,i]>max)
                {
                    max = mas[i, i];
                    maxind = i;
                }
            }
            for (int i=0; i<maxind;i++)
            {
                for (int j=maxind+1; j<n; j++)
                {
                    mas[i, j] = 0;
                }
            }
            Console.WriteLine("Answer");
            for (int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.WriteLine($"{mas[i,j],5}");
                }
                Console.WriteLine();
            }
        }
        static void Level2_8()
        {
            Console.WriteLine("Level2_8");
            int n = 6;
            double[,] mas = new double[n, n];
            int k = 0;
            double swap,swap1;
            int swapind=0;
            Console.WriteLine("Write elements in matrix");
            for (int i=0;i<n;i++)
            {
                double max = double.MinValue;
                int maxind = 0;
                k = i % 2;
                for(int j=0;j<n;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                    if (s>max)
                    {
                        max = s;
                        maxind = j;
                    }
                }
                if (k==0)
                {
                    swap = max;
                    swapind = maxind;
                }
                if (k == 1)
                {
                    swap = mas[i-1,swapind];
                    mas[i - 1, swapind] = mas[i, maxind];
                    mas[i, maxind] = swap;
                }

            }
            Console.WriteLine("Answer");
            for (int i=0;i<n;i++)
            {
                for(int j =0;j<n;j++)
                {
                    Console.WriteLine($"{mas[i, j],5}");
                }
                Console.WriteLine();
            }

        }
        static void Level2_9()
        {
            Console.WriteLine("Level2_9");
            int n = 6, m = 7;
            double[,] mas = new double[n, m];
            double swap;
            Console.WriteLine("Write elements in matrix");
            for (int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                }    
            }
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m/2;j++)
                {
                    swap = mas[i,j];
                    mas[i, j] = mas[i, m - j - 1];
                    mas[i, m - j - 1] = swap;
                }
            }
            Console.WriteLine("Answer");
            for(int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    Console.WriteLine($"{mas[i,j],5}");
                }
                Console.WriteLine();
            }
        }
        static void Level3_1()
        {
            Console.WriteLine("Level3_1");
            List < Tuple < double,int>>folder = new List<Tuple<double, int>>();
            double[,] mas = new double[7, 5];
            double[,] answer = new double[7, 5];
            Console.WriteLine("Write elements in matrix");
            for (int i=0;i<7;i++)
            {
                double min = double.MaxValue;
                for (int j=0;j<5;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                    if (s<min)
                    {
                        min = s;
                    }
                }
                folder.Add(Tuple.Create(min, i));

            }
            folder.OrderBy(x => x.Item1);
            folder.Reverse();
            int k = 0;
            for(int i=0;i<7;i++)
            {
                for (int j=0;j<5;j++)
                {
                    answer[i, j] = mas[folder[k].Item2, j];
                }
                k++;
            }
            Console.WriteLine("Answer");
            for (int i =0;i<7;i++)
            {
                for (int j=0;j<5;j++)
                {
                    Console.WriteLine($"{mas[i, j],5}");
                }
                Console.WriteLine();
            }
        }
        static void Level3_2()
        {
            Console.WriteLine("Level3_2");
            int n;
            Console.WriteLine("Write amount of lines and colomns in matrix");
            int.TryParse(Console.ReadLine(), out n);
            double[,] mas = new double[n,n];
            Console.WriteLine("Write elements in matrix");
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                }
            }
            for (int i=0;i<n;i++)
            {
                mas[i, 0] = 0;
                mas[0, i] = 0;
                mas[n-1,i] = 0;
                mas[i, n - 1] = 0;
            }
            Console.WriteLine("Answer");
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    Console.WriteLine($"{mas[i, j],5}");
                }
                Console.WriteLine();
            }    
        }
        static void Level3_3()
        {
            Console.WriteLine("Level3_3");
            int n;
            Console.WriteLine("Write amount of lines and colomns in matrix");
            int.TryParse(Console.ReadLine(), out n);
            double[,] mas = new double[n, n];
            double[] answer = new double[n * 2-1];
            Console.WriteLine("Write elements in mas");
            for (int i =0;i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(),out s);
                    mas[i, j] = s;
                    
                }
            }
            for (int i=0;i<n;i++)
            {
                double sum = 0;
                double obrsum = 0;
                for (int j=0;j<=i;j++)
                {
                    sum+=mas[n-1-i+j, j];
                    obrsum += mas[i-j, n - 1 - j];
                }
                answer[i] = sum;
                answer[n*2-i-2] = obrsum;
            }
            Console.WriteLine("Answer");
            Console.WriteLine(string.Join(", ", answer));
        }
        static void Level3_4()
        {
            Console.WriteLine("Level3_4");
            int n;
            Console.WriteLine("Write amount of lines and colomns in matrix");
            int.TryParse(Console.ReadLine(), out n);
            double[,] mas = new double[n, n];
            Console.WriteLine("Write elements in matrix");
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                    if (i>=(n/2) && (i-j)>=0)
                    {
                        mas[i, j] = 1;
                    }
                }
            }
            Console.WriteLine("Answer");
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.WriteLine($"{mas[i,j],5}");
                }
                Console.WriteLine();
            }
        }
        static void Level3_8()
        {
            Console.WriteLine("Level3_8");
            List<Tuple<int,int>> folder = new List<Tuple<int,int>>();
            double[,] mas = new double[7, 5];
            double[,] answer = new double[7, 5];
            Console.WriteLine("Write elements in matrix");
            for (int i=0;i<7;i++)
            {
                int kol = 0;
                for (int j=0; j<5;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                    if (s > 0) kol++;
                }
                folder.Add(Tuple.Create(kol, i));
            }
            folder.OrderBy(x => x.Item1);
            folder.Reverse();
            int k = 0;
            for (int i=0;i<7;i++)
            {
                for (int j=0;j<5;j++)
                {
                    answer[i, j] = mas[folder[k].Item2, j];
                }
                k++;
            }
            Console.WriteLine("Answer");
            for  (int i=0;i<7;i++)
            {
                for (int j=0;j<5;j++)
                {
                    Console.WriteLine($"{answer[i, j],5}");
                }
                Console.WriteLine();
            }
        }
        static void Level3_10()
        {
            Console.WriteLine("Level3_10");
            List<double> folder1= new List<double>();
            List<double> folder2 = new List<double>();
            int n;
            Console.WriteLine("Write amount of lines in matrix");
            int.TryParse(Console.ReadLine(), out n);
            int m;
            Console.WriteLine("Write amount of colomns in matrix");
            int.TryParse(Console.ReadLine(), out m);
            double[,] mas = new double[n, m];
            double[,] answer = new double[n, m];
            Console.WriteLine("Write elements in matrix");
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                    if (j % 2 == 0) folder1.Add(s);
                   
                    else folder2.Add(s);
                }
                folder1.Sort();
                folder1.Reverse();
                folder2.Sort();
                for(int z=0;z<folder1.Count;z++)
                {
                    answer[i,z*2]=folder1[z];
                }
                for(int t=0;t<folder2.Count;t++)
                {
                    answer[i,t*2+1]=folder2[t];
                }
                folder1 = new List<double>();
                folder2 = new List<double>();
            }
            Console.WriteLine("Answer");
            for (int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    Console.WriteLine($"{answer[i, j],5}");
                }
                Console.WriteLine();
            }
        }
        static void Level3_11()
        {
            Console.WriteLine("Level3_11");
            List<int> folder = new List<int>();
            int n;
            Console.WriteLine("Write amount of lines");
            int.TryParse(Console.ReadLine(), out n);
            int m;
            Console.WriteLine("Write amount of colomns");
            int.TryParse(Console.ReadLine(), out m);
            double[,] mas= new double[n,m];
            Console.WriteLine("Write elements in matrix");
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    double s;
                    double.TryParse(Console.ReadLine(), out s);
                    mas[i, j] = s;
                    if (s==0) folder.Add(i);
                }
            }
            int k = 0;
            for(int i=1;i<n;i++)
            {
                if (folder.Contains(i) == false) ;
                for (int j=0;j<m;j++)
                {
                    mas[folder[k], j] = mas[i, j];
                }
            }
            Console.WriteLine("Answer");
            for (int i=0;i<(n-folder.Count);i++)
            {
                for(int j=0;j<m;j++)
                {
                    Console.WriteLine($"{mas[i, j], 5}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] arg)
        {
            Level1_3();
            Level1_6();
            Level1_12();
            Level1_13();
            Level1_17();
            Level1_29();
            Level1_31();
            Level2_7();
            Level2_8();
            Level2_9();
            Level3_1();
            Level3_2();
            Level3_3();
            Level3_4();
            Level3_8();
            Level3_10();
            Level3_11();
        }
    }
}
