using System;

namespace LaboratoryL3N10
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write($"N: ");
            string input_n = Console.ReadLine();
            if (!int.TryParse(input_n, out var n) || (n < 1))
            {
                Console.WriteLine("Invalid number");
                return 1;
            }

            Console.Write($"M: ");
            string input_m = Console.ReadLine();
            if (!int.TryParse(input_m, out var m) || (m < 1))
            {
                Console.WriteLine("Invalid number");
                return 1;
            }

            double[,] array = new double[n,m];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Array_A[{i}][{j}]: ");
                    string input_ai = Console.ReadLine();
                    if (!double.TryParse(input_ai, out var a))
                    {
                        Console.WriteLine("Invalid number");
                        return 1;
                    }
                    array[i,j] = a;
                }
            }
            for (int i = 0; i < n; i++)
            {   
                if (i % 2 == 0)
                {
                    for (int j = 0; j < m; j++)
                    {
                        double maxim = array[i,j];
                        for (int q = j + 1; q < m; q++)
                        {
                            if (maxim < array[i,q])
                            {
                                maxim = array[i,q];
                                array[i,q] = array[i,j];
                                array[i,j] = maxim;
                            }
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < m; j++)
                    {
                        double minim = array[i,j];
                        for (int q = j + 1; q < m; q++)
                        {
                            if (minim > array[i,q])
                            {
                                minim = array[i,q];
                                array[i,q] = array[i,j];
                                array[i,j] = minim;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            return 0;
        }
    }
}