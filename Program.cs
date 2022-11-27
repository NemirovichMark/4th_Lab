using System.Globalization;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

static double[][] asd(int x, int y)
{
    double[][] a = new double[x][];
    double[][] flag = new double[0][];  
    try
    {
        for (int i = 0; i < x; i++)
        {
            double[] a1 = new double[y];
            a[i] = a1;
            for (int j = 0; j < y; j++)
            {
                Console.WriteLine($"введите {i} {j} элемент");
                a[i][j] = double.Parse(Console.ReadLine());
            }
        }
        return a;
    }
    catch(Exception)
    {
        Console.WriteLine("Error");
        return flag;
    }
}

static void Result(double[][] p)
{   
    for (int i = 0; i < p.Length; i++)
    {
        for (int j = 0; j < p[i].Length; j++)
        {
            Console.Write(p[i][j] + "\t");
        }
        Console.WriteLine();
    }
}
static double[][] ASD()
{
    int x = 0;
    int y = 0;
    double[][] flag = new double[0][];
    try
    {
        Console.WriteLine("введите количество строк");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("введите количество столбцов");
        y = int.Parse(Console.ReadLine());
        double[][] a = new double[x][];
        for (int i = 0; i < x; i++)
        {
            double[] a1 = new double[y];
            a[i] = a1;
            for (int j = 0; j < y; j++)
            {
                Console.WriteLine($"введите {i} {j} элемент");
                a[i][j] = double.Parse(Console.ReadLine());
            }
        }
        return a;
    }
    catch (Exception)
    {
        Console.WriteLine("Error");
        return flag;
    }
}


#region lvl1

#region ex3
{
    double[][] arr = asd(4, 4);
    double sum = 0;
    int k = 0;
    if (arr.Length != 0)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i][k];
            k += 1;
        }
        Console.WriteLine($"сумма равна {k}");
    }

}
#endregion

#region ex6
{
    double[][] arr = asd(4, 7);
    double[] arr1 = new double[4];
    if (arr.Length != 0)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            arr1[i] = arr[i].Min();
        }
        Console.WriteLine(string.Join(", ", arr1));
    }
}
#endregion

#region ex12
{
    double[][] arr = asd(6, 7);
    double[][] arr2 = new double[5][];
    double k = arr[0].Max();
    int k1 = Array.IndexOf(arr[0], k);
    int k2 = 0;
    int z1 = 0;
    for (int i = 1; i < arr.Length; i++)
    {

        if (k < arr[i].Max())
        {
            k = arr[i].Max();
            k1 = Array.IndexOf(arr[i], k);
            k2 = i;
        }
    }
    
    
    for (int i = 0; i < arr.Length; i++)
    {
        double[] arr3 = new double[6];
        if (i != k2)
        {
            int z = 0;
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (j != k1)
                {
                    arr3[z] = arr[i][j];
                    z += 1;
                }
            }
            arr2[z1] = arr3;
            z1 += 1;
        }
    }
    Result(arr2); 
}
    
#endregion

#region ex13
{
    double[][] arr = asd(5, 5);
    double[] a4 = new double[5];
    double[] ax = new double[5];
    double k = arr[0][0];
    int ki = 0;
    int z = 1;
    a4[0] = arr[0][3];
    for (int i = 1; i < arr.Length; i++)
    {
        a4[i] = arr[i][3];
        if (k < arr[i][z])
        {
            k = arr[i][z];
            ki = i;
        }
        z++;
    }
    for (int j = 0; j < arr.Length; j++)
    {
        ax[j] = arr[j][ki];
    }
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i][ki] = a4[i];
        arr[i][3] = ax[i];
    }
    Result(arr);
}
#endregion

#region ex17
{
    double[][] arr = ASD();
    for (int i = 0; i < arr.Length ; i++)
    {
        double k = arr[i].Min();
        int k1 = Array.IndexOf(arr[i], k);
        for (int j = k1; j > 0; j--)
        {
            arr[i][j] = arr[i][j - 1];
        }
        arr[i][0] = k;
    }
    Result(arr);
}
#endregion

#region ex29
{
    double[][] arr = asd(2, 4);
    int k = Array.IndexOf(arr[1], arr[1].Min());
    if (k < arr[1].Length - 1)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = k + 1; j < arr[i].Length - 1; j++)
            {
                arr[i][j] = arr[i][j + 1];
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Array.Resize(ref arr[i], arr[i].Length - 1);
        }
        Result(arr);
    }
    else
        Result(arr);
    
}
#endregion

#region ex31

{
    int x = 5;
    int y = 8;
    Console.WriteLine("Матрица А");
    int[,] a = new int[x, y];
    Random r = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y - 1; j++)
        {
            a[i, j] = r.Next(100);
        }
    }
    Console.WriteLine();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write(a[i, j] + "\t");

        }
        Console.WriteLine();
    }
    int xmin = int.MaxValue;
    int imin = 0;
    for (int i = 0; i < y - 1; i++)
    {
        if (a[4, i] < xmin)
        {
            xmin = a[4, i];
            imin = i;
        }
    }
    Console.WriteLine("Минимальный элемент пятой строки = " + xmin);
    Console.WriteLine("Его индекс = " + imin);
    Console.WriteLine("Введите элементы массива B");
    int[] b = new int[5];
    for (int i = 0; i < 5; i++)
    {
        while (!int.TryParse(Console.ReadLine(), out b[i]))
        {

        }
    }
    for (int i = 0; i < x; i++)
    {
        for (int j = y - 2; j >= imin; j--)
        {
            a[i, j + 1] = a[i, j];
        }
    }
    for (int j = 0; j < x; j++)
    {
        a[j, imin + 1] = b[j];
    }



    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write(a[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

#endregion
#endregion

#region lvl2

#region ex7
{
    double[][] arr = asd(6, 6);
    int z = 1;
    int k1 = 0;
    int k2 = 0;
    int f = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i][z] > arr[i - 1][z - 1])
        {
            k1 = i;
            k2 = z;
        }
    }
    for (int i = 0; i < k1; i++)
    {
        for (int j = f; j < arr[i].Length; j++)
        {
            arr[i][j] = 0;
        }
        f++;
    }
    Result(arr);
}
#endregion

#region ex8

{
    double[][] arr = asd(6, 6);
    double mx1 = 0;
    double mx2 = 0;
    for (int i = 0; i < arr.Length - 1; i += 2)
    {
        mx1 = arr[i].Max();
        mx2 = arr[i + 1].Max();
        arr[i][Array.IndexOf(arr[i], mx1)] = mx2;
        arr[i + 1][Array.IndexOf(arr[i + 1], mx2)] = mx1;
    }
    Result(arr);
}
#endregion

#region ex9
{
    double[][] arr = asd(6, 7);
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i].Reverse();
    }
    Result(arr);
}

#endregion

#endregion

#region lvl3
#region ex1
{
    double[][] arr = asd(7, 5);
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j].Min() < arr[j + 1].Min())
            {
                double[] vp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = vp;
            }
        }
    }
    Result(arr);
}
#endregion

#region ex2
{
    double[][] arr = ASD();
    for (int i  = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < arr[i].Length; j++)
                arr[i][j] = 0;
        }
        if (i == arr.Length - 1)
        {
            for (int j = 0; j < arr[i].Length; j++)
                arr[i][j] = 0;
        }
        arr[i][0] = 0;
        arr[i][^1] = 0;
    }
    Result(arr);
}
#endregion

#region ex3
{
    double[][] arr = ASD();
    int x = arr.Length;
    double[] b = new double[2 * x - 1];
    int bi = 0;
    for (int i = x - 1; i >= 0; i--)
    {
        int dlength = x - i;
        double sum = 0;
        for (int j = 0; j < dlength; j++)
        {
            sum += arr[i + j][j];
        }
        b[bi++] = sum;
    }
    for (int i = 1; i < x; i++)
    {

        int dlength = x - i;
        double sum = 0;
        for (int j = 0; j < dlength; j++)
        {
            sum += arr[j][i + j];
        }
        b[bi++] = sum;
    }
    Console.WriteLine("Массив из сумм элементов диагоналей");
    Result(arr);
    Console.WriteLine(string.Join(", ", b));
}
#endregion

#region ex4
{
    double[][] arr = ASD();
    if (arr.Length % 2 == 0)
    {
        int z = 0;
        for (int i =0; i < arr.Length; i++)
        {
            for (int j = 0; j < z; j++)
            {
                arr[i][j] = 0;
            }
            z += 1;
        }
    }
    else
    {
        int z = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < z; j++)
            {
                arr[i][j] = 0;
            }
            z += 1;
        }
    }
    Result(arr);
}
#endregion

#region ex8
{
    double[][] arr = asd(7, 5);
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j].Where(i=>i>0).ToArray().Length < arr[j + 1].Where(i => i > 0).ToArray().Length)
            {
                double[] vp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = vp;
            }
        }
    }
    Result(arr);
}
#endregion

#region ex10
{
    double[][] arr = ASD();
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            Array.Sort(arr[i]);
            Array.Reverse(arr[i]);
        }
        else
        {
            Array.Sort(arr[i]);
        }
    }
    Result(arr);
}
#endregion

#region ex11
{
    double[][] arr = ASD();
    double[] a = new double[0];

    for (int i = 0; i < arr.Length; i++)
    { 
        if (arr[i].Contains(0))
        {
            arr[i] = a;
        }
    }
    Result(arr);
}
#endregion
#endregion
