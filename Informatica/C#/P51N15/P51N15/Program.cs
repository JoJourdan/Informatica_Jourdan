using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P51N15
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, s, pf;
            int sconto;

            do
            {
                Console.Write("Inserisci il prezzo: ");
                p = Convert.ToDouble(Console.ReadLine());
            } 
            while (p<=0);
            if (p < 100)
                sconto = 5;
            else
            {
                if (p >= 300)
                    sconto = 20;
                else
                    sconto = 10;
            }
            s = (p * sconto) / 100;
            pf = p - s;
            Console.WriteLine("Il prezzo finale è " + pf.ToString() + " euro");
            Console.ReadKey();

        }
    }
}
