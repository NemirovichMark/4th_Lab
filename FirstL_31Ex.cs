using System;
class First_31LEx {
  static void Main() {
            int IndexMinElement;
            double minElement;
            double[,] a = new double[5,8] {         {1,2,3,4,5,6,7,0},
                                                    {0,0,0,0,0,0,0,0},
                                                    {0,0,0,0,0,0,0,0},
                                                    {0,0,0,0,0,0,0,0},
                                                    {2,3,4,5,1,4,3,0}};
            double[] b = new double[5] {1,1,1,1,1};
            minElement = a[4, 0];
            IndexMinElement = 0;
            for (int j = 0; j < 7; j++){
                if (a[4, j] < minElement){
                    minElement = a[4,j];
                    IndexMinElement = j;
                }
            }
            for (int i = 0; i < 5; i++){
                for (int j = 7; j > IndexMinElement + 1; j--){
                    a[i,j] = a[i,j - 1];
                }
            }
            for (int i = 0; i < 5; i++){
                a[i,IndexMinElement + 1] = b[i];
            }
            Console.WriteLine($"new array: ");
            for (int i = 0; i < 5 ; i++){
                for (int j = 0; j < 8; j++){
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
  }
}