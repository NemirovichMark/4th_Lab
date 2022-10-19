using System;

namespace Laboratory_defend
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write($"n: ");
            string input_n = Console.ReadLine();
            if (!int.TryParse(input_n, out var n) || (n < 2))
            {
                Console.WriteLine("Invalid n");
                return 1;
            }
            
            double[] p_sums = new double[n+1];
            p_sums[0] = 0;

            double[] array = new double[n];

            //First element of the array
            Console.Write("Array[0]: ");
            string input_x = Console.ReadLine();
            if (!double.TryParse(input_x, out var one))
            {
                Console.WriteLine("Invalid number");
                return 1;
            }
            
            array[0] = one;
            //Prefix sum for second element is 0 + array[0]
            p_sums[1] = one;
            double max = one;

            for (int i = 1; i < n; i++)
            {
                //Array[i] input
                Console.Write($"Array[{i}]: ");
                string input_ai = Console.ReadLine();
                if (!double.TryParse(input_ai, out var x))
                {
                    Console.WriteLine("Invalid number");
                    return 1;
                }

                p_sums[i+1] = p_sums[i] + x;
                
                if (x > max)
                {
                    max = x;
                }
                array[i] = x;
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] == max)
                {
                    Console.Write($"{p_sums[i]} ");
                }
                else
                {
                    Console.Write($"{array[i]} ");
                }
            }
            return 0;
        }
    }
}