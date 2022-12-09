#region Level 3 Task 10

static void ShellSort(int[,] matrix, int row, int a)
{
    if (a == 0)
    {
        var step = matrix.GetLength(1) / 2;
        while (step > 0)
        {
            for (int i = step; i < matrix.GetLength(1); i++)
            {
                int j = i;
                while ((j >= step) && matrix[row, j - step] < matrix[row, j])
                {
                    var temp = matrix[row, j - step];
                    matrix[row, j - step] = matrix[row, j];
                    matrix[row, j] = temp;
                    j -= step;
                }
            }
            step /= 2;
        }
    }

    else if (a == 1)
    {
        var step = matrix.GetLength(1) / 2;
        while (step > 0)
        {
            for (int i = step; i < matrix.GetLength(1); i++)
            {
                int j = i;
                while ((j >= step) && matrix[row, j - step] > matrix[row, j])
                {
                    var temp = matrix[row, j - step];
                    matrix[row, j - step] = matrix[row, j];
                    matrix[row, j] = temp;
                    j -= step;
                }
            }
            step /= 2;
        }
    }
}


int n;
do
{
    Console.Write("enter n: ");
}
while (!int.TryParse(Console.ReadLine(), out n));

int m;
do
{
    Console.Write("enter m: ");
}
while (!int.TryParse(Console.ReadLine(), out m));

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

for (int i = 0; i < n; i++) ShellSort(A, i, i%2);

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
