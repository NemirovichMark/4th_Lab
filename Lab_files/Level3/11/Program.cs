using System;

namespace LaboratoryL3N11
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
            List<double> zero_index = new List<double>();
            
            for (int i = 0; i < n; i++)
            {
                bool flag = false;
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
                    if (a == 0)
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    zero_index.Add(i);
                }
            }   

            int index = 0;
            int size = zero_index.Count();

            for (int i = 0; i < n; i++)
            {
                if (index == size)
                {
                    index = 0;
                }
                if (i == zero_index[index])
                {
                    index += 1;
                    continue;
                }
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