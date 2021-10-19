using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoAltoBasso
{
    class Program
    {
        static void Main(string[] args)
        {
            char scelta;
            int nMax=0, maxTentativi=0, n=0, t=0, cont=0;
            Random rnd = new Random();
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*** GIOCO ALTO-BASSO ***");
                
                Console.WriteLine("\n1) Facile (1...100)");
                Console.WriteLine("2) Medio (1...500)");
                Console.WriteLine("3) Difficile (1...1000)");
                Console.WriteLine("-----------------------");
                Console.WriteLine("0) Esci");
                Console.Write("\nScegli il livello del gioco");
                scelta =Console.ReadKey(true).KeyChar;
                switch(scelta)
                {
                    case '1':
                        nMax = 100;
                        maxTentativi = 5;
                        break;
                    case '2':
                        nMax = 500;
                        maxTentativi = 8;
                        break;
                    case '3':
                        nMax = 1000;
                        maxTentativi = 10;
                        break;
                    case '0':
                        Console.WriteLine("\n\nGrazie per aver giocato");
                        break;
                    default:
                        Console.WriteLine("\n\nScelta non valida, riprovare");
                        break;
                }
                if (scelta == '1' || scelta == '2' || scelta == '3')
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nInizia gioco con intervallo tra 1 e " + nMax);
                    n = rnd.Next(1, nMax + 1);
                    cont = 1;
                    do
                    {
                        
                        do
                        {
                            Console.Write("\nTentativo " + cont + ": ");
                            int.TryParse(Console.ReadLine(), out t);
                            if(t<0||t>nMax)
                            {
                                Console.WriteLine("Devi inserire un numero tra 1 e " + nMax);
                            }
                            
                        }
                        while (t <= 0 || t>nMax);
                        if (t == n)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nHai vinto; hai indovinato in "+ cont+ " tentativi");
                        }
                        else if (t < n)
                        { 
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nIl tuo numero è troppo basso");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nIl tuo numero è troppo alto");
                        }
                        cont++;
                    } while (cont<=maxTentativi && t!=n);
                    if (t != n)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nHai perso!");
                        Console.WriteLine("\nIl numero segreto era: " + n);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nClicca un pulsante qualsiasi per riavviare");
                }
                
                Console.ReadKey(true);
                Console.Clear();
            }
            while (scelta != '0');
        }
    }
}
