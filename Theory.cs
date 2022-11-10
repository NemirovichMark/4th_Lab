//FIRST AND SECOND PART
//1.3
 
using System.ComponentModel.DataAnnotations;
 
int[,] matrix = { {1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16} };
int c1 = 0, c2 = 3,s1 = 0, s2 = 0;
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write(" ");
    }
    Console.Write("\n");
}
for (int i = 0; i < 4; i++)
{
        s1 += matrix[i, c1];
        c1++;
        s2 += matrix[i, c2];
        c2--;
}
 
Console.WriteLine($"Сумма = {s1+s2}");
 
//1.6
 
int[,] matrix2 = { 
    { 1, 2, 3, -4, 5, 6, 7 },
    { 5, 6, 7, -8, 9, 10, 11 },
    { 9, 10, -11, 12, 13, 14, 15 },
    { 13, -14, 15, 16, 17, 18, 19 } };
 
int[] minmas = new int[4];
 
int min = 0;
 
for (int i = 0; i < 4; i++)
{
    min = matrix2[i, 0];
    for (int j = 0; j < 7; j++)
    {
        if (matrix2[i,j]<min)
        {
            min = matrix2[i, j];
        }
    }
    minmas[i] = min;
}
 
Console.WriteLine("Массив мин. элементов:");
for (int i = 0; i < minmas.Length; i++)
{
    Console.WriteLine(minmas[i]);
}
 
 
//1.12
 
int[,] matrix12 = { {0,1,3,   4,5,6,7000},
                    {6,7,8,   9,10,11,12},
                    {11,12,13,14,15,16,17},
                    {16,17,18,19,20,21,22},
                    {21,22,23,24,25,26,27},
                    {21,22,23,24,25,26,27}};
int max = 0, maxi = 0, maxj = 0;
 
int[,] matrix121 = {{0,0,0,0,0,0},
                    {0,0,0,0,0,0},
                    {0,0,0,0,0,0},
                    {0,0,0,0,0,0},
                    {0,0,0,0,0,0},};
 
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if (matrix12[i,j]>max)
        {
            max = matrix12[i, j];
            maxi = i;
            maxj = j;
        }
    }
}
 
int ic = 0, jc = 0;
 
for (int i = 0; i < 6; i++)
{
    if(i==maxi)
    {
        continue;
    }
    for (int j = 0; j < 7; j++)
    {
        if(j==maxj)
        {
            continue;
        }
        matrix121[ic, jc] = matrix12[i,j];
        jc++;
    }
    ic++;
    jc = 0;
}
 
Console.WriteLine("Исправленный массив:");
 
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write(matrix121[i,j]);
        Console.Write(" ");
    }
    Console.Write("\n");
}
 
//1.29
 
int[,] matrix29 = { {0,1,3,   4,5,6,70},
                    {-2,5,8,   9,10,11,111},
                    {11,12,13,14,15,16,17},
                    {16,17,18,19,20,21,22},
                    {21,22,23,24,25,26,27},};
int[,] matrix291 = { {0,0,0,   0,0,0},
                    {0,0,0,   0,0,0},
                    {0,0,0,   0,0,0},
                    {0,0,0,   0,0,0},
                    {0,0,0,   0,0,0},};
 
min = Math.Abs(matrix29[1,0]);
int minj = 1;
for (int j = 0; j < 7; j++)
{
    if (Math.Abs(matrix29[1,j]) < min)
    {
        min = Math.Abs(matrix29[1, j]);
        if (j < 6)
        {
            minj = j + 1;
        } else
        {
            Console.WriteLine("Неверный формат массива!!! Будет выведен массив с удалением последнего столбца");
            minj = 6;
        }
    }
}
 
jc = 0;
 
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if(j==minj)
        {
            continue;
        }
        matrix291[i, jc] = matrix29[i,j];
        jc++;
    }
    jc = 0;
}
 
Console.WriteLine("1.29 Исправленный массив:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write(matrix291[i,j]);
        Console.Write(" ");
    }
    Console.Write("\n");
}
 
//1.17
int n = 0, m = 0;
double inp = 0;
Console.WriteLine("Введите кол-во строк в матрице:");
if (Int32.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Введите кол-во столбцов в матрице:");
    if (Int32.TryParse(Console.ReadLine(), out m))
    {
        double[,] matrix17 = new double[n,m];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите строку {i + 1}:");
            for (int j = 0; j < m; j++)
            {
                if (Double.TryParse(Console.ReadLine(), out inp))
                {
                    matrix17[i, j] = inp;
                }
            }
        }
        double[,] matrix171 = new double[n, m];
        double min17 = 0;
        Console.WriteLine("Матрица до исправления:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix17[i, j]);
                Console.Write(" ");
            }
            Console.Write("\n");
        }
        Console.WriteLine("Матрица после исправления:");
        for (int i = 0; i < n; i++)
        {
            min17 = matrix17[i, 0];
            jc = 1;
            int jc1 = 0;
            for (int j = 1; j < m; j++)
            {
                if (matrix17[i,j]<min17)
                {
                    min17 = matrix17[i, j];
                }
            }
            matrix171[i, 0] = min17;
            while (jc < m)
            {
                if (matrix17[i,jc1] == min17)
                {
                    jc1++;
                    continue;
                }
                matrix171[i, jc] = matrix17[i,jc1];
                jc1++;
                jc++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix171[i, j]);
                Console.Write(" ");
            }
            Console.Write("\n");
        }
    }
}
 
//1.13
int[,] matrix13 = { {1,2,3,4,5},
                    {1,2,3,4,5},
                    {1,2,3,4,5},
                    {1,2,3,4,5},
                    {1,2,3,4,5},
                    };
 
 
int max13 = matrix13[0,0];
int temp;
for (int i = 0; i < 5; i++)
{
    if (matrix13[i,i] > max13)
    {
        max13 = matrix13[i, i];
        maxj = i;
    }
}
 
for (int j = 0; j < 5; j++)
{
    temp = matrix13[j, maxj];
    matrix13[j,maxj] = matrix13[j,3];
    matrix13[j, 3] = temp;
}
 
Console.WriteLine("Исправленная матрица:");
 
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matrix13[i, j]);
        Console.Write(" ");
    }
    Console.Write("\n");
}
 
//1.31
 
int[,] matrixlast1 = { {1,2,3,4,5,6,7,0},
                    {1,2,3,4,5,6,7,0},
                    {1,2,3,4,5,6,7,0},
                    {1,2,3,4,5,6,7,0},
                    {1,2,3,4,-5,6,7,0},
                    };
int[] vector = {1,2,3,4,5};
 
min = matrixlast1[4,0]; 
 
for (int i = 1; i < 7; i++)
{
    if (matrixlast1[4,i] < min)
    {
        min = matrixlast1[4, i];
        minj = i;
    }
}
 
for (int j = 7; j > minj; j--)
{
    for (int i = 0; i < 5; i++)
    {
        matrixlast1[i, j] = matrixlast1[i, j - 1];
    }
}
 
for (int i = 0; i < 5; i++)
{
    matrixlast1[i, minj] = vector[i];
}
 
Console.WriteLine("1.31 Исправленная матрица:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 8; j++)
    {
        Console.Write(matrixlast1[i, j]);
        Console.Write(" ");
    }
    Console.Write("\n");
}
 
//2.7
 
int[,] matrix27 = { {1,2,3,4,5,6},
                    {1,2,3,4,5,6},
                    {1,2,3,4,5,6},
                    {1,2,3,9,5,6},
                    {1,2,3,4,5,6},
                    {1,2,3,4,5,6},
                    };
 
max = 0;
 
for (int i = 0; i < 6; i++)
{
    if (matrix27[i,i] > max)
    {
        max = matrix27[i, i];
        maxj = i;
    } 
}
 
for (int i = 0; i < maxj; i++)
{
    for (int j = i+1; j < 6; j++)
    {
        matrix27[i, j] = 0;
    }
}
 
Console.WriteLine("2.7 Исправленная матрица:");
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write(matrix27[i, j]);
        Console.Write(" ");
    }
    Console.Write("\n");
}
 
//2.8
 
int[,] matrix28 = { {1,2,8,4,5,6},
                    {1,2,3,9,5,6},
                    {1,2,9,4,5,6},
                    {1,2,3,8,7,6},
                    {1,2,10,4,5,6},
                    {1,2,3,4,5,6},
                    };
int[,] masmax = new int[6,3];
for (int i = 0; i < 6; i++)
{
    masmax[i,0] = matrix28[i, 0];
    masmax[i, 1] = i;
    masmax[i, 2] = 0;
}
for (int i = 0; i < 6; i++)
{
    switch (i)
    {
        case 0:
            for (int j = 1; j < 6; j++)
            {
                if (matrix28[i,j] > masmax[0,0])
                {
                    masmax[0,0] = matrix28[i, j];
                    masmax[0, 1] = i;
                    masmax[0, 2] = j;
                }
            }
            break;
        case 1:
            for (int j = 1; j < 6; j++)
            {
                if (matrix28[i, j] > masmax[1,0])
                {
                    masmax[1,0] = matrix28[i, j];
                    masmax[1, 1] = i;
                    masmax[1, 2] = j;
                }
            }
            break;
        case 2:
            for (int j = 1; j < 6; j++)
            {
                if (matrix28[i, j] > masmax[2,0])
                {
                    masmax[2,0] = matrix28[i, j];
                    masmax[2, 1] = i;
                    masmax[2, 2] = j;
                }
            }
            break;
        case 3:
            for (int j = 1; j < 6; j++)
            {
                if (matrix28[i, j] > masmax[3,0])
                {
                    masmax[3,0] = matrix28[i, j];
                    masmax[3, 1] = i;
                    masmax[3, 2] = j;
                }
            }
            break;
        case 4:
            for (int j = 1; j < 6; j++)
            {
                if (matrix28[i, j] > masmax[4,0])
                {
                    masmax[4,0] = matrix28[i, j];
                    masmax[4, 1] = i;
                    masmax[4, 2] = j;
                }
            }
            break;
        case 5:
            for (int j = 1; j < 6; j++)
            {
                if (matrix28[i, j] > masmax[5,0])
                {
                    masmax[5,0] = matrix28[i, j];
                    masmax[5, 1] = i;
                    masmax[5, 2] = j;
                }
            }
            break;
    }
}
 
temp = matrix28[masmax[0,1],masmax[0,2]];
matrix28[masmax[0, 1], masmax[0, 2]] = matrix28[masmax[1, 1], masmax[1, 2]];
matrix28[masmax[1, 1], masmax[1, 2]] = temp;
 
temp = matrix28[masmax[2, 1], masmax[2, 2]];
matrix28[masmax[2, 1], masmax[2, 2]] = matrix28[masmax[3, 1], masmax[3, 2]];
matrix28[masmax[3, 1], masmax[3, 2]] = temp;
 
temp = matrix28[masmax[4, 1], masmax[4, 2]];
matrix28[masmax[4, 1], masmax[4, 2]] = matrix28[masmax[5, 1], masmax[5, 2]];
matrix28[masmax[5, 1], masmax[5, 2]] = temp;
 
Console.WriteLine("2.8 Исправленная матрица:");
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write(matrix28[i,j]);
        Console.Write(" ");
    }
    Console.Write("\n");
}
 
//2.9
 
int[,] matrixlast2 = { {1,2,8,4,5,6},
                    {1,2,3,9,5,6},
                    {1,2,9,4,5,6},
                    {1,2,3,8,7,6},
                    {1,2,10,4,5,6},
                    {1,2,3,4,5,6},
                    };
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 3; j++)
    {
        temp = matrixlast2[i, j];
        matrixlast2[i, j] = matrixlast2[i,5-j];
        matrixlast2[i,5-j] = temp;
    }
}
Console.WriteLine("2.9 Исправленная матрица:");
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write(matrixlast2[i, j]);
        Console.Write(" ");
    }
    Console.Write("\n");
}
//THIRD PART
using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.2
            int[,] matrix32 = {
                {1,2,3,4,5},
                {1,2,3,4,5},
                {1,2,3,4,5},
                {1,2,3,4,5},
                {1,2,3,4,5},
            };

            for (int i = 0; i < 5; i++)
            {
                matrix32[0, i] = 0;
                matrix32[i, 0] = 0;
                matrix32[i, 4] = 0;
                matrix32[4, i] = 0;
            }

            Console.WriteLine("Исправленная матрица 3.2:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix32[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }

            //3.8
            int[,] matrix38 =
            {
                {-1,-2,-3,-4,-5},
                {-1,-2,3,4,5},
                {-1,-2,-3,-4,5},
                {1,2,3,4,-5},
                {1,2,3,4,5},
                {1,2,3,4,5},
                {1,2,3,4,5},
            };

            int[,] counters = new int[7, 2];
            int c;
            for (int i = 0; i < 7; i++)
            {
                c = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (matrix38[i, j] > 0)
                    {
                        c++;
                    }
                }
                counters[i, 0] = i;
                counters[i, 1] = c;
            }
            int[] temp = new int[5];
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 7; j++)
                {
                    if (counters[i, 1] < counters[j, 1])
                    {
                        for (int m = 0; m < 5; m++)
                        {
                            temp[m] = matrix38[j, m];
                            matrix38[j, m] = matrix38[i, m];
                            matrix38[i, m] = temp[m];
                        }
                    }
                }
            }
            Console.WriteLine("Исправленная матрица 3.8:");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix38[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            //3.1
            temp = new int[5];
            int[,] matrix31 =
            {
                {1,2,3,4,5},
                {2,7,8,9,10},
                {1,2,3,4,5},
                {3,10,10,50,45},
                {5,6,6,6,6},
                {1,2,3,4,5},
                {1,2,3,4,5},
            };
            int min, minj, mini;
            int[,] counters31 = new int[7, 3];
            for (int i = 0; i < 7; i++)
            {
                min = matrix31[i, 0];
                minj = 0;
                mini = i;
                for (int j = 0; j < 5; j++)
                {
                    if (matrix31[i, j] < min)
                    {
                        min = matrix31[i, j];
                        minj = j;
                    }
                }
                counters31[i, 0] = min;
                counters31[i, 1] = mini;
                counters31[i, 2] = minj;
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 7; j++)
                {
                    if (counters31[i, 0] < counters31[j, 0])
                    {
                        for (int m = 0; m < 5; m++)
                        {
                            temp[m] = matrix31[j, m];
                            matrix31[j, m] = matrix31[i, m];
                            matrix31[i, m] = temp[m];
                        }
                    }
                }
            }
            Console.WriteLine("Исправленная матрица 3.1:");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix31[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }

            //3.4
            Console.WriteLine("3.4 Введите n:");
            int n = 0;
            int[,] matrix34 = new int[n, n];
            if (Int32.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                matrix34 = new int[n, n];
                if (n % 2 == 0)
                {
                    for (int i = n / 2; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            matrix34[i, j] = 1;
                        }
                    }
                }
                else
                {
                    for (int i = n / 2; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            matrix34[i, j] = 1;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        matrix34[i, j] = 0;
                    }
                }
                Console.WriteLine("Исправленная матрица 3.4:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix34[i, j]);
                        Console.Write(" ");
                    }
                    Console.Write("\n");
                }
            }

            //3.10
            n = 0;
            int k = 0;
            double inp, temp310;
            double[,] matrix310 = new double[n, k];
            Console.WriteLine("3.10 Введите количество строк в матрице:");
            if (Int32.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                Console.WriteLine("3.10 Введите количество столбцов в матрице:");
                if (Int32.TryParse(Console.ReadLine(), out k) && k > 0)
                {
                    matrix310 = new double[n, k];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"3.10 Введите строку {i + 1}:");
                        for (int j = 0; j < k; j++)
                        {
                            if (Double.TryParse(Console.ReadLine(), out inp))
                            {
                                matrix310[i, j] = inp;
                            }
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < k - 2; j = j + 2)
                        {
                            for (int a = j; a < k; a = a + 2)
                            {
                                if (matrix310[i, j] < matrix310[i, a])
                                {
                                    temp310 = matrix310[i, j];
                                    matrix310[i, j] = matrix310[i, a];
                                    matrix310[i, a] = temp310;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 1; j < k - 2; j = j + 2)
                        {
                            for (int a = j; a < k; a = a + 2)
                            {
                                if (matrix310[i, j] > matrix310[i, a])
                                {
                                    temp310 = matrix310[i, j];
                                    matrix310[i, j] = matrix310[i, a];
                                    matrix310[i, a] = temp310;
                                }
                            }
                        }
                    }
                    Console.WriteLine("Исправленная матрица 3.10:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            Console.Write(matrix310[i, j]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                    }
                }
            }
            //3.11
            Console.WriteLine("3.11 Введите количество строк в матрице:");
            if (Int32.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                Console.WriteLine("3.11 Введите количество столбцов в матрице:");
                if (Int32.TryParse(Console.ReadLine(), out k) && k > 0)
                {
                    int n1 = 0;
                    int k1 = 0;
                    c = 0;
                    bool[] toDel = new bool[n];
                    double[,] matrix311 = new double[n, k];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"3.11 Введите строку {i + 1}:");
                        for (int j = 0; j < k; j++)
                        {
                            if (Double.TryParse(Console.ReadLine(), out inp))
                            {
                                matrix311[i, j] = inp;
                            }
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            if (matrix311[i,j] == 0)
                            {
                                toDel[i] = true;
                            }
                        }
                    }

                    for (int i = 0; i < toDel.Length; i++)
                    {
                        if (toDel[i])
                        {
                            c++;
                        }
                    }
                    double[,] matrix311a = new double[n-c, k];
                    int r = 0, col = 0,c1 = 0;
                    while (r <= n-c)
                    {
                        if (toDel[r] != true)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                matrix311a[c1, i] = matrix311[r, i];
                            }
                            c1++;
                        }
                        r++;
                    }
                    Console.WriteLine("Исправленная матрица 3.11:");
                    for (int i = 0; i < n-c; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            Console.Write(matrix311a[i, j]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                    }

                }
            }

            //3.3
            Console.WriteLine("3.3 Введите n:");
            if (Int32.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                double[,] matrix33 = new double[n, n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"3.3 Введите строку {i + 1}:");
                    for (int j = 0; j < n; j++)
                    {
                        if (Double.TryParse(Console.ReadLine(), out inp))
                        {
                            matrix33[i, j] = inp;
                        }
                    }
                }

                double[] diagonalSums = new double[2 * n - 1];
                double mirrorSum;

                int offset = 0;
                int middleIndex = diagonalSums.Length / 2;

                while (offset < n)
                {
                    double sum = 0;
                    mirrorSum = 0;

                    for (int j = 0; j < n - offset; j++)
                    {
                        if (offset == 0)
                            sum += matrix33[j, j];
                        else
                        {
                            sum += matrix33[j + offset, j];
                            mirrorSum += matrix33[j, j + offset];
                        }
                    }

                    diagonalSums[middleIndex + offset] = sum;
                    if (offset != 0)
                        diagonalSums[middleIndex - offset] = mirrorSum;

                    offset++;
                }


                Console.WriteLine("3.3 Ответ:");

                offset = diagonalSums.Length;
                foreach (var num in diagonalSums)
                {
                    for (int i = 0; i < offset - 1; i++)
                    Console.Write(num);
                    Console.Write(" ");
                    offset--;
                }
            }
        }
    }
}

