using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivi.Hry.Lode
{
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
}
