using System.Collections.Generic;
using System.Windows.Markup;

class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the first matrix size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second matrix size: ");
        int m = Convert.ToInt32(Console.ReadLine());
        List<List<int>> matrix = new List<List<int>>();
        var A = new List<int>();
        var mas = new List<int>();
        int sum = 0;
        string s = "0";
        int[] str = new int[n];
        int b;
        int v1 = 0, v2 = 0;
        Console.WriteLine("Enter the matrix: ");
        for (int i = 0; i < n; i++)
        {
            matrix.Add(new List<int>());
            string[] line = Console.ReadLine().Split(" ");
            for (int j = 0; j < m; j++)
            {
                A.Add(Convert.ToInt32(line[j]));
                matrix[i].Add(Convert.ToInt32(line[j]));

            }
            mas.Add(A.Max());
            A.Clear();
        }
        mas.Sort();
        b = mas[n - 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i][j] == b) { v1 = i; v2 = j; }

            }
        }
        for (int i = 0; i < n; i++)
        {
            matrix[i].RemoveAt(v2);
        }
        matrix.RemoveAt(v1);
        Console.WriteLine("New matrix: ");
        for (int i = 0; i < matrix.Count(); i++)
        {
            for (int j = 0; j < matrix[0].Count(); j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
        return 0;
    }
}