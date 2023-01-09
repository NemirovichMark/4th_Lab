using System;
class SecondL_7Ex {
  static void Main() {
            double[,] a = new double[6,6] {         {5,2,3,4,5,6},
                                                    {0,1,0,0,0,0},
                                                    {0,0,1,0,0,0},
                                                    {0,0,0,7,0,0},
                                                    {0,0,0,0,1,0},
                                                    {2,3,4,5,1,1}};
            double maxElementD = a[0, 0];
            int indexMaxD = 0;
            for (int i = 0; i < 6; i++){
                if(a[i,i] > maxElementD){
                    maxElementD = a[i,i];
                    indexMaxD = i;
                }
            }
            for (int i = 0; i < indexMaxD; i++){
                for (int j = i + 1; j < 6; j++){
                    a[i,j] = 0;
                }
            }
            Console.WriteLine($"new array: ");
            for (int i = 0; i < 6; i++){
                for (int j = 0; j < 6; j++){
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
  }
}