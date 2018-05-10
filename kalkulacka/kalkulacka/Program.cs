using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Caves, budem tvoja kalkulacka, ale neviem pocitat, tak bacha !");

            Console.WriteLine(" Urobime najprv pokus: zadaj mi číslo k zdvojnásobeniu:");
            string s = Console.ReadLine();
            int a = int.Parse(s);
            a = a * 2;
            Console.WriteLine(a);

            Console.WriteLine("No vyzera, ze to pojde.");
            Console.WriteLine("Podme pocitat!");


            Console.WriteLine("Zadaj si prve cislo .....aj desatinne mozes.");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj si druhe cislo.");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("No pekne hnusne ......cakaj");
            System.Threading.Thread.Sleep(2000); /*nieco ako timer...nech to pokracuje az po chvili*/

            float sucet = b + c;
            float rozdiel = b - c;
            float nasobok = b * c;
            float podiel = b / c;

            Console.WriteLine("Sucet je:" + sucet.ToString());
            Console.WriteLine("Rozdiel je:" + rozdiel.ToString());
            Console.WriteLine("Nasobok je:" + nasobok);
            Console.WriteLine("Podiel je:" + podiel);
            Console.WriteLine("Checkni si to ci nekecam a odklikni ma fuc, dik :)");
            Console.ReadKey();
        }

    }
}
