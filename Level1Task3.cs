class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the length of the side length of the square matrix: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int sum = 0;
        string s = "0";
        int[] str = new int[n];
        for (int i=0; i<n; i++)
        {
            string[] line = Console.ReadLine().Split(" ");
            for (int j=0; j<n; j++)
            {
                matrix[i,j] = Convert.ToInt32(line[j]);
            }
        }
        for (int i=0; i<n; i++)
        {
            sum=sum+matrix[i,i];
        }
        Console.WriteLine("Summ = " + sum);
        return 0;
    }
}