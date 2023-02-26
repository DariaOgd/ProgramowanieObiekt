using System;

namespace Sito{
    class Sito {
        static void Main(string[] args){
  const int MAX = 1000;

    bool[] pierwsze = new bool[MAX + 1];
    for (int i=0; i<pierwsze.Length; i++) {
      pierwsze[i] = true;
    }

    for (int i=2; i<Math.Sqrt(MAX)+1; i++) {
      if (pierwsze[i-1]) {
        for (int j=(int) Math.Pow(i,2); j<=MAX; j+=i) {
          pierwsze[j - 1] = false;
        }
      }
    }


    int count = 0;
    for (int i = 2; i < pierwsze.Length; i++) {
      if (pierwsze[i - 1]) {
        Console.WriteLine(i);
        count++;
      }
    }
    Console.WriteLine($"Jest {count} liczb pierwszych ze zbioru liczb do {MAX}");
            


            
    



           
        }

    }
}
