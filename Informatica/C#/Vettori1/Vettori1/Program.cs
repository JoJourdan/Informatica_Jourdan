using System;


namespace Vettori1
{
    class Program
    {
        const int MAX = 100;
        static void Main(string[] args)
        {

            int[] a = new int[MAX];
            int n;
            do
            {

                Console.Write("Inserire lunghezza vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Input errato");

            } while (n<=0 || n>MAX);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Inserire valore in posizione "+i+ " ");
                int.TryParse(Console.ReadLine(), out a[i]);

            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Valore in posizione " + i + " : "+ a[i]);
            }
            Console.ReadKey(true);
        }
    }
}
