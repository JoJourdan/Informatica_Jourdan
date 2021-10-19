using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P52N39
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a=1,b=2,c=3;
            
            do
            {
                Console.Write("Inserire valore di n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire un numero > 0");
                }
            } while (n <= 0);
            for (int i = 0; i < n ; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(a.ToString().PadRight(10));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(b.ToString().PadRight(10));
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(c.ToString().PadRight(10));
                a = c;
                b++;
                c = a + b;
               
            }
            Console.ReadKey();
        }
    }
}
