using System;

namespace P84N1
{
    class Program
    {
        static int MAX = 1000;
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n;
            int[] a = new int[MAX];
            int[] b = new int[MAX];
            do
            {

                Console.Write("Inserire lunghezza vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Input errato");

            } while (n <= 0 || n > MAX);

            caricaVet(a, n);

            copiaVet(a, b, n);
            
            Console.WriteLine("\nStampa vettore a\n");
            stampaVet(a, n);
            Console.WriteLine("\nStampa vettore b\n");
            stampaVet(b, n);
            Console.ReadKey(true);
        }

        static void copiaVet(int[] a, int[] b, int n)
        {
            for (int i = 0; i < n; i++)
                b[i] = a[i];
        }
        static void caricaVet(int[] v, int n)   
        {

            for (int i = 0; i < n; i++)
                v[i] = rnd.Next(1, 11);
        }
        static void stampaVet(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine("Posizione " + i + " :" + v[i]);
        }
    }
}
