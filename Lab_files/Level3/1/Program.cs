using System;

namespace LaboratoryL3N1
{
    class Program
    {
        struct info
        {
            public double x;
            public int index;
        }
        static int Main(string[] args)
        {
            int n = 7, m = 5;
            info[] max_info = new info[n];
            double[,] array = new double[n,m];
            
            for (int i = 0; i < n; i++)
            {
                double minim = 1000000000000;
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Array_A[{i}][{j}]: ");
                    string input_ai = Console.ReadLine();
                    if (!double.TryParse(input_ai, out var a))
                    {
                        Console.WriteLine("Invalid number");
                        return 1;
                    }
                    if (a < minim)
                    {
                        minim = a;
                        max_info[i].index = i;
                        max_info[i].x = a;
                    }
                    array[i,j] = a;
                }
            }
            for (int i = 0; i < n; i++)
            {
                double minim = max_info[i].x;
                for (int j = i + 1; j < n; j++)
                {
                    if (max_info[j].x < minim)
                    {
                        minim = max_info[j].x;
                        int temp_i = max_info[j].index;
                        max_info[j].x = max_info[i].x;
                        max_info[j].index = max_info[i].index;
                        max_info[i].x = minim;
                        max_info[i].index = temp_i;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array[max_info[i].index, j]} ");
                }
                Console.WriteLine();
            }
            return 0;
        }
    }
}