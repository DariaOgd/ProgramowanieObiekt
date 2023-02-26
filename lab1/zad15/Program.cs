using System;

namespace Imiona{
    class Imiona {
        static void Main(string[] args){
            Powiedz("Justyny");
            Powiedz("Piotra");
            Powiedz("Mateusza");
            Powiedz("Aleksandra");
            Powiedz("Bartłomieja");
            Powiedz("Stanisława");
            Powiedz("Doroty");
            Powiedz("Michała");
           

           
        }
        static void Powiedz(string imie){
            if(imie!=""){
                Console.WriteLine("Jeden  dla {0}, jedno dla mnie", imie);
            }else {
                Console.WriteLine("Jedno dla ciebie, jedno dla mnie");
            }

        }
        

    }
}
