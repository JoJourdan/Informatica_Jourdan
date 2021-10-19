using System;


namespace P64N4
{
    class Program
    {
        const int MAX = 100;
        static void Main(string[] args)
        {

            int[] a = new int[MAX];
            int n,m=int.MinValue;
            Random rnd = new Random();
            do
            {

                Console.Write("Inserire lunghezza vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Input errato");

            } while (n <= 0 || n > MAX);
            for (int i = 0; i < n; i++)
            {

                a[i] = rnd.Next(1,1001);

            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Valore in posizione " + i + " : " + a[i]);
            }

            for (int i = 0; i < n; i++)
            {
                m = (a[i] > m) ? a[i] : m;
            }

            Console.WriteLine("Il valore più grande è: " + m);
            Console.ReadKey(true);
        }
    }
}
