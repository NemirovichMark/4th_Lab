using System;
class FirstL_29Ex {
  static void Main() {
            double minElement;
            double[,] f = new double[5,7] {     {1,2,3,4,5,6,7},
                                                {9,5,6,4,5,1,7}, //second row
                                                {0,0,0,0,0,0,0},
                                                {0,0,0,0,0,0,0},
                                                {0,0,0,0,0,0,0}};
            Console.WriteLine("array: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write($"{f[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            minElement = Math.Abs(f[1, 0]);
            int IndexMinElement = 0;
            for (int i = 0; i < 7; i++){
                if (Math.Abs(f[1,i]) < minElement){
                    minElement = Math.Abs(f[1,i]);
                    IndexMinElement = i;
                }
            }
            
            for (int i = 0; i < 5; i++){
                for (int j = IndexMinElement + 1; j < 6; j++){
                    f[i,j] = f[i,j + 1];
                }
            }
            Console.WriteLine($"new array: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{f[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
  }
}