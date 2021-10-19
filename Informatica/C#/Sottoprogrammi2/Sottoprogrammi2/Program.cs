using System;

namespace Sottoprogrammi1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Inserire lunghezza vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Input errato");
            } while (n <= 0);
            int[] a = new int[n];
            double m=mediaVet(a, n, "Vettore A"), c= mediaVet(a, n, "Vettore B");
            if (m==c)
                Console.WriteLine("Le medie sono uguali");
            else
                Console.WriteLine("Le medie sono diverse");
            Console.ReadKey();
        }
        static void caricaVet(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
                v[i] = rnd.Next(1, 6);
        }//carica vettore
        static void stampaVet(int[] v, int n, string nome)
        {
            Console.WriteLine(nome);
            for (int i = 0; i < n; i++)
                Console.WriteLine("Posizione " + i + " :" + v[i]);
        }//stampa vettore
        private static double mediaVet(int[] v, int n, string nome)
        {
            caricaVet(v, n); 
            stampaVet(v, n, nome);


            int m = 0;
            for (int i = 0; i < n; i++)
            {
                m += v[i];
            }
            m /= n;
            Console.WriteLine("La media è: " + m);
            return (double) m;
        }//media vettore
    }
}