using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P52N31
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0, p = 0;

            do
            {
                n++;
                p = 0;
                for (int i = n/2; i > 0; i--)
                {
                    if (n % i == 0)
                    {
                        p += i;
                    }
                }
                if (n == p)
                    Console.Write(n + " ");
            } while (n < 10000);


            Console.ReadKey();
        }
    }
}
