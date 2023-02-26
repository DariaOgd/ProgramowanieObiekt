using System;

namespace SilniaRekurencja{
    class SilniaRekurencja {
        static void Main(string[] args){
            Console.WriteLine("Zad2");
            Console.WriteLine("Podaj liczbę");
            int liczba1 = Int32.Parse(Console.ReadLine());
             Console.WriteLine(wyliczSilnie(liczba1));
  

        }
        static int wyliczSilnie (int a){
            if(a == 1){
                return 1;
            }
            return a*wyliczSilnie(a-1);
        }
    }
}
