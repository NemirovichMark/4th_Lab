using System;
class HelloWorld{
    static void Main (){
        int n;
        Console.Write("Enter matrix order: ");
        if(!int.TryParse(Console.ReadLine(),out n)){
            Console.Write("Wrong input");
            return;
        }
        double[,] a = new double[n,n];
        Random rnd = new Random();
        for(int i=0; i<n; i++)
            for(int j=0; j<n; j++)
                a[i,j]=rnd.Next()%19+1;
        Console.Write("There is your random matrix:\n");
        for(int i=0; i<n; i++){
            for(int j=0; j<n; j++){
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
        
        for(int i=0; i<n; i++)
            a[0,i]=a[i,0]=a[n-1,i]=a[i,n-1]=0;
        
        Console.WriteLine("There is your answer matrix:");
        for(int i=0; i<n; i++){
            for(int j=0; j<n; j++){
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
