using System;

namespace TrojkatTekst{
    class TrojkatTekst {
        static void Main(string[] args){
            int k =1;
            int rows= 4 ;
            for(int i=1;i<=rows;i++)
            {
	            for(int j=1;j<=i;j++)
	            Console.Write("{0} ",k++);
	            Console.Write("\n");
            }

            Console.ReadKey();
             
             

            


            
    



           
        }

    }
}
