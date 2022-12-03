#region Level 1 Task 29

int n = 5, m = 7;
int[,] F = new int[n, m];

// input of matrix values
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        do
        {
            Console.Write($"enter the value ({i},{j}) of the array: ");
        }
        while (!int.TryParse(Console.ReadLine(), out F[i, j]));
    }
}

// matrix output
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{F[i, j],3} ");
    }
    Console.WriteLine();
}

int min_abs = Math.Abs(F[1, 0]);
int minj = 0;
for (int j = 0; j < 7; j++)
{
    if (Math.Abs(F[1, j]) < min_abs)
    {
        min_abs = Math.Abs(F[1, j]);
        minj = j;
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = minj; j < 7 - 1; j++)
    {
        F[i, j] = F[i, j + 1];
    }
}

// matrix output
Console.WriteLine();
for (int i = 0; i < n ; i++)
{
    for (int j = 0; j < m - 1; j++)
    {
        Console.Write($"{F[i, j],3} ");
    }
    Console.WriteLine();
}

#endregion
