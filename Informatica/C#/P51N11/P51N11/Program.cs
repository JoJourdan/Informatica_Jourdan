using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P51N11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m = 0, c = 0, d = 0, u = 0;

            Random rnd = new Random(); //Creazione oggetto random (costruzione senza parametri)
           
            n=rnd.Next(1, 9999); //numero casuale compreso fra due numeri

            //Nessun numero "random.Next()" per numeri positivi
            //Un numero "random.next(n)" per un numero da 0 a n

            Console.WriteLine("Il numero generato è: " + n.ToString()); 

            m = n / 1000;
            n = n % 1000;
            c = n / 100;
            n = n % 100;
            d = n / 10;
            n = n % 10;
            u = n / 1;

            Console.WriteLine("Il numero ha " + m.ToString() + " migliaia, " + c.ToString() + " centinaia, " + d.ToString() + " decine e " + u.ToString() + " unità");
            Console.ReadKey();

        }
    }
}