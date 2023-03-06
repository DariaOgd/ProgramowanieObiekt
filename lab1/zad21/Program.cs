using System;

namespace Fib{
    class Fib {
        static void Main(string[] args){
            uint n = 8;
           Console.WriteLine("Fib({0}) (metoda iteracyjna) = {1}", n, Iteracja(n));
           Console.WriteLine("Fib({0}) (metoda rekurencyjna) = {1}", n, Rekurencja(n));

           Console.ReadKey();




           
        }
        static uint Iteracja(uint n){
            uint fib = 1;
            uint pop =1;
            uint i =3;
            uint tmp;
            if(n <2){
                return n;
            }else {
            while(i<=n){
                tmp = pop;
                pop = fib;
                fib = tmp+pop;
               // Console.WriteLine(fib);
                i++;
            }
            return fib;
            }
        }

        static uint Rekurencja(uint n){
            if(n < 2){
                return n;
            }
            return (Rekurencja(n-1)+Rekurencja(n-2));
        }

    }
}
