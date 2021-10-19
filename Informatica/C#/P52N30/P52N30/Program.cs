using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P52N30
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p=0;

            do
            {
                Console.Write("Inserire valore di n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire un numero > 0");
                }
            }
            while (n < 0);

            for (int i = n/2; i > 0; i--)
            {
                if (n % i == 0)
                {
                    Console.Write(i.ToString());
                    p += i;
                    if (i != 1)
                        Console.Write("+");
                }   
            }
            Console.WriteLine("=" + p);
            if (n == p)
                Console.WriteLine(n + " è un numero perfetto");
            else
                Console.WriteLine(n + " non è un numero perfetto");
            Console.ReadKey();
        }
    }
}
