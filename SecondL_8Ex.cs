using System;
class SecondL_8Ex {
  static void Main() {
            int indexMax1, indexMax2;
            double max1, max2;
            double[,] a = new double[6, 6] {        {1,2,3,4,5,6},
                                                    {5,4,3,9,2,6},
                                                    {1,4,8,6,2,4},
                                                    {1,2,3,4,5,6},
                                                    {6,5,4,3,2,1},
                                                    {2,3,4,5,1,1}};
            for (int i = 0; i < 5; i += 2){
                max1 = a[i, 0];
                indexMax1 = 0;
                max2 = a[i + 1, 0];
                indexMax2 = 0;
                for (int j = 1; j < 6; j++)
                {
                    if (a[i,j] > max1)
                    {
                        max1 = a[i,j];
                        indexMax1 = j;
                    }
                    if (a[i + 1,j] > max2)
                    {
                        max2 = a[i + 1,j];
                        indexMax2 = j;
                    }
                }
                a[i,indexMax1] = max2;
                a[i + 1,indexMax2] = max1;
            }
            Console.WriteLine($"new array: ");
            for(int i = 0; i < 6; i++){
                for(int j = 0; j < 6; j++){
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
  }
}