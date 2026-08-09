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
using Tic_Tac_Toe_Project.Properties;

namespace Tic_Tac_Toe_Project
{
    public partial class frmPlayersChoices : Form
    {
        private void GivePictureBoxesCorrectValues()
        {
            if (clsGameCurrentStat.Player1 == 'X')
            {
                picPlayer1Choice.BackgroundImage = Resources.X_Blade_Shape;
                picPlayer2Choice.BackgroundImage = Resources.O_Blade_Shape;
            }
            else if (clsGameCurrentStat.Player1 == 'O')
            {
                picPlayer1Choice.BackgroundImage = Resources.O_Blade_Shape;
                picPlayer2Choice.BackgroundImage = Resources.X_Blade_Shape;
            }
        }
        public frmPlayersChoices()
        {
            InitializeComponent();

            GivePictureBoxesCorrectValues();
        }

        private async Task lblTimerFunction(int MilliSec, Label lbl)
        {
            lbl.Text = Convert.ToString(MilliSec / 1000);

            for (int i = 0; i < MilliSec / 1000; i++)
            {
                lbl.Text = Convert.ToString((MilliSec / 1000) - i);
                await Task.Delay(1000);
            }
        }
        private async void frmPlayersChoices_Shown(object sender, EventArgs e)
        {
            await lblTimerFunction(5000, lblTimer);

            frmGame frmGame = new frmGame();
            this.Hide();
            frmGame.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
