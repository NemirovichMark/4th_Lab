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
        var B = new List<int>();
        var mas = new List<int>();
        int sum = 0;
        string s = "0";
        int[] str = new int[n];
        int b=0;
        int v1 = 0, v2 = 0;
        int k = 0;
        int x;
        Console.WriteLine("Enter the matrix: ");
        for (int i = 0; i < n ; i++)
        {
            matrix.Add(new List<int>());
            string[] line = Console.ReadLine().Split(" ");
            for (int j = 0; j < m; j++)
            {
                matrix[i].Add(Convert.ToInt32(line[j]));
            }
        }
        for (int i=0; i<n; i++)
        {
            A.Add(matrix[i].Max());
        }
        for (int i=0; i<n; i++)
        {
            for (int j = 0; j<m; j++)
                if (matrix[i][j] == A[i]) B.Add(j);
        }
        for (int i=0; i<n-1; i=i+2)
        {
            x = matrix[i][B[i]];
            matrix[i][B[i]] = matrix[i + 1][B[i + 1]];
            matrix[i + 1][B[i + 1]] = x;
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