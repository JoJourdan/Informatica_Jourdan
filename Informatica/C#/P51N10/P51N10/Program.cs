using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P51N10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; //numero lati poligono
            double l; //lunghezza lato
            double p; //perimetro

            do
            {
                Console.Write("Inserisci il numero di lati: "); //scrivo su console
                n = Convert.ToInt32(Console.ReadLine()); //leggo da console
            }
            while (n < 3 || n > 6); //ciclo post condizionale

            do
            {
                Console.Write("Inserisci la lunghezza del lato: "); //scrivo su console
                 = Convert.ToInt32(Console.ReadLine()); //leggo da console
            }
            while (l < 0);
            switch (n) //blocco di controllo multidecisionale 
            {
                case 3:
                    Console.WriteLine("Triangolo equilatero");
                    break;
                case 4:
                    Console.WriteLine("Quadrato");
                    break;
                case 5:
                    Console.WriteLine("Pentagono");
                    break;
                case 6:
                    Console.WriteLine("Esagono");
                    break;
            }
            p = l * n;
            Console.WriteLine("Il perimetro del poligono è " + p.ToString());

            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}