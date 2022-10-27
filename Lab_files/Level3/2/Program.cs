using System;

namespace LaboratoryL3N2
{
    class Program
    {
        static int Main(string[] args)
        {
            double[,] array = new double[,]{{1,2,3},{1,2,3},{1,2,3}};
            int n = 3, m = 3;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || i == n-1)
                    {
                        array[i,j] = 0;
                        continue;
                    }
                    if (j == 0 || j == m-1)
                    {
                        array[i,j] = 0;
                        continue;
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
