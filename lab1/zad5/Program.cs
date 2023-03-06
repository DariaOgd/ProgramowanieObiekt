using System;

namespace Wyrazenie{
    class Wyrazenie {
        static void Main(string[] args){
            
           
            Console.WriteLine("Podaj liczbę x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę z");
            double z = double.Parse(Console.ReadLine());

            double v = (4*x-y)/(3*((z*z)+1));
            Console.WriteLine(v);
            Console.ReadKey();


           
        }

    }
}
