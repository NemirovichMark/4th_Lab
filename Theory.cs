
using System;
using System.Collections.Generic;
using System.Linq;

class HelloWorld 
{
  static void Main() 
  {
    Lab4Level3.Ex10();
  }
}

    public class Lab4Level1
    {
        public static void cout(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,3}", arr[i, j]));
                }
            }
            Console.WriteLine();
        }
        public static void cout(List<List<double>> arr)
        {
            for (int i = 0; i < arr[0].Count; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr[1].Count; j++)
                {
                    Console.Write(String.Format("{0,3}", arr[i][j]));
                }
            }
            Console.WriteLine();
        }
        public static void cout12(List<List<double>> arr)
        {
            for (int i = 0; i < arr[0].Count - 2; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr[1].Count - 2; j++)
                {
                    Console.Write(String.Format("{0,3}", arr[i][j]));
                }
            }
            Console.WriteLine();
        }

        public static void Ex3()
        {
            double x, sum = 0;
            double[,] arr = new double[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Enter {i} and {j} elem");
                    while (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    arr[i, j] = x;
                }
                Console.WriteLine();
            }
            cout(arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, i];
            }
            Console.WriteLine("The result is " + sum);


        }
        public static void Ex6()
        {
            double x, sum = 0;
            double[,] arr = new double[4, 7];
            double[] res = new double[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"Enter {i} and {j} elem");
                    while (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    arr[i, j] = x;
                }
                Console.WriteLine();
            }

            cout(arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double min = double.MaxValue;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
                res[i] = min;
            }
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
        public static void Ex12()
        {
            string[] tmp;
            int m = 6;
            int n = 7;
            List<List<double>> matrix = new List<List<double>>();
            Console.WriteLine($"Enter the matrix ({n} in a line and {m} in a column)");
            for (int i = 0; i < m; i++)
            {
                matrix.Add(new List<double>());
                while (true)
                {
                    tmp = Console.ReadLine().Split(" ");
                    if (tmp.Length != n)
                    {
                        Console.WriteLine($"Incorrect format, matrix should be {n} in a line and {m} in a column");
                        continue;
                    }
                    break;
                }
                for (int j = 0; j < n; j++)
                {
                    double x;
                    double.TryParse(tmp[j], out x);
                    matrix[i].Add(x);
                }
            }
            int IndexN = 0;
            int IndexM = 0;
            double max = matrix[0][0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (max < matrix[i][j])
                    {
                        max = matrix[i][j];
                        IndexN = j;
                        IndexM = i;
                    }
                }
            }
            matrix[IndexM].RemoveAt(IndexN);

            Console.WriteLine("The result:");
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Ex13()
        {
            string[] tmp;
            int n = 5;
            List<List<double>> matrix = new List<List<double>>();
            Console.WriteLine($"Enter the matrix ({n} in a line and {n} in a column)");
            for (int i = 0; i < n; i++)
            {
                matrix.Add(new List<double>());
                while (true)
                {
                    tmp = Console.ReadLine().Split(" ");
                    if (tmp.Length != n)
                    {
                        Console.WriteLine($"Incorrect format, matrix should be {n} in a line and {n} in a column");
                        continue;
                    }
                    break;
                }
                for (int j = 0; j < n; j++)
                {
                    double x;
                    double.TryParse(tmp[j], out x);
                    matrix[i].Add(x);
                }
            }
            double x1 = 0;
            double max = matrix[0][0];
            int index = 0;
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i][k] > max)
                {
                    max = matrix[i][k];
                    index = i;
                }
                k++;
            }

            for (int i = 0; i < n; i++)
            {
                x1 = matrix[i][index];
                matrix[i][index] = matrix[i][3];
                matrix[i][3] = x1;
            }

            Console.WriteLine(" Matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Ex17()
        {
            string[] tmp;
            int n, m;
            Console.WriteLine("Enter the anount of row");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out m))
                {
                    Console.WriteLine("Incorrect value");
                    continue;
                }
                if (m < 0)
                {
                    Console.WriteLine("Must be positive");
                    continue;
                }
                break;
            }

            Console.WriteLine("Enter the anount of column");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Incorrect value");
                    continue;
                }
                if (n < 0)
                {
                    Console.WriteLine("Must be positive");
                    continue;
                }
                break;
            }
            List<List<double>> matrix = new List<List<double>>();
            Console.WriteLine($"Enter the matrix ({n} in a line and {m} in a column)");
            for (int i = 0; i < m; i++)
            {
                matrix.Add(new List<double>());
                while (true)
                {
                    tmp = Console.ReadLine().Split(" ");
                    if (tmp.Length != n)
                    {
                        Console.WriteLine($"Incorrect format, matrix should be {n} in a line and {m} in a column");
                        continue;
                    }
                    break;
                }
                for (int j = 0; j < n; j++)
                {
                    double x;
                    double.TryParse(tmp[j], out x);
                    matrix[i].Add(x);
                }
            }
            for (int i = 0; i < n; i++)
            {
                matrix[i].Insert(0, matrix[i].Min());
            }

            Console.WriteLine("The result: ");
            cout(matrix);
        }
        public static void Ex29()
        {
            double[,] matrix = new double[5, 7];
            double[,] res = new double[5, 6];
            double min = double.MaxValue;
            int minIndex = 0;
            double x;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    while (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    matrix[i, j] = x;
                    if ((Math.Abs(matrix[i, j]) < min) && (i == 1))
                    {
                        min = matrix[i, j];
                        minIndex = j;
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0, counter = 0; j < 6; j++, counter++)
                {
                    if (j == minIndex)
                    {
                        counter++;
                    }
                    res[i, j] = matrix[i, counter];
                }
            }
            cout(res);
        }
        public static void Ex31()
        {

            double[,] matrix = new double[5, 4];
            double[,] res = new double[5, 5];
            double[] B = new double[5];
            double min = double.MaxValue;
            int minIndex = 0;
            double x;
            Console.WriteLine("Enter B:");
            for (int i = 0; i < 5; i++)
            {
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Incorrect value");
                }
                B[i] = x;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Enter {i} and {j} elem");
                    while (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    matrix[i, j] = x;
                    if ((Math.Abs(matrix[i, j]) < min) && (i == 4))
                    {
                        min = matrix[i, j];
                        minIndex = j;
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0, counter = 0; counter < 5; j++, counter++)
                {
                    res[i, counter] = matrix[i, j];
                    if (counter == minIndex)
                    {
                        counter++;
                        res[i, counter] = B[i];
                    }
                }
            }
            cout(res);
        }

    }
    public class Lab4Level2
    {
        public static void Ex7()
        {
            double[,] matrix = new double[6, 6]
            {
                { 1,2,3,4,5,6 },
                { 7,8,9,10,11,12 },
                { 13,14,15,16,17,18 },
                { 17,18,19,22,21,2 },
                { 18,19,20,21,22,23 },
                { 1,2,3,4,5,6 }
            };
            double max = double.MinValue;
            int maxi = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i == j && matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxi = j;
                    }
                }
            }
            for (int i = 0; i < maxi; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            Lab4Level1.cout(matrix);
        }
        public static void Ex8()
        {
            double[,] matrix = new double[6, 6]
            {
                { 1,2,3,4,5,6 },
                { 7,8,9,10,11,12 },
                { 13,14,15,16,17,18 },
                { 17,18,19,22,21,2 },
                { 18,19,20,21,22,23 },
                { 1,2,3,4,5,6 }
            };
            int max0 = 0;
            int max1 = 0;
            double tmp = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (matrix[i, j] > matrix[i, max0] && (i % 2 == 0))
                    {
                        max0 = j;
                    }
                    if (matrix[i, j] > matrix[i, max1] && (i % 2 == 1))
                    {
                        max1 = j;
                    }
                }
                if (i % 2 == 1)
                {
                    tmp = matrix[i - 1, max0];
                    matrix[i - 1, max0] = matrix[i, max1];
                    matrix[i, max1] = tmp;
                    max0 = 0;
                    max1 = 0;
                }
            }
            Lab4Level1.cout(matrix);
        }
        public static void Ex9()
        {
            double[,] matrix = new double[6, 7]
            {
                { 1,2,3,4,5,6,7 },
                { 7,8,9,10,11,12,13 },
                { 13,14,15,16,17,18,19 },
                { 17,18,19,22,21,2,4 },
                { 18,19,20,21,22,23,14},
                { 1,2,3,4,5,6,7 }
            };
            double tmp = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    tmp = matrix[i, k];
                    matrix[i, k] = matrix[i, 6 - k];
                    matrix[i, 6 - k] = tmp;
                }
            }
            Lab4Level1.cout(matrix);
        }
        
    }
    public class Lab4Level3
    {
        public static void Ex1()
        {
            double[,] matrix = new double[7, 5]
             {
                { 1,2,3,4,5 },
                { 7,8,9,10,11 },
                { 13,14,15,16,17 },
                { 17,18,19,22,21 },
                { 18,19,20,21,22},
                { 1,2,3,4,5},
                { 3,4,5,6,7}
            };
            double[,] result = new double[7, 5];
            double[] arr = new double[7];
            double min = double.MaxValue;
            int tmp = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                arr[i] = min;
                min = double.MaxValue;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        tmp = j;
                    }
                }
                for (int j = 0; j < 5; j++)
                {
                    result[i, j] = matrix[tmp, j];
                }
                arr[tmp] = double.MaxValue;
                min = double.MaxValue;
            }
            Lab4Level1.cout(result);
        }
        public static void Ex2()
        {
            Console.WriteLine("Enter size of square: ");
            int size;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out size))
                {
                    Console.WriteLine("Incorrect value");
                    continue;
                }
                if (size < 0)
                {
                    Console.WriteLine("Must be positive");
                    continue;
                }
                break;
            }
            double[,] matrix = new double[size, size];
            double x;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine($"Enter {i} and {j} elem");
                    while (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    matrix[i, j] = x;
                    if (i == 0 || j == 0 || i == size - 1 || j == size - 1)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            Lab4Level1.cout(matrix);
        }
        public static void Ex3()
        {
            Console.WriteLine("Enter size of square: ");
            int size;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out size))
                {
                    Console.WriteLine("Incorrect value");
                    continue;
                }
                if (size < 0)
                {
                    Console.WriteLine("Must be positive");
                    continue;
                }
                break;
            }
            double[,] matrix = new double[size, size];
            double[] sum = new double[size * 2 - 1];
            double x;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine($"Enter {i} and {j} elem");
                    while (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    matrix[i, j] = x;
                }
            }
            double tmp = 0, tmp1 = 0, tmp2 = 0;
            int help;
            for (int i = size - 1; i >= 0; i--)
            {
                help = i;
                for (int j = 0; j < size - i && i > 0; j++)
                {
                    tmp += matrix[help, j];
                    tmp1 += matrix[j, help];
                    help++;
                }
                tmp2 += matrix[i, i];
                sum[size - 1 - i] = tmp;
                sum[size - 1 + i] = tmp1;
                tmp = 0;
                tmp1 = 0;
            }
            sum[size - 1] = tmp2;
            for (int i = 0; i < size * 2 - 1; i++)
            {
                Console.Write(sum[i] + "\t");
            }
        }
        public static void Ex4()
        {
            Console.WriteLine("Enter size of square: ");
            int size;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out size))
                {
                    Console.WriteLine("Incorrect value");
                    continue;
                }
                if (size < 0)
                {
                    Console.WriteLine("Must be positive");
                    continue;
                }
                break;
            }
            double[,] matrix = new double[size, size];
            double x;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine($"Enter {i} and {j} elem");
                    while (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    matrix[i, j] = x;
                    if (i >= j && i > (size / 2 - size % 2))
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            Lab4Level1.cout(matrix);
        }
        public static void Ex8()
        {
            double[,] matrix = new double[7, 5]
            {
                {-5,-6,-7,-8,-9 },
                {-5,6,-7,-8,-9},
                {-5,7,-8,-9,6},
                {-5,8,-7,9,6},
                {-6,6,5,3,5 },
                {1,2,3,4,5 },
                {-1,-2,-3,-4,5 },
            };
            double[,] result = new double[7, 5];
            int[] arr = new int[7];
            int count = 0;
            int tmp = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        count++;
                    }
                }
                arr[i] = count;
                count = 0;
            }
            int max = int.MinValue;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                        tmp = j;
                    }
                }
                for (int j = 0; j < 5; j++)
                {
                    result[i, j] = matrix[tmp, j];
                }
                arr[tmp] = int.MinValue;
                max = int.MinValue;
            }
            Lab4Level1.cout(result);
        }
        public static void Ex10()
        {
            int line, column;
            Console.WriteLine("Enter number of lines: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out line))
                {
                    Console.WriteLine("Incorrect value");
                    continue;
                }
                if (line < 0)
                {
                    Console.WriteLine("Must be positive");
                    continue;
                }
                break;
            }
            Console.WriteLine("Enter number of columns: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out column))
                {
                    Console.WriteLine("Incorrect value");
                    continue;
                }
                if (column < 0)
                {
                    Console.WriteLine("Must be positive");
                    continue;
                }
                break;
            }
            double[,] matrix = new double[line, column];
            double x;
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.WriteLine($"Enter {i} and {j} elem");
                    while (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    matrix[i, j] = x;
                }
            }
            for (int i = 0; i < line; i++)
            {
                int tmp = 0;
                if (i % 2 != 0)
                {
                    while (tmp < column)
                    {
                        if (tmp == 0 || matrix[i, tmp - 1] <= matrix[i, tmp])
                        {
                            tmp++;
                        }
                        else
                        {
                            double swap = matrix[i, tmp];
                            matrix[i, tmp] = matrix[i, tmp - 1];
                            matrix[i, tmp - 1] = swap;
                            tmp--;
                        }
                    }
                }
                else
                {
                    while (tmp < column)
                    {
                        if (tmp == 0 || matrix[i, tmp - 1] >= matrix[i, tmp])
                        {
                            tmp++;
                        }
                        else
                        {
                            double swap = matrix[i, tmp];
                            matrix[i, tmp] = matrix[i, tmp - 1];
                            matrix[i, tmp - 1] = swap;
                            tmp--;
                        }
                    }
                }
            }
            Lab4Level1.cout(matrix);
        }
        public static void Ex11()
        {
            int line, column;
            Console.WriteLine("Enter size of line: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out line))
                {
                    Console.WriteLine("Incorrect value");
                    continue;
                }
                if (line < 0)
                {
                    Console.WriteLine("Must be positive");
                    continue;
                }
                break;
            }
            Console.WriteLine("Enter size of column: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out column))
                {
                    Console.WriteLine("Incorrect value");
                    continue;
                }
                if (column < 0)
                {
                    Console.WriteLine("Must be positive");
                    continue;
                }
                break;
            }
            List<int> ints = new List<int>();
            bool flag = false;
            double[,] matrix = new double[line, column];
            double x;
            for (int i = 0; i < line; i++)
            {
                flag = false;
                for (int j = 0; j < column; j++)
                {
                    Console.WriteLine($"Enter {i} and {j} elem");
                    while (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Incorrect value");
                    }
                    matrix[i, j] = x;
                    if (matrix[i, j] == 0)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    ints.Add(i);
                }
            }
            double[,] ans = new double[ints.Count(), column];
            for (int i = 0; i < ints.Count(); i++)
            {
                for (int j = 0; j < column; j++)
                {
                    ans[i, j] = matrix[ints[i], j];
                }
            }
            Lab4Level1.cout(ans);
            
        }
    }

