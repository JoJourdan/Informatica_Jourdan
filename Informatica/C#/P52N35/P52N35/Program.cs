using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P52N35
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, s1 = 1, s2=1 ;

            do
            {
                Console.Write("Inserire il primo numero ");
                if (!int.TryParse(Console.ReadLine(), out n1))
                {
                    Console.WriteLine("Devi inserire un numero > 0");
                }
            } while (n1 < 0);

            do
            {
                Console.Write("Inserire il secondo numero ");
                if (!int.TryParse(Console.ReadLine(), out n2))
                {
                    Console.WriteLine("Devi inserire un numero > 0");
                }
            } while (n2 < 0);

            for (int i = n1-1; i > 0; i--)
            {
                if (n1 % i == 0)
                {
                    s1 += i;
                }
            }

            for (int i = n2-1; i > 0; i--)
            {
                if (n2 % i == 0)
                {
                    s2 += i;
                }
            }
            if (n1 == s2-1 && n2 == s1-1)
                
            Console.WriteLine("Sono amichevoli");
            else
                Console.WriteLine("Non sono amichevoli");
            Console.ReadKey();
        }
    }
}
