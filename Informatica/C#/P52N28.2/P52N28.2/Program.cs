using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P52N28._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bit, m=2, a = 0, p=1;
            string codice = "";

            do
            {
                Console.Write("Inserire valore di n: ");
                if (!int.TryParse(Console.ReadLine(), out bit))
                {
                    Console.WriteLine("Devi inserire un numero > 0");
                }
            }
            while (bit <= 0);

            for (int i = 0; i < bit; i++)
            {
                p *= 2;
            }
            for (int i = 0; i < bit; i++)
            {
                do
                {
                    Console.Write("Inserire il valore del bit: ");
                    if (!int.TryParse(Console.ReadLine(), out m))
                    {
                        Console.WriteLine("Devi inserire 1 o 0");
                    }
                }
                while (m != 0 && m != 1);
                codice = codice+ m.ToString();
                p /= 2;
                if (m == 1)
                    a += p;
            }
            Console.WriteLine("Il valore di " + codice + " in decimale è: " + a);
            Console.ReadKey();
        }
    }
}
