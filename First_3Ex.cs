using System;
using System.Reflection;

namespace _4rd_Lab
{
    class Firts_3Ex
    {
        static void Main(string[] args)
        {
                        int i = 0, j = 0, n;
            double sum = 0;
            Console.Write("enter n numbers of the matrix: ");
            int.TryParse(Console.ReadLine(), out n);
            while (n <= 0)
            {
                Console.WriteLine("n > 0!");
                int.TryParse(Console.ReadLine(), out n);
            }
            double[,] a = new double[n,n];
            Console.WriteLine($"enter {n * n} elements");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    double.TryParse(Console.ReadLine(), out a[i, j]);
                }
            }
            Console.WriteLine($"Array: ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                    Console.WriteLine();
            }
            for(i = 0; i < n; i++) sum = a[i,i];
            Console.Write($"Diagonal sum: {sum}");
        }
    }
}