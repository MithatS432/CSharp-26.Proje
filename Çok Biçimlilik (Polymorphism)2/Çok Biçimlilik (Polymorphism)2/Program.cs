using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çok_Biçimlilik__Polymorphism_2
{
    internal class Program
    {
        class Sekil
        {
            public virtual void Ciz()
            {
                Console.WriteLine("Bir şekil çiziliyor.");
            }
        }

        class Daire : Sekil
        {
            public override void Ciz()
            {
                Console.WriteLine("Bir daire çiziliyor.");
            }
        }

        class Kare : Sekil
        {
            public override void Ciz()
            {
                Console.WriteLine("Bir kare çiziliyor.");
            }
        }
        static void Main(string[] args)
        {
            Sekil s1 = new Daire(); // Polimorfizm!
            Sekil s2 = new Kare();  // Polimorfizm!

            s1.Ciz(); // daire çiziliyor
            s2.Ciz(); // kare çiziliyor
        }
    }
}
