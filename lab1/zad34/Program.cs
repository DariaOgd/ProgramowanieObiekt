using System;

namespace Reverse{
    class Reverse {
        static void Main(string[] args){
            string s = "Wyświetl wzór jak piramida z użyciem alfabetu.";
             string[] words = s.Split(' ');
             Array.Reverse(words);
             string res = "";
             for(int i = 0; i < words.Length;i++){
                //Console.WriteLine(words[i]);
                res+=words[i];
                res+=" ";
             }
             

             Console.WriteLine(res);


            
    



           
        }

    }
}
