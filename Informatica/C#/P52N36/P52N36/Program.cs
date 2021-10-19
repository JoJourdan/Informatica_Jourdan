using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P52N36
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n1=0, n2=0, n3=0, n4=0, n5=0;

            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                n = rnd.Next(1, 6);
                switch (n)
                {
                    case 1:
                        n1++;
                        break;
                    case 2:
                        n2++;
                        break;
                    case 3:
                        n3++;
                        break;
                    case 4:
                        n4++;
                        break;
                    case 5:
                        n5++;
                        break;
                }
            }
            Console.Write("1: ");
            for (int i = 0; i < n1; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(n1);
            Console.Write("2: ");
            for (int i = 0; i < n2; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(n2);
            Console.Write("3: ");
            for (int i = 0; i < n3; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(n3);
            Console.Write("4: ");
            for (int i = 0; i < n4; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(n4);
            Console.Write("5: ");
            for (int i = 0; i < n5; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(n5);
            Console.ReadKey();
        }
    }
}
