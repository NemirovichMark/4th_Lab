using System;
class ThirdL_10Ex {
static void Main() {
            int k = 0;
            const int row = 4,column = 4;
            double[,] a = new double[row,column] {  {4,3,2,1},
                                                    {4,3,2,1},
                                                    {4,3,2,1},
                                                    {4,3,2,1}};
            double[] b = new double[column/2];
            for (int i = 0; i < row; i++){
                for (int j = 0; j < column; j += 2){
                    b[k] = a[i,j];
                    k++;
                }
                Array.Sort(b);
                k--;
                for (int j = 0; j < column;j +=2){
                    a[i,j] = b[k];
                    k--;
                }
                k = 0;
                for (int j = 1;j < column;j += 2){
                    b[k] = a[i,j];
                    k++;
                }
                k = 0;
                Array.Sort(b);
                for (int j = 1; j < column; j += 2){
                    a[i,j] = b[k];
                    k++;
                }
                k = 0;
            }
            Console.WriteLine($"new array: ");
            for (int i = 0; i < row; i++){
                for (int j = 0; j < column; j++){
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
    }
}