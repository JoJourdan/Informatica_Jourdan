using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P52N37
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, n1 = 0, n2 = 1, n3=0;

            do
            {
                Console.Write("Inserire il primo numero ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire un numero > 0");
                }
            } while (n < 0);
            for (int i = 0; i < n; i++)
            {

                
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
                n3= n1+n2;


            }
            Console.ReadKey();
        }
    }
}
