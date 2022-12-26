using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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


            M = new int[k2, m2];
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
            {
                for (int j = 0; j < m; j++)
                {
                    M[i, j] = random.Next(-50, 50);
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int min = Math.Abs(M[1, 0]);
            int minj = 0;
            for (int j = 0; j < m; j++)
            {
                if ((Math.Abs(M[1, j]) < Math.Abs(min)))
                {
                    min = M[1, j];
                    minj = j;
                }
            }
            Console.WriteLine($"The minimal abs element is {min}");

            if (minj < 6) { m -= 1; } else { m = m; }
            for (int i = 0; i < k; i++)
            {
                for (int j = minj + 1; j < m; j++)
                {
                    M[i, j] = M[i, j + 1];
                }
            }
            Console.WriteLine("Here`s our changed array:");
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
            k = 7;
            m = 5;
            M = new int [k, m];
            MM = new int [k, m];
            int index;
            double[] minimal = new double[7];
            double[] copied = new double[7];
            int[] ind = new int[7];
            bool flag = true;
            for (int i = 0; i < 7; i++)
            {
                double MinI = double.MaxValue;
                Console.WriteLine($"Write down 5 elems in i line");
                for (int j = 0; j < 5; j++)
                {
                    if (int.TryParse(Console.ReadLine(), out int s)) { M[i, j] = s; MM[i, j] = s; }
                    else
                    {
                        Console.WriteLine("wrong");
                        flag = false;
                        break;
                    }
                    if (s < MinI) { MinI = s; index = j; }
                }
                if (!flag) break;
                minimal[i] = MinI;
                copied[i] = MinI;
            }
            for (int i = 0; i < 7; i++)
            {
                double MaxI = minimal[i];
                int IND = i;
                for (int j = i + 1; j < 7; j++)
                {
                    if (minimal[j] > MaxI) { MaxI = minimal[j]; IND = j; }
                }
                ind[i] = Array.IndexOf(copied, MaxI);
                minimal[IND] = minimal[i];
                minimal[i] = MaxI;
                copied[Array.IndexOf(copied, MaxI)] = double.MinValue;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    M[i, j] = MM[ind[i], j];
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0,4}", M[i, j]);
                }
                Console.WriteLine();
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
            k = 7;
            m = 5;
            M = new int[k, m];
            Random ran = new Random();
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    M[i, j] = ran.Next(-20, 20);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(M[i, j] + "\t");

                }
                Console.WriteLine();
            }
            int[] b = new int[k];
            for (int i = 0; i < k; i++)
            {
                int x = 0;
                for (int j = 0; j < m; j++)
                {
                    if (M[i, j] > 0)
                    {
                        x++;
                    }
                }
                b[i] = x;
            }
            Console.WriteLine();
            foreach (int u in b)
            {
                Console.Write(u + " ");
            }
            Console.WriteLine();
            int f = 0;
            while (f < b.Length - 1)
            {
                if (b[f] < b[f + 1])
                {
                    int temp = b[f];
                    b[f] = b[f + 1];
                    b[f + 1] = temp;
                    for (int i = 0; i < m; i++)
                    {
                        int g = M[f, i];
                        M[f, i] = M[f + 1, i];
                        M[f + 1, i] = g;
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
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(M[i, j] + "\t");

                }
                Console.WriteLine();
            }
            #endregion
            #region 3.10
            Console.WriteLine("Task 3.10");
            Console.WriteLine("Write down Lines and Columns in array");
            flag = true;
            if (int.TryParse(Console.ReadLine(), out k) && k > 0 && int.TryParse(Console.ReadLine(), out m) && m > 0)
            {
                M = new int[k, m];
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine($"Write down {m} elems in {i} line");
                    for (int j = 0; j < m; j++)
                    {
                        if (int.TryParse(Console.ReadLine(), out int s)) { M[i, j] = s; }
                        else
                        {
                            Console.WriteLine("Wrong");
                            flag = false;
                            break;
                        }
                    }
                    if (!flag) break;
                }
                for (int i = 0; i < k; i++)
                {
                    int[] Z = new int[m];
                    if (i % 2 == 0)
                    {
                        for (q = 0; q < m; q++)
                        {
                            Z[q] = M[i, q];
                        }
                        Array.Sort(Z); Array.Reverse(Z);
                        for (q = 0; q < m; q++)
                        {
                            M[i, q] = Z[q];
                        }
                    }
                    else
                    {
                        for (q = 0; q < m; q++)
                        {
                            Z[q] = M[i, q];
                        }
                        Array.Sort(Z);
                        for (q = 0; q < m; q++)
                        {
                            M[i, q] = Z[q];
                        }
                    }
                }
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("{0,4}", M[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong");
                return;
            }
            #endregion
            #region 3.11
            Console.WriteLine("Task 3.11");
            Console.WriteLine("Write down Lines and Columns of the Array");
            flag = true;
            if (int.TryParse(Console.ReadLine(), out k) && k > 0 && int.TryParse(Console.ReadLine(), out m) && m > 0)
            {
                M = new int[k, m];
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine($"Write down {m} elems in i lines");
                    for (int j = 0; j < m; j++)
                    {
                        if (int.TryParse(Console.ReadLine(), out q)) { M[i, j] = q; }
                        else
                        {
                            Console.WriteLine("Wrong");
                            flag = false;
                            break;
                        }
                    }
                    if (!flag) break;
                }
                int IND = 0; 
                int IN = 0;
                MM = new int[k, m];
                for (int i = 0; i < k; i++)
                {
                    flag = true;
                    for (int j = 0; j < m; j++)
                    {
                        if (M[i, j] == 0) { flag = false; break; }
                    }
                    if (!flag) continue;
                    else
                    {
                        for (int j = 0; j < m; j++)
                        {

                            MM[IN, j] = M[i, j];
                        }
                        IN += 1;
                    }

                }
                for (int i = 0; i < IN; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("{0,4}", MM[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong");
                return;
            }
            #endregion
            #endregion
        }
    }
}