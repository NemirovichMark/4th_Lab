using System;
class ThirdL_8Ex {
  static void Main() {
         double[,] a = new double[7, 5]
            {
                {-2,-2,-2,-2,-2},
                {-2,1,-2,-2,-2},
                {-2,1,-2,-2,1},
                {-2,1,-2,1,1},
                {-2,1,1,1,1 },
                {1,1,1,1,1 },
                {-1,-2,-2,-2,1},
            };
            double[,] b = new double[7, 5];
            int[] arr = new int[7];
            int counter = 0; //counter of positives
            int temp = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a[i,j] >= 0)
                    {
                        counter++;
                    }
                }
                arr[i] = counter;
                counter = 0;
            }
            int max = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                        temp = j;
                    }
                }
                for (int j = 0; j < 5; j++)
                {
                    b[i, j] = a[temp, j];
                }
                arr[temp] = 0;
                max = 0;
            }
            Console.WriteLine($"new array: ");
            for (int i = 0; i < 7; i++){
                for (int j = 0; j < 5; j++){
                    Console.Write($"{b[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
    }
}
