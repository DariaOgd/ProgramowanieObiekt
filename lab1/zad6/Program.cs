using System;

namespace Kolo{
    class Kolo {
        static void Main(string[] args){
            
           
            Console.WriteLine("Podaj promien");
            int r = Int32.Parse(Console.ReadLine());
            double pi = Math.PI;
            double obw = 2*pi*r;
            obw = Math.Truncate(obw * 1000) / 1000;
            double pole = pi*r*r;
            pole = Math.Truncate(pole * 1000) / 1000;
            Console.WriteLine("Obwód wynosi {0}", obw);
            Console.WriteLine("Pole wynosi {0}", pole);

            Console.ReadKey();



           
        }

    }
}
