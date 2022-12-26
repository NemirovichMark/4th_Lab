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
        
        for(int i=0; i<7; i++){
            Qsort(0,5,i,a);
            if(i%2==0){
                for(int j=0; j<2; j++) a[i,j]=a[i,j]+a[i,4-j]-(a[i,4-j]=a[i,j]);
            }
        }
        
        Console.WriteLine("There is your answer matrix:");
        for(int i=0; i<7; i++){
            for(int j=0; j<5; j++){
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
