using System;

namespace LaboratoryL1N13
{
    class Program
    {
        static int Main(string[] args)
        {
            int n = 5, m = 5;

            double[,] array = new double[n,m];
            int index_j = -1;
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
                    if (i == j && a > max)
                    {
                        max = a;
                        index_j = j;
                    }
                    array[i,j] = a;
                }
            }
            
            double[,] array_ans = new double[n - 1,m - 1];
            

            for (int i = 0; i < n; i++)
            {
                double p = array[i, 3];
                array[i,3] = array[i,index_j];
                array[i,index_j] = p;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }
            return 0;
        }
    }
}