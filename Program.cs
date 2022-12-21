using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            #region Lvl1
            #region 1.3
            Console.WriteLine("Task 1.3");
            int k = 4;
            int[,] M = new int[k, k];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    M[i, j] = random.Next(50);
                }
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.WriteLine(M[i, j] + "\t");
                }
            }
            int a = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (i == j)
                    {
                        a += M[i, j];
                    }
                }
            }
            Console.WriteLine($"Summ of the elements is {a}");
            #endregion
            #region 1.6
            Console.WriteLine("Task 1.6");
            k = 4;
            int m = 7;
            M = new int[k, m];
            int[] A = new int[k];
            for (int i = 0; i < k; i++)
                for (int j = 0; j < m; j++)
                    M[i, j] = random.Next(-10, 10);
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < k; i++)
            {
                int minM = M[i, 0], jM = 0;
                for (int j = 0; j < m; j++)
                {
                    if (M[i, j] < minM)
                    {
                        minM = M[i, j];
                        jM = j;
                    }
                }
                A[i] = jM;
            }
            for (int i = 0; i < A.Length; i++)
                Console.Write(A[i]);
            Console.WriteLine();
            #endregion
            #region 1.12
            Console.WriteLine("Task 1.12");
            k = 6;
            m = 7;
            M = new int[k, m];
            for (int i = 0; i < k; i++)
                for (int j = 0; j < m; j++)
                    M[i, j] = random.Next(50);
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int maxM = M[0, 0], ik = 0, jk = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (maxM < M[i, j])
                    {
                        maxM = M[i, j];
                        ik = i;
                        jk = j;
                    }
                }
            }
            k -= 1; m -= 1;
            for (int i = ik; i < k; i++)
                for (int j = jk; j < m; j++)
                    M[i, j] = M[i + 1, j + 1];
            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region 1.13
            Console.WriteLine("Task 1.13");
            k = 5;
            M = new int[k, k];
            for (int i = 0; i < k; i++)
                for (int j = 0; j < k; j++)
                     M[i, j] = random.Next(50);
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            int maxA3 = M[0, 0], iM = 0, p = 0, q = 4;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (M[i, j] > maxA3 && i == j)
                    {
                        maxA3 = M[i, j];
                        iM = i;
                    }
                }
            }
            for (int i = 0; i < k; i++)
            {
                p = M[i, q]; M[i, q] = M[i, iM]; M[i, iM] = p;
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region 1.17
            Console.WriteLine("Task 1.17");




            Console.WriteLine($"Enter the number of columns in array ");
            int.TryParse(Console.ReadLine(), out int k2);


            Console.WriteLine($"Enter the number of lines in array");
            int.TryParse(Console.ReadLine(), out int m2);


            M = new int[k2, k2];
            for (int i = 0; i < k2; i++)
                for (int j = 0; j < m2; j++)
                    M[i, j] = random.Next(50);
            for (int i = 0; i < k2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            p = 0;
            Console.WriteLine("\n");
            for (int i = 0; i < k2; i++)
            {
                int minMM = M[i, 0], jM = 0;
                for (int j = 0; j < m2; j++)
                {
                    if (minMM > M[i, j])
                    {
                        minMM = M[i, j];
                        jM = j;
                    }
                }
                while (jM > 0)
                {
                    p = M[i, jM]; M[i, jM] = M[i, jM - 1]; M[i, jM - 1] = p;
                    jM--;
                }
            }
            for (int i = 0; i < k2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region 1.29
            Console.WriteLine("Task 1.29");
            k = 5;
            m = 7;
            M = new int[k, m];
            for (int i = 0; i < k; i++)
                for (int j = 0; j < m; j++)
                    M[i, j] = random.Next(-10, 10);
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            iM = 0;
            for (int i = 0; i < k; i++)
            {
                int minm = M[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (j == 2 && Math.Abs(minm) > Math.Abs(M[i, j]))
                    {
                        minm = M[i, j];
                        iM++;
                    }
                }
            }
            m -= 1;
            if (iM < m - 1)
            {
                for (int i = iM + 1; i < k; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        M[i, j] = M[i, j + 1];
                    }
                }
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region 1.31
            Console.WriteLine("Task 1.31");
            k = 5;
            m = 7;
            M = new int[5, 8];
            A = new int[k];
            for (int i = 0; i < k; i++)
                for (int j = 0; j < m; j++)
                    M[i, j] = random.Next(50);
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < k; i++)
                A[i] = random.Next(5);
            Console.WriteLine();
            int minA = M[0, 0], jMM = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (i == 4 && minA > M[i, j])
                    {
                        minA = M[i, j];
                        jMM = j;
                    }
                }
            }
            for (int i = 0; i < k; i++)
                for (int j = m - 1; j >= jMM + 1; j--)
                    M[i, j + 1] = M[i, j];
            for (int i = 0; i < k; i++)
                M[i, jMM + 1] = A[i];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m + 1; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #endregion
            #region Lvl2
            Console.WriteLine("Level 2!");
            #region 2.7
            Console.WriteLine("Task 2.7");
            k = 6;
            M = new int[k, k];
            for (int i = 0; i < k; i++)
                for (int j = 0; j < k; j++)
                    M[i, j] = random.Next(50);
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            int Mmax = M[0, 0];
            iM = 0;
            for (int i = 1; i < k; i++)
            {
                if (M[i, i] > Mmax)
                {
                    Mmax = M[i, i];
                    iM = i;
                }
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (iM > i && j > i)
                    {
                        M[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region 2.8
            Console.WriteLine("Task 2.8");
            k = 6;
            M = new int[k, k];
            int[] N = new int[k];
            for (int i = 0; i < k; i++)
                for (int j = 0; j < k; j++)
                    M[i, j] = random.Next(50);
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < k; i++)
            {
                maxM = 0; 
                int jM = 0;
                for (int j = 0; j < k; j++)
                {
                    if (M[i, j] > maxM)
                    {
                        maxM = M[i, j];
                        jM = j;
                    }
                }
                N[i] = jM;
            }
            p = 0;
            for (int i = 0; i < k; i += 2)
            {
                p = M[i, N[i]]; M[i, N[i]] = M[i + 1, N[i + 1]]; M[i + 1, N[i + 1]] = p;
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #region 2.9
            Console.WriteLine("Task 2.9");
            k = 6;
            m = 7;
            M = new int[k, m];
            int[,] MM =  new int[k, m];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    M[i, j] = random.Next(50);
                }
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    MM[i, m - j - 1] = M[i, j];
                }
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(MM[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #endregion
            #region Lvl3
            Console.WriteLine("Level 3!!!");
            #region 3.1
            Console.WriteLine("Task 3.1");
            M = new int[7, 5];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                M[i, j] = random.Next(-10, 10);

            }
            MM = new int[7, 2];
            int [,] MMM = new int[7, 5];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.WriteLine(M[i,j] + "\t" );
                }
            }
            for (int i = 0; i < 7; i++)
            {
                int minI = i;
                int minJ = 0;
                int minM = M[i, 0];
                for (int j = 0; j < 5; j++)
                {
                    if (M[i, j] < minM)
                    {
                        minM = M[i, j];
                        minI = i;
                        minJ = jk;
                    }
                }
                k = 0;
                q = 0;
                MM[q, k] = minI;
                MM[q, k + 1] = minM;
                q += 1;
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {

                    if (MM[i, 1] < MM[j + 1, 1])
                    {
                        m = MM[i, 1];

                        MM[i, 1] = MM[j + 1, 1];

                        MM[j + 1, 1] = m;

                        m = MM[i, 0];

                        MM[i, 0] = MM[j + 1, 0];

                        MM[j + 1, 0] = m;
                    }
                }
            }



            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    MMM[i, j] = M[MM[i, 0], j];
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(MMM[i, j] + "\t");
                }
            }

            #endregion
            #region 3.2
            Console.WriteLine("Task 3.2");
            Console.WriteLine("Enter the size of matrix");
            int.TryParse(Console.ReadLine(), out k);
            M = new int[k, k];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    M[i, j] = random.Next(50);
                }
            }
                
                    
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.WriteLine(M[i, j] + "\t");
                }
            }
            for (int i = 0; i < k; i++)
            {
                M[i, 0] = 0;

                M[0, i] = 0;

                M[i, M.GetLength(0) - 1] = 0;

                M[M.GetLength(1) - 1, i] = 0;
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
            }

            #endregion
            #region 3.3
            Console.WriteLine("Task 3.3");
            Console.WriteLine("Enter the size of matrix");
            int.TryParse(Console.ReadLine(), out k);
            M = new int[k, k];
            int [] M_M = new int[2 * k - 1];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    M[i, j] = random.Next(50);
                }
            }
                
                    
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                    
            }
            q = 0;
            for (int i = k - 1; i > 0; i--)
            {
                m = 0;
                for (int j = 0; j + i < k; j++)
                {
                    m += M[i + j, j];
                }
                M_M[q] = m;
                q++;
            }
            for (int i = k - 1; i >= 0; i--)
            {
                m = 0;
                for (int j = 0; j + i < k; j++)
                {
                    m += M[j, i + j];
                }
                M_M[q] = m;
                q++;
            }
            for (int i = 0; i < M_M.Length; i++)
            {
                Console.Write(M_M[i] + "\t");
            }
            #endregion
            #region 3.4
            Console.WriteLine("Task 3.4");
            Console.WriteLine("Enter the size of matrix");
            int.TryParse(Console.ReadLine(), out k);
            M = new int[k, k];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    M[i, j] = random.Next(50);
                }
            }
                
                    
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
            }


            for (int i = k / 2; i < k; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    M[i, j] = 1;
                }
            }


            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
            }
            #endregion
            #region 3.8
            Console.WriteLine("Task 3.8");
            M = new int[7, 5];
            MM = new int[7, 5];
            int fl, fl2, fl3;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    int.TryParse(Console.ReadLine(), out k);
                    M[i, j] = k;
                }
            }
            MMM = new int[7, 2];
            q = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (M[i, j] > 0)
                    {
                        q += 1;
                    }
                }
                MMM[i, 0] = i;

                MMM[i, 1] = q;
                q = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                maxM = MMM[i, 1];
                fl = i;

                for (int j = 1 + i; j < 7; j++)
                {
                    if (MMM[j, 1] > maxM)
                    {
                        maxM = MMM[j, 1];

                        fl = j;
                    }
                }

                fl2 = MMM[i, 0];

                MMM[i, 0] = fl;

                MMM[fl, 0] = fl2;

                fl3 = MMM[i, 1];

                MMM[i, 1] = maxM;

                MMM[fl, 1] = fl3;

            }
            for (int i = 0; i < 7; i++)
            {
                fl = MMM[i, 0];

                for (int j = 0; j < 5; j++)
                {
                    MM[i, j] = M[fl, j];
                }
            }


            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(MM[i, j]);
                }
            }
            #endregion
            #region 3.10
            Console.WriteLine("Task 3.10");
            Console.WriteLine("Enter the amount of lines in matrix");
            int.TryParse(Console.ReadLine(), out k);
            Console.WriteLine("Enter the amount of columns in matrix");
            int.TryParse(Console.ReadLine(), out q);
            M = new int[k, q];
            for (int i = 0; i < k; i++)
                for (int j = 0; j < q; j++)
                    M[i, j] = random.Next(50);
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < q - 1; j++)
                {
                    for (int s = j; s < q; s++)
                    {
                        if (i % 2 == 0)
                        {
                            if (M[i, j] < M[i, s])
                            {
                                p = M[i, j]; M[i, j] = M[i, s]; M[i, s] = p;
                            }
                        }
                        else
                        {
                            if (M[i, j] > M[i, s])
                            {
                                p = M[i, j]; M    [i, j] = M[i, s]; M[i, k] = p;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
            }
            #endregion
            #region 3.11
            Console.WriteLine("Task 3.11");
            Console.WriteLine("Enter the amount of lines in matrix");
            int.TryParse(Console.ReadLine(), out k);
            Console.WriteLine("Enter the amount of columns in matrix");
            int.TryParse(Console.ReadLine(), out q);
            M = new int[k, q];
            List<int> ok = new List<int>();

            for (int i = 0; i < k; i++)
            {
                bool fla = false;
                for (int j = 0; j < q; j++)
                {
                    M[i, j] = random.Next(-50, 50);
                    if (M[i, j] == 0)
                    {
                        fla = true;
                    }
                }
                if (fla == true)
                {
                    ok.Add(i);
                }
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < q; j++)
                {   
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            q = 0;
            a = ok.Count();
            for (int i = 0; i < k; i++)
            {
                if (q == a)
                {
                    q = 0;
                }
                else if (i == ok[q])
                {
                    q += 1;
                    continue;
                }
                for (int j = 0; j < q; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            #endregion
        }
    }
}