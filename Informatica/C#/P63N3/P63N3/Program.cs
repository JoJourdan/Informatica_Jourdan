using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P63N3
{
    class Program
    {
        const int MAX = 1000;
        static void Main(string[] args)
        {
            int[] a = new int[MAX];
            int n;
            float s = 0;
            do
            {

                Console.Write("Inserire lunghezza vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Input errato");

            } while (n <= 0 || n > MAX);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Inserire valore in posizione " + i + " ");
                do
                {

                    Console.Write("Inserire valore: ");
                    if (!int.TryParse(Console.ReadLine(), out a[i]))
                        Console.WriteLine("Input errato");

                } while (a[i]==0);

            }

            for (int i = 0; i < n; i++)
                s += a[i];

            Console.WriteLine("La media vale: " + (s / n).ToString());
            Console.ReadKey(true);
        }
    }
}
