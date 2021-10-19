using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P51N20
{
    class Program
    {
        static void Main(string[] args)
        {

            int ng;
            double cm=0;

            do
            {

                Console.Write("Inseirire il numero di giorno: ");
                ng = Convert.ToInt32(Console.ReadLine());

            } while (ng<0);

            if (ng > 15)
                cm = (ng - 15) * 0.20;
            Console.WriteLine("Il costo della multa è di: " + cm.ToString()+ " euro");

            Console.ReadKey();
        }
    }
}
