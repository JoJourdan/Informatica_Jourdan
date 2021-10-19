using System;

namespace Sottoprogrammi1
{ 
    class Program   
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            mediaVet();
        }
        static void caricaVet(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
                v[i] = rnd.Next(1, 11);
        }//carica vettore
        static void stampaVet(int[] v, int n, string nome)
        {
            Console.WriteLine(nome);
            for (int i = 0; i < n; i++)
                Console.WriteLine("Posizione " + i + " :" + v[i]);
        }//stampa vettore
        private static void mediaVet()
        {
            int n;
            do
            {
                Console.Write("Inserire lunghezza vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Input errato");
            } while (n <= 0);
            int[] a = new int[n];
            caricaVet(a, n);
            stampaVet(a, n, "Vettore A");
            
            
            double m = 0;
                for (int i = 0; i < n; i++)
                {
                    m += a[i];
                }
                m/=n;
                Console.WriteLine("La media è: " + m);
            Console.ReadKey();
        }//media vettore
    }
}
