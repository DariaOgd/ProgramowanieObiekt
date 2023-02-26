using System;

namespace Program{
    class Program {
        static void Main(string[] args){
            //a

            // double liczba1 = 5;
            // double liczba2 = 5;

            // double srednia = (liczba1 + liczba2)/2;
            // Console.WriteLine(srednia);

            //b
            // Console.WriteLine("Podaj liczbę:");
            // double liczba1 = Double.Parse(Console.ReadLine());
            // Console.WriteLine("Podaj liczbę:");
            // double liczba2 = Double.Parse(Console.ReadLine());
            // double srednia = (liczba1 + liczba2)/2;
            // Console.WriteLine(srednia);
            wyliczSredniaProceduralnie(4,1);
            Console.WriteLine(wyliczSredniaFunkcyjnie(5,4));
            
            //6
            double wynik = wyliczSredniaFunkcyjnie(5,5);

        }
        static void wyliczSredniaProceduralnie(double a, double b){
            double srednia = (a+b)/2;
            Console.WriteLine("Średnia to {0}", srednia);
        }
        static Double wyliczSredniaFunkcyjnie(double a, double b){
            double srednia = (a+b)/2;
            return srednia;
        }
    }
}