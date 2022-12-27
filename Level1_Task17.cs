using System;
using System.Linq;
class HelloWorld {
    static void Main() {
        try{
            Console.Write("Introduce n ans m: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            double[,] a = new double[n,m];
            Random rnd = new Random();
            for(int i=0; i<n; i++)
                for(int j=0; j<m; j++)
                    a[i,j] = rnd.Next()%20;
                    
           Console.Write("Your random matrix:\n");
            for(int i=0; i<n; i++){
                for(int j=0; j<m; j++){
                    Console.Write("{0} ",a[i,j]);
                }
                Console.WriteLine();
            }
            int min=0;
            double tmp;
            for(int i=0; i<n; i++){
                min=0;
                for(int j=0; j<m; j++){
                    if(a[i,j]<a[i,min])
                        min=j;
                }
                tmp=a[i,min];
                for(int j=min; j>0; j--)
                    a[i,j] = a[i,j-1];
                a[i,0] = tmp;
            }
                    
            Console.Write("\nThe answer matrix:\n");
            for(int i=0; i<n; i++){
                for(int j=0; j<m; j++){
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
