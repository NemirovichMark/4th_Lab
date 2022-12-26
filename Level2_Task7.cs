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
                    a[i,j] = rnd.Next()%10;
            Console.WriteLine("Your random matrix:");
            for(int i=0; i<6; i++){
                for(int j=0; j<6; j++)
                    Console.Write($"{a[i,j]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
            int max=0;
            for(int i=0; i<6; i++)
                max=(a[i,i]>a[max,max])?i:max;
            for(int i=0; i<6; i++)
                for(int j=0; j<6; j++)
                    if(i<max&&j>i) a[i,j]=0;
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
