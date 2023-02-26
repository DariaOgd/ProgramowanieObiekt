using System;

namespace Gra{
    class Gra {
        static void Main(string[] args){
            var random = new Random();
            int n = random.Next(1,9);
            Console.WriteLine("Podaj liczbę z przedziału (1,9)");
            int m = int.Parse(Console.ReadLine());

            while(n != m){
                if(m > n){
                    Console.WriteLine("Liczba za duża!");
                    Console.WriteLine("Podaj liczbę z przedziału (1,9)");
                    m = int.Parse(Console.ReadLine());
                }
                else if(m < n){
                    Console.WriteLine("Liczba za mała!");
                    Console.WriteLine("Podaj liczbę z przedziału (1,9)");
                    m = int.Parse(Console.ReadLine());

                }

            }
            Console.WriteLine("Brawo zgadłeś!");
            Console.ReadKey();








           
        }

    }
}
