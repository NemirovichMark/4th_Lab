using System;
using System.Linq;
class HelloWorld {
    static void Main() {
        try{
            int n=4,m=7;
            Random rnd = new Random();
            double[,] a = new double[n,m];
            double[] mins = new double[n];
            Console.Write("Do you want enter your numbers or want to see this program working initialized with random numbers? (Rnd/My): ");
            string inp = Console.ReadLine();
            if(inp=="My"){
                for(int i=0; i<n;i++)
                    for(int j=0; j<m; j++){
                        a[i,j] = double.Parse(Console.ReadLine());
                        if(j==0) mins[i]=a[i,j];
                        else if(a[i,j]<mins[i]) mins[i]=a[i,j];
                    }
            }
            else{
                for(int i=0; i<n;i++){
                    for(int j=0; j<m; j++){
                        a[i,j] = rnd.Next()%10;
                        Console.Write($"{a[i,j]} ");
                        if(j==0) mins[i]=a[i,j];
                        else if(a[i,j]<mins[i]) mins[i]=a[i,j];
                    }
                    Console.WriteLine();
                }
            }
            Console.Write("Answer:");
            foreach(var i in mins)
                Console.Write(" {0}",i);
        }
        catch{Console.Write("error");}
    }
}
