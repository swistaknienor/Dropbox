using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivi.Hry.Lode
{
    static class Zvuky
    {
        static public System.Media.SoundPlayer prehravac;

        static public void Voda()
        {
            prehravac.Stream = Kivi.Hry.Lode.Properties.Resources.Voda;
            prehravac.Play();
        }

        static public void Pohyb()
        {
            prehravac.Stream = Kivi.Hry.Lode.Properties.Resources.Pohyb;
            prehravac.Play();
        }

        static public void ZasahLode()
        {
            prehravac.Stream = Kivi.Hry.Lode.Properties.Resources.Zasah_Lode;
            prehravac.Play();
        }

        static public void ZniceniLode()
        {
            prehravac.Stream = Kivi.Hry.Lode.Properties.Resources.vybuch;
            prehravac.Play();
        }

        static public void Chyba()
        {
            prehravac.Stream = Kivi.Hry.Lode.Properties.Resources.Chyba;
            prehravac.Play();
        }

        static public void MelodieMenu(bool hraje)
        {
            prehravac.Stream = Kivi.Hry.Lode.Properties.Resources.Melodie_Menu;

            if(hraje)
            {
                prehravac.PlayLooping();
            }
            else
            {
                prehravac.Stop();
            }
        }

        static public void Vyhra()
        {
            prehravac.Stream = Kivi.Hry.Lode.Properties.Resources.Vyhra;
            prehravac.Play();
        }

        static public void Prohra()
        {
            prehravac.Stream = Kivi.Hry.Lode.Properties.Resources.Prohra;
            prehravac.Play();
        }
    }
}
