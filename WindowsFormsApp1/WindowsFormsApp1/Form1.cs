using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private BattleShip battle = new BattleShip();

        public Form1()
        {
            InitializeComponent();

            dgwPlayer.Rows.Clear();
            dgwPC.Rows.Clear();

            DataGridViewRow row;
            for (int i =0; i < 10; i++)
            {
                row = new DataGridViewRow();
                row.Height = 30;
                dgwPlayer.Rows.Add(row);

                row = new DataGridViewRow();
                row.Height = 30;
                dgwPC.Rows.Add(row);

            }

            battle.OnShipDeployFinished += OnShipDeployFinished;
        }

        private void OnShipDeployFinished()
        {
            MessageBox.Show("All ships deployed. START!");
        }

        private void dgwPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(battle.AddShip(e.ColumnIndex, e.RowIndex))
            {
                dgwPlayer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
            }
        }

        private void dgwPlayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
