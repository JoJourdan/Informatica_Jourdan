using System;

namespace P52N30
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=4, p=0;

            do
            {
                for (int i = n / 2; i > 0; i--)
                {
                    p = 0;
                    if (n % i == 0)
                    {
                        Console.Write(i.ToString());
                        p += i;
                        if (i != 1)
                            Console.Write("+");
                    }
                }
                Console.WriteLine("=" + p);
                if (n == p)
                    Console.WriteLine(n + " è un numero perfetto");
                else
                    Console.WriteLine(n + " non è un numero perfetto");
                n++;
            }
            while (n != p);
                Console.ReadKey();
        }
    }
}
