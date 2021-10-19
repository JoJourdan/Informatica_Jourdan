using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterischi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c,color;
            Random rnd = new Random();
            do
            {
                Console.Write("Inserire il numero di colonne: ");
                if (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Devi inserire un numero > 0");
                }
            }
            while (c <= 0|| c>60);
            n = c * 2;
            for (int i = 0; i < c; i++)
            {
                color = rnd.Next(1, 11);
                switch (color)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case 9:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case 10:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                }
                for (int j = 0; j < n; j++)
                {
                    
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
