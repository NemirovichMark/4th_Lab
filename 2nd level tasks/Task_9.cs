#region Level 2 Task 9

int n = 6, m = 7;
int[,] A = new int[n, m];

// input of matrix values
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        do
        {
            Console.Write($"enter value ({i},{j}) of the matrix: ");
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

int save;
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < ((int)(7 / 2)); j++)
    {
        save = A[i, j];
        A[i, j] = A[i, m - 1 - j];
        A[i, m - 1 - j] = save;
    }
}

// matrix output
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{A[i, j],3} ");
    }
    Console.WriteLine();
}

#endregion
