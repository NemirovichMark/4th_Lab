using System;

namespace LaboratoryL3N4
{
    class Program
    {
        static int Main(string[] args)
        {
            double[,] array = new double[,]{{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5}};
            int n = 5, m = 5;

            for (int i = n / 2; i < n; i++) 
            {
                for (int j = 0; j < i; j++) 
                {
                    array[i, j] = 0;
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