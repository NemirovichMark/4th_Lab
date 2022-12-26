using System;
using System.Linq;
class HelloWorld {
    static void Main() {
        try{
            double[,] a = new double[6,7]{{3,1,4,1,5,9,2},
                                          {6,5,3,5,8,9,7},
                                          {9,3,2,3,8,4,6},
                                          {2,6,4,3,3,8,3},
                                          {2,7,9,5,0,2,8},
                                          {8,4,1,9,7,1,5}};
            double[,] b = new double[5,6];
            int mx=0,my=0;
            for(int i=0; i<6; i++)
                for(int j=0; j<7; j++)
                    if(a[mx,my]<a[i,j]){
                        mx=i;
                        my=j;
                    }
            int cx=0,cy=0;
            for(int i=0; i<6; i++){
                if(i==mx) continue;
                cy=0;
                for(int j=0; j<7; j++){
                    if(j==my) continue;
                    b[cx,cy]=a[i,j];
                    cy++;
                }
                cx++;
            }
            Console.Write("The answer matrix:\n");
            for(int i=0; i<5; i++){
                for(int j=0; j<6; j++){
                    Console.Write("{0} ",b[i,j]);
                }
                Console.WriteLine();
            }
        }
        catch{
            Console.WriteLine("An error occured");
        }
    }
}
