using System;
using System.Reflection;

namespace _4rd_Lab
{
    class FirtL_6Ex
    {
        static void Main(string[] args)
        {
            const int row = 4;
            const int column = 7;
            double min = 0; double indexMin = 0;
            int k = 0;
            double [] b = new double[4];
            double[,] a = new double[row, column]{  {1,4,3,2,5,6,9},
                                                    {1,2, 3,4,0,-1,3},
                                                    {1,2,7,3,-1,8,13},
                                                    {9,2,1,3,5,7,11}};
            Console.WriteLine($"Array: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                    Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < row;i++){
                min = a[i,0];
                indexMin = k;
                for(int j = 0; j < column; j++){
                    if(a[i,j] < min){
                        min = a[i,j];
                        indexMin = k;
                    }
                    k++;
                }
                b[i] = indexMin;
            }
            foreach(int elements in b) Console.Write($"{elements} ");
        }
    }
}

