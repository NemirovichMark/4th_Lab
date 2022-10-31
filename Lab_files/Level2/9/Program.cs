using System;

namespace LaboratoryL2N9
{
    class Program
    {
        static int Main(string[] args)
        {
            int n = 6, m = 7;

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
                for (int j = 0; j < (m / 2); j++)
                {
                    double temp = array[i,j];
                    array[i,j] = array[i, m - 1 - j];
                    array[i, m - 1 - j] = temp;
                }
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
            