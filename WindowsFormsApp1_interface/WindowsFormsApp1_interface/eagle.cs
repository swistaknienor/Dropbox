using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_interface
{
    public class eagle : IInteligence1
    {
        int IQ = 150;

        public int GetInteligence()
        {
            return IQ;
        }

        public void makeBetterInteligence()
        {
            IQ = (int)(IQ * 1.05f);
        }
    }
}
