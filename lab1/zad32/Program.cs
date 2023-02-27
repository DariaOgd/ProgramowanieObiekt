using System;

namespace Katalogi{
    class Macierz {
        static void Main(string[] args){
        int i, j;
        
        int N = 2;
        int M = 3;
            int[,] a = new int[N, M];
            Console.WriteLine("Podaj wymiary 2x3");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Macierz pierwsza:");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                  Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine(); 
            }


            int[,] b = new int[N, M];
            Console.WriteLine("Enter no for 2*2 matrix");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j< M; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mzcierz druga:");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Mnożenie - macierz C:");
            int[,] c = new int[N, M];
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {


                    c[i,j]=0;
                     for (int k = 0; k < N; k++)
                     {
                         c[i, j] +=  a[i, k] * b[k, j];
                     }
                 }
            }
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    Console.Write(c[i, j]+"\t");
                }
                Console.WriteLine();
            }




            
    



           
        }

    }
}
