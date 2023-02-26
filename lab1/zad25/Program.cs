using System;

namespace SumaIloczyn{
    class SumaIloczyn {
        static void Main(string[] args){

        checked
{
                   uint n,k;
            long suma = 0;
            long iloczyn  = 1;
            long a;
            

            Console.WriteLine("Podaj k");
            k = uint.Parse(Console.ReadLine());
            Console.WriteLine("Podaj n");
            n = uint.Parse(Console.ReadLine());

           a=k;
          
    try
    {
              for(int i = 1; i <= n+1;i++){
                suma+=a;
                iloczyn*=a;
                a=k*i;
            };
            Console.WriteLine("Suma : {0} Iloczyn : {1}",suma,iloczyn);

    }
    catch (OverflowException e)
    {
        Console.WriteLine(e.Message);   
}






           
        }

    }
}
}
