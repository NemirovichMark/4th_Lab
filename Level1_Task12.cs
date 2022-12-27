using System;
using System.Linq;
class HelloWorld {
    static void Main() {
        try{
            int n=6,m=7;
            Random rnd = new Random();
            double[,] a = new double[n,m];
            double[,] b = new double[n-1,m-1];
            int mx=0,my=0;
            for(int i=0; i<n; i++){
                for(int j=0; j<m; j++){
                    a[i,j] = rnd.Next()%10;
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
                    
            for(int i=0; i<n; i++)
                for(int j=0; j<m; j++)
                    if(a[mx,my]<a[i,j]){
                        mx=i;
                        my=j;
                    }
            int cx=0,cy=0;
            for(int i=0; i<n; i++){
                if(i==mx) continue;
                cy=0;
                for(int j=0; j<m; j++){
                    if(j==my) continue;
                    b[cx,cy]=a[i,j];
                    cy++;
                }
                cx++;
            }
            Console.Write("The answer matrix:\n");
            for(int i=0; i<n-1; i++){
                for(int j=0; j<m-1; j++){
                    Console.Write("{0} ",b[i,j]);
                }
                Console.WriteLine();
            }
        }
        catch{
            Console.WriteLine("An error occured");
        }
    }
}
