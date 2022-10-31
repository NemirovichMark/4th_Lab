using System;

namespace LaboratoryL1N6
{
    class Program
    {
        static int Main(string[] args)
        {
            int n = 4, m = 7;

            List<int> ans = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int index = -1;
                double min = 100000000000;
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
                }
                ans.Add(index);
            }

            for (int i = 0; i < ans.Count(); i++)
            {
                Console.Write($"{ans[i]} ");
            }
            return 0;
        }
    }
}