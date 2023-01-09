using System;
class ThirdL_3Ex {
  static void Main() {
        const int n = 3;
        double[,] array = new double[n,n]{
                {1,3,9},
                {1,2,0},
                {11,3,3},
         };
            double[] vector = new double[2 * n - 1];
            int index = 0;
            for (int i = n - 1; i > -1; i--){
                double sum = 0;
                for (int j = 0; i + j < n; j++){
                    sum += array[i + j, j];
                }
                vector[index] = sum;
                index++;
            }
            for (int i = 1; i < n; i++){
                double sum = 0;
                for (int j = 0; i + j < n; j++){
                    sum += array[j , i + j];
                }
                vector[index] = sum;
                index++;
            }
            Console.Write("Vector: ");
            for (int i = 0; i < 2 * n - 1; i++) Console.Write($"{vector[i]} ");
            Console.WriteLine();
            for (int i = 0; i < n; i++){
                for (int j = 0; j < n; j++){
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
  }
}