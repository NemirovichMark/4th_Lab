#region Level 2 Task 7

int n = 6, m = 6;
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

int max = A[0, 0];
int maxi = 0;
for (int i = 0; i < m; i++)
{
    if (A[i, i] > max)
    {
        max = A[i, i];
        maxi = i;
    }
}

for (int i = 0; i < maxi; i++)
{
    for (int j = maxi; j < m; j++)
    {
        A[i, j] = 0;
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
