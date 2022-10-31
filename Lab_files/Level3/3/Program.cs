using System;

namespace LaboratoryL3N3
{
    class Program
    {
        static int Main(string[] args)
        {
            double[,] array = new double[,]{{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5}};
            int n = 5, m = 5;
            double[] ans = new double[2 * n - 1];
            int index = 0;

            for (int i = n - 1; i > -1; i--) 
            {
                double sum = 0;
                for (int j = 0; i + j < m; j++)
                {
                    sum += array[i + j, j];
                }
                ans[index] = sum;
                index += 1;
            }

            for (int i = 1; i < n; i++) 
            {
                double sum = 0;
                for (int j = 0; i + j < m; j++)
                {
                    sum += array[j , i + j];
                }
                ans[index] = sum;
                index += 1;
            }

            for (int i = 0; i < 2*n - 1; i++)
            {
                Console.Write($"{ans[i]} ");
            }
            Console.WriteLine();
            
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
