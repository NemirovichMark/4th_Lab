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
        int b;
        int v1 = 0, v2 = 0;
        int k = 0;
        int x;
        Console.WriteLine("Enter the matrix: ");
        for (int i = 0; i < n ; i++)
        {
            matrix.Add(new List<int>());
            string[] line = Console.ReadLine().Split(" ");
            for (int j = 0; j < m - 1; j++)
            {
                matrix[i].Add(Convert.ToInt32(line[j]));
            }
        }
        Console.WriteLine("Enter the vector: ");
        string[] ty = Console.ReadLine().Split(" ");
        for (int i = 0; i<n; i++)
        {
            A.Add(Convert.ToInt32(ty[i]));
        }
        for (int i=0; i<m-1; i++)
        {
            B.Add(matrix[4][i]);
        }
        x = B.Min();
        for (int i=0; i<m-1; i++)
        {
            if (matrix[4][i] == x) k=i;
        }
        for (int i=0; i<n; i++)
        {
            matrix[i].Insert(k + 1, A[i]);
        }
        if (k == matrix[0].Count()) { Console.WriteLine("It is the last table!"); return 0; }
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