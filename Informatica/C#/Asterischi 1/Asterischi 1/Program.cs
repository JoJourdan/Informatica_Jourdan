using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterischi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 120; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < 28; i++)
            {
                Console.Write("*");
                for (int j = 0; j < 118; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
            }
            for (int i = 0; i < 119; i++)
            {
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
