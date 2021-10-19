using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P65N5
{
    class Program
    {
        const int MAX= 1000;
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] a = new int[MAX];
            int[] b = new int[MAX];
            int n,ps=0;
            
            
            do
            {

                Console.Write("Inserire lunghezza vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Input errato");

            } while (n <= 0 || n > MAX);

            Console.WriteLine("\nCaricamento vettore a\n");
            caricaVet(a, n); //richiamo di un metodo
            Console.WriteLine("Caricamento vettore b\n");
            caricaVet(b, n); //b e n sono parametri attuali 
            Console.WriteLine("Stampa vettore a\n");
            stampaVet(a, n); 
            Console.WriteLine("\nStampa vettore b\n");
            stampaVet(b, n);
            for (int i = 0; i < n; i++)
            {
                ps = a[i]*b[i] + ps;
            }
            
            Console.WriteLine("\nProdotto scalare= " + ps);
            Console.ReadKey(true);
        }
        // v e n sono parametri formali
        static void caricaVet(int[] v, int n)   //firma(intestazione) del metodo(sottoprogramma) 
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
