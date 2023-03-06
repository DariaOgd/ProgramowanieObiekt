using System;

namespace zamiana{
    class Program {
        static void Main(string[] args){
            
           
            Console.WriteLine("Podaj liczbę a");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b");
            int b = Int32.Parse(Console.ReadLine());
            int tmp;
            tmp = a;
            a=b;
            b = tmp;
            Console.WriteLine("a :" + a + " b: " + b);
            Console.ReadKey();


           
        }

    }
}
