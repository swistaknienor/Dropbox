using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivi.Hry.Lode
{
    enum Lode
    {
        ponorka, torpedoborec, kriznik, bitevniLod, letadlovaLod
    }
    class Lod
    {
        public Lode TypLode { get; private set; }
        public bool Rozmistena { get; set; }
        public string NazevLodi { get; private set; }
        public int VelikostLode { get; private set; }
        private Pozice[] polePozic;  //Pozice lode na herni plose
        private bool zasah;

        public Pozice this[int i]
        {
            get
            {
                return polePozic[i];
            }

            set
            {
                polePozic[i] = value;
            }
        }

        public Lod(Lode typLode, string nazevLodi, int delkaLode)
        {
            VelikostLode = delkaLode;
            NazevLodi = nazevLodi;
            TypLode = typLode;
            polePozic = new Pozice[VelikostLode];
            Rozmistena = false;
        }

        /// <summary>
        /// Metoda kontroluje zda se na pozici nachazi tato lod
        /// </summary>
        /// <param name="x">Aktualni souradnice x na plose</param>
        /// <param name="y">Aktualni souradnice y na plose</param>
        /// <returns></returns>
        public bool SkontrolujPozici(int x, int y)
        {
            for(int i = 0; i < polePozic.Length; i++)
            {
                //Rovna-li se pozice odkryteho policka, pozici lode tak je zasazena lod
                if((x == polePozic[i].X) && (y == polePozic[i].Y))
                {
                    zasah = true;
                    VelikostLode--;
                    break;
                }

                else
                {
                    zasah = false;
                }
            }

            return zasah;
        }

        /// <summary>
        /// Metoda kontroluje zda neni lod znicena
        /// </summary>
        /// <returns>Vraci true pokud je lod znicena</returns>
        public bool Znicena()
        {
            if (VelikostLode == 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return NazevLodi;
        }
    }
}
