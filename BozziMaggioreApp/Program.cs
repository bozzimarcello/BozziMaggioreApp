using System;

namespace BozziMaggioreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questo programma trova il maggiore fra due numeri");

            // leggo i valori dalla tastiera
            Console.WriteLine("Inserisci il primo numero poi premi invio");
            string xStringa = Console.ReadLine();
            Console.WriteLine("Inserisci il secondo numero poi premi invio");
            string yStringa = Console.ReadLine();

            // converto le stringhe in interi
            int primoNumero = int.Parse(xStringa);
            int secondoNumero = int.Parse(yStringa);

            if (primoNumero>secondoNumero) 
            {
                Console.WriteLine("Il maggiore è il numero: " + primoNumero);
            }
            else
            {
                Console.WriteLine("Il maggiore è il numero: " + secondoNumero);
            }

        }
    }
}
