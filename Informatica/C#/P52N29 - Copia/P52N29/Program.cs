using System;

namespace P52N29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Inserire valore di n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire un numero > 0");
                }
            }
            while (n < 0);

            Console.Write(n.ToString().PadRight(10));

            for (int i = n/2; i >= 1; i--)
            {
                if (n % i == 0)
                {
                    Console.Write(i.ToString().PadRight(10));
                }
            }

            Console.ReadKey();


        }
    }
}
