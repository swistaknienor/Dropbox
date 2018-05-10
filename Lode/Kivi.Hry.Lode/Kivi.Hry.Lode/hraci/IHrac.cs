using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivi.Hry.Lode
{
    interface IHrac
    {
        string JmenoHrace { get; set; }
        bool KontrolaStavuPolicka { get; set; }
        ConsoleColor BarvaHrace { get; set; }
        void HerniOknoHrace();
        void PohybPoHerniPlose(int x, int y);
    }
}
