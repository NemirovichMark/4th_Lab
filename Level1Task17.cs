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
        for (int i = 0; i < n; i++)
        {
            matrix[i].Insert(0,matrix[i].Min());
        }
        for (int i=0; i<n; i++)
        {
            for (int j=1; j<m; j++)
            {
                if (matrix[i][j] == matrix[i].Min()) matrix[i].RemoveAt(j);
            }
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