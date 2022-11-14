using System;
using System.Globalization;

static double[,] CreateArray()
{
    int x;
    int y;
    double[,] error = new double[0,0];
    Console.WriteLine("Enter array height and width");
    try { x = int.Parse(Console.ReadLine()); y = int.Parse(Console.ReadLine()); }
    catch { Console.WriteLine("Error"); return error; }
    double[,] array = new double[x,y];
    for (int i = 0; i < x; i++)
    {
        Console.WriteLine($"Enter {i+1} line");
        for (int j = 0; j < y; j++)
        {
            try { array[i, j] = double.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Error"); return error; }
        }
    }
    return array;
}

static void PrintArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

static void lvl1Task3()
{
    Console.WriteLine("Lvl 1 Task 3");
    double result = 0;
    int check = 0;
    double[,] array = CreateArray();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == check)
            {
                result += array[i, j];
            }
        }
        check++;
    }
    Console.WriteLine(result);

}

static void lvl1Task6()
{
    Console.WriteLine("Lvl 1 Task 6");
    int[] result = new int[4];
    double min;
    double[,] array = CreateArray();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        min = double.PositiveInfinity;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                result[i] = j;
                min = array[i, j];
            }
        }
    }
    Console.WriteLine(string.Join("", result));
}

static void lvl1Task12()
{
    int x = 0;
    int y = 0;
    double max = double.NegativeInfinity;
    int[] indexes = new int[2];
    double[,] array = CreateArray();
    double[,] array1 = new double[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
                indexes[0] = i; 
                indexes[1] = j; 
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == indexes[0])
        {
            continue;
        }
        else
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == indexes[1])
                {
                    continue;
                }
                else
                {
                    array1[y,x] = array[i,j];
                    x++;
                }
            }
            x = 0;
            y++;
        }
    }
    PrintArray(array1);
}
static void lvl1Task13()
{
    int diagonal = 0;
    double temp = 0;
    double max = double.NegativeInfinity;
    int max_index = 0;
    double[,] array = CreateArray();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= array.GetLength(1); j++)
        {
            if (j == diagonal)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                    max_index = j;
                }
            }
            else
            {
                continue;
            }
        }
        diagonal++;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp = array[i, max_index];
        array[i, max_index] = array[i,3];
        array[i, 3] = temp;
    }
    PrintArray(array);
}

static void lvl1Task17()
{
    double min = double.PositiveInfinity;
    double temp = 0;
    double[,] array = CreateArray();
    int[] array1 = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                array1[i] = j;
            }
        }
        min = double.PositiveInfinity;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp = array[i, array1[i]];
        for (int j = array1[i]; j > 0; j--)
        {
            array[i,j] = array[i, j-1];
        }
        array[i, 0] = temp;
    }
    PrintArray(array);
}

static void lvl1Task29()
{
    double[,] array = CreateArray();
    double min = double.PositiveInfinity;
    int min_index = 0;
    double temp = 0;
    double[,] array1 = new double[array.GetLength(0), array.GetLength(1)-1];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int i = 1;
        if (array[i, j] < min)
        {
            min = array[i, j];
            min_index = j;
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = min_index+1; j < array.GetLength(1)-1; j++)
        {
            temp = array[i,j];
            array[i, j] = array[i, j+1];
            array[i, j+1] = temp;
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            array1[i, j] = array[i, j];
        }
    }
    PrintArray(array1);
}

