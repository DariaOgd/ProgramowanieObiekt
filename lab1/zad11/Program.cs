using System;

namespace NWD{
    class NWD {
        static void Main(string[] args){
            Console.WriteLine("Podaj liczbę a");
            int a = int.Parse(Console.ReadLine());
            //int x = a;
            Console.WriteLine("Podaj liczbę b");
            int b = int.Parse(Console.ReadLine());
           // int z = b;
            while (a!=b){
                if(a > b){
                    a-=b;
                }
                else{
                    b-=a;
                }
            }
            Console.WriteLine("NWD wynosi {0}",a);

            Console.ReadKey();






           
        }

    }
}
