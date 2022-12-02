#region Level 1 Task 3

int n = 4, m = 4;
int[,] A = new int[4, 4];

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
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{A[i, j],3} ");
    }
    Console.WriteLine();
}

int trace = 0;
for (int i = 0; i < n; i++)
{
    trace += A[i, i];
}

Console.WriteLine($"Trace of a matrix: {trace}");

#endregion
