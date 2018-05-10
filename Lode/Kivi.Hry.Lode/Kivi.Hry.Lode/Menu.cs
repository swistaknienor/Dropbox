using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivi.Hry.Lode
{
    enum PolozkyNabidky
    {
        NovaHra, Ohre, Konec, HraJednohoHrace, HraDvouHracu, Zpet
    }

    static class Menu
    {
       private static string jmenoHrace1;
       private static string jmenoHrace2;

        /// <summary>
        /// Metoda vykresli hlavni menu
        /// </summary>
        /// <returns>Vraci aktualni pozici v menu</returns>
       static public PolozkyNabidky ZobrazHlavniNabidku()
        {
            string[] hlavniNabidka = new string[3] { "Nová hra", "O hře", "Konec" };
            PolozkyNabidky[] polozkyNabidky = new PolozkyNabidky[3] { PolozkyNabidky.NovaHra, PolozkyNabidky.Ohre, PolozkyNabidky.Konec };
            bool vyberDokoncen = true;
            int vybranaPolozka = 0;
            ConsoleKeyInfo klavesa;

            //Smycka bude probihat do te doby nez bude potvrzeny vyber
            while(vyberDokoncen)
            {
                Console.Clear();  //Vycisti obrazovku
                Nadpis();
                Console.ForegroundColor = ConsoleColor.Green;  //Nastavi text na zelenou barvu
                Console.SetCursorPosition(Console.WindowWidth / 2 - 6, 14);
                Console.WriteLine("Hlavní nabídka");
                Console.ResetColor();
                
                //Vypise nabidku
                for(int i = 0; i < hlavniNabidka.Length; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 3, 16 + i);  // Nastaveni pozice nabidky
                    if(vybranaPolozka == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow; //Nastavi aktualni text nabidky na zlutou
                    }
                    Console.WriteLine(hlavniNabidka[i]);
                    Console.ResetColor();
                    Console.CursorVisible = false;  //Zneviditelni kurzor
                }
         
                klavesa = Console.ReadKey();

                switch(klavesa.Key)
                {
                    case ConsoleKey.DownArrow:  //Pri stisku sipky dolu 
                        vybranaPolozka++;
                        if(vybranaPolozka > hlavniNabidka.Length - 1)
                        {
                            vybranaPolozka = 0;
                        }
                        break;

                    case ConsoleKey.UpArrow:  //Pri stisku sipky na horu
                        vybranaPolozka--;
                        if(vybranaPolozka < 0)
                        {
                            vybranaPolozka = hlavniNabidka.Length - 1;
                        }
                        break;

                    case ConsoleKey.Enter: //Pri stisku entru
                        vyberDokoncen = false; //Ukonci smycku while
                        break;
                }
            }
            return polozkyNabidky[vybranaPolozka];  //Vrati aktulni pozici v nabidce
        }

        /// <summary>
        /// Metoda zobrazi podmenu
        /// </summary>
       /// <returns>Vraci aktualni pozici v podmenu</returns>
       public static PolozkyNabidky ZobrazPodMenu()
       {
           string[] podNabidka = new string[3] { "Hra pro jednoho hráče", "Hra pro dva hráče", "Zpět" };
           PolozkyNabidky[] polozkyNabidky = new PolozkyNabidky[3] { PolozkyNabidky.HraJednohoHrace, PolozkyNabidky.HraDvouHracu, PolozkyNabidky.Zpet };
           bool vyberDokoncen = true;
           int vybranaPolozka = 0;
           ConsoleKeyInfo klavesa;

           //Smycka bude probihat do te doby nez bude potvrzeny vyber
           while (vyberDokoncen)
           {
               Console.Clear();  //Vycisti obrazovku
               Nadpis();
               Console.ForegroundColor = ConsoleColor.Green;  //Nastavi text na zelenou barvu
               Console.SetCursorPosition(Console.WindowWidth / 2 - 6, 14);
               Console.WriteLine("Hlavní nabídka");
               Console.ResetColor();

               //Vypise nabidku
               for (int i = 0; i < podNabidka.Length; i++)
               {
                   Console.SetCursorPosition(Console.WindowWidth / 2 - 10, 16 + i);  // Nastaveni pozice nabidky
                   if (vybranaPolozka == i)
                   {
                       Console.BackgroundColor = ConsoleColor.Blue;
                       Console.ForegroundColor = ConsoleColor.Yellow; //Nastavi aktualni text nabidky na zlutou
                   }
                   Console.WriteLine(podNabidka[i]);
                   Console.ResetColor();
                   Console.CursorVisible = false;  //Zneviditelni kurzor
               }

               klavesa = Console.ReadKey();

               switch (klavesa.Key)
               {
                   case ConsoleKey.DownArrow:  //Pri stisku sipky dolu 
                       vybranaPolozka++;
                       if (vybranaPolozka > podNabidka.Length - 1)
                       {
                           vybranaPolozka = 0;
                       }
                       break;

                   case ConsoleKey.UpArrow:  //Pri stisku sipky na horu
                       vybranaPolozka--;
                       if (vybranaPolozka < 0)
                       {
                           vybranaPolozka = podNabidka.Length - 1;
                       }
                       break;

                   case ConsoleKey.Enter: //Pri stisku entru
                       vyberDokoncen = false; //Ukonci smycku while
                       break;
               }
           }
           return polozkyNabidky[vybranaPolozka];  //Vrati aktulni pozici v nabidce
       }

        /// <summary>
        /// Metoda spusti hru pro jednoho hrace
        /// </summary>
        public static void NovaHraJednohoHrace()
        {
            Hrac.index = 0;
            bool kontrolaJmena = true;
            string vstup = "Zadejte jméno hráče: ";

            while (kontrolaJmena)  //ziskani jemna hrace
            {
                Console.Clear();
                Console.SetCursorPosition(1, 3);
                Console.Write(vstup);
                jmenoHrace1 = Console.ReadLine();

                if (jmenoHrace1.Length < 10)
                {
                    kontrolaJmena = false;
                }
                else
                {
                    Hra.Zprava("Zadali jste příliš dlouhé jméno. Můžete zadat Max. 10 znaků", ConsoleColor.Red, ConsoleColor.Cyan);
                }
            }

            Hrac hrac = new Hrac(jmenoHrace1, ConsoleColor.DarkGreen);
            Pocitac pocitac = new Pocitac(ConsoleColor.Red);
            hrac.OdkryjPolicko += pocitac.OdkryjHerniPolicko;
            pocitac.OdkryjPolicko += hrac.OdkryjHerniPolicko;
            hrac.VytvoreniHerniPlochy();
            System.Threading.Thread.Sleep(300);
            pocitac.VytvoreniHerniPlochy();
            hrac.Pohyb += pocitac.PohybPoHerniPlose;
          
            //Herni smycka
            while(hrac.PocetLodi > 0 && pocitac.PocetLodi > 0 && !hrac.UkonceniHry && !pocitac.UkonceniHry)
            {
                    try
                    {
                        if (hrac.NaTahu)
                        {
                            pocitac.KontrolaStavuPolicka = false;
                            while(!pocitac.KontrolaStavuPolicka && !hrac.UkonceniHry)
                            {
                                Hra.hrac = hrac;
                                Hra.NaTahu();
                                Hra.HerniOkno(pocitac);
                                hrac.Hraje();
                            }
                            if(!hrac.UkonceniHry)
                            {
                                hrac.NaTahu = false;
                                pocitac.NaTahu = true;
                            }
                        }
                        else if(pocitac.NaTahu)
                        {
                            Hra.hrac = pocitac;
                            Hra.NaTahu();
                            Hra.HerniOkno(hrac);
                            pocitac.Hraje();
                            pocitac.NaTahu = false;
                            hrac.NaTahu = true;
                        }
                       
                    }
                   
                    catch
                    {
                        Zvuky.Chyba();
                        Hra.Zprava("Neočekávaná chyba", ConsoleColor.Red, ConsoleColor.Cyan);
                    }
                }
             
            //Vypis viteze na konci hry
            if(hrac.PocetLodi > 0 && !hrac.UkonceniHry && !pocitac.UkonceniHry)
            {
                Zvuky.Vyhra();
                Hra.ZpravaKonecHry("Vyhrál(a)", hrac);
            }
            else if(pocitac.PocetLodi > 0 && !hrac.UkonceniHry && !pocitac.UkonceniHry)
            {
                Zvuky.Prohra();
                Hra.ZpravaKonecHry("Vyhrál(a)", pocitac);
            }
        }

        /// <summary>
        /// Metoda spusti hru pro dva hrace
        /// </summary>
        static public void NovaHraProDvaHrace()
        {
            Hrac.index = 0;
            bool kontrolaJmena1 = true;
            bool kontrolaJmena2 = true;
            string vstup1 = "Zadejte jméno 1.hráče: ";
            string vstup2 = "Zadejte jméno 2.hráče: ";

            while(kontrolaJmena1) //Ziskani jmena 1.hrace
            {
                Console.Clear();
                Console.SetCursorPosition(1, 3);
                Console.Write(vstup1);
                jmenoHrace1 = Console.ReadLine();

                if(jmenoHrace1.Length < 10)
                {
                    kontrolaJmena1 = false;
                }
                else
                {
                    Hra.Zprava("Zadali jste příliš dlouhé jméno. Můžete zadat Max. 10 znaků", ConsoleColor.Red, ConsoleColor.Cyan);
                }
            }

            while(kontrolaJmena2)  //Ziskani jmena 2.hrace
            {
                Console.Clear();
                Console.SetCursorPosition(1, 3);
                Console.Write(vstup2);
                jmenoHrace2 = Console.ReadLine();

                if(jmenoHrace2.Length < 10)
                {
                    kontrolaJmena2 = false;
                }
                else
                {
                    Hra.Zprava("Zadali jste příliš dlouhé jméno. Můžete zadat Max. 10 znaků", ConsoleColor.Red, ConsoleColor.Cyan);
                }
            }
       
            Hrac hrac1 = new Hrac(jmenoHrace1, ConsoleColor.DarkGreen);
            Hrac hrac2 = new Hrac(jmenoHrace2, ConsoleColor.Magenta);
            hrac1.OdkryjPolicko += hrac2.OdkryjHerniPolicko;
            hrac2.OdkryjPolicko += hrac1.OdkryjHerniPolicko;
            hrac1.VytvoreniHerniPlochy();
            System.Threading.Thread.Sleep(300);
            hrac2.VytvoreniHerniPlochy();
            hrac1.Pohyb += hrac2.PohybPoHerniPlose;
            hrac2.Pohyb += hrac1.PohybPoHerniPlose;

            //Herni smycka
            while (hrac1.PocetLodi > 0 && hrac2.PocetLodi > 0 && !hrac1.UkonceniHry && !hrac2.UkonceniHry)
            {
                try
                {

                    if (hrac1.NaTahu)
                    {
                        hrac2.KontrolaStavuPolicka = false;
                        while (!hrac2.KontrolaStavuPolicka && !hrac1.UkonceniHry)
                        {
                            Hra.hrac = hrac1;
                            Hra.NaTahu();
                            Hra.HerniOkno(hrac2);
                            hrac1.Hraje();
                        }
                        if (!hrac2.UkonceniHry)
                        {
                            hrac1.NaTahu = false;
                            hrac2.NaTahu = true;
                        }
                    }

                    else if (hrac2.NaTahu)
                    {
                        hrac1.KontrolaStavuPolicka = false;
                        while (!hrac1.KontrolaStavuPolicka && !hrac2.UkonceniHry)
                        {
                            Hra.hrac = hrac2;
                            Hra.NaTahu();
                            Hra.HerniOkno(hrac1);
                            hrac2.Hraje();
                        }

                        if (!hrac2.UkonceniHry)
                        {
                            hrac2.NaTahu = false;
                            hrac1.NaTahu = true;
                        }
                    }
                }

                catch
                {
                    Zvuky.Chyba();
                    Hra.Zprava("Neočekávaná chyba", ConsoleColor.Red, ConsoleColor.Cyan);
                }
            }

            //Vypise na konci hry kdo vyhral
            if (hrac1.PocetLodi > 0 && !hrac1.UkonceniHry && !hrac2.UkonceniHry)
            {
                Zvuky.Vyhra();
                Hra.ZpravaKonecHry("Vyhrál(a)", hrac1);
            }
            else if (hrac2.PocetLodi > 0 && !hrac1.UkonceniHry && !hrac2.UkonceniHry)
            {
                Zvuky.Vyhra();
                Hra.ZpravaKonecHry("Vyhrál(a)", hrac2);
            }
             
        }
        
        /// <summary>
        /// Metoda pro vypis instrukci
        /// </summary>
        public static void Info()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Herní prvky");
            Console.SetCursorPosition(5, 5);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(' ');
            Console.ResetColor();
            Console.WriteLine(" - Loď");
            Console.SetCursorPosition(5, 7);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(' ');
            Console.ResetColor();
            Console.WriteLine(" - Voda");

            Console.SetCursorPosition(25, 3);
            Console.WriteLine("Cíl hry: ");
            Console.SetCursorPosition(25, 5);
            Console.WriteLine("* Najít a zlikvidovat všechny protivníkovy lodě.");
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("* Hráči se v tazích pravidelně střídají.");
            Console.SetCursorPosition(25, 9);
            Console.WriteLine("* Hráč na tahu odkryje políčko, o kterém");
            Console.SetCursorPosition(25, 10);
            Console.WriteLine("  si myslí, že by na něm mohla být některá z lodí");
            Console.SetCursorPosition(25, 12);
            Console.WriteLine("* Při zasáhnutí posledního dosud nezasaženého pole");
            Console.SetCursorPosition(25, 13);
            Console.WriteLine("  protivníkovy lodě, bude lod potopena");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(5, 21);
            Console.WriteLine("Zpracoval: Zdeněk Pelikán");
            Console.SetCursorPosition(5, 22);
            Console.WriteLine("Kontakt: Z.Pelikan@seznam.cz");
            Console.ResetColor();
            Console.SetCursorPosition(1, 25);
            Console.WriteLine("Verze: 1.0");
            Console.ReadKey();
        }

        /// <summary>
        /// Metoda pro vypis nadpisu v menu
        /// </summary>
        private static void Nadpis()
        {
            string[,] nadpis = { {"#"," "," "," "," "," "," "," ","#","#"," "," ", " "," ","#","#"," "," "," "," ","#","#","#","#"}, 
                                 {"#"," "," "," "," "," "," ","#"," "," ","#"," "," "," ","#"," ","#"," "," "," ","#"," "," "," ",},
                                 {"#"," "," "," "," "," ","#"," "," "," "," ","#"," "," ","#"," "," ","#"," "," ","#"," "," "," ",},
                                 {"#"," "," "," "," "," ","#"," "," "," "," ","#"," "," ","#"," "," ","#"," "," ","#","#","#"," ",},
                                 {"#"," "," "," "," "," ","#"," "," "," "," ","#"," "," ","#"," "," ","#"," "," ","#"," "," "," ",},
                                 {"#"," "," "," "," "," "," ","#"," "," ","#"," "," "," ","#"," ","#"," "," "," ","#"," "," "," ",},
                                 {"#","#","#","#"," "," "," "," ","#","#"," "," "," "," ","#","#"," "," ", " "," ","#","#","#","#",},};

            for(int i = 0; i < nadpis.GetLength(0); i++)
            {
                for(int y = 0; y < nadpis.GetLength(1); y++)
                {
                    if(nadpis[i,y] == "#")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition((Console.WindowWidth / 2 - 10) + y, 3 + i);
                        Console.Write(nadpis[i, y]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.SetCursorPosition((Console.WindowWidth / 2 - 10) + y, 3 + i);
                        Console.Write(nadpis[i,y]);
                    }
                }
                
            }

        }
    }
}
