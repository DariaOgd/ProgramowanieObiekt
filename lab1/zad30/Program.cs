using System;

namespace MinMax{
    class MinMax {
        static void Main(string[] args){
            Console.WriteLine("Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę: ");
            int c = int.Parse(Console.ReadLine());

            int max = Math.Max(a, Math.Max(b,c));
            int min = Math.Min(a, Math.Min(b,c));
            Console.WriteLine("Największa liczba to {0}\nNajmniejsza to {1}", max, min);

            Console.ReadKey();
            


            
    



           
        }

    }
}
