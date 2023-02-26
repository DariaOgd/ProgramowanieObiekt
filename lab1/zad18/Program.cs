using System;

namespace Liczby_zad17{
    class Liczby_zad17 {
        static void Main(string[] args){
            int liczba = 100;
            do {
                sprawdz(liczba);
                liczba--;
            }
            while(liczba > 0);
           

           
        }
        static void sprawdz(int i){
            if(i%3 == 0 && i %2!=0){
                     Console.WriteLine(i);
                }

        }

        

    }
}
