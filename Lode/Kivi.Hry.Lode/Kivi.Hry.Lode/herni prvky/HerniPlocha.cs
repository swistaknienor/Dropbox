using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivi.Hry.Lode
{
    enum StavPolicka
    {
        Skryte, Odkryte, OznacenePole
    }

    enum HerniPrvek
    {
        Voda, Lod
    }

    /// <summary>
    /// Trida HerniPlocha.
    /// Vykresluje a odkryva herni plochu na ktere jsou umisteny lode
    /// </summary>
    class HerniPlocha
    {
        //legenda herni plochy
        public readonly char[] legenda = new char[20] {'1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K'};
        private HerniPrvek[,] herniPrvek;
        private StavPolicka[,] poleStavu;
        private int sirka = 20, vyska = 20;        //Sirka a vyska herni plochy
        private List<Pozice> seznamPozic;         //Seznam volnych pozic
        private List<Lode> seznamTypLodi;
        private List<Lod> seznamLodi;            //seznam vytvorenych lodi
        private Random aktualniPozice;
        private Random aktualniLod;
        private bool prazdnaPozice;

        public HerniPrvek OdkrytePolicko { get; private set; }
        public int SirkaX { get { return sirka; } }
        public int VyskaY { get { return vyska; } }
 
        public HerniPlocha(List<Lod> lode)
        {
            seznamTypLodi = new List<Lode>();
            this.seznamLodi = lode;
            herniPrvek = new HerniPrvek[sirka, vyska];
            poleStavu = new StavPolicka[sirka, vyska];
            seznamPozic = new List<Pozice>();
            
                //Naplni pole hodnotami
                for (int y = 0; y < vyska; y++)
                {
                    for (int x = 0; x < sirka; x++)
                    {
                        herniPrvek[x, y] = HerniPrvek.Voda;
                        poleStavu[x, y] = StavPolicka.Skryte;
                        seznamPozic.Add(new Pozice(x, y));  //Na plni seznam volnymi pozicemi
                    }
                }

                for (int i = 0; i < seznamLodi.Count; i++)
                {
                    seznamTypLodi.Add(seznamLodi[i].TypLode);
                }
        }

        public HerniPlocha(List<Lod> lode, List<Pozice> seznamPozicPocitace): this(lode)
        {
            for (int i = 0; i < seznamPozic.Count; i++)
            {
                seznamPozicPocitace.Add(seznamPozic[i]);
            }
        }

        /// <summary>
        /// Metoda pro vykresleni herni plochy
        /// </summary>
        public void VykresliHerniPlochu()
        {
            for(int y = 0; y < vyska; y++)
            {
                //zobrazeni legendy vodorovne
                Console.SetCursorPosition(2 + y, 3);
                Console.Write(legenda[y]);

                for(int x = 0; x < sirka; x++)
                {
                    Console.SetCursorPosition(2 + x, 4 + y);
                    switch(poleStavu[x,y])
                    {
                        case StavPolicka.Skryte:
                            if ((x % 2 == 0) && (y % 2 == 0) || (x % 2 != 0) && (y % 2 != 0))  //Zobrazi hraci plochu jako sachovnici
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(' ');
                                Console.ResetColor();
                            }

                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Gray;
                                Console.Write(' ');
                                Console.ResetColor();
                            }
                            break;

                        case StavPolicka.Odkryte:

                            //Kdyz na odkrytem policku se bude nachazet voda nastavi se pozadi na modrou
                            if(herniPrvek[x,y] == HerniPrvek.Voda)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write(' ');
                                Console.ResetColor();
                            }

                            //Kdyz na odkrytem policku se bude nachazet lod nastavi se pozadi na zlutou 
                            else if(herniPrvek[x,y] == HerniPrvek.Lod)
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.Write(' ');
                                Console.ResetColor();
                            }
                            break;

                        //Zvirazneni aktualni pozice na herni plose
                        case StavPolicka.OznacenePole:
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.Write(' ');
                            Console.ResetColor();
                            break;
                    }
                    //Zobrazeni legendy svisle
                    Console.SetCursorPosition(1, 4 + y);
                    Console.WriteLine(legenda[y]);
                }
            }
        }

        /// <summary>
        /// Metoda pro odkryti aktualniho policka 
        /// </summary>
        /// <param name="x">Prvni souradnice</param>
        /// <param name="y">Druha souradnice</param>
        /// <returns>Metoda vraci true kdyz je policko skryte a false kdyz je odkryte</returns>
        public bool OdkryjPolicko(int x, int y)
        {
            if (poleStavu[x, y] == StavPolicka.Skryte)
            {
                poleStavu[x, y] = StavPolicka.Odkryte;

                if (herniPrvek[x, y] == HerniPrvek.Lod)
                {
                    OdkrytePolicko = HerniPrvek.Lod;
                }

                else if (herniPrvek[x, y] == HerniPrvek.Voda)
                {
                    //VykresliHerniPlochu();
                    OdkrytePolicko = HerniPrvek.Voda;
                }
                return true;
            }
            else
                return false;
        }
          
        //Metoda vrati stav policka, jestli je skryte nebo odkryte
        public StavPolicka Policko(int x, int y)
        {
            return poleStavu[x, y];
        }

        /// <summary>
        /// Metoda RozmistiLode, rozmisti lode na herni plochu
        /// </summary>
        public void RozmistiLode()
        {
            aktualniLod = new Random();
            aktualniPozice = new Random();
            bool vyhledava = true;

            while(vyhledava)
            {
                int vybranaPozice = aktualniPozice.Next(0, seznamPozic.Count);  //Vygeneruje volnou pozici
                int vybranaLod = aktualniLod.Next(0, seznamTypLodi.Count);  //Vygeneruje lod ktera se ma umistit na herni plochu
                Pozice pomPozice = seznamPozic[vybranaPozice];

                switch(seznamTypLodi[vybranaLod])  //Podle vybrane lodi ji vykresli na hraci plochu
                {
                    case Lode.bitevniLod:
                        UmistiLod(Lode.bitevniLod, pomPozice);
                        break;

                    case Lode.kriznik:
                        UmistiLod(Lode.kriznik, pomPozice);
                        break;

                    case Lode.letadlovaLod:
                        UmistiLod(Lode.letadlovaLod, pomPozice);
                        break;

                    case Lode.ponorka:
                        UmistiLod(Lode.ponorka, pomPozice);
                        break;

                    case Lode.torpedoborec:
                        UmistiLod(Lode.torpedoborec, pomPozice);
                        break;
                }

                //Je-li seznam lodi prazdny ukonci rozmistovani lodi
                if (seznamTypLodi.Count == 0)
                    vyhledava = false;
            }
        }

        /// <summary>
        /// Metoda VolnaPozice zkontroluje zda je pozice volna
        /// </summary>
        /// <param name="velLode">Udava velikost umistovane lode</param>
        /// <param name="pomomocnaPozice">Slouzi ke kontrole vedlejsich pozic</param>
        /// <returns>Vraci true pokud je pozice volna a kdyz je pozice obsazena tak vraci false</returns>
        private bool VolnaPozice(int velLode, Pozice pomomocnaPozice)
        {
            prazdnaPozice = false;
            int pomX, pomY;
            //kontroluje zda se pozice vyskytuje na pozici na zacatku v rohu a v rohu na  x = 0
            if ((pomomocnaPozice.X == 0 && pomomocnaPozice.Y == 0) || (pomomocnaPozice.X == 0 && pomomocnaPozice.Y == (vyska - 1)))
            {
                //kontrola pozice na zacatku v rohu
                if (pomomocnaPozice.Y == 0)
                {
                    for (int y = 0; y < 2; y++)
                    {
                        for (int x = 0; x < velLode + 1; x++)
                        {
                            if (herniPrvek[pomomocnaPozice.X + x, pomomocnaPozice.Y + y] == HerniPrvek.Voda)
                                prazdnaPozice = true;
                            else
                            {
                                prazdnaPozice = false;
                                break;
                            }
                        }
                        if (prazdnaPozice == false)
                            break;
                    }
                }

                //Kontrola pozice v rohu na hore, na zacatku
                else if (pomomocnaPozice.Y == (vyska - 1))
                {
                    pomY = pomomocnaPozice.Y - 1;
                    for (int y = 0; y < 2; y++)
                    {
                        for (int x = 0; x < velLode + 1; x++)
                        {
                            if (herniPrvek[pomomocnaPozice.X + x, pomY + y] == HerniPrvek.Voda)
                                prazdnaPozice = true;
                            else
                            {
                                prazdnaPozice = false;
                                break;
                            }
                        }
                        if (prazdnaPozice == false)
                            break;
                    }
                }
            }

            //Kontrola pozice dole na kraji a nahore na kraji
            if ((pomomocnaPozice.Y == 0 && pomomocnaPozice.X > 0) && (pomomocnaPozice.X + velLode) <= (sirka - 1) || 
                (pomomocnaPozice.X > 0 && pomomocnaPozice.Y == (vyska - 1)) && (pomomocnaPozice.X + velLode) <= (sirka - 1))
            {
                if (pomomocnaPozice.Y == 0)
                {
                    pomX = pomomocnaPozice.X - 1;
                    
                    for (int y = 0; y < 2; y++)
                    {
                        for (int x = 0; x < velLode + 2; x++)
                        {
                            if (herniPrvek[pomX + x, pomomocnaPozice.Y + y] == HerniPrvek.Voda)
                                prazdnaPozice = true;
                            else
                            {
                                prazdnaPozice = false;
                                break;
                            }
                        }
                        if (prazdnaPozice == false)
                            break;
                    }
                }

                else if (pomomocnaPozice.Y == (vyska - 1))
                {
                    pomX = pomomocnaPozice.X - 1;
                    pomY = pomomocnaPozice.Y - 1;
                    for (int y = 0; y < 2; y++)
                    {
                        for (int x = 0; x < velLode + 2; x++)
                        {
                            if (herniPrvek[pomX + x, pomY + y] == HerniPrvek.Voda)
                                prazdnaPozice = true;
                            else
                            {
                                prazdnaPozice = false;
                                break;
                            }
                        }
                        if (prazdnaPozice == false)
                            break;
                    }
                }
            }
            //Kontroluje pozice v prostoru v poli
            if (pomomocnaPozice.X != 0 && pomomocnaPozice.Y != 0 && (pomomocnaPozice.X + velLode) <= (sirka - 1) &&
                pomomocnaPozice.Y != (vyska - 1))
            {
                pomX = pomomocnaPozice.X - 1;
                pomY = pomomocnaPozice.Y - 1;
                for (int y = 0; y < 3; y++)
                {
                    for (int x = 0; x < velLode + 2; x++)
                    {
                        if (herniPrvek[pomX + x, pomY + y] == HerniPrvek.Voda)
                            prazdnaPozice = true;
                        else
                        {
                            prazdnaPozice = false;
                            break;
                        }
                    }
                    if (prazdnaPozice == false)
                        break;
                }
            }

            //Kontrola pozice na kraji
            if (pomomocnaPozice.X == 0 && pomomocnaPozice.Y != 0 && pomomocnaPozice.Y < (vyska - 1))
            {
                pomY = pomomocnaPozice.Y - 1;
                for (int y = 0; y < 3; y++)
                {
                    for (int x = 0; x < velLode + 1; x++)
                    {
                        if (herniPrvek[pomomocnaPozice.X + x, pomY + y] == HerniPrvek.Voda)
                            prazdnaPozice = true;
                        else
                        {
                            prazdnaPozice = false;
                            break;
                        }
                    }
                    if (prazdnaPozice == false)
                        break;
                }
            }

            return prazdnaPozice; //vraci true jestli je pozice volna A false kdyz je pozice obsazena
        }

        /// <summary>
        /// Metoda PohybPoPlose slouzi, pro pohyb na plose ktery je zviraznen
        /// </summary>
        /// <param name="x">Aktualni pozice na plose na souradnici x</param>
        /// <param name="y">Aktualni pozice na plose na souradnici y</param>
        /// <param name="stav">Nastavi stav policka</param>
        public void PohybPoPlose(int x, int y, StavPolicka stav)
        {
            poleStavu[x, y] = stav;
        }

        /// <summary>
        /// Metoda slouzi k umisteni lode na herni plochu
        /// </summary>
        /// <param name="aktualniLod">Umisti predanou lod</param>
        /// <param name="pomPozice">Umisteni na predane pozice</param>
        private void UmistiLod(Lode aktualniLod, Pozice pomPozice)
        {
            for (int i = 0; i < seznamLodi.Count; i++)
            {
                if (seznamLodi[i].TypLode == aktualniLod)
                {
                    if (!seznamLodi[i].Rozmistena)
                    {
                        //Kontrola zda je pozice volna 
                        if (VolnaPozice(seznamLodi[i].VelikostLode, pomPozice))
                        {
                            for (int x = 0; x < seznamLodi[i].VelikostLode; x++)
                            {
                                herniPrvek[pomPozice.X + x, pomPozice.Y] = HerniPrvek.Lod;
                                seznamLodi[i][x] = new Pozice(pomPozice.X + x, pomPozice.Y); //ulozi do indexeru pozici lode
                            }
                            seznamPozic.Remove(pomPozice);  //Vymaze pozici ze seznamu
                            seznamTypLodi.Remove(seznamLodi[i].TypLode);   //Vymaze lod ze seznamu
                            seznamLodi[i].Rozmistena = true;
                        }
                    }
                }
            }  
        }
    }
}
