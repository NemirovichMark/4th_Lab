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
                    a[i,j] = rnd.Next()%20;
            Console.WriteLine("Your random matrix:");
            for(int i=0; i<n; i++){
                for(int j=0; j<n; j++)
                    Console.Write($"{a[i,j]} ");
                Console.WriteLine();
            }
            int[] maxes = new int[n];
            for(int i=0; i<n;i++) maxes[i]=0;
            for(int i=0; i<n; i++)
                for(int j=0; j<n; j++)
                    maxes[i]=(a[i,j]>a[i,maxes[i]])?j:maxes[i];
            for(int i=0; i<n; i+=2){
                a[i,maxes[i]] = a[i+1,maxes[i+1]] + a[i,maxes[i]] - (a[i+1,maxes[i+1]] = a[i,maxes[i]]);
            }
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
