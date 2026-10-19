using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pr_1_Konstruktori
{
    internal class Program
    {
        struct Racionalan
        {
            public int broilac;
            public int imenilac;
            public Racionalan(int broilac, int imenilac)
            {
                this.broilac = broilac;
                this.imenilac = imenilac;
            }
            public void Ispisi()
            {
                Console.WriteLine($"{broilac}/{imenilac}");
            }
        }
        static void Main(string[] args)
        {
            Racionalan r1 = new Racionalan();
            r1.broilac = 1;
            r1.imenilac = 3;
            Racionalan r2 = new Racionalan(1, 2);
            Racionalan r3 = new Racionalan()
            {
                broilac = 2,
                imenilac = 5
            };
            Racionalan r4;
            r4.broilac = 3;
            r4.imenilac = 4;
            Console.WriteLine("Prikaz razlomaka:");
            Console.Write("r1 = ");
            r1.Ispisi();
            Console.Write("r2 = ");
            r2.Ispisi();
            Console.Write("r3 = ");
            r3.Ispisi();
            Console.Write("r4 = ");
            r4.Ispisi();
            Racionalan r5 = r1;
            r5.Ispisi();
            r5.broilac = 9;
            r5.imenilac = 5;
            Console.Write("Novo r5 = ");
            r5.Ispisi();
            Console.Write("r1 = ");
            r1.Ispisi();

        }
    }
}
