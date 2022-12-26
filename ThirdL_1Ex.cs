using System;
class ThirdL_1Ex {
  static void Main() {
            const int row = 7, column = 5;
            double minE, maxE,d;
            int IndexMinE=0;
            double[,] a = new double[row,column]{
                {9,4,9,9,9},
                {9,9,1,9,8},
                {9,2,9,9,7},
                {9,9,5,9,9},
                {9,9,9,0,5},
                {9,9,9,6,9},
                {3,9,9,9,9},
                
            };
            double[] b = new double[row];
            double[,] c = new double[row,column];
            maxE = a[0,0];
            d = a[0,0];
            for (int i = 0; i < row;i++){
                minE = a[i,0];
                for (int j = 0; j < column;j++){
                    if (a[i,j] < minE){
                        minE= a[i,j];
                    }
                    if (a[i,j] > maxE){
                        maxE = a[i,j];
                    }
                }
                b[i] = minE;
            }
            for(int k = 0; k < row; k++){
                if (b[k] < d){
                    d = b[k];
                }
            }
            for (int i = 0; i < row;i++){
                minE = d - 1;
                for (int k=0;k < row;k++){
                    if (b[k] > minE){
                        minE= b[k];
                        IndexMinE = k;
                    }
                }
                b[IndexMinE] = d - 1;
                for (int j = 0; j < column;j++){
                    c[i,j] = a[IndexMinE,j];
                }
            }
            Console.WriteLine($"new array: ");
            for (int i = 0; i < row; i++){
                for (int j = 0; j < column; j++){
                    Console.Write($"{c[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
  }
}