using System;
class HelloWorld{
    static Random rnd = new Random();
    static void Qsort(int l, int r, int row, double[,] a){
        if((r-l)<=1) return;
        double pivot = a[row, l+rnd.Next()%(r-l)];
        int m=l;
        for(int i=l; i<r; i++)
            if(a[row,i]<pivot)
                a[row,i]=a[row,i]+a[row,m]-(a[row,m++]=a[row,i]);
        int p=l,q=l;
        for(;a[row,p]<pivot;p++);
        for(;q<a.GetLength(1)&&a[row,q]<=pivot;q++);
        Qsort(l,p,row,a);
        Qsort(q,r,row,a);
    }
    static void Main (){
        int n=7,m=5;
        double[,] a = new double[n,m];
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
        bool flag=true;
        int[] non_zero_rows = new int[0];
        for(int i=0; i<n; i++){
            flag=true;
            for(int j=0; j<m; j++){
                if(a[i,j]==0) flag=false;
            }
            if(flag){
                Array.Resize(ref non_zero_rows, non_zero_rows.Length+1);
                non_zero_rows[non_zero_rows.Length-1]=i;
            }
        }
        
        double[,] b = new double[non_zero_rows.Length,m];
        int counter=0;
        foreach(var i in non_zero_rows){
            for(int j=0; j<m; j++)
                b[counter,j]=a[i,j];
            counter++;
        }
        
        Console.WriteLine("There is your answer matrix:");
        for(int i=0; i<non_zero_rows.Length; i++){
            for(int j=0; j<m; j++){
                Console.Write($"{b[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
