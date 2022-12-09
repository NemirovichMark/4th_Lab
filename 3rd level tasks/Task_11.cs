#region Level 3 Task 11

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

bool[] check = new bool[n];
for (int i = 0; i < n; i++)
{
    bool iszero = false;
    for (int j = 0; j < m; j++)
    {
        if (A[i, j] == 0)
        {
            iszero = true;
        }
    }
    check[i] = iszero;
}

int[,] B = new int[n, m];
int c = 0;
for (int i = 0; i < n; i++)
{
    if (check[i])
    {
        continue;
    }

    for (int j = 0; j < m; j++)
    {
        B[c, j] = A[i, j];
    }
    c++;
}

// matrix output
Console.WriteLine();
for (int i = 0; i < c; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{B[i, j],3} ");
    }
    Console.WriteLine();
}

#endregion
