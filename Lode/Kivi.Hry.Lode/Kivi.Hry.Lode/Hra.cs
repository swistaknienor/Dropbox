using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivi.Hry.Lode
{
    static class Hra
    {

        public static IHrac hrac;
        /// <summary>
        /// Metoda vykresli herni plochu a udaje hrace
        /// </summary>
        /// <param name="hraci">Preda hrace k zobrazeni okna</param>
        static public void HerniOkno(IHrac hraci)
        {
            hraci.HerniOknoHrace();
        }

        /// <summary>
        /// Metoda vypise kdo je na tahu
        /// </summary>
        static public void NaTahu()
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2, 0);
            Console.Write("Na Tahu je ");
            Console.ForegroundColor = hrac.BarvaHrace;
            Console.WriteLine(hrac.JmenoHrace);
            Console.ResetColor();
        }

        /// <summary>
        /// Metoda pro vypis zprav
        /// </summary>
        /// <param name="zprava">Zprava ktera se ma zobrazit</param>
        /// <param name="barvaPisma">Barva pisma zpravy</param>
        /// <param name="barvaPozadi">Barva pozadi zpravy</param>
        static public void Zprava(string zprava, ConsoleColor barvaPisma, ConsoleColor barvaPozadi)
        {
            Console.SetCursorPosition(7, 11);
            Console.ForegroundColor = barvaPisma;
            Console.BackgroundColor = barvaPozadi;
            Console.WriteLine(zprava);
            Console.ResetColor();
            System.Threading.Thread.Sleep(1800);
        }

        /// <summary>
        /// Metoda pro vypis zpravy na konci hry
        /// </summary>
        /// <param name="zprava">Zprava ktera se ma zobrazit</param>
        /// <param name="hrac">Hrac ktery zvitezil</param>
        static public  void ZpravaKonecHry(string zprava, IHrac hrac)
        {
            bool stiskMezerniku = false;
            ConsoleKeyInfo klavesa;

            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth / 2) - (hrac.JmenoHrace.Length / 2) - 7, 10);
            Console.ForegroundColor = hrac.BarvaHrace;
            Console.Write(hrac.JmenoHrace + " ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(zprava);
            Console.ResetColor();

            while(!stiskMezerniku)
            {
                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 15);
                Console.Write("<<< Stiskni Mezerník >>>");
                klavesa = Console.ReadKey(true);

                if (klavesa.Key == ConsoleKey.Spacebar)
                    stiskMezerniku = true;
            }
        }

        /// <summary>
        /// Metoda pro vykresleni napovedy
        /// </summary>
        static public void Napoveda()
        {
            Console.SetCursorPosition((Console.WindowWidth / 2) + 14, 10);
            Console.Write("Nápověda");
            Console.SetCursorPosition((Console.WindowWidth / 2) + 14, 11);
            Console.Write("=======================");
            Console.SetCursorPosition((Console.WindowWidth / 2) + 14, 12);
            Console.Write("Šipkami se pohybuješ");
            Console.SetCursorPosition((Console.WindowWidth / 2) + 14, 13);
            Console.Write("po herní ploše.");
            Console.SetCursorPosition((Console.WindowWidth / 2) + 14, 15);
            Console.Write("Stiskni [ENTER] a ");
            Console.SetCursorPosition((Console.WindowWidth / 2) + 14, 16);
            Console.Write("odkryješ políčko.");
            Console.SetCursorPosition((Console.WindowWidth / 2) + 14, 18);
            Console.Write("Hru ukončíš [ESC] ");
        }
    }
}
