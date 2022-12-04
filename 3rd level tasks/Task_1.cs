#region Level 3 Task 1

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
    int min = A[i, 0];
    for (int j = 1; j < m; j++)
    {
        if (A[i, j] < min)
        {
            min = A[i, j];
        }
    }
    B[i] = min;
}

Console.WriteLine("\nminimum values in each row:");
foreach (int x in B) Console.WriteLine(x);


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
