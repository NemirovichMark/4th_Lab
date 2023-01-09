using System; 
using System.Linq; 
class HelloWorld { 
    static void Main() { 
            double[,] a = new double[6,7]{{1,2,3,4,5,6,7}, 
                                        {8,9,0,1,2,3,4}, 
                                        {1,6,7,1,1,4,2}, 
                                        {2,2,2,5,6,2,8}, 
                                        {9,3,1,3,3,4,3}, 
                                        {3,7,3,9,4,1,12}}; 
            double[,] b = new double[5,6]; 
            int maxX=0,maxY=0; 
            for(int i=0; i<6; i++){
                for(int j=0; j<7; j++){
                    if(a[maxX,maxY]<a[i,j]){ 
                        maxX=i; 
                        maxY=j; 
                    }
                }
            }
            for(int i= maxX; i < 5;i++){
                for(int j= 0; j < 6 ;j++){
                    a[i,j] = a[i + 1, j];
                }
            }
            for(int i=0;i < 5;i++){
                for(int j= maxY;j < 6 ;j++){
                    a[i,j] = a[i,j+1];
                }
            }
            /*
            for(int i=0; i < 5; i++){
                for(int j=0; j < 6; j++){
                        if((maxX==j || maxX==i )) continue;
                        else
                            b[i,j] = a[i,j];
                }
            } */
            Console.WriteLine("New Array: "); 
            for(int i=0; i<5; i++){ 
                for(int j=0; j<6; j++){ 
                    Console.Write("{0} ",a[i,j]); 
                } 
                Console.WriteLine(); 
            } 
        
    } 
}