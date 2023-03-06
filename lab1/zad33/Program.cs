using System;

namespace Zamiana{
    class Zamiana {
        static void Main(string[] args){
            Console.WriteLine("Podaj napis");
            string s = Console.ReadLine();
           // string s = "Java";
             char[] words = s.ToCharArray();
             char start = words[0];
             char end  = words[words.Length-1];
            
             words[words.Length-1] = start;
             words[0] = end;
             
             string res = "";

            for(int i = 0; i < words.Length;i++){
                //Console.WriteLine(words[i]);
                res+=words[i];
                res+="";
             }
             
             
             

             Console.WriteLine(res);

             Console.ReadKey();


            
    



           
        }

    }
}
