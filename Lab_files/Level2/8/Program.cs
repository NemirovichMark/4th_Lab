using System;

namespace LaboratoryL2N8
{
    class Program
    {
        static int Main(string[] args)
        {
            int n = 6, m = 6;

            double[,] array = new double[n,m];
            int[] index = new int[]{-1,-1};
            double[] max = new double[]{-10000000,-100000000};

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
                    if (a > max[i%2])
                    {
                        max[i%2] = a;
                        index[i%2] = j;
                    }
                    array[i,j] = a;
                }
                if (i % 2 == 1 && i > 0)
                {
                    array[i-1,index[0]] = max[1];
                    array[i, index[1]] = max[0];
                    max[0] = -1000000000;
                    max[1] = -1000000000;
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
            