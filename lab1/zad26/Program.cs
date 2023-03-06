using System;

namespace SzyfrCezara{
    class SzyfrCezara {
        static void Main(string[] args){
            string input;
          int k;
          
          do{ Console.WriteLine("Podaj przesunięcie");
          k = int.Parse(Console.ReadLine());
              Console.Write("Podaj napis, naciśnij q aby zakończyć\n");
              input = Console.ReadLine();
              input = Cezar(input,k);
              
          }
  
       
        while (Console.ReadKey().Key != ConsoleKey.Q) ;
        Console.WriteLine("\n");
        Console.WriteLine(input);

        Console.ReadKey();

        
 



           
        }

        static char Szyfruj(char ch, int k){
             char d = char.IsUpper(ch) ? 'A' : 'a';
            return(char)((((ch+k) - d) %26 ) + d);


        }
        static string Cezar(string inp, int k){
            string res = string.Empty;
            foreach(char ch in inp){
                res+=Szyfruj(ch,k);
            }
            return res;
        }

    }
}
