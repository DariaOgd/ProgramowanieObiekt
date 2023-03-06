using System;

namespace LiczbaParzyszta{
    class LiczbaParzyszta {
        static void Main(string[] args){
            Console.WriteLine("Podaj liczbę:");

            int liczba = Int32.Parse(Console.ReadLine());
            if(liczba %2 == 0){
                Console.WriteLine("Liczba {0} jest parzysta",liczba);

            }
            else{
                Console.WriteLine("Liczba {0} jest nieparzysta", liczba);


            }

            Console.ReadKey();

           
        }

    }
}