#region Level 1 Task 12

int n = 6, m = 7;
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

// find max index
int max = A[0, 0];
int maxi = 0, maxj = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (A[i, j] > max)
        {
            max = A[i, j];
            maxi = i;
            maxj = j;
        }
    }
}

// delete line
for (int i = maxi; i < n - 1; i++)
{
    for (int j = 0; j < m; j++)
    {
        A[i, j] = A[i + 1, j];
    }
}

// delete column
for (int i = 0; i < n; i++)
{
    for (int j = maxj; j < m - 1; j++)
    {
        A[i, j] = A[i, j + 1];
    }
}

// matrix output
Console.WriteLine();
for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < m - 1; j++)
    {
        Console.Write($"{A[i, j],3} ");
    }
    Console.WriteLine();
}

#endregion
