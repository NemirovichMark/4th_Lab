using System;
using System.Linq;
using System.Collections.Generic;
class HelloWorld {
    static void SwapRows(double[,] a, int first, int second){
        for(int i=0; i<5; i++)
            a[first,i] = a[first,i] + a[second,i] - (a[second,i]=a[first,i]);
    }
    static void Main() {
        try{
            double[,] a = new double[7,5];
            Random rnd = new Random();
            for(int i=0; i<7; i++)
                for(int j=0; j<5; j++)
                    a[i,j] = rnd.Next()%10;
            Console.WriteLine("Your random matrix:");
            for(int i=0; i<7; i++){
                for(int j=0; j<5; j++)
                    Console.Write($"{a[i,j]} ");
                Console.WriteLine();
            }
            int[] mins = new int[7]{0,0,0,0,0,0,0};
            for(int i=0; i<7; i++)
                for(int j=0; j<5; j++)
                    mins[i]=(a[i,j]<a[i,mins[i]])?j:mins[i];
            for(int j=0; j<6; j++)
                for(int i=0; i<6; i++)
                    if(a[i,mins[i]]<a[i+1,mins[i+1]]){
                        SwapRows(a,i,i+1);
                        mins[i] = mins[i+1] + mins[i] - (mins[i+1]=mins[i]);
                    }
            Console.WriteLine("\nYour answer matrix:");
            for(int i=0; i<7; i++){
                for(int j=0; j<5; j++)
                    Console.Write($"{a[i,j]} ");
                Console.WriteLine();
            }
        }
        catch{}
    }
}
