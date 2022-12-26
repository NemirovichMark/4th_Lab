using System;
using System.Linq;
using System.Collections.Generic;
class HelloWorld {
    static void Main() {
        try{
            double[,] a = new double[6,6];
            Random rnd = new Random();
            for(int i=0; i<6; i++)
                for(int j=0; j<6; j++)
                    a[i,j] = rnd.Next()%20;
            Console.WriteLine("Your random matrix:");
            for(int i=0; i<6; i++){
                for(int j=0; j<6; j++)
                    Console.Write($"{a[i,j]} ");
                Console.WriteLine();
            }
            int[] maxes = new int[6]{0,0,0,0,0,0};
            for(int i=0; i<6; i++)
                for(int j=0; j<6; j++)
                    maxes[i]=(a[i,j]>a[i,maxes[i]])?j:maxes[i];
            for(int i=0; i<6; i+=2){
                a[i,maxes[i]] = a[i+1,maxes[i+1]] + a[i,maxes[i]] - (a[i+1,maxes[i+1]] = a[i,maxes[i]]);
            }
            Console.WriteLine("Your answer matrix:");
            for(int i=0; i<6; i++){
                for(int j=0; j<6; j++)
                    Console.Write($"{a[i,j]} ");
                Console.WriteLine();
            }
        }
        catch{}
    }
}
