using System;
using System.ComponentModel;

Console.WriteLine("choose: 1lvl_3(1); 1lvl_6(2); 1lvl_12(3); 1lvl_13(4)/" +
    "1lvl_17(5), 1lvl_29(6), 1lvl_31(7), 2lvl_7(8), 2lvl_8(9), 2lvl_9(10)/" +
    ", 3lvl_1(11), 3lvl_2(12), 3lvl_3(13), 3lvl_4(14), 3lvl_8(15), 3lvl_10(16), 3lvl_11(17)");
int choose = Convert.ToInt32(Console.ReadLine());
if (choose == 1)
{
    int[,] aray = new int[4, 4];
    Random random = new Random();
    int sum = 0;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            aray[i, j] = random.Next(0, 10);
        }
    }
    for (int i = 0; i < aray.GetLength(0); i++)
    {
        for (int j = 0; j < aray.GetLength(1); j++)
        {
            Console.Write(aray[i, j] + "\t");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < aray.GetLength(0); i++)
        sum += aray[i, i];

    Console.WriteLine("sum matrix trace:" + sum);
}
if (choose == 2)
{
    int[,] aray = new int[4, 7];
    int[] b = new int[4];
    Random random = new Random();
    int sum = 0;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            aray[i, j] = random.Next(0, 10);
        }
    }
    for (int i = 0; i < aray.GetLength(0); i++)
    {
        for (int j = 0; j < aray.GetLength(1); j++)
        {
            Console.Write(aray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    for(int i = 0; i < aray.GetLength(0); i++)
    {
        int min = aray[i, 0];
        int minix = 0;
        for(int j = 0; j < aray.GetLength(1); j++)
        {
            if (aray[i, j] < min)
            {
                min = aray[i, j];
                minix = j;
            }
            b[i] = minix;
        }
    }

    Console.WriteLine("Array:");
    for(int i = 0; i < b.Length; i++)
    {
        Console.Write(b[i] + " ");
    }
}
if (choose == 3)
{
    int[,] aray = new int[6, 7];
    Random random = new Random();
    int sum = 0;
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            aray[i, j] = random.Next(0, 10);
        }
    }
    for (int i = 0; i < aray.GetLength(0); i++)
    {
        for (int j = 0; j < aray.GetLength(1); j++)
        {
            Console.Write(aray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    int max = aray[0, 0];
    int maxi = 0;
    int maxj = 0;
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            if (aray[i, j] > max)
            {
                max = aray[i, j];
                maxi = i;
                maxj = j;
            }
        }
    }
    for(int i = maxi; i < 5; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            aray[i, j] = aray[i + 1, j];
        }
    }

    for(int i = 0; i < 6; i++)
    {
        for (int j = maxj; j < 6; j++)
        {
            aray[i, j] = aray[i, j + 1];
        }
    }
    Console.WriteLine("max: {0} \n", max);

    Console.WriteLine("final matrix:");
    for(int i = 0; i < 5; i++)
    {
        for(int j = 0; j < 6; j++)
        {
            Console.Write(aray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

if (choose == 4)
{
    int[,] aray = new int[5, 5];
    Random random = new Random();
    int s = 0;
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            aray[i, j] = random.Next(0, 10);
        }
    }
    for (int i = 0; i < aray.GetLength(0); i++)
    {
        for (int j = 0; j < aray.GetLength(1); j++)
        {
            Console.Write(aray[i, j] + "\t");
        }
        Console.WriteLine();
    }

    int max = aray[0, 0];
    int maxj = 0;
    for(int i = 0; i < 5; i++)
    {
        if (aray[i, i] > max)
        {
            max = aray[i, i];
            maxj = i;
        }
    }
    for(int k = 0; k < 5; k++)
    {
        s = aray[k, 3];
        aray[k, 3] = aray[k, maxj];
        aray[k, maxj] = s;
    }
    Console.WriteLine("max: {0} \n", max);

    Console.WriteLine("final matrix:");
    for(int i = 0; i < 5; i++)
    {
        for(int j = 0; j < 5; j++)
        {
            Console.Write(aray[i, j] + "\t");
        }
        Console.WriteLine();
    }

}
if (choose == 5)
{
    int n, m;
    Console.WriteLine("enter number of rows:");
    Int32.TryParse(Console.ReadLine(), out n);
    Console.WriteLine("enter number of columns");
    Int32.TryParse(Console.ReadLine(), out m);

    int[,] aray = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            aray[i, j] = random.Next(0, 50);
        }
    }
    for (int i = 0; i < aray.GetLength(0); i++)
    {
        for (int j = 0; j < aray.GetLength(1); j++)
        {
            Console.Write(aray[i, j] + "\t");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < n; i++)
    {
        int min = aray[i, 0];
        int minj = 0;

        for (int j = 0; j < m; j++)
        {
            if (aray[i, j] < min)
            {
                min = aray[i, j];
                minj = j;
            }
        }

        for (int k = minj; k > 0; k--)
        {
            aray[i, k] = aray[i, k - 1];
        }
        aray[i, 0] = min;
    }

    Console.WriteLine("final matrix:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(aray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

if (choose == 6)
{
    int[,] F = new int[5, 7];
    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            F[i, j] = random.Next(0, 50);
        }
    }
    for (int i = 0; i < F.GetLength(0); i++)
    {
        for (int j = 0; j < F.GetLength(1); j++)
        {
            Console.Write(F[i, j] + "\t");
        }
        Console.WriteLine();
    }

    int min = Math.Abs(F[1, 0]);
    int minj = 0;

    for(int j = 0; j < 7; j++)
    {
        int modj = Math.Abs(F[1, j]);
        if(modj < min)
        {
            min = modj;
            minj = j;
        }
    }
    if(minj == 6)
    {
        Console.WriteLine("the matrix don't changed");
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 7; j++)
            {
                Console.Write(F[i, j]);
            }
            Console.WriteLine();
        }
    }
    else
    {
        for(int i = 0; i < 5; i++)
        {
            for(int j = minj + 1; j < 6; j++)
            {
                F[i, j] = F[i, j + 1];
            }
        }
        Console.WriteLine("final matrix:");
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 6; j++)
            {
                Console.Write(F[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

if (choose == 7)
{
    int[,] aray = new int[5, 8];
    int[] aray2 = new int[5];
    Random random = new Random();

    
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            aray[i, j] = random.Next(0, 45);
            Console.Write(aray[i, j]);
        }
        Console.WriteLine();
    }

    for (int i = 0; i < 5; i++)
    {
        aray2[i] = random.Next(0, 10);
    }

    Console.WriteLine("array B:");
    for (int i = 0; i < 5; i++)
    {
        Console.Write(aray2[i] + " ");
    }

    int min = aray[4, 0];
    int j_min = 0;

    for (int j = 0; j < 7; j++)
    {
        if (aray[4, j] < min)
        {
            min = aray[4, j];
            j_min = j;
        }
    }

    for (int i = 0; i < 5; i++)
    {
        for (int j = j_min + 1; j < 7; j++)
        {
            aray[i, j + 1] = aray[i, j];
        }
    }

    for (int i = 0; i < 5; i++)
    {
        aray[i, j_min + 1] = aray2[i];
    }

    Console.WriteLine("\nfinal matrix:");
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            Console.Write(aray[i, j] + "\t");
        }
        Console.WriteLine();
    }

}
if (choose == 8)
{
    int[,] A = new int[6, 6];
    Random random = new Random();
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            A[i, j] = random.Next(0, 50);
        }
    }
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write(A[i, j] + "\t");
        }
        Console.WriteLine();
    }

    int max = A[0, 0];
    int maxi = 0;
    for (int i = 0; i < 6; i++)
    {
        if (A[i, i] > max)
        {
            max = A[i, i];
            maxi = i;
        }
    }
    for(int i = 0; i < maxi; i++)
    {
        for(int j = i + 1; j < 6; j++)
        {
            A[i, j] = 0;
        }
    }
    Console.WriteLine("final matrix");
    for(int i = 0; i < 6; i++)
    {
        for(int j = 0; j < 6; j++)
        {
            Console.Write(A[i, j] + " ");
        }
        Console.WriteLine();
    }
}
if (choose == 9)
{
    int[,] A = new int[6, 6];
    Random random = new Random();
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            A[i, j] = random.Next(0, 50);
        }
    }
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write(A[i, j] + "\t");
        }
        Console.WriteLine();
    }
    int erlmax = 0;
    int erlmaxj = 0;
    int k = 0;
    int change = 0;

    for(int i = 0; i < 6; i++)
    {
        int max = A[i, 0];
        int maxj = 0;
         
        for(int j = 0; j < 6; j++)
        {
            if (A[i, j] > max)
            {
                max = A[i, j];
                maxj = j;
            }
        }
        k++;

        if (k % 2 == 0)
        {
            change = A[i, maxj];
            A[i, maxj] = erlmax;
            A[i - 1, erlmaxj] = change;
        }
        else
        {
            erlmax = max;
            erlmaxj = maxj;
        }

    }
    Console.WriteLine("final matrix");
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            Console.Write(A[i, j] + " ");
        }
        Console.WriteLine();
    }
}
if (choose == 10)
{
    int[,] A = new int[6, 7];
    Random random = new Random();
    int change = 0;
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            A[i, j] = random.Next(0, 50);
        }
    }
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write(A[i, j] + "\t");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < 6; i++)
    {
        for(int j = 0; j < (7/2); j++)
        {
            change = A[i, j];
            A[i, j] = A[i, 7 - (j + 1)];
            A[i, 7 - (j + 1)] = change;
        }
    }
    Console.WriteLine("final matrix");
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            Console.Write(A[i, j] + " ");
        }
        Console.WriteLine();
    }
}
if (choose == 11)
{
    int[,] A = new int[7, 5];
    Random random = new Random();
    int min = 0;
    int[] aray = new int[7];
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            A[i, j] = random.Next(0, 50);
        }
    }
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write(A[i, j] + "\t");
        }
        Console.WriteLine();
    }

    for(int i = 0; i < 7; i++)
    {
        min = A[i, 0];
        for(int j = 0; j < 5; j++)
        {
            if (A[i, j] < min)
            {
                min = A[i, j];
            }
            aray[i] = min;
        }
    }

    int sorti = 1;
    while(sorti < aray.Length)
    {
        if(sorti == 0 || aray[sorti] <= aray[sorti - 1])
        {
            sorti++;
        }
        else
        {
            int change = aray[sorti - 1];
            aray[sorti - 1] = aray[sorti];
            aray[sorti] = change;

            for(int j = 0; j < 5; j++)
            {
                change = A[sorti - 1, j];
                A[sorti - 1, j] = A[sorti, j];
                A[sorti, j] = change;
            }
            sorti--;
        }
    }
    Console.WriteLine("final matrix");
    for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write(A[i, j] + " ");
        }
        Console.WriteLine();
    }
}
if (choose == 12)
{
    int[,] A = new int[5, 5];
    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            A[i, j] = random.Next(0, 50);
        }
    }
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write(A[i, j] + "\t");
        }
        Console.WriteLine();
    }

    for ( int i = 0; i < 5; i++)
    {
        A[0, i] = 0;
        A[i, 0] = 0;

        A[5 - 1, i] = 0;
        A[i, 5 - 1] = 0;
    }

    Console.WriteLine("final matrix");
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write(A[i, j] + " ");
        }
        Console.WriteLine();
    }
}
if (choose == 13)
{
    int[,] matrix = new int[7, 7];
    int sum1 = 0;
    int sum2 = 0;
    Random random = new Random();
    for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            matrix[i, j] = random.Next(0, 50);
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    int[] aray = new int[2 * 5 - 1];
    int pli = 0;
    int arayi = 0;

    while (pli < 5)
    {
        sum1 = 0;
        sum2 = 0;
        for (int i = 0; i < 5 - pli; i++)
        {
            if (pli == 0)
            {
                sum1 += matrix[i, i];
            }
            else
            {
                sum1 += matrix[i + pli, i];

                sum2 += matrix[i, i + pli];
            }
        }

        if (arayi == 0)
        {
            aray[0] = sum1;
            arayi++;
        }
        else
        {
            aray[arayi] = sum1;
            arayi++;

            aray[arayi] = sum2;
            arayi++;

        }

        pli++;
    }
    Console.WriteLine("final array: ");
    for(int i = 0; i < 2 * 5 - 1; i++)
    {
        Console.WriteLine($"{aray[i]}, ");
    }
}
if (choose == 14)
{
    int n;
    Console.WriteLine("Enter the side of a square matrix: ");
    Int32.TryParse(Console.ReadLine(), out n);

    int[,] a = new int[n, n];
    Random r = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = r.Next(0, 50);
            Console.Write(a[i, j]);
        }
        Console.WriteLine();
    }

    for (int i = n / 2; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j) break;
            a[i, j] = 1;
        }
    }


    Console.WriteLine("Final matrix: ");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a[i, j]);
        }
        Console.WriteLine();
    }

}
if (choose == 15)
{
    int[,] a = new int[7, 5];
    Random r = new Random();

    Console.WriteLine("Start matrix: ");
    for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            a[i, j] = r.Next(-10, 50);
            Console.Write(a[i, j]);
        }
        Console.WriteLine();
    }

    int max_count = 0;
    int[] a_count = new int[7];

    for (int i = 0; i < 7; i++)
    {
        max_count = 0;

        for (int j = 0; j < 5; j++)
        {
            if (a[i, j] > 0)
            {
                max_count++;
            }
        }

        a_count[i] = max_count;
    }

    int f = 1;
    while (f < a_count.Length)
    {
        if (f == 0 || a_count[f - 1] >= a_count[f])
        {
            f++;
        }
        else
        {
            int s = a_count[f];

            a_count[f] = a_count[f - 1];
            a_count[f - 1] = s;

            for (int j = 0; j < 5; j++)
            {
                s = a[f - 1, j];
                a[f - 1, j] = a[f, j];
                a[f, j] = s;
            }

            f--;
        }
    }

    Console.WriteLine("Final matrix: ");
    for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write(a[i, j]);
        }
        Console.WriteLine();
    }
}
if (choose == 16)
{
    int n;
    Console.WriteLine("Enter N: ");
    Int32.TryParse(Console.ReadLine(), out n);

    int[,] a = new int[n, n];
    Random r = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = r.Next(-10, 50);
            Console.Write(a[i, j]);
        }
        Console.WriteLine();
    }

    for (int i = 0; i < n; i++)
    {
        if ((i + 1) % 2 != 0)
        {
            int f = 0;
            while (f < n)
            {
                if (f == 0 || a[i, f - 1] <= a[i, f])
                {
                    f++;
                }
                else
                {
                    int s = a[i, f];
                    a[i, f] = a[i, f - 1];
                    a[i, f - 1] = s;

                    f--;
                }
            }
        }
        else
        {
            int f = 0;
            while (f < n)
            {
                if (f == 0 || a[i, f - 1] >= a[i, f])
                {
                    f++;
                }
                else
                {
                    int swap = a[i, f];
                    a[i, f] = a[i, f - 1];
                    a[i, f - 1] = swap;

                    f--;
                }
            }
        }

    }

    Console.WriteLine("Final matrix: ");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a[i, j]);
        }
        Console.WriteLine();
    }
}
if (choose == 17)
{
    int[,] a = new int[7, 7]
            {
                {2, 0, 1, 4, 9, 34, 18},
                {10, 12, 4, 6, 8, 38, 0},
                {32, 6, 123, 59, 35, 72, 53},
                {22, 3, 0, 6, 65, 1, 81},
                {1, 90, 58, 16, 8, 34, 69},
                {0, 39, 19, 53, 194, 17, 43},
                {54, 965, 14, 61, 14, 84, 13}
            };

    int count = 0;

    for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            if (a[i, j] == 0)
            {
                count++;
            }
        }
    }

    int[,] b = new int[7 - count, 7];
    int f = 0;
    int s = 0;

    for (int i = 0; i < 7; i++)
    {
        f = 0;
        for (int j = 0; j < 7; j++)
        {
            if (a[i, j] == 0)
            {
                f = 1;
                break;
            }
        }
        if (f == 0)
        {
            for (int j = 0; j < 7; j++)
            {
                b[s, j] = a[i, j];
            }
            s++;
        }
    }

    Console.WriteLine("Final matrix: ");
    for (int i = 0; i < 7 - count; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            Console.Write(b[i, j]);
        }
        Console.WriteLine();
    }
}