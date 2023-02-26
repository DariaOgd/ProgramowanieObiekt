using System;

namespace Delta{
    class Delta {
        static void Main(string[] args){
            double a;
            double b,c,x1,x2,delta;
           

            try {
                Console.WriteLine("Podaj a");
                 a = double.Parse(Console.ReadLine());
                 if(a == 0){
                    throw new Exception();
                 }else {
                     Console.WriteLine("Podaj b");
                 b = double.Parse(Console.ReadLine());
                  Console.WriteLine("Podaj c");
                 c = double.Parse(Console.ReadLine());
                    delta = b*b -4*a*c;
                    if(delta > 0){
                        x1 = (-b-Math.Sqrt(delta))/(2*a);
                        x2 = (b-Math.Sqrt(delta))/(2*a);

                        Console.WriteLine("x1 : {0} x2:{1}",x1,x2);
                    }
                    if(delta == 0){
                         x1 = -b/2*a;
                       

                        Console.WriteLine("x1 : {0}",x1);

                    }
                    if(delta <0){
                        Console.WriteLine("Brak pierwiastków!");
                    }

                 }
                

            }
            catch(Exception e){
                Console.WriteLine("A nie może być 0!!");
                Console.ReadKey();
            }
  

        }

    }
}
