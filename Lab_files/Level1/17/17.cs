using System;

namespace LaboratoryL1N17
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
                double min = 1000000000;
                int index = -1;
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Array_A[{i}][{j}]: ");
                    string input_ai = Console.ReadLine();
                    if (!double.TryParse(input_ai, out var a))
                    {
                        Console.WriteLine("Invalid number");
                        return 1;
                    }
                    if (a < min)
                    {
                        min = a;
                        index = j;
                    }
                    array[i,j] = a;
                }
                int temp_i = index - 1;
                while (index != 0)
                {
                    double temp = array[i, temp_i];
                    array[i, temp_i] = array[i, index];
                    array[i,index] = temp;
                    index--;
                    temp_i--;
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