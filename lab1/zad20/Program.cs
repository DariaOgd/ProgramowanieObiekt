using System;

namespace Oszczednosci{
    class Oszczednosci {
        static void Main(string[] args){

           double d = 200.75;
           float x = (float) d;

           float z = (float)(3.213*x)/100;
           Console.Write("Stopa procentowa: ");
           Console.WriteLine(StopaProcentowa(d));
           Console.Write("Aktualizacja roczna: ");
           Console.WriteLine(AktulaizacjaSaldaRocznego(d));
           Console.WriteLine(IleLatPrzedOczekiwanymSaldem(d,201));

           Console.ReadKey();


           
        }
        static float StopaProcentowa(double d){
            float x = (float) d;
            if(d < 0){
                return (float)((3.213*(x)/100));
            }
            else if(d > 0 && d < 1000){
                return (float)((0.5*x)/100);

            }
            else if(d >=100 && d < 5000){
                return (float)((1.621*x)/100);
            }
            else{
                 return (float)((1.621*x)/100);
            }

        }

        static double AktulaizacjaSaldaRocznego(double d){
            double stopa = (double)StopaProcentowa(d);
           
            return stopa+d;
            
        }

        static int IleLatPrzedOczekiwanymSaldem(double d, double oczekiwana){
            float stopa = StopaProcentowa(d);
            int helper1 = 0;
            double helper2 = d;

            while(oczekiwana > helper2){
                helper1++;
                helper2+=stopa;
            }
            return helper1;
        }

       
        

        

    }
}
