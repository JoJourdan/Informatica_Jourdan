using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P52N26
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, f = 1;
            do
            {
                Console.Write("Inserire valore di n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire un numero > 0");
                }
            }
            while (n < 0);
            Console.Write("Il fattoriale di " + n + " è: 1");
            for (int i = 2; i <= n; i++)
            {
                Console.Write(" * "+ i);
                f = f * i;
            }
            Console.Write(" = " + f);
            Console.ReadKey();
            
        }
    }
}
