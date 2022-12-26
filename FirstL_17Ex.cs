using System;
class FirstL_17Ex {
  static void Main() {
            int IndexMinElement;
            double minElement;
            const int row = 4;
            const int column = 4;
            double [,] a = new double[row,column]   {{2,3,1,4},
                                                    {4,1,2,3},
                                                    {1,2,3,4},
                                                    {4,3,2,1}};
            Console.WriteLine("Array: ");
            for (int i = 0; i < row; i++){
                for (int j = 0; j < column; j++){
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < row; i++){
                minElement = a[i, 0];
                IndexMinElement = 0;
                for (int j = 1; j < column; j++) //here we got the min element
                {
                if (a[i, j] < minElement){
                        minElement = a[i,j];
                        IndexMinElement = j;
                    }
                }
                if (IndexMinElement != 0){
                    for (int j = IndexMinElement; j > 0; j--)
                    {
                        a[i, j] = a[i, j - 1];
                    }
                    a[i, 0] = minElement; // here we put the min element to the beggining of the row
                }
            }
            Console.WriteLine($"New array: ");
            for (int i = 0; i < row; i++){
                for (int j = 0; j < column; j++){
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
  }
}