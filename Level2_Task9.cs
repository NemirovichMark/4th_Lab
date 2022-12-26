using System;
using System.Linq;
using System.Collections.Generic;
class HelloWorld {
    static void Main() {
        try{
            double[,] a = new double[6,7];
            Random rnd = new Random();
            for(int i=0; i<6; i++)
                for(int j=0; j<7; j++)
                    a[i,j] = rnd.Next()%10;
            Console.WriteLine("Your random matrix:");
            for(int i=0; i<6; i++){
                for(int j=0; j<7; j++)
                    Console.Write($"{a[i,j]} ");
                Console.WriteLine();
            }
            for(int i=0; i<6; i++)
                for(int j=0; j<3; j++)
                    a[i,j] = a[i,6-j] + a[i,j] - (a[i,6-j]=a[i,j]);
            Console.WriteLine("\nYour answer matrix:");
            for(int i=0; i<6; i++){
                for(int j=0; j<7; j++)
                    Console.Write($"{a[i,j]} ");
                Console.WriteLine();
            }
        }
        catch{}
    }
}
