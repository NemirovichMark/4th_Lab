using System;

namespace LaboratoryL1N31
{
    class Program
    {
        static int Main(string[] args)
        {
            int n = 5, m = 8;
            
            //base array (minimum == -7 (at the end))
            double[,] array = new double[,]{{1,2,3,4,5,6,7},{7,8,9,10,11,12,13},
            {10,11,12,13,14,15,16},{20,21,22,23,24,25,26},{-1,-2,-3,-4,-5,-6,-7}};
            //Ans array (with additional column at the end)
            double[,] array_ans = new double[n,m];
            //Array for insert
            double[] array_b = new double[]{10,10,10,10,10};
            int index_min = 6;
            int i_2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j == (index_min+1))
                    {
                        array_ans[i_2,j] = array_b[i_2];
                        i_2++;
                    }
                    else
                    {
                        array_ans[i,j] = array[i,j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array_ans[i,j]} ");

                }
                Console.WriteLine();
            }
            return 0;
        }
    }
}