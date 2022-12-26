using System;  
using System.Linq;  
class HelloWorld {  
    static void Main() {  
        try{  
            double[,] a = new double[5,8];  
            double[] b = new double[5]{3,1,4,1,5}; 
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
            Console.Write("\nThe array to insert: "); 
            for(int i=0; i<5; i++) Console.Write($" {b[i]}"); 
            Console.Write("\n"); 
            int min=0; 
            for(int i=0; i<7; i++) 
                if(a[4,i]<a[4,min]) min=i; 
            for(int i=0; i<5; i++){ 
                for(int j=7; j>min+1; j--){ 
                    a[i,j-1] = a[i,j] + a[i,j-1] - (a[i,j]=a[i,j-1]); 
                } 
                a[i,min+1]=b[i]; 
            } 
             
            Console.Write("\nThe answer matrix:\n");  
            for(int i=0; i<5; i++){  
                for(int j=0; j<8; j++){  
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
