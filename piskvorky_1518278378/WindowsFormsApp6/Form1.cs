using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(tbTicTacToe.Text);
            
            for (int i = 0; i < cislo; i++)
            {
                dgwTicTacToe.Columns.Add(new DataGridViewTextBoxColumn());
                dgwTicTacToe.Rows.Add();
            }
        }

        /// <summary>
        /// V teto metode udelejte:
        /// Jakmile kliknu do stejne bunky, tak osetrete aby se nic nestalo, aby se nic neprepsalo a stejny hrac byl stale natahu.
        /// Lichy klik do bunky bude pismeno X a sudy klik do bunky bude pismeno O.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwTicTacToe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgwTicTacToe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "X";
        }

        private void dgwTicTacToe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            }
        }
    }
}
