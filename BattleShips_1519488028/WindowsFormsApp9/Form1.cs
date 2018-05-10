using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        private BattleShips battle = new BattleShips();

        public Form1()
        {
            InitializeComponent();

            dgwPlayer.Rows.Clear();
            dgwPc.Rows.Clear();

            DataGridViewRow row;
            for (int i = 0; i < 10; i++)
            {
                row = new DataGridViewRow();
                row.Height = 30;
                dgwPlayer.Rows.Add(row);

                row = new DataGridViewRow();
                row.Height = 30;
                dgwPc.Rows.Add(row);
            }

            battle.OnShipDeployFinished += OnShipDeployFinished;
            battle.OnGameEnd += OnGameEnd;
        }

        private void OnGameEnd(bool pPlayerWin)
        {
            string s = pPlayerWin ? "Player wins!": "Computer wins!";
            MessageBox.Show(s);
        }

        private void OnShipDeployFinished()
        {
            MessageBox.Show("All ships deployed! You can start attack!!!!!");
        }

        private void dgwPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(battle.AddShip(e.ColumnIndex, e.RowIndex))
            {
                dgwPlayer.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
            }

            dgwPlayer.ClearSelection();
        }

        private void dgwPc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ship;
            if (battle.PlayerAttack(e.ColumnIndex, e.RowIndex, out ship))
            {
                Color color = Color.Gray;
                if (ship == 0)
                {
                    PcAttack();
                }
                else
                {
                    color = Color.Red;
                }
                dgwPc.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = color;
            }

            dgwPc.ClearSelection();
        }

        private void PcAttack()
        {
            Color color = Color.Gray;
            int x;
            int y;
            int pcShip = battle.PcAttack(out x, out y);

            if (pcShip > 0)
            {
                color = Color.Red;
            }

            dgwPlayer.Rows[y].Cells[x].Style.BackColor = color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
