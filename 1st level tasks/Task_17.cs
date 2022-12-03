#region Level 1 Task 17

int n;
do
{
    Console.Write($"enter n: ");
}
while (!int.TryParse(Console.ReadLine(), out n));

int m;
do
{
    Console.Write($"enter m: ");
}
while (!int.TryParse(Console.ReadLine(), out m));


int[,] B = new int[n, m];

// input of matrix values
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        do
        {
            Console.Write($"enter the value ({i},{j}) of the array: ");
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

int min, minj;
int save;
for (int i = 0; i < n; i++)
{
    min = B[i, 0];
    minj = 0;

    // found the minimum value in the "i" line
    for (int j = 0; j < m; j++)
    {
        if (B[i, j] < min)
        {
            min = B[i, j];
            minj = j;
        }
    }

    while (minj != 0)
    {
        save = B[i, minj];
        B[i, minj] = B[i, minj - 1];
        B[i, minj - 1] = save;
        minj--;
    }
}

// matrix output
Console.WriteLine();
for (int i = 0; i < n ; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{B[i, j],3} ");
    }
    Console.WriteLine();
}

#endregion
