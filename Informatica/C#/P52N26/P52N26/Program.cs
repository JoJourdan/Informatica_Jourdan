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
            int n, f=1;

            do
            {
                Console.Write("Inserire valore di n1: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Devi inserire un numero > 0");
            } while (n<0);

            for (int i = n; i > 0; i--)
                f = f * i;
            Console.WriteLine("Il fattoriale di "+ n + " vale: "+ f);
            Console.ReadKey();
        }
    }
}
