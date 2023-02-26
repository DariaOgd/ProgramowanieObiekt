using System;

namespace TotoLotek{
    class TotoLotek {
        static void Main(string[] args){

            Random r = new Random();
            
            int i = 0;

            int[] liczby = new int[100];
            while(i < 4){
                int rInt = r.Next(0, 100);
                if(!liczby.Contains(rInt)){
                    liczby[i] = rInt;
                
                    i++;
                }
            }
            Console.WriteLine("Wylosowane liczby to:");
            for(int x = 0; x <4; x++){
                Console.Write("{0}, ",liczby[x]);
            }
            Console.ReadKey();





            
    



           
        }

    }
}
