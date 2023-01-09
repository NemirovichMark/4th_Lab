using System;
class ThirdL_4Ex {
static void Main() {
            const int n = 3;
            double[,] a = new double[n,n]{
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };
            for (int i = n / 2; i < n; i++){
                for (int j = 0; j <= i; j++){
                    a[i,j] = 0;
                }
            }
            Console.WriteLine($"new array: ");
            for (int i = 0; i < n; i++){
                for (int j = 0; j < n;j++){
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
    }
}