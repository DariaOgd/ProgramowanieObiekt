using System;

namespace Program{
    class Program {
        static void Main(string[] args){
            Console.WriteLine("Zad2");
            Console.WriteLine("Podaj liczbę");
            int liczba1 = Int32.Parse(Console.ReadLine());
            // Console.WriteLine(silnia(liczba1));
            int helper = 1;
            for(int i =1; i < liczba1+1; i++){
                helper*=i;

            }
            Console.WriteLine(helper);

        }
        static int silnia(int a){
            if(a == 1){
                return 1;
            }
            return a*silnia(a-1);
        }
    }
}
