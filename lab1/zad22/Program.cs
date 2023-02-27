using System;
using System.IO;
namespace Katalogi{
    class Katalogi {
        static void Main(string[] args){

            DirSearch(Environment.CurrentDirectory, " ");
   


           
        }

        static void DirSearch(string sDir,string wciecie)
{
    try
    {
        foreach (string d in Directory.GetDirectories(sDir))
        {
            Console.Write(wciecie);
            foreach (string f in Directory.GetFiles(d))
            {
                
                Console.WriteLine(d);
            }
            DirSearch(d, wciecie);
        }
    }
    catch (System.Exception excpt)
    {
        Console.WriteLine(excpt.Message);
    }
}
 

    }
}
