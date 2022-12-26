using System;
class SecondL_9Ex {
static void Main() {
            const int row = 6, column = 7;
            double temp;
            double[,] a = new double[row,column]{      {1,2,3,4,5,6,7},
                                                {7,6,5,4,3,2,1},
                                                {1,2,3,4,5,6,7},
                                                {7,6,5,4,3,2,1},
                                                {1,2,3,4,5,6,7},
                                                {7,6,5,4,3,2,1}};
            for (int i = 0; i < row; i++){
                for (int j = 0; j < column/2 ;j++){
                    temp = a[i,j];
                    a[i,j] = a[i, column - 1 - j];
                    a[i,column - 1 - j ] = temp;
                }
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