using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LABA_4
{
    internal class Program
    {

        static void lvl1_3()
        {
            int x, y;
            Console.WriteLine("Введите количество строк");
            while (!int.TryParse(Console.ReadLine(), out x))
            {

            }
            Console.WriteLine("Введите количество столбоцов");
            while (!int.TryParse(Console.ReadLine(), out y))
            {

            }
            Console.WriteLine("Введите элементы");
            int[,] a = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    while (!int.TryParse(Console.ReadLine(), out a[i, j]))
                    {

                    }
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
            int sum = 0;
            for (int i = 0; i < x; i++)
            {
                sum += a[i, i];
            }
            Console.WriteLine("Сумма элементов по диагонали =" + sum);
        }
        static void lvl1_6()
        {
            int x, y;
            Console.WriteLine("Введите количество строк");
            while (!int.TryParse(Console.ReadLine(), out x))
            {

            }
            Console.WriteLine("Введите количество столбоцов");
            while (!int.TryParse(Console.ReadLine(), out y))
            {

            }
            Console.WriteLine("Введите элементы");
            int[,] a = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    while (!int.TryParse(Console.ReadLine(), out a[i, j]))
                    {

                    }
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
            int[] b = new int[x];
            for (int i=0; i < x; i++)
            {
                int xmin = a[i, 0];
                for (int j=0; j < y; j++)
                {
                    if (a[i, j] <= xmin)
                    {
                        b[i] = j;
                        
                    }
                }
            }
          foreach (int u in b)
            {
                Console.WriteLine(u);
            }
           
        }
        static void lvl1_12()
        {
            int x, y;    
            Console.WriteLine("Введите количество строк");
            while (!int.TryParse(Console.ReadLine(), out x))
            {

            }
            Console.WriteLine("Введите количество столбоцов");
            while (!int.TryParse(Console.ReadLine(), out y))
            {

            }
            Console.WriteLine("Введите элементы");
            int[,] a = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    while (!int.TryParse(Console.ReadLine(), out a[i, j]))
                    {

                    }
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
            int max = int.MinValue;
            int imax = 0;
            int jmax = 0;
            for (int i=0; i<x; i++)
            {
                
                for (int j=0; j<y; j++)
                {
                
                    if (a[i, j] >= max)
                    {
                        max = a[i, j];
                        imax = i;
                        jmax = j;
                    }
                }
            }
            Console.WriteLine("Максимальный элемент = "+max);
            Console.WriteLine("Его индекс по строке = "+imax);
            Console.WriteLine("Его индекс по столбцу = "+jmax);
            x--;
            
            for (int i=imax; i<x; i++)
            {
                for (int j=0; j<y; j++)
                {
                    a[i, j] = a[i + 1, j];
                }
            }
            y--;
            for (int i = 0; i < x; i++)
            {
                for (int j = jmax; j < y; j++)
                {
                    a[i, j] = a[i, j + 1];
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
        static void lvl1_13()
        {
            int x, y;
            Console.WriteLine("Введите количество строк");
            while (!int.TryParse(Console.ReadLine(), out x))
            {

            }
            Console.WriteLine("Введите количество столбоцов");
            while (!int.TryParse(Console.ReadLine(), out y))
            {

            }
            Console.WriteLine("Введите элементы");
            int[,] a = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    while (!int.TryParse(Console.ReadLine(), out a[i, j]))
                    {

                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(a[i, j] + "   ");

                }
                Console.WriteLine();
            }
            int max = int.MinValue;
            int imax = 0;
            for (int i=0; i<x; i++)
            {
                if (a[i,i]>max)
                {
                    max = a[i, i];
                    imax = i;
                }
            }
            Console.WriteLine("Максимальый элемент на главной диагонали = " + max);
            Console.WriteLine("Его столбец = "+imax);
            int jj = 3;
            int temp = 0;
            for (int k=0; k<x; k++)
            {
                temp = a[k, imax];
                a[k, imax] = a[k, jj];
                a[k, jj] = temp;
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
        static void lvl1_17()
        {
            int x, y;
            Console.WriteLine("Введите количество строк");
            while (!int.TryParse(Console.ReadLine(), out x))
            {

            }
            Console.WriteLine("Введите количество столбоцов");
            while (!int.TryParse(Console.ReadLine(), out y))
            {

            }
            Console.WriteLine("Введите элементы");
            int[,] a = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    while (!int.TryParse(Console.ReadLine(), out a[i, j]))
                    {

                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(a[i, j] + "   ");

                }
                Console.WriteLine();
            }
            
            
            for (int i=0; i < x; i++)
            {
                int xmin = int.MaxValue;
                int imin = 0;
                for (int j=0; j < y; j++)
                {
                    if (a[i,j]<xmin)
                    {
                        xmin = a[i,j];
                        imin = j;
                    }
                }
                for (int k=imin; k>0; k--)
                {
                    a[i, k] = a[i, k - 1];
                    
                }
                a[i, 0] = xmin;
            }
           
           
            
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(a[i, j] + " ");

                }
                Console.WriteLine();
            }

        }
        static void lvl1_29()
        {
            int x, y;
            Console.WriteLine("Введите количество строк");
            while (!int.TryParse(Console.ReadLine(), out x))
            {

            }
            Console.WriteLine("Введите количество столбоцов");
            while (!int.TryParse(Console.ReadLine(), out y))
            {

            }
            Console.WriteLine("Введите элементы");
            int[,] a = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    while (!int.TryParse(Console.ReadLine(), out a[i, j]))
                    {

                    }
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
           for (int i=0; i < y; i++)
            { 
                    if (Math.Abs(a[1,i])<xmin)
                {
                    xmin = Math.Abs(a[1,i]);
                    imin = i;
                }
            }
            Console.WriteLine("Минимальный элемент второй строки = "+xmin);
            Console.WriteLine("Его индекс = " + imin);
            
            
            if (imin+1==y)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(a[i, j] + "\t");

                    }
                    Console.WriteLine();
                }
            }
            if (imin +1 != y)
            {
                y--;
                for (int i = 0; i < x; i++)
                {
                    for (int j = imin + 1; j < y; j++)
                    {
                        a[i, j] = a[i, j + 1];
                    }
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

        }
        static void lvl1_31()
        {
            int x = 5;
            int y = 8;
            Console.WriteLine("Матрица А");
            int[,] a = new int[x, y];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y-1; j++)
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
            for (int i =0; i < y-1; i++)
            {
                if (a[4,i]<xmin)
                {
                    xmin = a[4,i];
                    imin = i;
                }
            }
            Console.WriteLine("Минимальный элемент пятой строки = " + xmin);
            Console.WriteLine("Его индекс = " + imin);
            Console.WriteLine("Введите элементы массива B");
            int[] b = new int[5];
            for (int i=0; i<5; i++)
            {
                while(!int.TryParse(Console.ReadLine(), out b[i]))
                {

                }
            }
           for (int i=0; i<x; i++)
            {
                for (int j=y-2; j>=imin; j--)
                {
                    a[i, j+1 ] = a[i, j];
                }
            }
           for (int j =0; j<x; j++)
            {
                a[j, imin+1] = b[j];
            }



            for (int i = 0; i < x; i++)
            {
                for (int j=0; j<y; j++)
                {
                    Console.Write(a[i, j]+"\t");
                }
                Console.WriteLine();
            }

        }
        static void lvl2_7()
        {
            int x = 6;
            int y = 6;
            Console.WriteLine("Матрица А");
            int[,] a = new int[x, y];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
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
            int dmax = int.MinValue;
            int imax = 0;
            for (int i=0; i < x; i++)
            {
                if (a[i,i]>dmax)
                {
                    dmax = a[i, i];
                    imax = i;
                }
            }
            Console.WriteLine("Максимальный элемент на главной диагонали = " + dmax);
            Console.WriteLine("Его индекс = "+imax);
            for (int i = imax-1 ; i >= 0; i--)
            {
                for (int j = y-1; j > i; j--)
                {
                    a[i, j] = 0;
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
        }
        static void lvl2_8()
        {
            int x = 6;
            int y = 6;
            Console.WriteLine("Матрица А");
            int[,] a = new int[x, y];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
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
            Console.WriteLine();
            Console.WriteLine("Новая матрица");
            int[] b = new int[x];
            int [] c = new int[y];
            for (int i=0;i<x; i++)
            {
                int xmax = int.MinValue;
                for (int j=0;j<y; j++)
                {
                    if (a[i, j] > xmax)
                    {
                        xmax= a[i, j];
                        c[i] = xmax;
                        b[i] = j;
                    }
                }
            }
            for (int i = 0; i < x-1; i=i+2)
            {
                for (int j = b[i]; j <= b[i]; j++)
                {
                    
                    a[i, j] = c[i + 1];
                    a[i + 1, b[i+1]] = c[i];
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
        }
        static void lvl2_9()
        {
            int x = 6;
            int y = 7;
            Console.WriteLine("Матрица А");
            int[,] a = new int[x, y];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
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
            Console.WriteLine();
            Console.WriteLine("Инвертированная матрица");
            int temp = 0;
            for (int i=0; i < x; i++)
            {
                for (int j=y-1; j>y/2-1 ; j--)
                {
                    temp = a[i, j];
                    a[i, j] = a[i, y - j - 1];
                    a[i, y - j - 1] = temp;
                    
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
        }
        static void lvl3_1()
        {
            int x = 7;
            int y = 5;
            Console.WriteLine("Матрица А");
            int[,] a = new int[x, y];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
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
            int[] b = new int[x];
            for (int i=0; i < x; i++)
            {
                int xmin=int.MaxValue;
                for (int j=0; j<y; j++)
                {
                    if (a[i,j]<xmin)
                    {
                        xmin = a[i, j];
                        b[i] = xmin;
                    }
                }
            }
            Console.WriteLine("Минимальные элементы строк ");
            foreach(int u in b)
            {

                Console.WriteLine(u);
            }
            int f = 0;
            while( f < b.Length-1)
            {
                if (b[f] < b[f+1])    
                {
                  int  temp = b[f];  // меняю минимальные элементы строк местами, если надо
                    b[f] = b[f+1];
                    b[f+1] = temp;
                    for (int i=0; i < y; i++)  // меняю местами строки с минимальными элементами
                    {
                        int p = a[f, i];
                        a[f, i] = a[f+1,i];
                        a[f + 1, i] = p;
                    }
                    if (f>0)
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
                    Console.Write(a[i, j] + "\t");

                }
                Console.WriteLine();
            }



        }
        static void lvl3_2()
        {
            int x = 4;
            Console.WriteLine("Матрица А");
            int[,] a = new int[x, x];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    a[i, j] = r.Next(100);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(a[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Новая матрица");
            for (int i=0; i<x; i++)
            {
                a[i, 0] = 0;
                a[0, i] = 0;
                a[x - 1, i] = 0;
                a[i, x - 1] = 0;
            }
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(a[i, j] + "\t");

                }
                Console.WriteLine();
            }






        }
        static void lvl3_3()
        {
            int x = 3;
            Console.WriteLine("Матрица А");
            int[,] a = new int[x, x];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    a[i, j] = r.Next(100);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(a[i, j] + "\t");

                }
                Console.WriteLine();
            }
            int[] b = new int[2 * x - 1];
            int bi = 0;
            for( int i=x-1; i>=0; i--)
            {
                int dlength = x - i;
                int sum = 0;
                for (int j=0; j<dlength; j++)
                {
                    sum += a[i + j, j];
                }
                b[bi++] = sum;
            }
          for (int i=1; i<x; i++)
            {
                
                int dlength = x - i;
                int sum = 0;
                for (int j=0; j<dlength; j++)
                {
                    sum += a[j, i + j];
                }
                b[bi++] = sum;
            }
            Console.WriteLine("Массив из сумм элементов диагоналей");
          foreach (int u in b)
            {
                Console.WriteLine(u);
            }


        }
        static void lvl3_4()
        {
            int x;
            Console.WriteLine("Введите размер квардратной матрицы");
            while (!int.TryParse(Console.ReadLine(), out x))
            {

            }
            Console.WriteLine("Матрица");
            int[,] a = new int[x, x];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    a[i, j] = r.Next(100);
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
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
            Console.WriteLine();
            Console.WriteLine("Новая матрица");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void lvl3_8()
        {
            int x = 7;
            int y = 5;
            Console.WriteLine("Матрица");
            int[,] a = new int[x, y];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    a[i, j] = r.Next(-20,20);
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
            int[] b = new int[x];
            for (int i=0; i < x; i++)
            {
                int k = 0;
                for (int j=0; j<y; j++)
                {
                    if (a[i,j]>0)
                    {
                        k++;
                    }
                }
                b[i] = k;
            }
            Console.WriteLine();
            Console.WriteLine("Количество положительных элемнтов в каждой строке");
            foreach(int u in b)
            {
                Console.Write(u+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Новая матрица");
            int f = 0;
            while(f<b.Length-1)
            {
                if (b[f] < b[f+1])
                {
                    int temp = b[f];
                    b[f] = b[f + 1];
                    b[f + 1] = temp;
                    for (int i=0; i<y; i++)
                    {
                        int p = a[f, i];
                        a[f, i] = a[f + 1, i];
                        a[f + 1, i] = p;
                    }
                    if (f>0)
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
                    Console.Write(a[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
        static void lvl3_9()
        {
            int x = 5;
            int y = 7;
            Console.WriteLine("Матрица");
            int[,] a = new int[x, y];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    a[i, j] = r.Next(-20, 20);
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
            int[] b = new int[y];
            for (int i = 0; i < y; i++)
            {
                int k = 0;
                for (int j = 0; j < x; j++)
                {
                    if (a[j, i] < 0)
                    {
                        k++;
                    }
                }
                b[i] = k;
            }
            Console.WriteLine();
            Console.WriteLine("Количество отрицательных элемнтов в каждом столбце");
            foreach (int u in b)
            {
                Console.Write(u + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Новая матрица");
            int f = 0;
            while(f<b.Length-1)
            {
                if (b[f] > b[f + 1])
                {
                    int temp = b[f];
                    b[f] = b[f + 1];
                    b[f + 1] = temp;
                    for (int i = 0; i < x; i++)
                    {
                        int p = a[i, f];
                        a[i, f] = a[i, f + 1];
                        a[i, f + 1] = p;
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
                    Console.Write(a[i, j] + "\t");

                }
                Console.WriteLine();
            }


        }
        static void lvl3_11()
        {
            int x;
            int y;
            Console.WriteLine("Введите количество строк");
            while(!int.TryParse(Console.ReadLine(), out x))
            {

            }
            Console.WriteLine("Введите количество столбцов");
            while (!int.TryParse(Console.ReadLine(), out y))
            {

            }
            Console.WriteLine("Матрица");
            int[,] a = new int[x, y];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    a[i, j] = r.Next(-10,5);
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
            Console.WriteLine();
            int k = 0;
           for (int i=0;i<x; i++)
            {
                for (int j=0; j<y; j++)
                {
                    if (a[i,j]==0)
                    {
                        k++;
                        break;
                    }
                }
            }
            Console.WriteLine("Количество строк с нулями " + k);
            bool[] b = new bool[x];
            for (int i=0; i<x; i++)
            {
                for (int j=0; j<y; j++)
                {
                    if (a[i,j]==0)
                    {
                        b[i] = true;
                        break;
                    }
                }
            }
            Console.WriteLine("Строки содержат нули?");
            foreach (bool u in b)
            {
                Console.WriteLine(u);
            }
            Console.WriteLine("Новая  матрица");
            int n = x - k;
            int[,] c = new int[n, y];
            int s = 0;
            for (int i=0; i < x; i++)
            {
                if (b[i] == true)
                {
                    continue;
                }
                for (int j=0; j<y; j++)
                {
                    c[s, j] = a[i, j];
                }
                s++;
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(c[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
            
        static void Main(string[] args)
        {


            // lvl1_3();


            //   lvl1_6();


            //  lvl1_12();

            //  lvl1_13();




            //  lvl1_17();



            // lvl1_29();



            //   lvl1_31();



            // lvl2_7();


            //   lvl2_8();



            // lvl2_9();





            // lvl3_1();

            //  lvl3_2();

            // lvl3_3();


            // lvl3_4();



            // lvl3_8();



            //   lvl3_9();


          //  lvl3_11();

           
            

        }
    }
}
