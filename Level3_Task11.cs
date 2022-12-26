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
        for(;q<5&&a[row,q]<=pivot;q++);
        Qsort(l,p,row,a);
        Qsort(q,r,row,a);
    }
    static void Main (){
        double[,] a = new double[7,5];
        for(int i=0; i<7; i++)
            for(int j=0; j<5; j++)
                a[i,j]=rnd.Next()%21-10;
        Console.Write("There is your random matrix:\n");
        for(int i=0; i<7; i++){
            for(int j=0; j<5; j++){
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
        bool flag=true;
        int[] non_zero_rows = new int[0];
        for(int i=0; i<7; i++){
            flag=true;
            for(int j=0; j<5; j++){
                if(a[i,j]==0) flag=false;
            }
            if(flag){
                Array.Resize(ref non_zero_rows, non_zero_rows.Length+1);
                non_zero_rows[non_zero_rows.Length-1]=i;
            }
        }
        
        double[,] b = new double[non_zero_rows.Length,5];
        int counter=0;
        foreach(var i in non_zero_rows){
            for(int j=0; j<5; j++)
                b[counter,j]=a[i,j];
            counter++;
        }
        
        Console.WriteLine("There is your answer matrix:");
        for(int i=0; i<non_zero_rows.Length; i++){
            for(int j=0; j<5; j++){
                Console.Write($"{b[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
