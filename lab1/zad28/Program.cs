using System;

namespace Nieparzysta{
    class Nieparzysta {
        static void Main(string[] args){
            string[] arr = {};
            bool posiadaNieparzystosc =false;
            Console.WriteLine("Podaj liczby oddzielone spacjami");
            
           string[] input =  Console.ReadLine().Split(' ');
           for(int i =0; i < input.Length;i++){
            if(int.Parse(input[i])%2 != 0){
                posiadaNieparzystosc = true;
                break;
            }
           }
           Console.WriteLine("Czy tablica posiada liczby nieparzyste?");
           Console.WriteLine(posiadaNieparzystosc);
           Console.ReadKey();




            
    



           
        }

    }
}
