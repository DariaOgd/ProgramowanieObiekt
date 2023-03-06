using System;

namespace Pierwiastek{
    class Pierwiastek {
        static void Main(string[] args){
            float epsilon = 0.00001f;
            double a = 5;
            float x = 1;
            Console.WriteLine("Podaj liczbę do spierwiastkowania: ");

            a= double.Parse(Console.ReadLine());
            if(a< 0){
                Console.WriteLine("Błąd!");

            }
            else {
                while(Math.Abs(x*x -a) > epsilon){
                    x = (float )(0.5*(x+(a/x)));

                }
            }
            Console.WriteLine("Pierwiastek wynosi {0}", x);

            Console.ReadKey();



    



           
        }

    }
}
