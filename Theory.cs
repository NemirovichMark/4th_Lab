using System;
using System.Collections.Generic;

namespace _4th_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            #region lvl1-3
            int[,] m1 = new int[4, 4];
            int s1 = 0;
            Console.WriteLine("Введите элементы матрицы");
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    int d;
                    int.TryParse(Console.ReadLine(), out d);
                    m1[y, x] = d;
                }
            }
            Console.WriteLine("Сумма равна");

            for (int i = 3; i >= 0; i--)
            {
                s1 += m1[i, i];
            }
            for (int i = 0; i < 4; i++)
            {
                s1 += m1[i, i];
            }

            Console.WriteLine(s1);
            #endregion
            #region lvl1-6
            int[,] m2 = new int[4, 7];
            int[] m2a = new int[4];
            int minm2 = 1000000;
            int km2 = 0;
            Console.WriteLine("Введите элементы матрицы");
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    int d;
                    int.TryParse(Console.ReadLine(), out d);
                    m2[y, x] = d;
                    if (d <= minm2)
                    {
                        minm2 = d;
                        m2a[km2] = x;
                    }

                }
                km2++;
            }

            foreach (int z in m2a)
            {
                Console.Write(z);
                Console.Write(" ");
            }

            #endregion
            #region lvl1-12
            int[,] myArray = new int[6,7]
            {
                {1,1,1,1,0,1,1},
                {2,2,2,2,0,2,2},
                {3,3,3,3,0,3,3},
                {4,4,4,4,9,4,4},
                {5,5,5,5,0,5,5},
                {6,6,6,6,0,6,6}
            };
            int maxArray = 0;
            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);
            int indexheight = 0;
            int indexwidth = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if(myArray[y,x] > maxArray)
                    {
                        indexheight = y;
                        indexwidth = x;
                        maxArray = myArray[y,x];
                    }
                }
            }
            for (int y = indexheight; y < height - 1; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    myArray[y,x] = myArray[y+1,x];
                }
            }
            for (int y = 0; y < height; y++)
            {
                for (int x = indexwidth; x < width-1; x++)
                {
                    myArray[y,x] = myArray[y,x + 1];
                }
            }
            
            for (int y = 0; y < height-1; y++)
	        {
                for (int x = 0; x < width-1; x++)
                {
                    Console.Write(myArray[y,x] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region lvl1-13
            int[,] myArray = new int[5,5]
            {
                {3,4,6,1,2},
                {7,4,9,2,4},
                {10,23,5,8,8},
                {12,3,3,9,6},
                {12,13,14,15,16}
            };
            int maxArray = 0;
            int indexwidth = 0;
            for (int i = 0; i < 5; i++)
            {
                if (myArray[i,i] > maxArray)
                {
                    indexwidth = i;
                    maxArray = myArray[i,i];
                }
            }
           
            for (int y = 0; y < 5; y++)
            {
                int s = myArray[y,3];
                int p = myArray[y,indexwidth];
                for (int x = 3; x < 5; x++)
                {
                   myArray[y,x] = p;
                   p = s;
                   
                   
                }
            }
            for (int y = 0; y < 5; y++)
	        {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write(myArray[y,x] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region lvl1-17
            int n, m;
            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out m);
            int[,] myArray = new int[n,m];
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    int s;
                    int.TryParse(Console.ReadLine(), out s);
                    myArray[y,x] = s;
                }
            }
            for (int y = 0; y < n; y++)
            {
                int indexArray = 0;
                int minArray = 10000000;
                for (int x = 0; x < m; x++)
                {
                    if (myArray[y,x] < minArray)
                    {
                        minArray = myArray[y,x];
                        indexArray = x;

                    }
                    for (int j = indexArray; j > 0; j--)
                    {
                        myArray[y, j] = myArray[y, j - 1];
                    }
                    myArray[y, 0] = minArray;
                }
                
            }
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    Console.Write(myArray[y,x] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region lvl1-29
            int[,] f = new int[5,7]
            {
                {3,4,6,5,6,7,8},
                {1,9,9,8,7,6,8},
                {2,0,5,4,6,10,7},
                {3,4,6,5,6,7,8},
                {-1,9,9,8,7,6,4}
                
                
            };
            int minF = 10000000;
            int indexF = 0;
            for (int y = 0; y < f.GetLength(0); y++)
            {
                for (int x = 0; x < f.GetLength(1); x++)
                {
                    if (Math.Abs(f[1,x]) < minF)
                    {
                        minF = Math.Abs(f[1,x]);
                        indexF = x;

                    }
                   
                }
            }
            if (indexF == 6)
            {
                for (int y = 0; y < f.GetLength(0); y++)
                {
                    for (int x = 0; x < f.GetLength(1); x++)
                    {
                        Console.Write(f[y,x] + "\t");

                    }
                    Console.WriteLine();
                } 
                
                
                
                
                
                
                
                
                
                Console.ReadLine();
                return;
               
            }
            
            for (int y = 0; y < f.GetLength(0); y++)
            {
                  
                    for (int x = indexF+1; x < f.GetLength(1)-1; x++)
                    {
                        f[y,x] = f[y,x+1];
                    }   
            }
            for (int y = 0; y < f.GetLength(0); y++)
            {
                for (int x = 0; x < f.GetLength(1)-1; x++)
                {
                    Console.Write(f[y,x] + "\t");

                }
                Console.WriteLine();
            }
            #endregion
            #region lvl1-31
            int[,] myArray = new int[5, 8]
            {
                {2, 3, 1, 53, 0, 52, 1, 0},
                {8, 4, 87, 65, 1, -37, 13, 0},
                {7, 2, 75, 1, -5, -47, 2, 0},
                {8, 4, 1, 5, 23, 7, 127, 0},
                {17,-2, 1,-100,1,  57, 5, 0},
            };
            int[] B = new int[5] { 9, 9, 9, 9, 9 };
            int minArray = 100000000;
            int indexArray = 0;
            for (int i = 0; i < myArray.GetLength(1) - 1; i++)
            {
                if (minArray > myArray[4, i])
                {
                    minArray = myArray[4, i];
                    indexArray = i;
                }
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = myArray.GetLength(1) - 1; j > indexArray; j--)
                {
                    myArray[i, j] = myArray[i, j - 1];
                }
                myArray[i, indexArray + 1] = B[i];
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion
            #region lvl2-7
                const int n = 6;
                double[,] array = new double[n, n]
                {
                    {5,6,4,3,7,4},
                    {3,7,8,4,3,9},
                    {0,8,9,3,6,2},
                    {1,6,3,4,7,4},
                    {7,6,8,2,1,0},
                    {9,4,8,1,7,2}
                };
                double max = 0;
                int indexs = 0;
                for (int i = 0; i < n; i++)
                {
                    if (array[i, i] > max)
                    {
                        max = array[i, i];
                        indexs = i;
                    }
                }
                for (int y = 0; y < indexs; y++)
                {
                    for (int x = y + 1; x < n; x++)
                        array[y, x] = 0;
                }
                for (int y = 0; y < n; y++)
                {
                    for (int x = 0; x < n; x++)
                    {
                        Console.Write(array[y, x] + "\t");
                    }
                    Console.WriteLine();
                }
            #endregion
            #region lvl2-8
                const int n = 6;
                double[,] array = new double[n, n]
                {
                    {10,9,8,7,6,5},
                    {9,8,7,6,5,4},
                    {8,7,6,5,4,3},
                    {7,6,5,4,3,2},
                    {6,5,4,3,2,1},
                    {5,4,3,2,1,0}
                };
                int[] index = new int[n];
                for (int y = 0; y < n; y++)
                {
                    double mx = array[y, 0];
                    int maxi = 0;
                    for (int x = 0; x < n; x++)
                    {
                        if (array[y, x] > mx)
                        {
                            mx = array[y, x];
                            maxi = x;
                        }
                    }
                    index[y] = maxi;
                }
                for (int i = 0; i < n; i += 2)
                {
                    double p = array[i, index[i]];
                    array[i, index[i]] = array[i + 1, index[i + 1]];
                    array[i + 1, index[i + 1]] = p;
                }
                for (int y = 0; y < n; y++)
                {
                    for (int x = 0; x < n; x++)
                    {
                        Console.Write(array[y, x] + "\t");
                    }
                    Console.WriteLine();
                }
            #endregion
            #region lvl2-9
            int[,] array = new int[6,7]
            {
                {1,2,3,4,5,6,7},
                {1,2,3,4,5,6,7},
                {1,2,3,4,5,6,7},
                {1,2,3,4,5,6,7},
                {1,2,3,4,5,6,7},
                {1,2,3,4,5,6,7}
            
            };
            for(int y = 0; y < 6; y++)
            {
                int[] array2 = new int[7];
                int k = 0;
                for (int j = 6; j >= 0; j--)
                {
                    array2[k] = array[y, j];
                    k++;
                }
                for (int x = 0; x < 7; x++)
                {
                    array[y, x] = array2[x];
                }
            }
            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    Console.Write(array[y, x] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region lvl3-1
            int min = 0;
            int n = 3, m = 3;
            int[,] array = new int[n,m];
            int[] array_min = new int[n];
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    int z;
                    int.TryParse(Console.ReadLine(), out z);
                    array[y,x] = z;
                }
            }
            for (int y = 0; y < n; y++)
            {
                min = array[y,0];
                for (int x = 0; x < m; x++)
                {
                    if (array[y,x] < min)
                    {
                        min = array[y,x];
                    }
                    array_min[y] = min;
                    
                }
            }
            int sort_array = 1;
            while (sort_array < array_min.Length)
            {
                if (sort_array == 0 || array_min[sort_array] <= array_min[sort_array - 1])
                {
                    sort_array++;
                }
                else
                {
                    int s = array_min[sort_array - 1];

                    array_min[sort_array - 1] = array_min[sort_array];
                    array_min[sort_array] = s;

                    for (int j = 0; j < m; j++)
                    {
                        s = array[sort_array - 1, j];
                        array[sort_array - 1, j] = array[sort_array, j];
                        array[sort_array, j] = s;
                    }

                    sort_array--;
                }
            }
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    Console.Write(array[y, x] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region lvl3-2
            const int c = 4;
            double[,] array = new double[c,c];
            for (int y = 0; y < c; y++)
            { 
              for (int x = 0; x < c; x++)
              {
                 double z;
                 double.TryParse(Console.ReadLine(), out z);
                 array[y,x] = z;
              }
            }
            for (int i = 0; i < c; i++)
            { 
                for (int j = 0; j < c; j++)
                {
                  if ((i == 0) | (i == c - 1))
                  array[i, j] = 0;
                }
                array[i, 0] = 0;
                array[i, c - 1] = 0;
            }
            for (int i = 0; i < c; i++)
            {
              for (int j = 0; j < c; j++)
              {
                 Console.Write(array[i, j] + "\t");
              }
              Console.WriteLine();
            }
            #endregion
            #region lvl3-3
                const int c = 4;
                double[,] array = new double[c, c];
                for (int y = 0; y < c; y++)
                    for (int x = 0; x < c; x++)
                    {
                      double z;
                      double.TryParse(Console.ReadLine(), out z);
                      array[y, x] = z;
                    }
                double[] m3 = new double[2 * c - 1];
                int el = 0;
                for (int y = c - 1; y != -1; y--)
                {
                    for (int x = 0; x + y != c; x++)
                    {
                        m3[el] += array[y + x, x];
                    }
                    el++;
                }
                for (int y = c - 1; y != 0; y--)
                {
                    for (int x = 0; x + y != c; x++)
                    {
                        m3[el] += array[x, x + y];
                    }
                    el++;
                }
                foreach (int i in m3)
                {
                    Console.Write(i + " ");
                }
                #endregion
            #region lvl3-4
            const int c = 4;
            double[,] array = new double[c, c];
            for (int y = 0; y < c; y++)
                for (int x = 0; x < c; x++)
                {
                    double z;
                    double.TryParse(Console.ReadLine(), out z);
                    array[y, x] = z;
                }
            for (int y = c / 2; y < c; y++)
            {
                for (int x = 0; x <= y; x++)
                {
                    array[y, x] = 0;
                }
            }
            for (int y = 0; y < c; y++)
            {
                for (int x = 0; x < c; x++)
                {
                    Console.Write(array[y,x] + "\t");
                }
                Console.WriteLine();
                
            }
            #endregion
            #region lvl3-8
            int[,] array = new int[4, 4]
            {
                {2, 1, -4, 7,},
                {8, -2, 15, 21},
                {9, 3, 23, 13},
                {7, -12, 1, -2}
             
            };
            int[] m1 = new int[array.GetLength(0)];
            int c, k = 1;
            for (int y = 0; y < array.GetLength(0); y++)
            {
                c = 0;
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    if (array[y, x] > 0)
                    {
                        c++;
                    }
                }
                m1[y] = c;
            }
            while (k < m1.Length)
            {
                if (k == 0 || m1[k - 1] >= m1[k])
                {
                    k++;
                }
                else
                {
                    int s = m1[k];
                    m1[k] = m1[k - 1];
                    m1[k - 1] = s;
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        s = array[k - 1, j];
                        array[k - 1, j] = array[k, j];
                        array[k, j] = s;
                    }
                    k--;
                }
            }
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    Console.Write(array[y, x] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region lvl3-10
            int[,] array = new int[4, 4]
            {
                {2, 1, -4, 7},
                {8, -2, 15, 21},
                {9, 3, 23, 13,},
                {7, -12, 1, -2,},
               
            };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int k1 = 0;
                if (i%2 != 0)
                {
                    while (k1 < array.GetLength(1))
                    {
                        if (k1 == 0 || array[i, k1 - 1] <= array[i, k1])
                        {
                            k1++;
                        }
                        else
                        {
                            int s = array[i, k1];
                            array[i, k1] = array[i, k1 - 1];
                            array[i, k1 - 1] = s;
                            k1--;
                        }
                    }
                }
                else
                {
                    while (k1 < array.GetLength(1))
                    {
                        if (k1 == 0 || array[i, k1 - 1] >= array[i, k1])
                        {
                            k1++;
                        }
                        else
                        {
                            int s2 = array[i, k1];
                            array[i, k1] = array[i, k1 - 1];
                            array[i, k1 - 1] = s2;
                            k1--;
                        }
                    }
                }
            }
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    Console.Write(array[y, x] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region lvl3-11
            int[,] array = new int[4, 4]
            {
                {8, 1, -4, 7},
                {7, -2, 21, 0},
                {9, 3, 13, 1},
                {7, 1, -2, 11}
             
            };
            int n1 = array.GetLength(0);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 0)
                    {
                        n1 -= 1;
                        break;
                    }
                }
            }
            int[,] array2 = new int[n1, 5];
            int k, c = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                k = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 0)
                    {
                        k = 1;
                        break;
                    }
                }
                if (k == 0)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array2[c, j] = array[i, j];
                        
                    }
                    c += 1;
                }
            }
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < array2.GetLength(1) - 1; j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
        }


    }
    
}
