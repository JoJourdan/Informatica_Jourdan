using System;

namespace P66N6
{
    class Program
    {
        static Random rnd = new Random();
        static int MAX = 1000;

        static void Main(string[] args)
        {
            int n;
            int[] a = new int[MAX];
            int[] b = new int[MAX];
            int[] c = new int[MAX];

            do
            {
                Console.Write("Inserire lunghezza vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Input errato");
            } while (n <= 0 || n > MAX);
             
            caricaVet(a, n);
            caricaVet(b, n);
            
            Console.WriteLine("\nStampa vettore a\n");
            stampaVet(a, n);
            Console.WriteLine("\nStampa vettore b\n");
            stampaVet(b, n);

            prodottoVet(a, b, c, n);
           

            Console.WriteLine("\nStampa vettore c\n");
            stampaVet(c, n);

            Console.ReadKey(true);
        }

        static void prodottoVet(int[] a, int[] b, int[] c, int n)
        {
            for (int i = 0; i < n; i++)
                c[i] = a[i] * b[i];
        }
        static void caricaVet(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
                v[i] = rnd.Next(1,10);
        }
        static void stampaVet(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine("Posizione " + i + " :" + v[i]);
        }
        
    }
}
