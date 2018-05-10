using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivi.Hry.Lode
{
    /// <summary>
    /// Struktura ktera uchovava pozici
    /// </summary>
    struct Pozice
    {
        private int x;
        public int X { get { return x; } }
        private int y;
        public int Y { get { return y; } }

        public Pozice(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lodě";  //Nastaveni napisu hlavniho okna
            bool hraPokracuje = true; //pro opakovane zobrazeni hlavni nabidky po ukonceni hry
            Zvuky.prehravac = new System.Media.SoundPlayer();

            Zvuky.MelodieMenu(true);
            while(hraPokracuje)
            {
                //Hlavni nabidka
                switch (Menu.ZobrazHlavniNabidku())
                {
                    case PolozkyNabidky.NovaHra:  //Spusteni hry
                        bool podMenu = true;

                        while(podMenu)
                        {
                            //Zobrazi podnabidku
                            switch(Menu.ZobrazPodMenu())
                            {
                                case PolozkyNabidky.HraJednohoHrace:
                                    podMenu = false;
                                    Zvuky.MelodieMenu(false);
                                    Menu.NovaHraJednohoHrace();
                                    Zvuky.MelodieMenu(true);
                                    break;
                                case PolozkyNabidky.HraDvouHracu:
                                    podMenu = false;
                                    Zvuky.MelodieMenu(false);
                                    Menu.NovaHraProDvaHrace();
                                    Zvuky.MelodieMenu(true);
                                    break;
                                case PolozkyNabidky.Zpet:
                                    podMenu = false;
                                    break;
                            }
                        }
                        break;

                    case PolozkyNabidky.Ohre:
                        Zvuky.MelodieMenu(false);
                        Menu.Info();
                        Zvuky.MelodieMenu(true);
                        break;

                    case PolozkyNabidky.Konec:
                        hraPokracuje = false;
                        break;
                }
            }
        }
    }
}
