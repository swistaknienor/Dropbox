using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivi.Hry.Lode
{
    delegate void OdkryjPolicko(int x, int y);     //delegat pro metodu odkryj policko
    delegate void PohybPoPlose(int x, int y);     //delegat pro pohyb na herni plose protihrace

    class Hrac : IHrac
    {
        public OdkryjPolicko OdkryjPolicko;
        public PohybPoPlose Pohyb;

        protected HerniPlocha herniPlocha;  //Herni plocha hrace
        protected List<Lod> seznamLodi;     //Seznam vytvorenych lodi
        protected Lod[] vytvoreneLode;
        protected int zniceneLode;          //Poceet znicenych lodi
        protected int pocetZashu;     
        protected ConsoleKeyInfo klavesa;      //Stisknuta klavesa
        private int[] velikostLode;
        private string[] nazevLode;
        private int x, y;
        public static int index = 0;
        public string JmenoHrace { get; set; }
        public bool NaTahu { get; set; }
        public bool UkonceniHry { get; protected set; }
        public ConsoleColor BarvaHrace { get; set; }
        public bool KontrolaStavuPolicka { get; set; }
        public int PocetLodi { get { return seznamLodi.Count; } }

        public Hrac(ConsoleColor barvaHrace)
        {
            velikostLode = new int[5];
            nazevLode = new string[5];
            seznamLodi = new List<Lod>();
            JmenoHrace = string.Empty;
            BarvaHrace = barvaHrace;
            zniceneLode = 0;
            pocetZashu = 0;
            x = 0;
            y = 0;
            NaTahu = true;
            UkonceniHry = false;
            index++;
            VytvoreniLodi();
        
            for (int i = 0; i < 5; i++)
            {
                velikostLode[i] = vytvoreneLode[i].VelikostLode;
                nazevLode[i] = vytvoreneLode[i].ToString();
            }
        }

        public Hrac(string jmenoHrace, ConsoleColor barvaHrace) : this(barvaHrace)
        {
            JmenoHrace = jmenoHrace;

            if (jmenoHrace == string.Empty)
                JmenoHrace = "hrac" + index;
        }

        /// <summary>
        /// Metoda vykresli okno hrace. Herni plochu a udaje o hraci
        /// </summary>
        public void HerniOknoHrace()
        {
            for (int i = 2; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth / 2) + 12, i);
                Console.Write('|');
            }

            //Udaje o hraci
            Console.SetCursorPosition(herniPlocha.SirkaX + 7, 3);
            Console.ForegroundColor = BarvaHrace;
            Console.WriteLine(JmenoHrace);
            Console.ResetColor();
            Console.SetCursorPosition(herniPlocha.SirkaX + 4, 5);
            Console.WriteLine("Počet lodí: " + PocetLodi);
            Console.SetCursorPosition(herniPlocha.SirkaX + 4, 7);
            Console.WriteLine("Zasažené lodě: " + pocetZashu);
            Console.SetCursorPosition(herniPlocha.SirkaX + 4, 9);
            Console.WriteLine("Zničené lodě: " + zniceneLode);
            TypyLodi();
            VykresliHerniPole();  //Vykresli herni plochu
        }

        /// <summary>
        /// Metoda Hraje, umoznuje pohyb na herni plose soupere
        /// </summary>
        public virtual void Hraje()
        {
            bool pohybHrace = true;
           
            Console.SetCursorPosition(herniPlocha.SirkaX + 35, 5);
            Console.WriteLine("Aktualní pozice: " + herniPlocha.legenda[x] + " , " + herniPlocha.legenda[y]);  //Vypise aktualni pozici na plose
            Hra.Napoveda();
            Pohyb(x, y);           //Vyznaci policko na kterym se nachazime
            
            while(pohybHrace)
            {
                klavesa = Console.ReadKey(true);

                switch(klavesa.Key)
                {
                        //pohyb na horu
                    case ConsoleKey.UpArrow:
                        y--;
                        if (y < 0)
                            y = herniPlocha.VyskaY - 1;
                        break;
                        
                        //Pohyb dolu
                    case ConsoleKey.DownArrow:
                        y++;
                        if (y > herniPlocha.VyskaY - 1)
                            y = 0;
                        break;

                        //Pohyb do leva
                    case ConsoleKey.LeftArrow:
                        x--;
                        if (x < 0)
                            x = herniPlocha.SirkaX - 1;
                        break;

                        //Pohyb do prava
                    case ConsoleKey.RightArrow:
                        x++;
                        if (x > herniPlocha.SirkaX - 1)
                            x = 0;
                        break;

                        //Stisk ENTER odkryje policko
                    case ConsoleKey.Enter:
                        pohybHrace = false;
                        break;

                        //Ukonceni hry
                    case ConsoleKey.Escape:
                        pohybHrace = false;
                        UkonceniHry = true;
                        KontrolaStavuPolicka = true;
                        break;
                }
                Zvuky.Pohyb();  //Zvuk pri pohybu
                Pohyb(x, y);
                Console.SetCursorPosition(herniPlocha.SirkaX + 35, 5);
                Console.WriteLine("Aktualní pozice: " + herniPlocha.legenda[x] + " , " + herniPlocha.legenda[y]);
                Hra.Napoveda();
                
            }

            //Kdyz neni stisknuto ESC odkryje policko
            if(klavesa.Key != ConsoleKey.Escape)
                OdkryjPolicko(x, y);
        }

        /// <summary>
        /// Metoda vykresli herni plochu 
        /// </summary>
        public void VykresliHerniPole()
        {
            string nazev = JmenoHrace + " herní plocha";
            Console.SetCursorPosition(2, 0);
            Console.ForegroundColor = BarvaHrace;
            Console.Write(JmenoHrace);
            Console.ResetColor();
            Console.WriteLine(" herní plocha");
            Console.SetCursorPosition(2, 1);
            for (int i = 0; i < nazev.Length; i++)
                Console.Write("_");
       
            herniPlocha.VykresliHerniPlochu();
        }

        /// <summary>
        /// Metoda pro odkryti policka
        /// </summary>
        /// <param name="x">Aktualni souradnice x na plose</param>
        /// <param name="y">Aktualni souradnice y na plose</param>
        public virtual void OdkryjHerniPolicko(int x, int y)
        {
            //Kontroluje za je policko skryte
            if(herniPlocha.OdkryjPolicko(x, y))
            {
                KontrolaStavuPolicka = true;
                if(herniPlocha.OdkrytePolicko == HerniPrvek.Lod)    //Kdyz se na policku bude nachazet lod
                {
                    Pocitac.Logika = true;
                    Pocitac.Policko = HerniPrvek.Lod;
                    for(int i = 0; i < seznamLodi.Count; i++)
                    {
                        if(seznamLodi[i].SkontrolujPozici(x, y))
                        {
                            Pocitac.VelikostZasazeneLode = seznamLodi[i].VelikostLode;
                            //Kontrola zda lod nebyla znicena
                            if (seznamLodi[i].Znicena())
                            {
                                Zvuky.ZniceniLode();
                                Hra.Zprava("Zasáhl si, a zničil jsi loď " + seznamLodi[i].ToString() + " !!!!", ConsoleColor.DarkGreen, ConsoleColor.White);
                                Pocitac.Logika = false;
                                seznamLodi.Remove(seznamLodi[i]);  //Znicenou lod vymaze ze seznamu lodi
                                zniceneLode++;
                                pocetZashu++;
                            }
                            else
                            {
                                Zvuky.ZasahLode();
                                Hra.Zprava("Zasahl si loď " + seznamLodi[i].ToString() + "!!!!", ConsoleColor.DarkGreen, ConsoleColor.White);
                                pocetZashu++;
                            }
                        }
                    }
                    //Prekresleni plochy
                    Hra.NaTahu();
                    Hra.HerniOkno(this);
                    System.Threading.Thread.Sleep(1000);
                }

                else if (herniPlocha.OdkrytePolicko == HerniPrvek.Voda)
                {
                    Pocitac.Policko = HerniPrvek.Voda;
                    Zvuky.Voda();
                    Hra.NaTahu();
                    Hra.HerniOkno(this);
                    System.Threading.Thread.Sleep(1000);
                }
                KontrolaStavuPolicka = true;
            }
            //Kdyz se snazime odkryt odkryte policko
            else
            {
                Zvuky.Chyba();
                Hra.Zprava("Tuto pozici jste už odkryly. Hrajte znovu!!!!!!!", ConsoleColor.Red, ConsoleColor.Cyan);
                KontrolaStavuPolicka = false;
            }
        }

        /// <summary>
        /// Metoda ktera vytvori herni plochu a rozmisti lode
        /// </summary>
        public virtual void VytvoreniHerniPlochy()
        {
            herniPlocha = new HerniPlocha(seznamLodi);
            herniPlocha.RozmistiLode();
        }

        /// <summary>
        /// Metoda pro pohyb na herni plose
        /// </summary>
        /// <param name="x">Aktualni souradnice x na plose</param>
        /// <param name="y">Aktualni souradnice y na plose</param>
        public void PohybPoHerniPlose(int x, int y)
        {
            //Kdyz policko odkryte nastavi ho zpet na odkryte
            if (herniPlocha.Policko(x, y) == StavPolicka.Odkryte)
            {
                herniPlocha.PohybPoPlose(x, y, StavPolicka.OznacenePole);
                herniPlocha.VykresliHerniPlochu();
                herniPlocha.PohybPoPlose(x, y, StavPolicka.Odkryte);
            }
            else
            {
                herniPlocha.PohybPoPlose(x, y, StavPolicka.OznacenePole);
                herniPlocha.VykresliHerniPlochu();
                herniPlocha.PohybPoPlose(x, y, StavPolicka.Skryte);
            }
        }


        /// <summary>
        /// Metoda vypise lode a jejich tvar
        /// </summary>
        private void TypyLodi()
        {
            Console.SetCursorPosition(herniPlocha.SirkaX + 3, 11);
            Console.Write("-----------------------------");
            Console.SetCursorPosition(herniPlocha.SirkaX + 10, 12);
            Console.Write("Tvary lodí");
            Console.SetCursorPosition(herniPlocha.SirkaX + 3, 13);
            Console.Write("-----------------------------");

            for(int i = 0; i < nazevLode.Length; i++)
            {
                Console.SetCursorPosition(herniPlocha.SirkaX + 4, 14 + (i * 2));
                Console.Write(nazevLode[i].ToString() + ":");

                for(int j = 0; j < velikostLode[i]; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write(" ");
                }
                Console.ResetColor();
            }
        }

        //Metoda vytvori lode a preda je do seznamulodi
        protected void VytvoreniLodi()
        {
            vytvoreneLode = new Lod[] { 
                                        new Lod(Lode.letadlovaLod, "letadlová", 5),
                                        new Lod(Lode.bitevniLod, "bitevní", 4),
                                        new Lod(Lode.kriznik, "křižník", 3),
                                        new Lod(Lode.torpedoborec, "torpédoborec", 2),
                                        new Lod(Lode.ponorka, "ponorka", 1),
                                        new Lod(Lode.ponorka, "ponorka", 1),
                                        new Lod(Lode.ponorka, "ponorka", 1),
                                        new Lod(Lode.ponorka,"ponorka", 1),
                                        new Lod(Lode.bitevniLod, "bitevní", 4),
                                        new Lod(Lode.bitevniLod, "bitevní", 4),
                                        new Lod(Lode.torpedoborec, "torpédoborec", 2),
                                        new Lod(Lode.torpedoborec, "torpédoborec", 2),
                                         new Lod(Lode.torpedoborec, "torpédoborec", 2),
                                        new Lod(Lode.torpedoborec, "torpédoborec", 2),
                                        new Lod(Lode.kriznik, "křižník", 3), };

            for (int i = 0; i < vytvoreneLode.Length; i++)
            {
                seznamLodi.Add(vytvoreneLode[i]);
            }
        }
        public override string ToString()
        {
            return JmenoHrace;

        }
    }
}
