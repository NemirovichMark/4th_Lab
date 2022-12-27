using System;
using System.Linq;
using System.Collections.Generic;
class HelloWorld {
    static void Main() {
        try{
            int n=6;
            double[,] a = new double[n,n];
            Random rnd = new Random();
            for(int i=0; i<n; i++)
                for(int j=0; j<n; j++)
                    a[i,j] = rnd.Next()%10;
            Console.WriteLine("Your random matrix:");
            for(int i=0; i<n; i++){
                for(int j=0; j<n; j++)
                    Console.Write($"{a[i,j]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
            int max=0;
            for(int i=0; i<n; i++)
                max=(a[i,i]>a[max,max])?i:max;
            for(int i=0; i<n; i++)
                for(int j=0; j<n; j++)
                    if(i<max&&j>i) a[i,j]=0;
            Console.WriteLine("Your answer matrix:");
            for(int i=0; i<n; i++){
                for(int j=0; j<n; j++)
                    Console.Write($"{a[i,j]} ");
                Console.WriteLine();
            }
        }
        catch{}
    }
}
