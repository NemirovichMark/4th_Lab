using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    { 
        static void Printing_Int(int[] Nums) { for (int i = 0; i < Nums.Length; i++) Console.Write($"{Nums[i]} "); Console.WriteLine(); }
        static void Printing_Double(double[] Nums) { for(int i = 0; i < Nums.Length; i++) Console.Write($"{Nums[i]} "); Console.WriteLine(); }
        static void Printing_Matrix(double[,] Nums)
        {
            for(int i =0; i <Nums.GetLength(0); i++)
            {
                for(int x = 0; x<Nums.GetLength(1); x++)
                {
                    Console.Write($"{Nums[i, x]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Printing_Matrix_Diff_Way(double[,] Nums)
        {
            for (int i = 0; i < Nums.GetLength(0); i++)
            {
                for (int x = 0; x < Nums.GetLength(1); x++)
                {
                    Console.Write($"{Nums[i, x]}  ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Task_3_Level_1() {
            double[,]  Nums = { {3, 4, 1, 2}, { 7, 9, 7, 1}, {-7.19, 20, -3, 9 }, {-30, 7.2, 1, 8 } };
            double sum = 0;
            for(int i = 0; i<4; i++)
            {
                sum += Nums[i, i];
            }
            Console.WriteLine(sum);
        }
        static void Task_6_Level_1() {
            double[,] Nums = 
            { 
                { 3, 4, 1, 2, 7, 9, 7 }, 
                { 7, 9, 7, 1, 7, 9, 7 }, 
                { -7.19, 20, -3, 9, 7, 9, 7 }, 
                { -30, 7.2, 1, 8, 7, 9, 7 } 
            };
            int[] Indexes = new int[4];
            for(int i = 0; i < 4; i++)
            {
                double Maxi = Nums[i, 0];
                int Max_Ind = 0;
                for(int x = 0; x < 7; x++)
                {
                    if(Nums[i, x] > Maxi) { Maxi = Nums[i, x]; Max_Ind = x; }
                }
                Indexes[i] = Max_Ind;
            }
            Printing_Int(Indexes);
        }
        static void Task_12_Level_1() {
            double[,] Nums =
            {
                { 1, 2, -3, 7, 7, 2, 8},
                { 14, 123.3, 9, -1, 3, 5, 6},
                { -1142, 3, 5, 2, 5, 7, 1 },
                { - 3, 914, 20, 1, 1412, 5, 8},
                { - 1, 5, 5, 23, 6, 234, 4},
                { 14, 5, 525, 643, 6, 23, 1 },
            };
            double[,] Final_Nums = new double[5, 6];
            double Maxi = Nums[0, 0];
            int[] Maxi_Indexes = new int[2];
            for(int i = 0; i < Nums.GetLength(0); i++)
            {
                for(int x = 0; x < Nums.GetLength(1); x++)
                {
                    if (Nums[i, x] > Maxi) { Maxi = Nums[i, x]; Maxi_Indexes[0] = i; Maxi_Indexes[1] = x; }
                }
            }
            for (int i = 0; i < Nums.GetLength(0); i++)
            {
                if (i == Maxi_Indexes[0]) continue;
                for (int x = 0; x < Nums.GetLength(1); x++)
                {
                    if (x == Maxi_Indexes[1]) continue;

                    else if ((Maxi_Indexes[0] > i) && (Maxi_Indexes[1] > x)) Final_Nums[i, x] = Nums[i, x];
                    else if ((Maxi_Indexes[0] > i) && (Maxi_Indexes[1] < x)) Final_Nums[i, x - 1] = Nums[i, x];
                    else if ((Maxi_Indexes[0] < i) && (Maxi_Indexes[1] > x)) Final_Nums[i-1, x] = Nums[i, x];
                    else if ((Maxi_Indexes[0] < i) && (Maxi_Indexes[1] < x)) Final_Nums[i-1, x - 1] = Nums[i, x];
                }
            }
            Printing_Matrix(Final_Nums);
        }
        static void Task_13_Level_1() {
            double[,] Nums =
            {
                { 1, 2, -3, 7, 7},
                { 14, 123.3, 9, -1, 3},
                { -1142, 3, 5, 2, 5},
                { - 3, 914, 20, 1, 1412},
                { - 1, 5, 5, 23, 6},
            };
            double Maxi = Nums[0, 0];
            int Maxi_Index = 0;
            for (int i = 1; i < Nums.GetLength(0); i++) if(Nums[i, i] > Maxi) { Maxi = Nums[i, i]; Maxi_Index = i; }
            for (int i = 0; i < Nums.GetLength(1); i++) (Nums[i, 3], Nums[i, Maxi_Index]) = (Nums[i, Maxi_Index], Nums[i, 3]);
            Printing_Matrix(Nums);
        }
        static void Task_17_Level_1() {
            double[,] Nums =
            {
                { 1, 2, -3, 7, 7, 2, 8},
                { 14, 123.3, 9, -1, 3, 5, 6},
                { -1142, 3, 5, 2, 5, 7, 1 },
                { - 3, 914, 20, 1, 1412, 5, 8},
                { - 1, 5, 5, 23, 6, 234, 4},
                { 14, 5, 525, 643, 6, 23, 1 },
            };
            double Mini = Nums[0, 0];
            int[] Mini_Indexes = { 0, 0};
            int Point = 0;
            for (int i = 0; i < Nums.GetLength(0); i++)
            {
                for (int x = 0; x < Nums.GetLength(1); x++)
                {
                    if (Nums[i, x] < Mini) { Mini = Nums[i, x]; Mini_Indexes[0] = i; Mini_Indexes[1] = x; }
                }
            }
            (Nums[Mini_Indexes[0], 0], Nums[Mini_Indexes[0], Mini_Indexes[1]]) = (Nums[Mini_Indexes[0], Mini_Indexes[1]], Nums[Mini_Indexes[0], 0]);
            Printing_Matrix(Nums);
        }
        static void Task_29_Level_1() {
            double[,] Nums =
            {
                { 3, 4, 1, 2, 7, 9, 7 },
                { 7, 9, 7, 1, 7, 9, 7 },
                { -7.19, 20, -3, 9, 7, 9, 7 },
                { -30, 7.2, 1, 8, 7, 9, 7 },
                { 7, 9, 7, 1, 7, 9, 7 },
            };
            double[,] Final_Nums = new double[5, 6];
            double Mini = Nums[1, 0];
            int Mini_Index = 0;
            for (int i = 1; i < Nums.GetLength(0); i++) if(Nums[1, i] < Mini) { Mini = Nums[1, i]; Mini_Index = i; }
            for (int i = 0; i < Nums.GetLength(0); i++)
            {
                for(int x = 0; x < Nums.GetLength(1); x++)
                {
                    if (Mini_Index == 6) { if (i == 6) break; Final_Nums[i, x] = Nums[i, x]; }
                    else
                    {
                        if (Mini_Index == x) continue;
                        else if (Mini_Index > x) Final_Nums[i, x] = Nums[i, x];
                        else Final_Nums[i, x - 1] = Nums[i, x];
                    }
                }
            }

            Printing_Matrix(Final_Nums);
        }
        static void Task_31_Level_1()
        {
            double[,] Nums =
            {
                { 3, 4, 1, 2, 7, 9, 7, 0},
                { 7, 9, 7, 1, 7, 9, 7, 0},
                { -7.19, 20, -3, 9, 7, 9, 7, 0},
                { -30, 7.2, 1, 8, 7, 9, 7, 0},
                { 7, 9, 7, 1, 7, 9, 7, 0},
            };
            double[] B = { 1, 2, 3, 4, 5 };
            double Mini = Nums[1, 0];
            int Mini_Index = 0;
            for (int i = 1; i < Nums.GetLength(0); i++) if (Nums[4, i] < Mini) { Mini = Nums[4, i]; Mini_Index = i; }
            for (int i = 0; i < Nums.GetLength(0); i++) for (int x = Nums.GetLength(1)-1; x > Mini_Index; x--) Nums[i, x] = Nums[i, x - 1];
            for (int i = 0; i < Nums.GetLength(0); i++) Nums[i, Mini_Index] = B[i];
            Printing_Matrix(Nums);
        }
        static void Task_7_Level_2() {
            double[,] Nums =
            {
                { 1, 2, -3, 7, 7, 2},
                { 14, 120, 9, -1, 3, 5},
                { -1142, 3, 5, 2, 5, 7},
                { - 3, 914, 20, 1, 1412, 5},
                { - 1, 5, 5, 23, 6, 234},
                { 14, 5, 525, 643, 6, 23},
            };
            double Maxi = 0;
            int Maxi_Index = 0;
            for(int i= 0; i < Nums.GetLength(0); i++) if(Nums[i, i] > Maxi) { Maxi = Nums[i, i]; Maxi_Index = i; }
            Console.WriteLine(Maxi_Index);
            for (int i = 0; i < Maxi_Index; i++)
            {
                for( int x = Nums.GetLength(0)-1; x > Maxi_Index; x--)
                {
                    Nums[i, x] = 0;
                }
            }
            Printing_Matrix(Nums);
        }
        static void Task_8_Level_2() {
            double[,] Nums =
            {
                { 1, 2, -3, 7, 7, 2, 1},
                { 14, 120, 9, -1, 3, 5, 1},
                { -1142, 3, 5, 2, 5, 7, 3},
                { - 3, 914, 20, 1, 1412, 5, 5},
                { - 1, 5, 5, 23, 6, 234, 7},
                { 14, 5, 525, 643, 6, 23, 2},
            };
            for(int i = 0; i<Nums.GetLength(0); i++)
            {
                for(int x = 0; x < Nums.GetLength(1)/2; x++)
                {
                    (Nums[i, x], Nums[i, Nums.GetLength(1) - 1 - x]) = (Nums[i, Nums.GetLength(1) - 1 - x], Nums[i, x]);
                }
            }
            Printing_Matrix(Nums);
        }
        static void Task_9_Level_2() {
            double[,] Nums =
            {
                { 1, 2, -3, 7, 7, 2, 1},
                { 14, 120, 9, -1, 3, 5, 1},
                { -1142, 3, 5, 2, 5, 7, 3},
                { - 3, 914, 20, 1, 1412, 5, 5},
                { - 1, 5, 5, 23, 6, 234, 7},
                { 14, 5, 525, 643, 6, 23, 2},
            };
            
            for(int i = 0; i < Nums.GetLength(0); i++)
            {
                for(int x = 0; x < Nums.GetLength(1)/2; x++)
                {
                    (Nums[i, x], Nums[i, Nums.GetLength(1)-1-x]) = (Nums[i, Nums.GetLength(1) - 1 - x], Nums[i, x]);
                }
            }
            Printing_Matrix(Nums);
        }
        //In the tasks for level 3, it was written in the output to represent a two-dimensional array in two versions. So I prescribed 2 different methods
        static void Task_1_Level_3() 
        {
            double[,] Nums =
            {
                { 1, 2, -3, 7, 4},
                { 14, 120, 9, -1, -1000},
                { -1142, 3, 5, 2, 14},
                { 200, 914, 20, 1, 5},
                {1, 5, 5, 23, 6},
                { 100, 5, 5, 23, 6},
                { 18, 13, 14, 23, 6},
        };

            int[] Indexes = new int[7];

            for(int i = 0; i < Nums.GetLength(0); i++)
            {
                for (int x = 1; x < Nums.GetLength(1); x++)
                {
                    if (Nums[i, Indexes[i]] > Nums[i, x]) Indexes[i] = x;
                }
                for(int x = i; x > 0; x--)
                {
                    if (Nums[x, Indexes[x]] < Nums[x - 1, Indexes[x - 1]]) 
                    {
                        (Indexes[x], Indexes[x - 1]) = (Indexes[x - 1], Indexes[x]);
                        for (int j = 0; j < Nums.GetLength(1); j++) (Nums[x, j], Nums[x - 1, j]) = (Nums[x - 1, j], Nums[x, j]); 
                    }
                    else break;
                }
            }

            Printing_Matrix(Nums);
            Printing_Matrix_Diff_Way(Nums);
        }
        static void Task_2_Level_3()
        {
            double[,] Nums =
            {
                {1, 1, 1, 1},
                {1, 1, 1, 1},
                {1, 1, 1, 1},
                {1, 1, 1, 1}
            };
            int Len = Nums.GetLength(0);
            for(int i = 0; i<Len; i++)
            {
                Nums[i, 0] = 0;
                Nums[0, i] = 0;
                Nums[Len - i - 1, Len-1] = 0;
                Nums[Len-1, Len - i-1] = 0;
            }
            Printing_Matrix(Nums);
            Printing_Matrix_Diff_Way(Nums);
        }
        static void Task_3_Level_3() 
        {
            double[,] Nums =
            {
                {1, 123, 1423, 134},
                {1, 51, 112, 1352},
                {11, 12124, 2351, 1},
                {1, 55231, 431, 114}
            };

            double[] Vector = new double[Nums.GetLength(0) + Nums.GetLength(1) - 1];
            int Vector_Pos = 0;
            for(int i = Nums.GetLength(0)-1; i > 0; i--)
            {
                int y = 0;
                for(int x = i; x < Nums.GetLength(1); x++)
                {
                    Vector[Vector_Pos] += Nums[x, y];
                    y += 1;
                }
                Vector_Pos ++;
            }

            for (int x = 0; x < Nums.GetLength(0); x++) Vector[Vector_Pos] += Nums[x, x];
            Vector_Pos++;

            for (int i = 1; i < Nums.GetLength(0); i++)
            {
                int y = 0;
                for (int x = i; x < Nums.GetLength(1); x++)
                {
                    Vector[Vector_Pos] += Nums[y, x];
                    y += 1;
                }
                Vector_Pos ++;
            }
            Printing_Double(Vector);
        }
        static void Task_4_Level_3() 
        {
            double[,] Nums =
            {
                {1, 123, 1423, 134, 1, 123, 1423, 134},
                {1, 51, 112, 1352, 1, 123, 1423, 134},
                {11, 12124, 2351, 1, 1, 123, 1423, 134},
                {1, 55231, 431, 114, 1, 123, 1423, 134},
                {1, 55231, 431, 114, 1, 123, 1423, 134},
                {1, 55231, 431, 114, 1, 123, 1423, 134},
                {1, 55231, 431, 114, 1, 123, 1423, 134},
                {1, 55231, 431, 114, 1, 123, 1423, 134}
            };
            for(int i = Nums.GetLength(0)/2; i < Nums.GetLength(0); i++)
            {
                for(int x = 0; x <= i; x++)
                {
                    Nums[i, x] = 0;
                }
            }
            Printing_Matrix(Nums);
            Printing_Matrix_Diff_Way(Nums);
        }
        static void Task_8_Level_3() 
        {
            double[,] Nums =
            {
                { 1, -2, -3, -7, -7, 2, -1},
                { 14, 120, 9, -1, -3, 5, 1},
                { -1142, 3, 5, -2, -5, 7, 3},
                { - 3, 914, 20, 1, 1412, 5, 5},
                { - 1, 5, -5, 23,6, 234, 7},
                { 14, 5, 525, 643, 6, 23, 2},
            };

            int[] Points = new int[7];

            for (int i = 0; i < Nums.GetLength(0); i++)
            {
                for (int x = 0; x < Nums.GetLength(1); x++)
                {
                    if (Nums[i, x] >= 0) Points[i]++;
                }
                for (int x = i; x > 0; x--)
                {
                    if (Points[x] > Points[x-1])
                    {
                        (Points[x], Points[x - 1]) = (Points[x - 1], Points[x]);
                        for (int j = 0; j < Nums.GetLength(1); j++) (Nums[x, j], Nums[x - 1, j]) = (Nums[x - 1, j], Nums[x, j]);
                    }
                    else break;
                }
            }
            Printing_Matrix(Nums);
            Printing_Matrix_Diff_Way(Nums);
        }
        static void Task_10_Level_3() 
        {
            double[,] Nums =
            {
                {1, 123, 1423, 134},
                {1, 51, 112, 1352},
                {11, 12124, 2351, 1},
                {55231, 431, 114, 1}
            };

            for(int i = 0; i < Nums.GetLength(0); i++)
            {
                for (int x = 0; x < Nums.GetLength(1); x++)
                {
                    for(int j = x+1; j < Nums.GetLength(1); j++)
                    {
                        if(i%2 == 0)
                        {
                            if (Nums[i, x] > Nums[i, j]) (Nums[i, x], Nums[i, j]) = (Nums[i, j], Nums[i, x]);
                        }
                        else
                        {
                            if (Nums[i, x] < Nums[i, j]) (Nums[i, x], Nums[i, j]) = (Nums[i, j], Nums[i, x]);
                        }
                    }
                }
            }
            Printing_Matrix(Nums);
            Printing_Matrix_Diff_Way(Nums);
        }
        static void Task_11_Level_3()
        {
            double[,] Nums =
            {
                { 1, -2, -3, -7, -7, 2, -1},
                { 0, 120, 9, -1, -3, 5, 4},
                { -1142, 3, 5, -2, -5, 7, 3},
                { - 3, 914, 20, 0, 1412, 5, 5},
                { - 1, 5, 0, 23,6, 234, 7},
                { 14, 5, 525, 643, 6, 23, 2},
            };
            List<int> Points = new List<int>();
            for (int i = 0; i < Nums.GetLength(0); i++)
            {
                for (int x = 0; x < Nums.GetLength(1); x++) if (Nums[i, x] == 0) { Points.Add(x); break; }
            }
            double[,] Final_Nums = new double[Nums.GetLength(0) - Points.Count, Nums.GetLength(1)];
            int revision = 0;
            for(int i = 0; i < Nums.GetLength(0); i++)
            {
                if (Points.Contains(i)) { revision++; continue; }
                else
                {
                    for (int x = 0; x < Nums.GetLength(1); x++) Final_Nums[i - revision, x] = Nums[i, x];
                }
            }
            Printing_Matrix(Nums);
            Printing_Matrix_Diff_Way(Nums);
        }


        static void Main(string[] args)
        {
            Task_3_Level_1();
            Task_6_Level_1();
            Task_12_Level_1();
            Task_13_Level_1();
            Task_17_Level_1();
            Task_29_Level_1();
            Task_31_Level_1();
            Task_7_Level_2();
            Task_8_Level_2();
            Task_9_Level_2();
            Task_1_Level_3();
            Task_2_Level_3();
            Task_3_Level_3();
            Task_4_Level_3();
            Task_8_Level_3();
            Task_10_Level_3();
            Task_11_Level_3();
        }
    }
}
