using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P52N32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i=1;

            do
            {
                Console.Write("Inserire valore di n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire un numero > 0");
                }
            } while (n<=0);
            i = n;
            do
            {
                i--;
            }
            while (i > 1 && n%i!=0);
            if (i == 1)
                Console.WriteLine(n+ " è un numero primo");
            else
                Console.WriteLine(n+ " non è un numero primo");
            Console.ReadKey();
        }
    }
}
