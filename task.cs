using System;
using System.Globalization;

static double[,] CreateArray()
{
    int x;
    int y;
    double[,] error = new double[0, 0];
    Console.WriteLine("Enter array height and width");
    try { x = int.Parse(Console.ReadLine()); y = int.Parse(Console.ReadLine()); }
    catch { Console.WriteLine("Error"); return error; }
    double[,] array = new double[x, y];
    for (int i = 0; i < x; i++)
    {
        Console.WriteLine($"Enter {i + 1} line");
        for (int j = 0; j < y; j++)
        {
            try { array[i, j] = double.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Error"); return error; }
        }
    }
    return array;
}

static void PrintArray(double[,] array)
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
                    array1[y, x] = array[i, j];
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
        array[i, max_index] = array[i, 3];
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
            array[i, j] = array[i, j - 1];
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
    double[,] array1 = new double[array.GetLength(0), array.GetLength(1) - 1];
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
        for (int j = min_index + 1; j < array.GetLength(1) - 1; j++)
        {
            temp = array[i, j];
            array[i, j] = array[i, j + 1];
            array[i, j + 1] = temp;
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

static void lvl1Task31()
{
    double temp = 0;
    int min_index = 0;
    double min = double.PositiveInfinity;
    double[] vector = new double[5];
    Console.WriteLine("Enter vector");
    for (int i = 0; i < 5; i++)
    {
        try { vector[i] = Convert.ToDouble(Console.ReadLine()); }
        catch { Console.Write("Error"); return; }
    }
    double[,] array = CreateArray();

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int i = 4;
        if (array[i, j] < min)
        {
            min = array[i, j];
            min_index = j;
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1; j > min_index + 1; j--)
        {
            temp = array[i, j];
            array[i, j] = array[i, j - 1];
            array[i, j - 1] = temp;
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = min_index + 1;
        array[i, j] = vector[i];
    }
    PrintArray(array);
}


static void lvl2Task7()
{
    double max = double.NegativeInfinity;
    int max_index = 0;
    int d = 0;
    double[,] array = CreateArray();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == d)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                    max_index = i;
                }
            }
        }
        d++;
    }

    d = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = d + 1; j < array.GetLength(1); j++)
        {
            if (i < max_index)
            {
                array[i, j] = 0;
            }
        }
        d++;
    }
    PrintArray(array);

}

static void lvl2Task8()
{
    double temp = 0;
    double[,] array = CreateArray();
    double[] max = new double[array.GetLength(0)];
    int[] index = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max[i])
            {
                max[i] = array[i, j];
                index[i] = j;
            }
        }
    }

    for (int i = 0; i < max.Length; i += 2)
    {
        temp = max[i];
        max[i] = max[i + 1];
        max[i + 1] = temp;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == index[i])
            {
                array[i, j] = max[i];
            }
        }
    }
    PrintArray(array);
}

static void lvl2Task9()
{
    double[,] array = CreateArray();
    double temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) / 2 + 1; j++)
        {
            temp = array[i, (array.GetLength(1) / 2) - j];
            array[i, (array.GetLength(1) / 2) - j] = array[i, (array.GetLength(1) / 2) + j];
            array[i, (array.GetLength(1) / 2) + j] = temp;
        }
    }
    PrintArray(array);
}
//1-4,8,10,11

/**
static void lvl3Task1()
{
    double[,] array = CreateArray();
    int min = 0;
    double temp = double.PositiveInfinity;
    int temp_1 = 0;
    double[,] min_index = new double[2, array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < temp)
            {
                temp = array[i, j];
                min_index[1, i] = array[i, j];
                min_index[2, i] = i;
            }
        }
    }

    for (int j = 0; j < min_index.GetLength(1) - 1; j++)
    {
        if (min_index[1, j] < min_index[1, j + 1])
        {
            temp = min_index[1, j];
            temp_1 = min_index[2, j];
        }
    }

}
**/

static void lvl3Task2()
{
    double[,] array = CreateArray();
    PrintArray(array);
    Console.WriteLine();
    int end = array.GetLength(0) - 1;
    for (int i = 0; i < end + 1; i++)
    {
        for (int j = 0; j < end + 1; j++)
        {
            if (i == 0 || i == end || j == 0 || j == end)
            {
                array[i, j] = 0;
            }
        }
    }
    PrintArray(array);
}



static void lvl3Task3()
{
    double[,] array = CreateArray();
    double summ = 0;
    int end = array.GetLength(0) - 1;
    for (int i = 0; i < end + 1; i++)
    {
        for (int j = 0; j < end + 1; j++)
        {
            if (i == 0 && j == end || i == end && j == 0)
            {
                continue;
            }
            else
            {
                summ += array[i, j];
            }
        }
    }
    Console.WriteLine(2 * summ - 1);
}

static void lvl3Task4()
{

    double[,] array = CreateArray();
    int end = array.GetLength(0);
    int middle = (end / 2);
    for (int i = middle; i < end; i++)
    {
        for (int j = 0; j < end; j++)
        {
            if (j < middle)
            {
                array[i, j] = 1;
            }
        }
        middle++;
    }
    PrintArray(array);
}

static void lvl3Task1()
{
    double[,] array = CreateArray();
    int f;
    double temp = double.PositiveInfinity;
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    double[,] array1 = new double[a, b];
    double[,] indexes = new double[2, a];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            if (array[i, j] < temp)
            {
                temp = array[i, j];
                indexes[0,i] = array[i, j];
                indexes[1, i] = i;
            }
        }
        temp = double.PositiveInfinity;
    }

    for (int i = 0; i < a - 1; i++)
    {
        for (int j = 0; j < a - 1; j++)
        {
            if (indexes[0, j + 1] < indexes[0, j])
            {
                temp = indexes[0, j + 1];
                indexes[0, j + 1] = indexes[0, j];
                indexes[0, j] = temp;

                temp = indexes[1, j + 1];
                indexes[1, j + 1] = indexes[1, j];
                indexes[1, j] = temp;
            }
        }
    }

    for (int i = 0; i < a; i++)
    {
        f = Convert.ToInt32(indexes[1, i]);
        for (int j = 0; j < b; j++)
        {
            array1[i, j] = array[f, j];
        }
    }

    array = array1;

    PrintArray(array);
}
