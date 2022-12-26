using System;
using System.Linq;
class HelloWorld {
    static void Main() {
        try{
            double sum=0;
            double[,] a = new double[4,7]{{3,1,4,1,5,9,2},
                                          {6,5,3,5,8,9,7},
                                          {9,3,2,3,8,4,6},
                                          {2,6,5,3,5,8,9}};
            double[] mins = new double[4];
            Console.Write("Do you want enter your numbers or want to see this program working with a initialized with numbers of Pi? (Pi/My): ");
            string inp = Console.ReadLine();
            if(inp=="My"){
                for(int i=0; i<4;i++)
                    for(int j=0; j<7; j++){
                        a[i,j] = double.Parse(Console.ReadLine());
                        if(j==0) mins[i]=a[i,j];
                        else if(a[i,j]<mins[i]) mins[i]=a[i,j];
                    }
            }
            else{
                for(int i=0; i<4;i++)
                    for(int j=0; j<7; j++)
                        if(j==0) mins[i]=a[i,j];
                        else if(a[i,j]<mins[i]) mins[i]=a[i,j];
            }
            Console.Write("Answer:");
            foreach(var i in mins)
                Console.Write(" {0}",i);
        }
        catch{Console.Write("error");}
    }
}
