#region Level 3 Task 2

int n;
do
{
    Console.WriteLine($"enter n: ");
}
while (!int.TryParse(Console.ReadLine(), out n));

int[,] A = new int[n, n];

// input of matrix values
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
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
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{A[i, j],3} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    A[0, i] = 0;
    A[n-1, i] = 0;
    A[i, 0] = 0;
    A[i, n-1] = 0;
}

// matrix output
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{A[i, j],3} ");
    }
    Console.WriteLine();
}

#endregion
