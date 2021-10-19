using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P52N22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=2;//per numeri interi

            for (int i = 0; i < 100; i++)
            {
                Console.Write( n.ToString().PadLeft(10));
                n=n+2;
            }
            Console.ReadKey();

        }
    }
}
