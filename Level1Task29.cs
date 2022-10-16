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
        int k = 0;
        int x;
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
        }
        for (int i = 0; i < m; i++)
        {
            A.Add(Math.Abs(matrix[1][i]));
        }
        x = A.Min();
        for (int i = 0; i < m; i++)
        {
            if (matrix[1][i] == x) {k = i; break; }
        }
        if (k == matrix[0].Count()) { Console.WriteLine("It is the last table!"); return 0; }
        for (int i=0; i<n; i++)
        {
            matrix[i].RemoveAt(k+1);
        }
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