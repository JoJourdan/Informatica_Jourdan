using System;

namespace P52N29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, a=0, p=1;
            string codice="";
            Random rnd = new Random();

            do
            {
                Console.Write("Inserire valore di n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire un numero > 0");
                }
            }
            while (n <= 0);

            for (int i = 1; i < n; i++)
            {
                m = rnd.Next(2);
                codice = m.ToString() + codice ;
                if (m == 1)
                    a += p;     
                p *= 2;
            }
            m = 1;
            codice = m.ToString() + codice;
            a += p;

            Console.WriteLine("Il valore di " + codice + " in decimale è: " + a);
            Console.ReadKey();
        }   
    }
}
