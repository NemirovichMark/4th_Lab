using System;
using System.Linq;
class HelloWorld {
    static void Main() {
        try{
            double sum=0;
            Random rnd = new Random();
            int n=4;
            double[,] a = new double[n,n];
            Console.Write("Do you want to enter your numbers or want to see this program working initialized with random numbers? (Rnd/My): ");
            string inp = Console.ReadLine();
            if(inp=="My"){
                for(int i=0; i<n;i++)
                    for(int j=0; j<n; j++){
                        a[i,j] = double.Parse(Console.ReadLine());
                        if(i==j) sum+=a[i,j];
                    }
            }
            else if(inp=="Rnd"){
                for(int i=0; i<n; i++){
                    for(int j=0; j<n; j++){
                        a[i,j] = rnd.Next()%21-10;
                        Console.Write($"{a[i,j]} ");
                        if(i==j) sum+=a[i,j];
                    }
                    Console.WriteLine();
                }
            }
            else{
                Console.Write("Good bye");
                return;
            }
            Console.Write("Answer: {0}",sum);
        }
        catch{Console.Write("error");}
    }
}
