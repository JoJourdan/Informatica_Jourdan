using System;


namespace P52N27
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, bit;
            string output = "";

            do
            {
                Console.Write("Inserire valore di n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire un numero > 0");
                }
            }
            while (n < 0);
            do
            {
                bit = n % 2;
                output = bit.ToString() + output;
                n = n / 2;
                

            } while (n>0);
            Console.WriteLine(output);
            Console.ReadKey();

        }
    }
}
