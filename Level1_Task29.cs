using System; 
using System.Linq; 
class HelloWorld { 
    static void Main() { 
        try{
            int n=5,m=7,row=1;
            double[,] a = new double[n,m]; 
            double[,] b = new double[n,m-1]; 
            Random rnd = new Random(); 
            for(int i=0; i<n; i++) 
                for(int j=0; j<m; j++) 
                    a[i,j] = rnd.Next()%20; 
             
           Console.Write("Your random matrix:\n"); 
            for(int i=0; i<n; i++){ 
                for(int j=0; j<m; j++){ 
                    Console.Write("{0} ",a[i,j]); 
                } 
                Console.WriteLine(); 
            } 
            int min=0; 
            for(int i=0; i<m; i++) if(Math.Abs(a[row,i])<Math.Abs(a[row,min])) min=i; 
            if(min==m-1){ 
                Console.Write("\nThe answer matrix:\n"); 
                for(int i=0; i<n; i++){ 
                    for(int j=0; j<m; j++){ 
                        Console.Write("{0} ",a[i,j]); 
                    } 
                    Console.WriteLine(); 
                } 
                return; 
            } 
            int cy=0; 
            for(int i=0; i<n; i++){ 
                cy=0; 
                for(int j=0; j<m; j++){ 
                    if(j==min+1) continue; 
                    b[i,cy++] = a[i,j]; 
                } 
            } 
                     
            Console.Write("\nThe answer matrix:\n"); 
            for(int i=0; i<n; i++){ 
                for(int j=0; j<m-1; j++){ 
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
