/*
. В матрице размером n  n сформировать два одномерных масdoсива: в один переслать по строкам верхний треугольник матрицы, 
включая элементы главной диагонали, в другой – нижний треугольник. Вывести верхний и нижний треугольники по строкам
*/

using System;
class ThirdL_10Ex {
static void Main() {
            int k = 0; // index of b
            int z = 0; // index of c
            const int n = 3;
            double[,] a = new double[n,n] {         {11,12,13},
                                                    {19,11,16},
                                                    {27,18,19},};
            // i find the length of the arrays b and c
            for (int i = 0; i < n; i++){
                for (int j = 0; j < n; j++){
                    if(i <= j){
                        k++;
                    }else if(i > j){
                        z++;
                    }
                }
            }
            double [] b = new double[k];  // b for upper triangle
            double [] c = new double[z];  // c for lower triangle
            k = 0;
            z = 0;
            for (int i = 0; i < n; i++){
                for (int j = 0; j < n; j++){
                    if(i <= j){ 
                        b[k] = a[i,j];
                        k++;
                    }else if(i > j){ 
                        c[z] = a[i,j];
                        z++;
                    }
                }
            }
            Console.WriteLine($"lower triangle: ");
            int counter = 0;
            for(int i = 1; i < z; i++){
                for(int j = 0; j < i; j++){
                    Console.Write($"{c[counter++]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"upper triangle: ");
            counter = 0;
            for(int i = n; i > 0; i--){
                for(int j = 0; j < i; j++){
                    Console.Write($"{b[counter++]} ");
                }
                Console.WriteLine();
            }
            insertSort(c);
            Console.WriteLine($"LOWER SORTED : ");
            counter = 0;
            for(int i = 1; i < z; i++){
                for(int j = 0; j < i; j++){
                    Console.Write($"{c[counter++]} ");
                }
                Console.WriteLine();
            }
            shakerCocktailSort(b);
            Console.WriteLine($"UPPER SORTED: ");
            counter = 0;
            for(int i = n; i > 0; i--){
                for(int j = 0; j < i; j++){
                    Console.Write($"{b[counter++]} ");
                }
                Console.WriteLine();
            }
            
            ////////////////////////////////////////////////////////////////
        static void shakerCocktailSort(double[] a){
        bool flag = true;
        int start = 0;
        int end = a.Length;
        while(flag){
            flag = false;  
            for (int i = start; i < end - 1; ++i) {
                if (a[i] > a[i + 1]) {
                    double temp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = temp;
                    flag = true;
                }
            }
            if (flag == false) break;
            flag = false;
            end = end - 1;
            for (int i = end - 1; i >= start; i--){
                if (a[i] > a[i+1]) {
                    double temp = a[i];
                    a[i] = a[i+1];
                    a[i+1] = temp;
                    flag = true;
                }
            }
            start += 1;
        }
    }
        static void insertSort(double [] a){
        int n = a.Length;
        for(int i = 1; i < n; ++i){
            double temp = a[i];
            int j = i - 1;
            while (j >= 0 && a[j] > temp){
                a[j+1] = a[j];
                j = j - 1;
            }
            a [j+1] = temp;
            }
        }
    }
}
