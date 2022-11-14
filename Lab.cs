using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Threading.Tasks;

namespace Project
{
    class Lab
    {
        static void Main(string[] args)
        {
            static void MatAns(string tasknumber, int[,] list)
            {
                Console.WriteLine($"Task {tasknumber} Answer:");
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = 0; j < list.GetLength(1); j++)
                    {
                        Console.Write($"{list[i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            static void MatPrint(string tasknumber, int[,] list)
            {
                Console.WriteLine($"Task {tasknumber}");
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = 0; j < list.GetLength(1); j++)
                    {
                        Console.Write($"{list[i, j]} ");
                    }
                    Console.WriteLine();
                }

            }

            static void VecPrint(int[] vector)
            {
                Console.WriteLine($"Vector:\n{string.Join(" ", vector)}");
            }

            static void VecAns(string tasknumber, int[] vector)
            {
                Console.WriteLine($"Task {tasknumber}\nAnswer (vector):\n{string.Join(" ", vector)}\n");
            }

            // Level 1

            static void Task_1_3()
            {
                int sum = 0;
                int[,] list = new int[4, 4] {{1,2,3,4},
                                             {5,6,7,8},
                                             {1,3,5,1},
                                             {2,8,3,4}};

                MatPrint("1.3", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    sum += list[i, i];
                    sum += list[i, list.GetLength(0) - i - 1];
                }
                Console.WriteLine($"Task 1.3 Answer:\n{sum}\n");
            }
            Task_1_3();

            static void Task_1_6()
            {
                int[,] list = new int[4, 7] {{1,2,3,4,5,6,7 },
                                             {15,8,7,10,11,12,13},
                                             {14,15,16,1,2,3,4},
                                             {-1,4,3,6,2,8,-3}};
                int[] ans = new int[list.GetLength(0)];
                int minInd = 0, minEl = 0;

                MatPrint("1.6", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    minEl = System.Int32.MaxValue;
                    for (int j = 0; j < list.GetLength(1); j++)
                    {
                        if (list[i, j] < minEl)
                        {
                            minEl = list[i, j];
                            minInd = j;
                        }
                    }
                    ans[i] = minInd;
                }

                VecAns("1.6", ans);
            }
            Task_1_6();

            static void Task_1_12()
            {
                int maxEl = System.Int32.MinValue, indi = 0, indj = 0;
                int[,] list = new int[6, 7] {{1,2,3,4,5,6,7 },
                                            {7,8,9,10,11,12,13},
                                            {14,15,16,1,2,3,4},
                                            {-1,4,3,6,2,8,-3},
                                            {14,-15,-16,1,-2,3,4},
                                            {-1,4,3,-6,2,8,-3}};

                MatPrint("1.12", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = 0; j < list.GetLength(1); j++)
                    {
                        if (list[i, j] > maxEl)
                        {
                            maxEl = list[i, j];
                            indi = i;
                            indj = j;
                        }
                    }
                }
                int[,] ans = new int[5, 6];
                int n = 0, m = 0;
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    if (i != indi)
                    {
                        m = 0;
                        for (int j = 0; j < list.GetLength(1); j++)
                        {
                            if (j != indj)
                            {
                                ans[n, m] = list[i, j];
                                m++;
                            }
                        }
                        n++;
                    }
                }
                MatAns("1.12", ans);
            }
            Task_1_12();

            static void Task_1_13()
            {
                int maxEl = System.Int32.MinValue, maxInd = 0, p = 0;
                int[,] list = new int[5, 5] {{1, 2, 3, 4, -1},
                                            {7, 19, -9, 10, 11},
                                            {14, 16, 15, 1, 2},
                                            {14, -15, -16, 1, -2},
                                            {-1, 4, 3, -6, 2}};

                MatPrint("1.13", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    if (maxEl < list[i, i])
                    {
                        maxEl = list[i, i];
                        maxInd = i;
                    }
                }
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    p = list[i, maxInd];
                    list[i, maxInd] = list[i, 3];
                    list[i, 3] = p;
                }
                MatAns("1.13", list);
            }
            Task_1_13();

            static void Task_1_17()
            {
                int minEl, ind = 0;
                int[,] list = new int[5, 6] {{1, 2, 3, 4, -1, 5},
                                            {7, 19, -9, 10, 11, 8},
                                            {14, 16, 15, 1, 2, 2},
                                            {14, -15, -16, 1, -2, 7},
                                            {-1, 4, 3, -6, 2, 1}};
                int[] listEl = new int[list.GetLength(1)];
                int[] listInd = new int[list.GetLength(1)];

                MatPrint("1.17", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    minEl = System.Int32.MaxValue;
                    for (int j = 0; j < list.GetLength(1); j++)
                    {
                        if (minEl > list[i, j])
                        {
                            minEl = list[i, j];
                            ind = j;
                        }
                    }
                    listEl[i] = minEl;
                    listInd[i] = ind;
                }
                int k = 0;
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = listInd[k]; j > 0; j--)
                    {
                        list[i, j] = list[i, j - 1];
                    }
                    k++;
                }
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    list[i, 0] = listEl[i];
                }
                MatAns("1.17", list);
            }
            Task_1_17();

            static void Task_1_29()
            {
                int[,] list = new int[5, 7] {{1,2,3,4,5,6,7 },
                                      {7,8,-9,2,-11,4,12},
                                      {14,15,16,1,2,3,4},
                                      {-1,5,3,16,2,8,-3},
                                      {14,-15,-16,1,-2,3,4}};
                int minEl = System.Int32.MaxValue, minInd = 0;

                MatPrint("1.29", list);

                for (int i = 0; i < list.GetLength(1); i++)
                {
                    if (Math.Abs(list[1, i]) < minEl)
                    {
                        minEl = Math.Abs(list[1, i]);
                        minInd = i;
                    }
                }
                Console.WriteLine($"{minInd} {list.GetLength(1)} {minEl}");
                if (minInd + 1 == list.GetLength(1))
                {
                    MatAns("1.29", list);
                    return;
                }
                int[,] ans = new int[5, 6];
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = 0; j <= minInd; j++)
                    {
                        ans[i, j] = list[i, j];
                    }
                }
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = minInd + 1; j < list.GetLength(1) - 1; j++)
                    {
                        ans[i, j] = list[i, j + 1];
                    }
                }
                MatAns("1.29", ans);
            }
            Task_1_29();

            static void Task_1_31()
            {
                int minEl = System.Int32.MaxValue, minInd = 0;
                int[,] list = new int[5, 8] {{1,2,3,4,5,6,7,0 },
                                      {7,8,-9,12,-11,4,12,0},
                                      {14,15,16,1,2,3,4,0},
                                      {-1,4,3,6,2,-5,-3,0},
                                      {14,-15,-16,1,-2,3,4,0}};
                int[] vec = new int[5] { 1, 2, 3, 4, 5 };

                MatPrint("1.31", list);

                for (int i = 0; i < list.GetLength(1); i++)
                {
                    if (list[4, i] < minEl)
                    {
                        minEl = list[4, i];
                        minInd = i;
                    }
                }
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = list.GetLength(1) - 1; j > minInd; j--)
                    {
                        list[i, j] = list[i, j - 1];
                    }
                }
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    list[i, minInd + 1] = vec[i];
                }
                MatAns("1.31", list);
            }
            Task_1_31();

            // Level 2

            static void Task_2_7()
            {
                int maxEl = System.Int32.MinValue, maxInd = 0;
                int[,] list = new int[6, 6] {{1,2,3,4,5,6 },
                                      {7,19,9,10,11,12},
                                      {14,16,15,1,2,3},
                                      {14,-15,-16,1,-2,-5},
                                      {-1,4,3,-6,200,14},
                                      {1,2,3,4,5,6 } };

                MatPrint("2.7", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    if (maxEl < list[i, i])
                    {
                        maxEl = list[i, i];
                        maxInd = i;
                    }   
                }

                for (int i = maxInd - 1; i >= 0; i--)
                {
                    for (int j = list.GetLength(0) - 1; j > i; j--)
                    {
                        list[i, j] = 0;
                    }
                }
                MatAns("2.7", list);
            }
            Task_2_7();

            static void Task_2_8()
            {
                int maxEl, maxInd = 0;
                int[,] list = new int[6, 6] {{1,2,3,4,5,6 },
                                      {7,19,9,10,11,12},
                                      {14,16,15,1,2,3},
                                      {14,-15,-16,1,-2,-5},
                                      {-1,4,3,-6,20,14},
                                      {1,2,3,4,5,6 } };
                int[] vec = new int[list.GetLength(0)];

                MatPrint("2.8", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    maxEl = System.Int32.MinValue;
                    for (int j = 0; j < list.GetLength(1); j++)
                    {
                        if (list[i, j] > maxEl)
                        {
                            maxEl = list[i, j];
                            maxInd = j;
                        }
                    }
                    vec[i] = maxInd;
                }
                int buf, ind = 0;
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    buf = list[i, vec[ind]];
                    list[i, vec[ind]] = list[i + 1, vec[ind + 1]];
                    list[i + 1, vec[ind + 1]] = buf;
                    i++;
                    ind += 2;   
                }
                MatAns("2.8", list);
            }
            Task_2_8();

            static void Task_2_9()
            {
                int buf;
                int[,] list = new int[6, 7] {{1,2,3,4,5,6,7},
                                      {7,19,9,10,11,12,13},
                                      {14,16,15,1,2,3,4},
                                      {14,-15,-16,1,-2,-5,6},
                                      {-1,4,3,-6,20,14,15},
                                      {1,2,3,4,5,6 ,16} };

                MatPrint("2.9", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = 0; j < list.GetLength(1) / 2; j++)
                    {
                        buf = list[i, j];
                        list[i, j] = list[i, list.GetLength(1) - j - 1];
                        list[i, list.GetLength(1) - 1 - j] = buf;
                    }
                }

                MatAns("2.9", list);
            }
            Task_2_9();

            // Level 3

            static void Task_3_1()
            {
                int buf;
                int[,] list = new int[7, 5] {{1,2,3,4,5},
                                      {7,19,9,10,11},
                                      {-14,16,15,1,2},
                                      {14,-15,-16,1,-2},
                                      {-1,4,3,-6,20},
                                      {1,2,3,-4,5},
                                      {2,6,4,1,-3} };
                int[,] matBuf = new int[list.GetLength(0), 2];
                int[,] matAns = new int[list.GetLength(0), list.GetLength(1)];

                MatPrint("3.1", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    buf = System.Int32.MaxValue;
                    for (int j = 0; j < list.GetLength(1); j++)
                    {
                        if (buf > list[i, j]) buf = list[i, j];
                    }
                    matBuf[i, 0] = buf;
                    matBuf[i, 1] = i;
                }
                for (int i = 0; i < matBuf.GetLength(0); i++)
                {
                    buf = System.Int32.MaxValue;
                    for (int j = i; j < matBuf.GetLength(0); j++)
                    {
                        if (matBuf[i, 0] < matBuf[j, 0])
                        {
                            buf = matBuf[i, 0];
                            matBuf[i, 0] = matBuf[j, 0];
                            matBuf[j, 0] = buf;
                            buf = matBuf[i, 1];
                            matBuf[i, 1] = matBuf[j, 1];
                            matBuf[j, 1] = buf;
                        }
                    }
                }
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = 0; j < list.GetLength(1); j++)
                    {
                        matAns[i, j] = list[matBuf[i, 1], j];
                    }
                }

                MatAns("3.1", matAns);
            }
            Task_3_1();

            static void Task_3_2()
            {
                int[,] list = new int[4, 4] {{1,2,3,4},
                                      {5,6,7,8},
                                      {4,3,5,1},
                                      {2,1,3,4}};

                MatPrint("3.2", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = 0; j < list.GetLength(0); j++)
                    {
                        if (i == 0 || i == list.GetLength(0) - 1)
                        {
                            list[i, j] = 0;
                        }
                        list[i, 0] = 0;
                        list[i, list.GetLength(1) - 1] = 0;
                    }
                }

                MatAns("3.2", list);
            }
            Task_3_2();

            static void Task_3_3()
            {
                int sumDiag, k = 0;
                int[,] list = new int[4, 4] {{1,2,3,4},
                                      {5,6,7,8},
                                      {4,3,5,1},
                                      {2,1,3,4}};
                int[] vec = new int[2 * list.GetLength(0) - 1];

                MatPrint("3.3", list);
                
                for (int j = list.GetLength(0) - 1;  j >= 0; j--)
                {
                    sumDiag = 0;
                    for (int i = 0; i + j != list.GetLength(0); i++)
                    {
                        sumDiag += list[i, j + i];
                    }
                    vec[k] = sumDiag;
                    k++;
                }

                k = vec.Length - 1;

                for (int j = list.GetLength(0) - 1; j > 0; j--)
                {
                    sumDiag = 0;
                    for (int i = 0; i + j != list.GetLength(0); i++)
                    {
                        sumDiag += list[i + j, i];
                    }
                    vec[k] = sumDiag;
                    k--;
                }

                VecAns("3.3", vec);
            }
            Task_3_3();

            static void Task_3_4()
            {
                int[,] list = new int[5, 5] {{1,2,3,4,5},
                                          {7,19,9,10,11},
                                          {14,16,15,6,2},
                                          {14,-15,-16,3,-2},
                                          {-1,4,3,-6,20}};
                //int[,] list = new int[6, 6] {{6,2,3,4,5,6 },
                //                      {7,19,9,10,11,12},
                //                      {14,16,15,6,2,3},
                //                      {14,-15,-16,3,-2,-5},
                //                      {-1,4,3,-6,20,14},
                //                      {9,2,3,4,5,6 } };

                MatPrint("3.4", list);

                for (int i = list.GetLength(0) - 1; i >= list.GetLength(0) / 2; i--)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        list[i, j] = 1;
                    }
                }

                MatAns("3.4", list);
            }
            Task_3_4();

            static void Task_3_8()
            {
                int buf;
                int[,] list = new int[7, 5] {{1,2,3,4,5},
                                      {7,19,-9,-10,11},
                                      {-14,16,-15,1,-2},
                                      {-14,-15,-16,-1,-2},
                                      {-1,4,-3,-6,-20},
                                      {1,2,3,-4,5},
                                      {2,6,-4,-1,-3} };
                int[,] matBuf = new int[list.GetLength(0), 2];
                int[,] matAns = new int[list.GetLength(0), list.GetLength(1)];

                MatPrint("3.8", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    buf = 0;
                    for (int j = 0; j < list.GetLength(1); j++)
                    {
                        if (list[i, j] > 0) buf += 1;
                    }
                    matBuf[i, 0] = buf;
                    matBuf[i, 1] = i;
                }
                for (int i = 0; i < matBuf.GetLength(0); i++)
                {
                    buf = System.Int32.MaxValue;
                    for (int j = i; j < matBuf.GetLength(0); j++)
                    {
                        if (matBuf[i, 0] < matBuf[j, 0])
                        {
                            buf = matBuf[i, 0];
                            matBuf[i, 0] = matBuf[j, 0];
                            matBuf[j, 0] = buf;
                            buf = matBuf[i, 1];
                            matBuf[i, 1] = matBuf[j, 1];
                            matBuf[j, 1] = buf;
                        }
                    }
                }
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = 0; j < list.GetLength(1); j++)
                    {
                        matAns[i, j] = list[matBuf[i, 1], j];
                    }
                }

                MatAns("3.8", matAns);
            }
            Task_3_8();

            static void Task_3_10()
            {
                int buf;
                int[,] list = new int[7, 5] {{1,2,3,4,5},
                                      {7,19,-9,-10,11},
                                      {-14,16,-15,1,-2},
                                      {-14,-15,-16,-1,-2},
                                      {-1,4,-3,-6,-20},
                                      {1,2,3,-4,5},
                                      {2,6,-4,-1,-3} };

                MatPrint("3.10", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = 0; j < list.GetLength(1); j += 2)
                    {
                        for (int k = j; k < list.GetLength(1); k += 2)
                        {
                            if (j % 2 == 0 && list[i, j] < list[i, k])
                            {
                                buf = list[i, j];
                                list[i, j] = list[i, k];
                                list[i, k] = buf;
                            }
                        }
                    }
                    for (int j = 1; j < list.GetLength(1); j += 2)
                        { 
                        for (int k = j; k < list.GetLength(1); k += 2) { 
                            if (j % 2 != 0 && list[i, j] > list[i, k])
                            {
                                buf = list[i, j];
                                list[i, j] = list[i, k];
                                list[i, k] = buf;
                            }
                        }
                    }
                }

                MatAns("3.10", list);
            }
            Task_3_10();

            static void Task_3_11()
            {
                int bufCounter = 0;
                int[,] list = new int[7, 5] {{1,2,3,4,5},
                                      {7,19,-9,-10,11},
                                      {-14,0,-15,1,-2},
                                      {-14,-15,-16,-1,-2},
                                      {-1,4,-3,-6,-20},
                                      {1,2,3,0,5},
                                      {2,6,0,-1,-3} };
                bool[] vec = new bool[list.GetLength(0)];

                MatPrint("3.11", list);

                for (int i = 0; i < list.GetLength(0); i++)
                {
                    for (int j = 0; j < list.GetLength(1); j++)
                    {
                        if (list[i, j] == 0)
                        {
                            vec[i] = true;
                            bufCounter++;
                            break;
                        }
                    }
                }

                int k = 0;
                int[,] ans = new int[list.GetLength(0) - bufCounter, list.GetLength(1)];
                for (int i = 0; i < list.GetLength(0); i++)
                {
                    if (vec[i] is false)
                    {
                        for (int j = 0; j < list.GetLength(1); j++)
                        {
                            ans[k, j] = list[i, j];
                        }
                        k++;
                    }
                }

                if (bufCounter == list.GetLength(0))
                {
                    Console.WriteLine("Task 3.11 Answer:\nAll rows contain zero");
                    return;
                }

                MatAns("3.11", ans);
            }
            Task_3_11();

        }
    }
}