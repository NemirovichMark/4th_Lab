#region Level 1 Task 31

int n = 5, m = 8;
int[,] A = new int[n, m];

// input of matrix values
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m - 1; j++)
    {
        do
        {
            Console.Write($"enter value ({i},{j}) of the matrix: ");
        }
        while (!int.TryParse(Console.ReadLine(), out A[i, j]));
    }
}

int l = 5;
int [] B = new int[l];

// input of array values
for (int i = 0; i < l; i++)
{
    do
    {
        Console.Write($"enter {i} value of array B: ");
    }
    while (!int.TryParse(Console.ReadLine(), out B[i]));
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

// array output
Console.Write("B = ");
foreach (int x in B) Console.Write($"{x} ");
Console.WriteLine();

int min = A[4, 0];
int minj = 0;
for (int j = 0; j < m - 1; j++)
{
    if (A[4, j] < min)
    {
        min = A[4, j];
        minj = j;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = m - 1; j > minj; j--)
    {
        A[i, j] = A[i, j - 1];
    }

    A[i, minj + 1] = B[i];
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
