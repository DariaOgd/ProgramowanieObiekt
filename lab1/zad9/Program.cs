using System;

namespace Maksimum2{
    class Maksimum2 {
        static void Main(string[] args){
            int a;
            int b;
            int c;
            int d;
            int max;
            
         Console.Write("Podaj liczbe a: ");
          a = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbe b: ");
         b = int.Parse(Console.ReadLine());
          Console.Write("Podaj liczbe c: ");
          c = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbe d: ");
         d = int.Parse(Console.ReadLine());

         int x1 = (a > b) ? a : b;
         int x2  = (c > d) ? c : d;

         max = (x1 > x2) ? x1 : x2;
         Console.WriteLine("Maksimum wynosi: " + max);

         Console.ReadKey();

            



           
        }

    }
}
