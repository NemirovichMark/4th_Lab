using System;
using System.Linq;
class HelloWorld {
    static void Main() {
        try{
            double[,] a = new double[5,5]{{3,1,4,1,5},
                                          {6,5,3,22,8},
                                          {9,8,2,14,8},
                                          {2,6,4,3,3},
                                          {2,7,9,8,0}};
            int max=0;
            for(int i=0; i<5; i++)
                if(a[i,i]>a[max,max]) max=i;
            for(int i=0; i<5; i++)
                a[i,3] = a[i,3] + a[i,max] - (a[i,max]=a[i,3]);
            Console.Write("The answer matrix:\n");
            for(int i=0; i<5; i++){
                for(int j=0; j<5; j++){
                    Console.Write("{0} ",a[i,j]);
                }
                Console.WriteLine();
            }
        }
        catch{
            Console.WriteLine("An error occured");
        }
    }
}
