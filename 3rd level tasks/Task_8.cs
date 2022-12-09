#region Level 3 Task 8

int n = 7, m = 5;
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

int[] B = new int [n];
for (int i = 0; i < n; i++)
{
    int cnt_positive = 0;
    for (int j = 0; j < m; j++)
    {
        if (A[i, j] > 0) cnt_positive++;
    }
    B[i] = cnt_positive;
}

Console.Write("B = ");
foreach (int x in B) Console.Write($"{x} ");

int element = 1;
int temp;
while (element < n)
{
    if (element == 0 || B[element] <= B[element - 1])
    {
        element++;
    }

    else
    {
        temp = B[element - 1];
        B[element - 1] = B[element];
        B[element] = temp;

        for (int j = 0; j < m; j++)
        {
            temp = A[element - 1, j];
            A[element - 1, j] = A[element, j];
            A[element, j] = temp;
        }

        element--;
    }
}

// matrix output
Console.WriteLine("\n");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{A[i, j],3} ");
    }
    Console.WriteLine();
}

#endregion
