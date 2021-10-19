using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P52N24
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2;

            do
            {

                Console.Write("Inserire valore di n1: ");
                if (!int.TryParse(Console.ReadLine(), out n1))
                    Console.WriteLine("Devi inserire un numero > 0");

            } while (n1<0);

            do
            {

                Console.Write("Inserire valore di n2: ");
                if (!int.TryParse(Console.ReadLine(), out n2))
                    Console.WriteLine("Devi inserire un numero > " + n1);

            } while (n2<n1);

            for (int i = n1; i <= n2; i++)
                if (i % 2 == 1)
                    Console.Write(i.ToString().PadLeft(5));

            Console.ReadKey();
        }
    }
}
