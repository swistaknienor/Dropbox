using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_interface
{
    public partial class Form1 : Form
    {
        public Action OnMakeBetterIQClicked;

        private human H;
        private dolphin D;
        private eagle E;

        private IInteligence1[] intel;


        public Form1()
        {
            InitializeComponent();

            H = new human();
            D = new dolphin();
            E = new eagle();

            intel = new IInteligence1[3];
            intel[0] = H;
            intel[1] = D;
            intel[2] = E;

            for (int i = 0; i < intel.Length; i++)
            {
                OnMakeBetterIQClicked += intel[i].makeBetterInteligence;
            }

        }

        private void CalcIQ_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < intel.Length; i++)
            {
                int iq = intel[i].GetInteligence();
                switch (i)
                {
                    case 0:
                        lhumanIQ.Text = iq.ToString();
                        break;
                    case 1:
                        ldolphinIQ.Text = iq.ToString();
                        break;
                    case 2:
                        leagleIQ.Text = iq.ToString();
                        break;
                } 
            }
        }

        private void MakeBetterIQ_Click(object sender, EventArgs e)
        {
            if (OnMakeBetterIQClicked != null)
            {
                OnMakeBetterIQClicked();
            }
        }

    }


}
