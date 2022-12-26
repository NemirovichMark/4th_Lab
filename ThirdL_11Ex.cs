using System;
class ThirdL_11Ex {
static void Main() {
            bool flag = false;
            int newRow = 0;
            int k = 0;
            const int row = 6, column = 7;
            double[,] a = new double[row,column]{   {1,2,3,4,5,6,7},
                                                    {7,6,5,0,3,0,1},
                                                    {1,2,3,4,5,6,7},
                                                    {7,6,5,4,3,2,1},
                                                    {1,2,3,0,5,6,7},
                                                    {7,6,5,4,3,2,1}};
            int [] c = new int[row];
            for(int i = 0; i < row; i++){
                for(int j = 0; j < column;j++){
                        if(a[i,j] == 0){
                            flag = true;
                            c[i] = i;
                        }
                    }
                if(flag == false){
                            newRow++;
                        }
                flag = false;
                }
            double [,] b = new double[ newRow ,column];
            for (int i = 0; i < row; i++){
                for (int j = 0; j < column; j++){
                        if(a[i,j] == 0){
                            flag = true;
                            break;
                        }
                    }
                if(flag == false){
                    for(int j = 0; j < column; j++){
                        b[k,j] = a[i,j];
                    }
                    k++;
                }
                flag = false;
            }
            Console.WriteLine($"new array: ");
            for (int i = 0; i < newRow; i++){
                for (int j = 0; j < column; j++){
                    Console.Write($"{b[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); 
        }
    }