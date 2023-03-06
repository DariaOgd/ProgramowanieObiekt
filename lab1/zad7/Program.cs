using System;

namespace Podatek{
    class Podatek {
        static void Main(string[] args){
            
            double vat = 0.22;
           
            Console.WriteLine("Podaj cene netto");
            double c = double.Parse(Console.ReadLine());
            double podatek = c*vat;
            Console.WriteLine(podatek);
            double brutto = podatek + c;
            Console.WriteLine("Cena brutto {0}", brutto);
            Console.WriteLine("Podatek wynosi {0}", podatek);

            Console.ReadKey();
            



           
        }

    }
}
