using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Project
{
    public partial class frmChooseBlade : Form
    {
        public frmChooseBlade()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            clsGameCurrentStat.Player1 = 'X';
            clsGameCurrentStat.Player2 = 'O';

            frmPlayersChoices frmPlayersChoices = new frmPlayersChoices();
            this.Hide();
            frmPlayersChoices.ShowDialog();
            this.Show();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            clsGameCurrentStat.Player1 = 'O';
            clsGameCurrentStat.Player2 = 'X';

            frmPlayersChoices frmPlayersChoices = new frmPlayersChoices();
            this.Hide();
            frmPlayersChoices.ShowDialog();
            this.Show();
        }
    }
}
