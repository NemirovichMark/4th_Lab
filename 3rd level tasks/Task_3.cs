#region Level 3 Task 3

int n;
do
{
    do
    {
        Console.Write("enter n: ");
    }
    while (!int.TryParse(Console.ReadLine(), out n));
}
while (n < 1);

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

int[] B = new int[2*n - 1];
for (int i = 0; i < n; i++)
{
    int sum1 = 0, sum2 = 0;
    for (int j = 0; j <= i; j++)
    {
        sum1 += A[n - 1 - i + j, j];
        sum2 += A[j, n - 1 - i + j];
    }
    B[i] = sum1;
    B[(2*n - 1) - 1 - i] = sum2;
}

foreach (int x in B) Console.Write($"{x} ");

#endregion
