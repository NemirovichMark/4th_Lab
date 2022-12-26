using System; 
using System.Linq; 
class HelloWorld { 
    static void Main() { 
        try{ 
            double[,] a = new double[5,7]; 
            double[,] b = new double[5,6]; 
            Random rnd = new Random(); 
            for(int i=0; i<5; i++) 
                for(int j=0; j<7; j++) 
                    a[i,j] = rnd.Next()%20; 
             
           Console.Write("Your random matrix:\n"); 
            for(int i=0; i<5; i++){ 
                for(int j=0; j<7; j++){ 
                    Console.Write("{0} ",a[i,j]); 
                } 
                Console.WriteLine(); 
            } 
            int min=0; 
            for(int i=0; i<7; i++) if(Math.Abs(a[1,i])<Math.Abs(a[1,min])) min=i; 
            if(min==6){ 
                Console.Write("\nThe answer matrix:\n"); 
                for(int i=0; i<5; i++){ 
                    for(int j=0; j<7; j++){ 
                        Console.Write("{0} ",a[i,j]); 
                    } 
                    Console.WriteLine(); 
                } 
                return; 
            } 
            int cy=0; 
            for(int i=0; i<5; i++){ 
                cy=0; 
                for(int j=0; j<7; j++){ 
                    if(j==min+1) continue; 
                    b[i,cy++] = a[i,j]; 
                } 
            } 
                     
            Console.Write("\nThe answer matrix:\n"); 
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
