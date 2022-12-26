using System;
class HelloWorld{
    static void SwapRows(double[,] a, int first, int second){
        for(int i=0; i<5; i++)
            a[first,i] = a[first,i] + a[second,i] - (a[second,i]=a[first,i]);
    }
    static void Main (){
        double[,] a = new double[7,5];
        Random rnd = new Random();
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
        
        int[] pos = new int[7]{0,0,0,0,0,0,0};
            for(int i=0; i<7; i++)
                for(int j=0; j<5; j++)
                    pos[i]+=(a[i,j]>0)?1:0;
            for(int j=0; j<6; j++)
                for(int i=0; i<6; i++)
                    if(pos[i]<pos[i+1]){
                        SwapRows(a,i,i+1);
                        pos[i] = pos[i+1] + pos[i] - (pos[i+1]=pos[i]);
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
