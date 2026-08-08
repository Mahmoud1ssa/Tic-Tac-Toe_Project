using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Project
{
    public partial class frmPlayersChoices : Form
    {
        public frmPlayersChoices()
        {
            InitializeComponent();

            lblPlayer1ChoiceValue.Text = clsGameCurrentStat.Player1.ToString();
            lblPlayer2ChoiceValue.Text = clsGameCurrentStat.Player2.ToString();
        }

        private async void lblTimerFunction(int MilliSec, Label lbl)
        {
            lbl.Text = Convert.ToString(MilliSec / 1000);

            for (int i = 0; i < MilliSec / 1000; i++)
            {
                lbl.Text = Convert.ToString((MilliSec / 1000) - i);
                await Task.Delay(1000);
            }
        }

        private void frmPlayersChoices_Load(object sender, EventArgs e)
        {
            lblTimerFunction(5000,lblTimer);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
