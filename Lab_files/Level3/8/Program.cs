using System;

namespace LaboratoryL3N8
{
    class Program
    {
        struct info
        {
            public int index;
            public int positive;
        }
        static int Main(string[] args)
        {
            int n = 7, m = 5;
            info[] i_info = new info[n];
            double[,] array = new double[n,m];
            
            for (int i = 0; i < n; i++)
            {
                int positive_count = 0;
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Array_A[{i}][{j}]: ");
                    string input_ai = Console.ReadLine();
                    if (!double.TryParse(input_ai, out var a))
                    {
                        Console.WriteLine("Invalid number");
                        return 1;
                    }
                    if (a > 0)
                    {
                        positive_count += 1;
                    }
                    array[i,j] = a;
                }
                i_info[i].index = i;
                i_info[i].positive = positive_count;
            }
            for (int i = 0; i < n; i++)
            {
                double maxim = i_info[i].positive;
                for (int j = i + 1; j < n; j++)
                {
                    if (i_info[j].positive > maxim)
                    {
                        maxim = i_info[j].positive;
                        info temp = i_info[i];
                        i_info[i] = i_info[j];
                        i_info[j] = temp;
                    }
                }
            }
            
            double[,] ans = new double[n,m];
            for (int i = 0; i < n; i++)
            {
                int index = i_info[i].index;
                for (int j = 0; j < m; j++)
                {
                    ans[i,j] = array[index, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{ans[i, j]} ");
                }
                Console.WriteLine();
            }
            return 0;
        }
    }
}