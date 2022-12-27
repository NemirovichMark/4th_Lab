using System;
using System.Linq;
class HelloWorld {
    static void Main() {
        try{
            int n=5,column=3;
            double[,] a = new double[n,n];
            Random rnd = new Random();
            int max=0;
            for(int i=0; i<n; i++){
                for(int j=0; j<n; j++){
                    a[i,j] = rnd.Next()%10;
                    Console.Write($"{a[i,j]} ");
                    if(i==j&&a[i,j]>a[max,max]) max=i;
                }
                Console.WriteLine();
            }
            for(int i=0; i<n; i++)
                a[i,column] = a[i,column] + a[i,max] - (a[i,max]=a[i,column]);
            Console.Write("The answer matrix:\n");
            for(int i=0; i<n; i++){
                for(int j=0; j<n; j++){
                    Console.Write("{0} ",a[i,j]);
                }
                Console.WriteLine();
            }
        }
        catch{
            Console.WriteLine("An error occured");
        }
    }
}
