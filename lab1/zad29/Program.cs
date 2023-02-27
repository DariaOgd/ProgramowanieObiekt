using System;

namespace MaxMin{
    class MaxMin {
        static void Main(string[] args){

            Random r = new Random();
            
            int i = 0;

            int[] liczby = new int[15];
            while(i < 15){
                int rInt = r.Next(0, 100);
                if(!liczby.Contains(rInt)){
                    liczby[i] = rInt;
                
                    i++;
                }
            }
            Console.WriteLine("Wylosowane liczby to:");
            // for(int x = 0; x <15; x++){
            //     Console.Write("{0}, ",liczby[x]);
            // }

            foreach(int num in liczby){
                Console.Write(num +", ");
            }
            //Console.ReadKey();

            int max = liczby[0];
            int indx = 0;
            for(int j = 0 ; j < liczby.Length;j++){
                if(liczby[j] > max){
                    max = liczby[j];
                    indx = j;
                }
            }
            Console.WriteLine();
            Console.Write("Największa liczba znajduje się na indeksie {0} i wynosi {1}, ",indx, max);

            int min = liczby[0];
            int indx2 = 0;
            for(int j = 0 ; j < liczby.Length;j++){
                if(liczby[j] < min){
                    min = liczby[j];
                    indx2 = j;
                }
            }
            Console.WriteLine();
            Console.Write("Najmniejsza liczba znajduje się na indeksie {0} i wynosi {1}, ",indx2, min);






            
    



           
        }

    }
}
