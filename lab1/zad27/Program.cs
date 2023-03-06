using System;

namespace Imiona{
    class Imiona {
        static void Main(string[] args){
            
           string[] imiona = {"Piotr", "Anna", "Jan", "Leszek"};
           for(int i = 1 ; i < imiona.Length+1; i++){
            Console.WriteLine("{0}. {1} ", i,imiona[i-1]);
           }
            Console.ReadKey();



           
        }

    }
}
