using System;

namespace Trojkat{
    class Trojkat {
        static void Main(string[] args){
            int a= 3;
            int b= 5;
            int c =5;
            Console.Write("Czy Trojkąt: ");
            Console.WriteLine(czyTrojkat(a,b,c));
            Console.Write("Czy Rownoboczny: ");
          Console.WriteLine(CzyRownoboczny(a,b,c));
          Console.Write("Czy Rownoramienny: ");
          Console.WriteLine(CzyRownoramienny(a,b,c));
          Console.Write("Czy skalenny: ");
          Console.WriteLine(CzySkalenny(a,b,c));
           

           
        }
        static bool czyTrojkat(int a, int b, int c){
            if(c>=a && c>=b && a+b>c){
                return true;
            }
            else if(a>=c && a>=b && b+c>a){
                return true;
            }
            else if(b>=a && b>=c && a+c>b){
                return true;
            }
            else {
                return false;
            }
            

        }

        static bool CzyRownoramienny(int a, int b, int c){
            if(czyTrojkat(a,b,c)){
                if((a==b) || (a==c) || (c == b)){
                    return true;
                }else return false;
                
                
            }
            else return false;

        }
            static bool CzyRownoboczny(int a, int b, int c){
            if(czyTrojkat(a,b,c)){
                if(a==b && a==c && c==b){
                    return true;
                }else return false;
                
                
            }
            else return false;

        }
            static bool CzySkalenny (int a, int b, int c){
            if(czyTrojkat(a,b,c)){
                if(a!=b && a!=c && c!=b){
                    return true;
                }else return false;
                
                
            }
            else return false;

        }
        

        

    }
}
