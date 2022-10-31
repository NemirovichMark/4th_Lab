using System;

namespace LaboratoryL2N7
{
    class Program
    {
        static int Main(string[] args)
        {
            int n = 6, m = 6;

            double[,] array = new double[n,m];
            int index_j = -1;
            int index_i = -1;
            double max = -100000000000;

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
                    if (a > max && (i == j))
                    {
                        max = a;
                        index_j = j;
                        index_i = i;
                    }
                    array[i,j] = a;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j > index_j && i < index_i)
                    {
                        Console.Write("0 ");
                    }
                    else
                    {
                        Console.Write($"{array[i,j]} ");
                    }
                }
                Console.WriteLine();
            }
            return 0;
        }
    }
}