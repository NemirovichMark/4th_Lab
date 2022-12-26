using System;
using System.Linq;
class FirstL_13Ex {
    static void Main() {
            double[,] a = new double[5,5]{{9,1,4,1,5},
                                          {6,5,3,1,8},
                                          {5,8,2,1,8},
                                          {2,6,4,1,3},
                                          {9,7,1,8,0}};
            int maxD=0;
            for(int i=0; i<5; i++)
                if(a[i,i]>a[maxD,maxD]) maxD=i;
            double [] aux = new double[5]; 
            for(int i=0; i<5; i++){
                aux[i] = a[i,3];
                a[i,3] = a[i,maxD];
                a[i,maxD] = aux[i];
            }
             Console.WriteLine("New Array: "); 
            for(int i=0; i<5; i++){ 
                for(int j=0; j<6; j++){ 
                    Console.Write("{0} ",a[i,j]); 
                } 
                Console.WriteLine(); 
            } 
    }
}