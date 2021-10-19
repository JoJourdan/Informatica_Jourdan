using System;
namespace P52N23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do {
                Console.Write("Inserire valore di n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Devi inserire un numero > 2");
            } while (n<=1);
            for(int i=2; n>=i; i+=2)
                    Console.Write(i.ToString().PadLeft(5));
            Console.ReadKey();
        }
    }
}
