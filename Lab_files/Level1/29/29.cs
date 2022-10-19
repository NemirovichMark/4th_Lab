using System;

namespace LaboratoryL1N29
{
    class Program
    {
        static int Main(string[] args)
        {
            int n = 5, m = 7;

            double[,] array = new double[n,m];
            int index_j = -1;
            double min = 100000000000;

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
                    if ((Math.Abs(a) < min) && (i == 1))
                    {
                        min = a;
                        index_j = j+1;
                        if (index_j == m)
                        {
                            Console.WriteLine("U cannot delete column after the last one");
                            return 1;
                        }
                    }
                    array[i,j] = a;
                }
            }

            double[,] array_ans = new double[n , m - 1];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (index_j == j)
                    {
                        j++;
                    }
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }
            return 0;
        }
    }
}