using System;
using System.Linq;
class HelloWorld {
    static void Main() {
        try{
            double sum=0;
            double[,] a = new double[4,4]{{3,1,4,1},
                                          {5,9,2,6},
                                          {5,3,5,8},
                                          {9,7,9,3}};
            Console.Write("Do you want enter your numbers or want to see this program working with a initialized with numbers of Pi? (Pi/My): ");
            string inp = Console.ReadLine();
            if(inp=="My"){
                for(int i=0; i<4;i++)
                    for(int j=0; j<4; j++){
                        a[i,j] = double.Parse(Console.ReadLine());
                        if(i==j) sum+=a[i,j];
                    }
            }
            else{
                for(int i=0; i<4;i++)
                    for(int j=0; j<4; j++)
                        if(i==j) sum+=a[i,j];
            }
            Console.Write("Answer: {0}",sum);
        }
        catch{Console.Write("error");}
    }
}
