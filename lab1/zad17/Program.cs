using System;

namespace Liczby_zad17{
    class Liczby_zad17 {
        static void Main(string[] args){
            int start = 100;
            while(start > 0){
                sprawdz(start);
                start--;
            }

            Console.ReadKey();

           

           
        }
        static void sprawdz(int i){
            if(i%3 == 0 && i %2!=0){
                     Console.WriteLine(i);
                }

        }

        

    }
}
