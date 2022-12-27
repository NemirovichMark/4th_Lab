using System;
class HelloWorld{
    static void SwapRows(double[,] a, int first, int second){
        for(int i=0; i<a.GetLength(1); i++)
            a[first,i] = a[first,i] + a[second,i] - (a[second,i]=a[first,i]);
    }
    static void Main (){
        int n=7,m=5;
        double[,] a = new double[n,m];
        Random rnd = new Random();
        for(int i=0; i<n; i++)
            for(int j=0; j<m; j++)
                a[i,j]=rnd.Next()%21-10;
        Console.Write("There is your random matrix:\n");
        for(int i=0; i<n; i++){
            for(int j=0; j<m; j++){
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
        
        int[] pos = new int[n];
        for(int i=0; i<n; i++) pos[i]=0;
        for(int i=0; i<n; i++)
            for(int j=0; j<m; j++)
                pos[i]+=(a[i,j]>0)?1:0;
        bool flag = true;
        for(int j=0; flag; j++){
            flag = false;
            for(int i=0; i<n-1; i++)
                if(pos[i]<pos[i+1]){
                    flag = true;
                    SwapRows(a,i,i+1);
                    pos[i] = pos[i+1] + pos[i] - (pos[i+1]=pos[i]);
                    break;
                }
        }
        
        Console.WriteLine("There is your answer matrix:");
        for(int i=0; i<n; i++){
            for(int j=0; j<m; j++){
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
