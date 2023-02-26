using System;

namespace Wyrazenie2{
    class Wyrazenie2 {
        static void Main(string[] args){
            int x,y,z,v;
            Console.Write("Podaj x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Podaj y: ");
            y = int.Parse(Console.ReadLine());

            if(x < 0 && y <0){
                z = x*y;
            }else if(x ==0 || y ==0){
                z = 10;
            }else {
                z = x+y;
            }
            Console.WriteLine("z : {0}", z);
            Console.ReadKey();





           
        }

    }
}
