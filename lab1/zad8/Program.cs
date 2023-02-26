using System;

namespace Maksimum{
    class Maksimum {
        static void Main(string[] args){
            int a;
            int b;
            int max;
            
         Console.Write("Podaj liczbe a: ");
          a = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbe b: ");
         b = int.Parse(Console.ReadLine());

         max = (a > b) ? a : b;
         Console.WriteLine("Maksimum wynosi: " + max);

            



           
        }

    }
}
