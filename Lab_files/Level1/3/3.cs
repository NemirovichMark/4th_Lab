using System;

namespace LaboratoryL1N3
{
    class Program
    {
        static int Main(string[] args)
        {
            int n = 4;

            double[,] array = new double[n,n];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
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

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (n-i-1 != i)
                {
                    sum += array[i, n-i-1] + array[i, i];
                }
                else
                {
                    sum += array[i,i];
                }
            }
            Console.WriteLine($"Ans: {sum}");
            return 0;
        }
    }
}