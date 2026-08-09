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
        private bool FlagIfBackButtonPressed = false;

        private void GivePictureBoxesCorrectImages()
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

            //I do this so if I close the form using the system exit button... all forms close.
            //But when I close form using the Back button that I add manually... only the active form close.
            //The tag value will be changed to 0 when I press Back button (see the back button func).
            //so in the previous form i check if the form ahead that was closed... if the tag in it was 0...
            //That means that I exited the form ahead by pressing back button
            //if the tag in it was 1... that means I exited the form ahead by pressing back button.
            this.Tag = "1";

            GivePictureBoxesCorrectImages();
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

            if (FlagIfBackButtonPressed)
                return;

            frmGame frmGame = new frmGame();
            this.Hide();
            frmGame.ShowDialog();
            this.Tag = "1";
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Tag = "0";
            FlagIfBackButtonPressed = true;
            this.Close();
        }
    }
}
