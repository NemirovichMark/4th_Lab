using System.Diagnostics.Tracing;

double[,] arr1 = new double[0, 0];
double[,] arr3 = new double[0, 0];
double[,] arr4 = new double[0, 0];
double[] arr2 = new double[0];
double sum1 = 0;
double min1 = Math.Pow(10, 10);
double max1 = -1 * Math.Pow(10, 10);
double trash;
double trash2;
int id_min = 0;
int id_max = 0;
int flag2 = 0;
int counter = 0;
int trash3;
int key;
int m, n;
int flag = 1;

static double[,] Add_mass(int row, int collom)
{
    double[,] arr12 = new double[row, collom];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < collom; j++)
        {
            try
            {
                arr12[i, j] = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error");
                arr12 = new double[0, 0];
                return arr12;
            }
        }
    }
    return arr12;
}


#region Task 1 - 3
 
arr1 = Add_mass(4, 4);
for(int i = 0; i < arr1.GetLength(0); i++)
{
    sum1 += arr1[i, i];
    flag = 0;
}
 
if (flag == 0)
{
    Console.WriteLine(sum1);
}
 
#endregion

#region Task 1 - 6
 
arr1 = Add_mass(4, 7);
flag = 1;
arr2 = new double[4];
for (int i = 0; i < arr1.GetLength(0); i++)
{
    flag = 0;
    min1 = arr1[i, 0];
    id_min = 0;
    for (int j = 0; j < 7; j++)
    {
        if (arr1[i, j] < min1)
        {
            min1 = arr1[i, j];
            id_min = j;
        }
    }
    arr2[i] = id_min;
}
 
if (flag == 0)
{
    Console.WriteLine(string.Join(" ", arr2));
}
 
#endregion

#region Task 1 - 12

arr1 = Add_mass(6, 7);
flag = 0;
int r_max = 0;
int c_max = 0;
try
{
    max1 = arr1[0, 0];
}
catch
{
}
for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 1; j < arr1.GetLength(1); j++)
    {
        if (max1 < arr1[i, j])
        {
            max1 = arr1[i, j];
            r_max = i;
            c_max = j;
        }
        flag = 1;
    }
}

if (flag == 1)
{
    arr3 = new double[arr1.GetLength(0) - 1, arr1.GetLength(1) - 1];
    for (int i = 0; i < arr3.GetLength(0) + 1; i++)
    {
        for (int j = 0; j < arr3.GetLength(1) + 1; j++)
        {
            if ((i < r_max) && (j < c_max))
            {
                arr3[i, j] = arr1[i, j];
            }

            if ((i < r_max) && (j > c_max))
            {
                arr3[i, j - 1] = arr1[i, j];
            }

            if ((i > r_max) && (j > c_max))
            {
                arr3[i - 1, j - 1] = arr1[i, j];
            }

            if ((i > r_max) && (j < c_max))
            {
                arr3[i - 1, j] = arr1[i, j];
            }

        }
    }

    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            Console.Write(arr3[i, j] + " ");
        }
        Console.WriteLine();
    }
}

#endregion

#region Task 1 - 13

arr1 = Add_mass(5, 5);
flag = 0;
id_max = 0;
try
{
    max1 = arr1[0, 0];
}
catch
{

}
for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        if (arr1[i, j] > max1)
        {
            id_max = j;
            max1 = arr1[i, j];
        }
        flag = 1;
    }
}

if (flag == 1)
{
    for (int i = 0; i < arr1.GetLength(1); i++)
    {
        trash = arr1[i, id_max];
        arr1[i, id_max] = arr1[i, 3];
        arr1[i, 3] = trash;
    }

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write(arr1[i, j] + " ");
        }
        Console.WriteLine();
    }
}
#endregion

#region Task 1 - 17
n = 0;
m = 0;
try
{
    Console.WriteLine("Введите n:");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите m:");
    m = Convert.ToInt32(Console.ReadLine());
    flag = 1;
}
catch
{
    flag = 0;
}

if (flag == 1)
{
    arr1 = Add_mass(n, m);
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        min1 = arr1[i, 0];
        id_min = 0;
        for (int j = 1; j < m; j++)
        {
            if (min1 > arr1[i, j])
            {
                min1 = arr1[i, j];
                id_min = j;
            }
        }

        trash = 0;
        for (int i1 = 0; i1 < id_min; i1++)
        {
            for (int j = 0; j < id_min; j++)
            {
                trash = arr1[i, j];
                arr1[i, j] = arr1[i, j + 1];
                arr1[i, j + 1] = trash;
            }


        }
        arr1[i, 0] = min1;
    }
}
for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(arr1[i, j] + " ");
    }
    Console.WriteLine();
}
#endregion

#region Task 1 - 29

arr1 = Add_mass(5, 7);
try
{
    min1 = arr1[1, 0];
}
catch
{

}
flag = 0;
id_min = 0;
trash = 0;
for (int j = 1; j < arr1.GetLength(0); j++)
{
    if (Math.Abs(arr1[1, j]) == Math.Abs(min1))
    {
        flag = 1;
    }

    if (Math.Abs(arr1[1, j]) < Math.Abs(min1))
    {
        id_min = j;
        min1 = arr1[1, j];
    }
}

if (flag == 0)
{
    if (arr1.GetLength(1) > 0)
    {


        if (id_min == 6)
        {
            arr3 = new double[arr1.GetLength(0), arr1.GetLength(1)];
        }
        else
        {
            arr3 = new double[arr1.GetLength(0), arr1.GetLength(1) - 1];
        }

        for (int i = 0; i < arr3.GetLength(0); i++)
        {
            for (int j = 0; j < id_min + 1; j++)
            {
                arr3[i, j] = arr1[i, j];
            }
        }

        for (int i = 0; i < arr3.GetLength(0); i++)
        {
            for (int j = id_min + 1; j < arr3.GetLength(1); j++)
            {
                arr3[i, j] = arr1[i, j + 1];
            }
        }

        for (int i = 0; i < arr3.GetLength(0); i++)
        {
            for (int j = 0; j < arr3.GetLength(1); j++)
            {
                Console.Write(arr3[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

#endregion

#region Task 1 - 31

arr1 = Add_mass(5, 7);
flag = 0;
try
{
    min1 = arr1[4, 0];
    id_min = 0;
}
catch
{
    Console.WriteLine("Error");
    flag = 1;
}

if (flag == 0)
{
    for (int j = 1; j < arr1.GetLength(1); j++)
    {
        if (min1 > arr1[4, j])
        {
            min1 = arr1[4, j];
            id_min = j;
        }
    }

    Console.WriteLine("Введите вектор В");

    arr2 = new double[5];
    flag2 = 0;
    for (int i = 0; i < 5; i++)
    {
        try
        {
            arr2[i] = Convert.ToDouble(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Error");
            flag2 = 1;
            break;
        }
    }

    if (flag2 != 1)
    {
        arr3 = new double[5, 8];

        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j <= id_min; j++)
            {
                arr3[i, j] = arr1[i, j];
            }
        }

        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = id_min + 2; j < 8; j++)
            {
                arr3[i, j] = arr1[i, j - 1];
            }
        }

        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            arr3[i, id_min + 1] = arr2[i];
        }

        for (int i = 0; i < arr3.GetLength(0); i++)
        {
            for (int j = 0; j < arr3.GetLength(1); j++)
            {
                Console.Write(arr3[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
else
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write(arr1[i, j] + " ");
        }
        Console.WriteLine();
    }
}

#endregion

#region Task 2 - 7

arr1 = Add_mass(6, 6);
try
{
    max1 = arr1[0, 0];
    flag = 1;
    id_max = 0;
}
catch
{
    flag = 0;
    Console.WriteLine("Error");
}

flag2 = 0;

if (flag != 0)
{
    for (int i = 1; i < arr1.GetLength(0); i++)
    {
        if (max1 < arr1[i, i])
        {
            max1 = arr1[i, i];
            id_max = i;
        }
        flag2 = 1;
    }

    if (flag2 == 1)
    {
        for (int i = 0; i < id_max; i++)
        {
            for (int j = i + 1; j < arr1.GetLength(1); j++)
            {
                arr1[i, j] = 0;
            }
        }
    }

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write(arr1[i, j] + " ");
        }
        Console.WriteLine();
    }
}

#endregion

#region Task 2 - 8

arr1 = Add_mass(6, 6);
arr3 = new double[2, 6];
flag2 = 0;
flag = 1;
for (int i = 0; i < arr1.GetLength(0); i++)
{
    max1 = arr1[i, 0];
    id_max = 0;

    for (int j = 1; j < arr1.GetLength(1); j++)
    {
        if (max1 < arr1[i, j])
        {
            max1 = arr1[i, j];
            id_max = j;
        }
    }
    arr3[0, i] = id_max;
    arr3[1, i] = max1;
}


for (int i = 0; i < arr1.GetLength(0); i += 2)
{
    trash3 = Convert.ToInt16(arr3[0, i]);
    arr1[i, trash3] = arr3[1, i + 1];
    trash3 = Convert.ToInt16(arr3[0, i + 1]);
    arr1[i + 1, trash3] = arr3[1, i];
}

for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        Console.Write(arr1[i, j] + " ");
    }
    Console.WriteLine();
}


#endregion

#region Task 2 - 9

arr1 = Add_mass(6, 7);

for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < 3; j++)
    {
        trash = arr1[i, j];
        arr1[i, j] = arr1[i, 6 - j];
        arr1[i, 6 - j] = trash;
    }
}


for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        Console.Write(arr1[i, j] + " ");
    }
    Console.WriteLine();
}
#endregion


#region Task 3 - 1

arr1 = Add_mass(7, 5);
arr3 = new double[2, 7];
flag = 0;

for (int i = 0; i < arr1.GetLength(0); i++)
{
    min1 = arr1[i, 0];
    for (int j = 1; j < arr1.GetLength(1); j++)
    {
        if (min1 > arr1[i, j])
        {
            min1 = arr1[i, j];
        }
    }
    arr3[0, i] = min1;
    arr3[1, i] = i;
    flag = 1;
}

arr4 = new double[7, 5];
trash = 0;
trash2 = 0;

if (flag == 1)
{
    for (int i = 0; i < arr3.GetLength(1); i++)
    {
        for (int j = 0; j < arr3.GetLength(1) - 1; j++)
        {
            if (arr3[0, j] < arr3[0, j + 1])
            {
                trash = arr3[0, j];
                arr3[0, j] = arr3[0, j + 1];
                arr3[0, j + 1] = trash;

                trash2 = arr3[1, j];
                arr3[1, j] = arr3[1, j + 1];
                arr3[1, j + 1] = trash2;
            }
        }
    }

    for (int i = 0; i < arr4.GetLength(0); i++)
    {
        key = Convert.ToInt16(arr3[1, i]);
        for (int j = 0; j < arr4.GetLength(1); j++)
        {
            arr4[i, j] = arr1[key, j];
        }
    }

    for (int i = 0; i < arr4.GetLength(0); i++)
    {
        for (int j = 0; j < arr4.GetLength(1); j++)
        {
            Console.Write(arr4[i, j] + " ");
        }
        Console.WriteLine();
    }
}
#endregion

#region Task 3 - 2
try
{
    Console.WriteLine("Введите сторону квадратной матрицы");
    key = Convert.ToInt16(Console.ReadLine());
    arr1 = Add_mass(key, key);
    arr3 = new double[key + 2, key + 2];
    flag = 1;
}
catch
{
    Console.Write("Error");
    flag = 0;
}

if (flag == 1)
{

    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            if ((j - 1 < 0) || (j + 1 == arr3.GetLength(1)) || (i - 1 < 0) || (i + 1 == arr3.GetLength(0)))
            {
                arr3[i, j] = 0;
            }
            else
            {
                arr3[i, j] = arr1[i - 1, j - 1];
            }
        }
    }

    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            Console.Write(arr3[i, j] + " ");
        }
        Console.WriteLine();
    }
}

#endregion

#region Task 3 - 3

try
{
    Console.WriteLine("Введите сторону квадратной матрицы");
    key = Convert.ToInt16(Console.ReadLine());
    arr1 = Add_mass(key, key);
    arr2 = new double[2 * key - 1];
    flag = 1;
}
catch
{
    Console.Write("Error");
    flag = 0;
    key = 1;
}

if (flag == 1)
{
    trash3 = 0;
    flag = 0;
    for (int i = arr1.GetLength(0) - 1; i > -1; i--)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arr2[(j + trash3) % (2 * key - 1)] += arr1[i, j];
        }
        trash3 += 1;
        flag = 1;
    }

    if (flag == 1)
    {
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            Console.Write(arr2[i] + " ");
        }
    }
}

#endregion

#region Task 3 - 4

try
{
    Console.WriteLine("Введите сторону квадратной матрицы");
    key = Convert.ToInt16(Console.ReadLine());
    arr1 = Add_mass(key, key);
    arr2 = new double[2 * key - 1];
    flag = 1;
}
catch
{
    Console.Write("Error");
    flag = 0;
    key = 1;
}

if (flag == 1)
{
    for (int i = key / 2; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (i >= j)
            {
                arr1[i, j] = 0;
            }
        }
    }

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write(arr1[i, j] + " ");
        }
        Console.WriteLine();
    }
}

#endregion

#region Task 3 - 8

arr1 = Add_mass(7, 5);
arr3 = new double[2, 7];
flag = 0;
counter = 0;

for (int i = 0; i < arr1.GetLength(0); i++)
{
    counter = 0;
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        if (arr1[i, j] > 0)
        {
            counter++;
        }
    }
    arr3[0, i] = counter;
    arr3[1, i] = i;
    flag = 1;
}

arr4 = new double[7, 5];
trash = 0;
trash2 = 0;

if (flag == 1)
{
    for (int i = 0; i < arr3.GetLength(1); i++)
    {
        for (int j = 0; j < arr3.GetLength(1) - 1; j++)
        {
            if (arr3[0, j] < arr3[0, j + 1])
            {
                trash = arr3[0, j];
                arr3[0, j] = arr3[0, j + 1];
                arr3[0, j + 1] = trash;

                trash2 = arr3[1, j];
                arr3[1, j] = arr3[1, j + 1];
                arr3[1, j + 1] = trash2;
            }
        }
    }

    for (int i = 0; i < arr4.GetLength(0); i++)
    {
        key = Convert.ToInt16(arr3[1, i]);
        for (int j = 0; j < arr4.GetLength(1); j++)
        {
            arr4[i, j] = arr1[key, j];
        }
    }

    for (int i = 0; i < arr4.GetLength(0); i++)
    {
        for (int j = 0; j < arr4.GetLength(1); j++)
        {
            Console.Write(arr4[i, j] + " ");
        }
        Console.WriteLine();
    }
}

#endregion

#region Task 3 - 10

try
{
    Console.WriteLine("Введите длинну матрицы");
    m = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите ширигу матрицы");
    n = Convert.ToInt16(Console.ReadLine());
    arr1 = Add_mass(m, n);
    arr2 = new double[n];
    flag = 1;
}
catch
{
    Console.Write("Error");
    flag = 0;
}

if (flag == 1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arr2[j] = arr1[i, j];
        }

        if (i % 2 == 0)
        {
            Array.Sort(arr2);
            Array.Reverse(arr2);
        }
        else
        {
            Array.Sort(arr2);
        }

        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arr1[i, j] = arr2[j];
        }
    }

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write(arr1[i, j] + " ");
        }
        Console.WriteLine();
    }

}

#endregion

#region Task 3 - 11

try
{
    Console.WriteLine("Введите длинну матрицы");
    m = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите ширигу матрицы");
    n = Convert.ToInt16(Console.ReadLine());
    arr1 = Add_mass(m, n);
    trash = arr1[0, 0];
    arr2 = new double[m];
    flag = 1;
    counter = 0;
}
catch
{
    Console.Write("Error");
    flag = 0;
    m = 0;
    n = 0;
}

if (flag == 1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        flag2 = 0;
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (arr1[i, j] == 0)
            {
                flag2 = 1;
            }
        }

        if (flag2 == 1)
        {
            arr2[i] = 1;
            counter++;
        }
    }

    arr3 = new double[m - counter, n];
    counter = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        if (arr2[i] == 1)
        {
            counter++;
        }
        else
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                arr3[i - counter, j] = arr1[i, j];
            }
        }
    }

    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            Console.Write(arr3[i, j] + " ");
        }
        Console.WriteLine();
    }

}

#endregion
