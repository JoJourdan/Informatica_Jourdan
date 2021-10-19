using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P51N12
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo l'ogetto random (costruttore senza parametri)
            Random rnd = new Random();

            //ritorna un numero casuale compreso tra 1 e 1000
            int n = rnd.Next(1, 1000);
            Console.WriteLine("n: " + n.ToString());
            if (n == 1000)
                Console.WriteLine("M");
            else 
            {
                int c = n / 100;
                if (c != 0)
                {
                    switch(c)
                    {
                        case 1:Console.Write("C");
                            break;
                        case 2:
                            Console.Write("CC");
                            break;
                        case 3:
                            Console.Write("CCC");
                            break;
                        case 4:
                            Console.Write("CD");
                            break;
                        case 5:
                            Console.Write("D");
                            break;
                        case 6:
                            Console.Write("DC");
                            break;
                        case 7:
                            Console.Write("DCC");
                            break;
                        case 8:
                            Console.Write("DCCC");
                            break;
                        case 9:
                            Console.Write("CM");
                            break;
                    }
                }
                n = n % 100;
                int d = n / 10;
                if (d != 0)
                {
                    switch (d)
                    {
                        case 1:
                            Console.Write("X");
                            break;
                        case 2:
                            Console.Write("XX");
                            break;
                        case 3:
                            Console.Write("XXX");
                            break;
                        case 4:
                            Console.Write("XL");
                            break;
                        case 5:
                            Console.Write("L");
                            break;
                        case 6:
                            Console.Write("LX");
                            break;
                        case 7:
                            Console.Write("LXX");
                            break;
                        case 8:
                            Console.Write("LXXX");
                            break;
                        case 9:
                            Console.Write("XC");
                            break;
                    }
                }
                int u = n % 10;
                if (u != 0)
                {
                    switch (u)
                    {
                        case 1:
                            Console.Write("I");
                            break;
                        case 2:
                            Console.Write("II");
                            break;
                        case 3:
                            Console.Write("III");
                            break;
                        case 4:
                            Console.Write("IV");
                            break;
                        case 5:
                            Console.Write("V");
                            break;
                        case 6:
                            Console.Write("VI");
                            break;
                        case 7:
                            Console.Write("VII");
                            break;
                        case 8:
                            Console.Write("VIII");
                            break;
                        case 9:
                            Console.Write("IX");
                            break;
                    }
                }
            }       
            Console.ReadKey();
        }
    }
}
