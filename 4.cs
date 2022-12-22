using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lab4
{
    internal class Program
    {
        static void Lvl_1_3()
        {
            int[,] a = new int[4, 4] {  { 1, 1, 1, 1 },
                                        { 2, 2, 2, 2 },
                                        { 3, 3, 3, 3 },
                                        { 4, 4, 4, 4 } };
            int s = 0;
            for (int i = 0; i < 4; i++)
            {
                s += a[i, i];
            }
            Console.WriteLine(s);
        }
        static void Lvl_1_6()
        {
            int[,] a = new int[4, 7] {  { 2, 3, 1, 4, 5, 6, 7 },
                                        { 2, -3, 1, 4, -5, 6, 7 },
                                        { -2, 3, 1, 4, 5, 6, 7 },
                                        { 2, 3, 1, 4, 5, 6, -7 } };
            int[] b = new int[4];
            int min, y = 0;
            for (int i = 0; i < 4; i++)
            {
                min = 999;
                for (int j = 0; j < 7; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        y = j;
                    }
                }
                b[i] = y;
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(b[i]);
            }
        }

        static void Lvl_1_12()
        {

            int[,] a = new int[3, 4] { {1,2,3,4},
                                       {3,5,2,3},
                                       {4,3,9,4 }};
            int[,] b = new int[2, 3];
            int max = -999, maxi = 0, maxj = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        maxi = i;
                        maxj = j;
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != maxi & j != maxj)
                    {
                        b[i, j] = a[i, j];
                    }
                    else
                    {
                        if (i == maxi & j != maxj)
                        {
                            b[i, j] = a[i + 1, j];
                        }
                        if (i != maxi & j == maxj)
                        {
                            b[i, j] = a[i, j + 1];
                        }
                        if (i == maxi & j == maxj)
                        {
                            b[i, j] = a[i + 1, j + 1];
                        }
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Lvl_1_13()
        {
            int[,] a = new int[5, 5]
            {
                { 1,  2,  3,  4,  5 },
                { 6,  7,  8,  9,  10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 }
            };
            int s = 0, max = -999;
            for (int i = 0; i < 5; i++)
            {
                if (a[i, i] > max)
                {
                    max = a[i, i];
                    s = i;
                }
            }
            Console.WriteLine(s);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 3)
                    {
                        Console.Write(a[i, s] + " ");
                    }
                    if (j == s)
                    {
                        Console.Write(a[i, 3] + " ");
                    }
                    if (j != 3 & j != s)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Lvl_1_17()
        {
            int[,] a = new int[3, 3]
            {
                { 2, 3, 1 },
                { 5, 6, 4 },
                { 8, 9, 7 }
            };
            int min, minj;
            for (int i = 0; i < 3; i++)
            {
                min = 99;
                minj = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        minj = j;
                    }
                }
                Console.Write(a[i, minj] + " ");
                for (int k = 0; k < 3; k++)
                {
                    if (k != minj)
                    {
                        Console.Write(a[i, k] + " ");
                    }
                }
                Console.WriteLine();

            }


        }

        static void Lvl_1_29()
        {
            int[,] a = new int[3, 4]
            {
                {1,2,3,-4},
                {-2,-3,4,5},
                {-1,-2,-4,3}
            };
            int min = 99, minj = 0;
            for (int j = 0; j < 4; j++)
            {
                if (Math.Abs(a[1, j]) < min)
                {
                    min = Math.Abs(a[1, j]);
                    minj = j;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 4; j++)
                {
                    if (j != (minj + 1))
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
            }

        }

        static void Lvl_2_7()
        {
            int[,] a = new int[4, 4]
            {
                {1,2,3,4,},
                {1,2,3,4,},
                {1,2,8,4,},
                {1,2,3,4,}
            };
            int max = -999, maxi = 0;
            for (int i = 0; i < 4; i++)
            {
                if (a[i, i] > max)
                {
                    max = a[i, i];
                    maxi = i;
                }
            }
            bool flag = true;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == maxi)
                    {
                        flag = false;
                    }
                    if (j > i & flag)
                    {
                        Console.Write("0 ");
                    }
                    else
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Lvl_2_8()
        {
            int[,] a = new int[4, 4]
            {
                {1,9,3,4,},
                {1,2,3,4,},
                {1,2,8,4,},
                {1,5,3,4,}
            };
            int maxv = -999, maxn = -999, v = 0, n = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j] > maxv)
                    {
                        maxv = a[i, j];
                        v = j;
                    }
                }
            }
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j] > maxn)
                    {
                        maxn = a[i, j];
                        n = j;
                    }
                }
            }
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == v)
                    {
                        Console.Write(maxn + " ");
                    }
                    else
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == n)
                    {
                        Console.Write(maxv + " ");
                    }
                    else
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
            }
            maxv = -999; maxn = -999; v = 0; n = 0;
            Console.WriteLine();
            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j] > maxv)
                    {
                        maxv = a[i, j];
                        v = j;
                    }
                }
            }
            for (int i = 3; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j] > maxn)
                    {
                        maxn = a[i, j];
                        n = j;
                    }
                }
            }
            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == v)
                    {
                        Console.Write(maxn + " ");
                    }
                    else
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();
            for (int i = 3; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == n)
                    {
                        Console.Write(maxv + " ");
                    }
                    else
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
            }

        }

        static void Lvl_2_9()
        {
            int[,] a = new int[4, 4]
            {
                {1,9,3,4,},
                {1,2,3,4,},
                {1,2,8,4,},
                {1,5,3,4,}
            };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Lvl_3_2()
        {
            int[,] a = new int[4, 4]
            {
                {1,1,4,1},
                {2,2,1,2},
                {3,3,3,5},
                {4,4,4,4}
            };
            for (int i = 0; i < 4; i++)
            {
                Console.Write("0");
                for (int j = 1; j < 3; j++)
                {
                    if (i == 0 | i == 3)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write(a[i, j]);
                    }
                }
                Console.Write('0');
                Console.WriteLine();
            }
        }

        static void Lvl_3_3()
        {
            int x = 4;
            int[,] a = new int[4, 4]
            {
                {1,1,4,1},
                {2,2,1,2},
                {4,3,3,4},
                {4,4,4,4}
            };
            int[] b = new int[2 * x - 1];
            int bi = 0;
            for (int i = x - 1; i >= 0; i--)
            {
                int d = x - i;
                int sum = 0;
                for (int j = 0; j < d; j++)
                {
                    sum += a[i + j, j];
                }
                b[bi++] = sum;
            }
            for (int i = 1; i < x; i++)
            {

                int d = x - i;
                int sum = 0;
                for (int j = 0; j < d; j++)
                {
                    sum += a[j, i + j];
                }
                b[bi++] = sum;
            }
            foreach (int u in b)
            {
                Console.Write(u + " ");
            }
        }

        static void Lvl_3_4()
        {
            int x = 3;
            int[,] a = new int[3, 3]
            {
                {0,0,0},
                {2,2,2},
                {3,3,3}
            };
            if (x % 2 == 0)
            {
                int p = 0;
                for (int i = x - 1; i >= x / 2; i--)
                {

                    for (int j = 0; j < x - p; j++)
                    {
                        a[i, j] = 1;
                    }
                    p++;
                }
            }
            else
            {
                int p = 0;
                for (int i = x - 1; i >= x / 2; i--)
                {

                    for (int j = 0; j < x - p; j++)
                    {
                        a[i, j] = 1;
                    }
                    p++;
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Lvl_3_8()
        {
            int x = 7;
            int y = 5;
            int[,] a = new int[x, y];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    a[i, j] = r.Next(-6, 6);
                }
            }
            int[] b = new int[x];
            for (int i = 0; i < x; i++)
            {
                int k = 0;
                for (int j = 0; j < y; j++)
                {
                    if (a[i, j] > 0)
                    {
                        k++;
                    }
                }
                b[i] = k;
            }
            int f = 0;
            while (f < b.Length - 1)
            {
                if (b[f] < b[f + 1])
                {
                    int temp = b[f];
                    b[f] = b[f + 1];
                    b[f + 1] = temp;
                    for (int i = 0; i < y; i++)
                    {
                        int p = a[f, i];
                        a[f, i] = a[f + 1, i];
                        a[f + 1, i] = p;
                    }
                    if (f > 0)
                    {
                        f--;
                    }
                }
                else
                {
                    f++;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(a[i, j] + " ");

                }
                Console.WriteLine();
            }
        }

        static void Lvl_3_1()
        {
            int[,] a = new int[4, 3]
            {
                {2,1,0},
                {3,4,2},
                {5,4,5},
                {1,-3,2}
            };
            int c = 0, min = 999, str = 0;
            while (c < 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (a[i, j] < min)
                        {
                            min = a[i, j];
                            str = i;
                        }
                    }
                }
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(a[str, k] + " ");
                    a[str, k] = 9999;
                }
                c += 1;
                min = 999;
                Console.WriteLine();
            }
        }

        static void Lvl_3_10()
        {
            int[,] a = new int[3, 3]
            {
                {1,2,3},
                {3,2,1},
                {4,4,3}
            };
            int temp = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (i % 2 != 0)
                    {
                        for (int e = 0; e < 3 - 1; e++)
                        {
                            if (a[i, e] > a[i, e + 1])
                            {
                                temp = a[i, e + 1];
                                a[i, e + 1] = a[i, e];
                                a[i, e] = temp;
                            }
                        }
                    }
                    else
                    {
                        for (int e = 0; e < 3 - 1; e++)
                        {
                            if (a[i, e] < a[i, e + 1])
                            {
                                temp = a[i, e + 1];
                                a[i, e + 1] = a[i, e];
                                a[i, e] = temp;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Lvl_3_11()
        {
            int[,] a = new int[4, 3] 
            {
                {2,1,0},
                {3,4,2},
                {5,0,5},
                {1,-3,2}
            };
            bool flag = true;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (a[i,j] == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                flag = true;
            }
        }





        static void Main(string[] args)
        {
            //Lvl_1_3();

            //Lvl_1_6();

            //Lvl_1_12();

            //Lvl_1_13();

            //Lvl_1_17();

            //Lvl_1_29();

            //Lvl_2_8();

            //Lvl_2_9;

            //Lvl_3_2();

            //lvl_3_3();

            //Lvl_3_4();

            //Lvl_3_8();

            //Lvl_3_1();

            //Lvl_3_10();

            Lvl_3_11();

            // 1 10 11
        }
    }
}
