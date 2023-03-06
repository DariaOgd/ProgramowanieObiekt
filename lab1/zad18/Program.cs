using System;

namespace Liczby_zad18{
    class Liczby_zad18 {
        static void Main(string[] args){
            int liczba = 100;
            do {
                sprawdz(liczba);
                liczba--;
            }
            while(liczba > 0);

            Console.ReadKey();
           

           
        }
        static void sprawdz(int i){
            if(i%3 == 0 && i %2!=0){
                     Console.WriteLine(i);
                }

        }

        

    }
}
