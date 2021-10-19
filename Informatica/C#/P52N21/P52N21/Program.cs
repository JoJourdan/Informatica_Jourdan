using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P52N21
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, m, o;

            do
            {

                Console.Write("Inserire valore di n: ");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n<0);

            Random rnd = new Random();

            m = n;

            do
            {

                o = rnd.Next(10);
                Console.WriteLine("Numero generato: " + o.ToString());
                if (o > m)
                    m = o;
                n--;


            } while (n>0);

            Console.WriteLine("Il numero maggiore è: " + m.ToString());


            Console.ReadKey();
        }
    }
}
