using System;
using System.Linq;
using System.Collections.Generic;
class HelloWorld {
    static void Main() {
        try{
            int n=6,m=7;
            double[,] a = new double[n,m];
            Random rnd = new Random();
            for(int i=0; i<n; i++)
                for(int j=0; j<m; j++)
                    a[i,j] = rnd.Next()%10;
            Console.WriteLine("Your random matrix:");
            for(int i=0; i<n; i++){
                for(int j=0; j<m; j++)
                    Console.Write($"{a[i,j]} ");
                Console.WriteLine();
            }
            for(int i=0; i<n; i++)
                for(int j=0; j<m/2; j++)
                    a[i,j] = a[i,m-1-j] + a[i,j] - (a[i,m-1-j]=a[i,j]);
            Console.WriteLine("\nYour answer matrix:");
            for(int i=0; i<n; i++){
                for(int j=0; j<m; j++)
                    Console.Write($"{a[i,j]} ");
                Console.WriteLine();
            }
        }
        catch{}
    }
}
