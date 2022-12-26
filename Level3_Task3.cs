using System;
class HelloWorld{
    static void Main (){
        int n;
        Console.Write("Enter matrix order: ");
        if(!int.TryParse(Console.ReadLine(),out n)){
            Console.Write("Wrong input");
            return;
        }
        if(n<=0){
            Console.Write("There is no answer array");
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
        
        double[] sum = new double[2*n-1];
        for(int i=0; i<sum.Length; i++) sum[i]=0;
        
        for(int i=0; i<n; i++){
            for(int j=0; j<n&&(i+j)<n; j++)
                sum[sum.Length/2+i]+=a[j,i+j];

            for(int j=0; j<n&&(i+j)<n; j++)
                sum[sum.Length/2-i]+=a[i+j,j];
        }
        sum[sum.Length/2]/=2;
        Console.Write("There is your answer array:");
        foreach(var i in sum) Console.Write($" {i}");
    }
}
