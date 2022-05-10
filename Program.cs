using System;           //riferimento alla libreria di base

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            //namespace, classe, metodo
            int v1, v2;
            Console.Write("Inserisci un numero: ");
            if  (!int.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Errore, non è stato digitato un numero");
                System.Environment.Exit(1);
            }
            Console.Write("Inserisci un numero: ");
            if (!int.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Errore, non è stato digitato un numero");
                System.Environment.Exit(1);
            }
            System.Console.WriteLine("Hello World: {0}, {1}", 
                Moltiplica(v1, v2), "Ciao");
            //while (true)
            //    ;
            //    ;
        }
        static int Moltiplica(int v1, int v2)
        {
            return v1 * v2;
        }
        static int Moltiplica1(int v1, int v2)
        {
            return v1 / v2;
        }
    }
}