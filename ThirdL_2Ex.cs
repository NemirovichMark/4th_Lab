using System;
class ThirdL_2Ex {
static void Main() {
            const int row = 6, column = 7;
            double[,] a = new double[row,column]{   {1,2,3,4,5,6,7},
                                                    {7,6,5,0,3,3,1},
                                                    {1,2,3,4,5,6,7},
                                                    {7,6,5,4,3,2,1},
                                                    {1,2,3,0,5,6,7},
                                                    {7,6,5,4,3,2,1}};
            for(int i = 0; i < row; i++){
                for(int j = 0; j < column; j++){
                    if(i == 0 || j == 0 || i == row - 1 || j == column - 1){
                        a[i,j] = 0;
                    }
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