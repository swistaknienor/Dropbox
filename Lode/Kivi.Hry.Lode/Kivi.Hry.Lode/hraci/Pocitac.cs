using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivi.Hry.Lode
{
    class Pocitac : Hrac
    {
        public static HerniPrvek Policko { get; set; }
        public static int VelikostZasazeneLode { get; set; }
        public static bool Logika { get; set; }
        private List<Pozice> seznamPozic;
        private Random hadanaPozice;
        private int pozice;
        private bool smerDoPrava;
        public Pozice AktualniPozice { get; private set; }
        public Pocitac(ConsoleColor barvaHrace) : base(barvaHrace)
        {
            JmenoHrace = "Počítač";
            NaTahu = false;
            smerDoPrava = true;
            seznamPozic = new List<Pozice>();
            hadanaPozice = new Random();
        }

        /// <summary>
        /// Metoda pro vykresleni pozic ktere zadal pocitac
        /// </summary>
        public override void Hraje()
        {
            //nastaveni smeru odkryvani
            if (!Logika)
                smerDoPrava = true;

            if(Logika)
            {
                LogikaPocitace();
            }
            
            else
            {
                pozice = hadanaPozice.Next(0, seznamPozic.Count);
                AktualniPozice = seznamPozic[pozice];
            }
          
            bool stisknutaKlavesa = false;
            
            Console.SetCursorPosition(herniPlocha.SirkaX + 35, 5);
            Console.WriteLine("Počítač zadal: " + herniPlocha.legenda[AktualniPozice.X] + " , " + herniPlocha.legenda[AktualniPozice.Y]);
            Console.SetCursorPosition(herniPlocha.SirkaX + 35, 8);
            Console.WriteLine("<<< Stiskni Mezerník >>>");
            Console.SetCursorPosition(herniPlocha.SirkaX + 35, 13);
            Console.Write("Nápověda");
            Console.SetCursorPosition(herniPlocha.SirkaX + 35, 14);
            Console.Write("======================");
            Console.SetCursorPosition(herniPlocha.SirkaX + 35, 15);
            Console.Write("Hru ukončíš [ESC] ");
            while(!stisknutaKlavesa)
            {
                klavesa = Console.ReadKey(true);

                if (klavesa.Key == ConsoleKey.Escape)  
                {
                    UkonceniHry = true;
                    stisknutaKlavesa = true;

                }
                else if (klavesa.Key == ConsoleKey.Spacebar)   //Hra pokracuje pri stisku mezerniku
                {
                    OdkryjPolicko(AktualniPozice.X, AktualniPozice.Y);
                    seznamPozic.Remove(AktualniPozice);
                    stisknutaKlavesa = true;
                }

            }
            
        }

        /// <summary>
        /// Metoda pro vytvoreno herni plochy pocitace
        /// </summary>
        public override void VytvoreniHerniPlochy()
        {
            herniPlocha = new HerniPlocha(seznamLodi, seznamPozic);
            herniPlocha.RozmistiLode();
        }

        /// <summary>
        /// Metoda pro odkryti zadaneho policka
        /// </summary>
        /// <param name="x">Aktualni souradnice x</param>
        /// <param name="y">Aktualni souradnice y</param>
        public override void OdkryjHerniPolicko(int x, int y)
        {
            //Kontroluje za je policko skryte
            if (herniPlocha.OdkryjPolicko(x, y))
            {
                KontrolaStavuPolicka = true;
                if (herniPlocha.OdkrytePolicko == HerniPrvek.Lod)    //Kdyz se na policku bude nachazet lod
                {
                    for (int i = 0; i < seznamLodi.Count; i++)
                    {
                        if (seznamLodi[i].SkontrolujPozici(x, y))
                        {
                            //Kontrola zda lod nebyla znicena
                            if (seznamLodi[i].Znicena())
                            {
                                Zvuky.ZniceniLode();
                                Hra.Zprava("Zasáhl si, a zničil jsi loď " + seznamLodi[i].ToString() + " !!!!", ConsoleColor.DarkGreen, ConsoleColor.White);
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

        //Metoda pri zasahu lode kontroluje vedlejsi policka
        private void LogikaPocitace()
        {
            if (Policko == HerniPrvek.Lod)
            {
                //odkryvani policek smerem do prava
                if(smerDoPrava)
                {
                    AktualniPozice = new Pozice(AktualniPozice.X + 1, AktualniPozice.Y);

                    //pokud je hadana pozice odkryta, odkryva do leva
                    if (!seznamPozic.Contains(AktualniPozice) && VelikostZasazeneLode > 0)
                    {
                        while (!seznamPozic.Contains(AktualniPozice))
                        {
                            AktualniPozice = new Pozice(AktualniPozice.X - 1, AktualniPozice.Y);
                        }
                        smerDoPrava = false; //zmeni smer odkryvani do leva
                    }
                }
                else
                {
                    //odkryvani policek do leva
                    AktualniPozice = new Pozice(AktualniPozice.X - 1, AktualniPozice.Y);
                }
            }
            else if ((Policko == HerniPrvek.Voda) && (VelikostZasazeneLode > 0))
            {
                smerDoPrava = false;
                
                do
                {
                    AktualniPozice = new Pozice(AktualniPozice.X - 1, AktualniPozice.Y);
                }
                while (!seznamPozic.Contains(AktualniPozice));
            }
        }
        public override string ToString()
        {
            return JmenoHrace;
        }
    }
}
