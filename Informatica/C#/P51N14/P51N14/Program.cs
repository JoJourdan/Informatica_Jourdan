using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P51N14
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, mp;
            int ng;

            do //doppio tab per creare la struttura
            {
                Console.Write("Inserisici la multa: ");
                m = Convert.ToDouble(Console.ReadLine());

            } while (m<=0);

            do
            {
                Console.Write("Inserisici numero giorni: ");
                ng = Convert.ToInt32(Console.ReadLine());

            } while (m <= 0);

            if (ng <= 7)
                mp = m;
            else
            {
                if (ng > 14)
                    mp = m + (m * 0.3);
                else
                    mp = m + (m * 0.1);
            }

            Console.WriteLine("La multa da pagare è di " + mp.ToString() + " euro");
            Console.ReadKey();
        }
    }
}
