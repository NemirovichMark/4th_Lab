#region Level 1 Task 13

int n = 5, m = 5;
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

// find max index (diag)
int max = A[0, 0];
int maxj = 0;
for (int i = 0; i < n; i++)
{
    if (A[i, i] > max)
    {
        max = A[i, i];
        maxj = i;
    }
}

int save;
for (int i = 0; i < n; i++)
{
    save = A[i, maxj];
    A[i, maxj] = A[i, 3];
    A[i, 3] = save;
}

// matrix output
Console.WriteLine();
for (int i = 0; i < n ; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{A[i, j],3} ");
    }
    Console.WriteLine();
}

#endregion
