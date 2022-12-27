using System;  
using System.Linq;  
class HelloWorld {  
    static void Main() {  
        try{ 
            int n=5,m=8,row=4;
            Random rnd = new Random();  
            double[,] a = new double[n,m];  
            double[] b = new double[n];
            for(int i=0; i<n; i++) b[i]=rnd.Next()%10;
            
            for(int i=0; i<n; i++)  
                for(int j=0; j<m-1; j++)  
                    a[i,j] = rnd.Next()%20; 
              
           Console.Write("Your random matrix:\n");  
            for(int i=0; i<n; i++){  
                for(int j=0; j<m-1; j++){  
                    Console.Write("{0} ",a[i,j]);  
                }  
                Console.WriteLine();  
            } 
            Console.Write("\nThe array to insert: "); 
            for(int i=0; i<n; i++) Console.Write($" {b[i]}"); 
            Console.Write("\n"); 
            int min=0; 
            for(int i=0; i<m-1; i++) 
                if(a[row,i]<a[row,min]) min=i; 
            for(int i=0; i<n; i++){ 
                for(int j=m-1; j>min+1; j--){ 
                    a[i,j-1] = a[i,j] + a[i,j-1] - (a[i,j]=a[i,j-1]); 
                } 
                a[i,min+1]=b[i]; 
            } 
             
            Console.Write("\nThe answer matrix:\n");  
            for(int i=0; i<n; i++){  
                for(int j=0; j<m; j++){  
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
