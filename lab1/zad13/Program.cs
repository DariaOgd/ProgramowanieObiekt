using System;

namespace LiczbaPierwsza{
    class LiczbaPierwsza {
        static void Main(string[] args){
            sprawdzLiczbePierwsza();
           
        }
        static void  sprawdzLiczbePierwsza(){
            Console.WriteLine("Podaj liczbę:");
            double a = double.Parse(Console.ReadLine());
            if(a == 2){
                Console.WriteLine("Liczba {0} jest pierwsza", a);

            }else if (a%2 == 0){
                Console.WriteLine("Liczba {0} nie jest pierwsza", a);

            }
            else {
                bool lpierwsza = true;
                for(int i = 3; i < Math.Sqrt(a); i+=2){
                    if(a%i == 0){
                        lpierwsza = false;
                        Console.WriteLine("Liczba {0} nie jest pierwsza", a);
                        break;
                    }
                }
                Console.WriteLine("Liczba {0} jest pierwsza", a);

            }

        }

    }
}
