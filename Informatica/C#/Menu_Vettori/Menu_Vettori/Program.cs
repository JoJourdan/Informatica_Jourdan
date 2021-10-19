using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Vettori
{
    class Program
    {
        
        static void scriviMenu()
        {
            Console.Clear();
            Console.WriteLine("*** GESTIONE VETTORI ***");
            Console.WriteLine("\nA) Cerca MAX");
            Console.WriteLine("B) Copia vettore A in vettore b");
            Console.WriteLine("C) Copia vettore A in vettore b invertito");
            Console.WriteLine("D) Invetire un vettore A su se stesso");
            Console.WriteLine("E) Prodotto scalare vettori");
            Console.WriteLine("F) Prodotto vettoriale");
            Console.WriteLine("G) Controllo ordinamento vettore");
            Console.WriteLine("H) Conto numero in vettore");
            Console.WriteLine("I) Somma elementi pari e dispari");
            Console.WriteLine("L) Verifica se gli elementi di un vettore sono tutti uguali tra loro"); //da finire
            Console.WriteLine("M) ");
            Console.WriteLine("N) ");
            Console.WriteLine("X) Esci");
        }
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            char scelta;
            do
            {
                scriviMenu();
                scelta = Console.ReadKey(true).KeyChar;
                switch (scelta)
                {
                    case 'a':
                    case 'A':
                        Console.Clear();
                        Console.WriteLine("Il valore massimo del vettore è: "+cercaMAX().ToString());
                        Console.ReadKey();
                        break;
                    case 'b':
                    case 'B':
                        Console.Clear();
                        copiaVet();
                        break;
                    case 'c':
                    case 'C':
                        Console.Clear();
                        copiaVetInverso();
                        break;
                    case 'd':
                    case 'D':
                        Console.Clear();
                        invertiVet();
                        break;
                    case 'e':
                    case 'E':
                        Console.Clear();
                        Console.WriteLine("\nIl prodotto scalare vale: " + prodottoScalareVet().ToString());
                        Console.WriteLine("\n(premi un tasto per continuare)");
                        Console.ReadKey();
                        break;
                    case 'f':
                    case 'F':
                        Console.Clear();
                        prodottoVet();
                        break;
                    case 'g':
                    case 'G':
                        Console.Clear();
                        Console.WriteLine(controlloOrdinamentoVet()?"Vettore ordinato":"vettore non ordinato");
                        Console.ReadKey();
                        break;
                    case 'H':
                    case 'h':
                        Console.Clear();
                        Console.WriteLine(contaOccorenzeVet().ToString() + " volte");
                        Console.ReadKey();
                        break;
                    case 'i':
                    case 'I':
                        Console.Clear();
                        sommaDispariPari();
                        break;
                    case 'l':
                    case 'L':
                        Console.Clear();
                        verificaUgualianzaVet();
                        break;
                    case 'M':
                    case 'm':
                        Console.Clear();
                        break;
                    case 'n':
                    case 'N':
                        Console.Clear();
                        break;
                    case 'x':
                    case 'X':
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\nValore errato\n\n");
                        Console.BackgroundColor = ConsoleColor.Black;
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            } while (scelta.ToString().ToUpper() != "X") ;
        }
        private static int lunghezzaVet()
        {
            int n; 
            do
            {
                Console.Write("Inserire lunghezza vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Input errato");
            } while (n <= 0);
            return (int)n;
        }//lunghezza vettore
        static void caricaVet(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
                v[i] = rnd.Next(1, 101);
        }//carica vettore
        static void stampaVet(int[] v, string nome)
        {
            Console.WriteLine(nome);
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine("Posizione " + i + " :" + v[i]);
        }//stampa vettore
        static int cercaMAX()
        {
            int[] a;
            int m = int.MinValue;
            int n = lunghezzaVet();
            a = new int[n];
            caricaVet(a);
            stampaVet(a, "vettore A");
            for (int i = 0; i < n; i++)
                if (a[i] > m)
                    m = a[i];
            return (int)m;
        }//cerca massimo
        static void copiaVet() //copia vettore a in vettore b
        {
            int[] a;
            int[] b;
            int n = lunghezzaVet();
            a = new int[n];
            b = new int[n];
            caricaVet(a);
            for (int i = 0; i < n; i++)
                b[i] = a[i];

            stampaVet(a, "\nVettore A\n");

            stampaVet(b, "\nVettore B\n");
            Console.ReadKey(true);
        }
        static void copiaVetInverso() //copia vettore a inverso in vettore b
        {
            int[] a;
            int[] b;
            int n = lunghezzaVet();
            int j = n - 1;
            a = new int[n];
            b = new int[n];
            caricaVet(a);
            for (int i = 0; i < n; i++)
                b[j--] = a[i];
            stampaVet(a, "\nVettore A\n");

            stampaVet(b, "\nVettore B\n");

            Console.ReadKey(true);
        }
        private static void verificaUgualianzaVet()
        {
            int[] a;
            int[] b;
            int p = 0, d = 0;
            int n = lunghezzaVet();
            a = new int[n];
            b = new int[n];
            caricaVet(b);
            caricaVet(a);
            stampaVet(a,  "\nVettore A\n");
            stampaVet(a,  "\nVettore B\n");
            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 1)
                    d += a[i];
                else
                    p += a[i];
            Console.WriteLine("La somma dei numeri pari è: " + p);
            Console.WriteLine("La somma dei numeri dispari è: " + d);
            Console.ReadKey();
        }
        private static void sommaDispariPari()
        {
            int[] a;
            int p = 0, d=0;
            int n=lunghezzaVet();
            
            a = new int[n];
            caricaVet(a);
            stampaVet(a, "\nVettore A\n");
            for (int i = 0; i < n; i++)
                if (a[i]%2==1)
                    d += a[i];
                else
                    p += a[i];
            Console.WriteLine("La somma dei numeri pari è: "+p);
            Console.WriteLine("La somma dei numeri dispari è: " + d);
            Console.ReadKey();
        }
        private static int contaOccorenzeVet()
        {
            int[] a;
            int m=0,x;
            int n = lunghezzaVet();
            do
            {
                Console.Write("Inserire numero da cercare: ");
                if (!int.TryParse(Console.ReadLine(), out x))
                    Console.WriteLine("Input errato");
            } while (x <= 0 || x>101);
            a = new int[n];
            caricaVet(a);
            stampaVet(a,  "\nVettore A\n");
            for (int i = 0; i < n; i++)
                if (a[i] == x)
                    m++;
            Console.Write("Il numero " + x + " compare ");
            return m;
        }
        private static bool controlloOrdinamentoVet()
        {
            int[] a;
            int m = int.MinValue;
            int n = lunghezzaVet();
            a = new int[n];
            caricaVet(a);
            stampaVet(a, "\nVettore A\n");
            for (int i = 0; i < n; i++)
            { 
                if (a[i] > m)
                {
                    m = a[i];
                }    
                else
                { 
                    i = n;
                    m = -1;
                }
            }
            return (m != -1); //true=ordinato
        }//verifica se un vettore è ordinato in modo crescenete
        static void prodottoVet() //prodotto vettoriale
        {
            int[] a;
            int[] b;
            int[] c;
            int n = lunghezzaVet();
            a = new int[n];
            b = new int[n];
            c = new int[n];
            caricaVet(a);
            caricaVet(b);
            for (int i = 0; i < n; i++)
                c[i] = a[i] * b[i];
            stampaVet(a,  "\nVettore A\n");

            stampaVet(b,  "\nVettore B\n");
            stampaVet(c,  "\nVettore C\n");
            Console.ReadKey(true);
        }
        static int prodottoScalareVet()
        {
            int[] a;
            int[] b;
            int ps=0;
            int n = lunghezzaVet();
            a = new int[n];
            b = new int[n];
            caricaVet(a);
            caricaVet(b );
            for (int i = 0; i < n; i++)
                ps = a[i] * b[i] + ps;
            stampaVet(a, "\nVettore A\n");
            stampaVet(b, "\nVettore B\n");
            return ps;
        }
        static void invertiVet()
        {
            int[] a;
            int b;
            int n = lunghezzaVet();
            int j = n - 1;
            a = new int[n];
            caricaVet(a );
            stampaVet(a, "\nVettore A\n");
            for (int i = 0; i < n/2; i++)
            {
                b = a[j];
                a[j--] = a[i];
                a[i] = b;
            }
            stampaVet(a, "\nVettore A\n");

            Console.ReadKey(true);
        }
    }
}
