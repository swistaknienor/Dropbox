using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_interface
{
    public class human : mammal, IInteligence1
    {

        public int GetInteligence()
        {
            return IQ - AGE;
        }

        public void makeBetterInteligence()
        {
            IQ -= 10;
        }
    }
}
