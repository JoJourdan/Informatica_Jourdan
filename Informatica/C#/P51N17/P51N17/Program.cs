using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P51N17
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnt = new Random();

            int n = rnt.Next(1, 5);

            Console.WriteLine("Il primo numero generato è: "+ n.ToString());

            int m = rnt.Next(1, 5);

            Console.WriteLine("Il secondo numero generato è: "+ m.ToString());

            int o = rnt.Next(1, 5);

            Console.WriteLine("Il terzo numero generato è: "+ o.ToString());

            if (n==m && m==o)
                Console.WriteLine("Hai fatto tris");
            else
                if(n==o||m==n||m==o)
                    Console.WriteLine("Hai fatto coppia");
                else
                    Console.WriteLine("Non hai fatto niente");

            Console.ReadKey();
            {

	}
        }
    }
}
