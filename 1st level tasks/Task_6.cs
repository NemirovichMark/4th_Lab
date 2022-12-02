#region Level 1 Task 6

int n = 4, m = 7;
int[,] A = new int[n, m];

// input of matrix values
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        do
        {
            Console.Write($"enter the value ({i},{j}) of the array: ");
        }
        while (!int.TryParse(Console.ReadLine(), out A[i, j]));
    }
}

// matrix output
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{A[i, j],3} ");
    }
    Console.WriteLine();
}

int[] B = new int[n];
for (int i = 0; i < n; i++)
{
    int min = A[i, 0];
    int minj = 0;
    for (int j = 0; j < 7; j++)
    {
        if (A[i, j] < min)
        {
            min = A[i, j];
            minj = j;
        }
    }
    B[i] = minj;
}

foreach(int x in B) Console.Write($"{x} ");

#endregion
