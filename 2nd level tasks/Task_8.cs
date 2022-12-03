#region Level 2 Task 8

int n = 6, m = 6;
int[,] B = new int[n, m];

// input of matrix values
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        do
        {
            Console.Write($"enter value ({i},{j}) of the matrix: ");
        }
        while (!int.TryParse(Console.ReadLine(), out B[i, j]));
    }
}

// matrix output
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{B[i, j],3} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i += 2)
{
    int max = B[i, 0];
    int maxj = 0;

    int max2 = B[i + 1, 0];
    int max2j = 0;

    int save;
    for (int j = 0; j < m; j++)
    {
        if (B[i, j] > max)
        {
            max = B[i, j];
            maxj = j;
        }

        if (B[i + 1, j] > max2)
        {
            max2 = B[i + 1, j];
            max2j = j;
        }
    }

    save = B[i, maxj];
    B[i, maxj] = B[i + 1, max2j];
    B[i + 1, max2j] = save;
}

// matrix output
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{B[i, j],3} ");
    }
    Console.WriteLine();
}

#endregion
