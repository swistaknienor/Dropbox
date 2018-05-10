using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priklad2_nasobok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj sem cislo k nasobku:");
            string s = Console.ReadLine();
            float a = float.Parse(s);
            a = a * a;
            Console.WriteLine("Vysledok by mal byt:" + a);
            Console.WriteLine("Sedi?......ak ano , pomme dalej......ale chvilku pockaj, spomeniem si.");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Zadaj mi polomer kruhu (r) v cm prosim.");
            string p = Console.ReadLine();
            float r = float.Parse(p);
            const float pi = 3.14F;
            Console.WriteLine("Pocitam ......");
        
            float obvodKruhu = 2 * r * pi;
            float obsahKruhu = (r * r) * pi ;

            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Obvod kruhu je:" + obvodKruhu);
            Console.WriteLine("Obsah kruhu je:" + obsahKruhu);
            Console.WriteLine("Vies co, vypni ma, nooooot");
            Console.ReadKey();
        }
    }
}
