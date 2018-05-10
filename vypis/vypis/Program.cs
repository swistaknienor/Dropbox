using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vypis
{
    class Program
    {
        static void Main(string[] args)
        {
            float b;
            b = 56.6F;
            Console.WriteLine(b);

            Console.WriteLine(" Ahoj, napis mi sem nieco nech mam o com mliet dokola >:) " );

            string vstup = Console.ReadLine();
            string vystup = vstup + " , " + vstup + " , " + vstup + "!";
            
            Console.WriteLine(vystup);
            Console.ReadKey();
        }
    }
}
