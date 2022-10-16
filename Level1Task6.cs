using System.Windows.Markup;

class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the first matrix size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second matrix size: ");
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[n, m];
        var A = new List<int>();
        var mas = new List<int>();
        int sum = 0;
        string s = "0";
        int[] str = new int[n];
        for (int i=0; i<n; i++)
        {
            string[] line = Console.ReadLine().Split(" ");
            for (int j=0; j<m; j++)
            {
                A.Add(Convert.ToInt32(line[j]));
                matrix[i,j] = Convert.ToInt32(line[j]);
            }
            mas.Add(A.Min());
            A.Clear();
        }
        for (int i=0; i<n; i++)
        {
            for (int j=0; j<m; j++)
            {
                if (matrix[i,j] == mas[i]) mas[i] = j;
            }
        }
        Console.WriteLine("Array of indexes of minimum values in rows: ");
        for (var i=0; i<n; i++)
        {
            Console.Write(mas[i] + " ");
        }
        return 0;
    }
}