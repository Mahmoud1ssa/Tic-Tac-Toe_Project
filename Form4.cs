using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Project.Properties;

namespace Tic_Tac_Toe_Project
{
    public partial class frmGame : Form
    {
        //Tag = 0 => Button not pressed yet.
        //Tag = 1 => Button pressed by X blade.
        //Tag = 2 => Button pressed by O blade.

        //When You See "BladeBox" word in the code... I mean blade play button in the "frmGame" form... We have 9 BladeBoxes.

        private void ResetForm()
        {
            foreach (Button btnBlade in pnlBladeBoxes.Controls)
            {
                btnBlade.BackgroundImage = Resources.Question_Mark_3D_Shape;
                btnBlade.BackColor = Color.Transparent;
                btnBlade.Tag = "0";
                btnBlade.Enabled = true;
            }

            pnlBladeBoxes.Enabled = true;

            lblTurnValue.Text = "Player 1";
            lblWinnerValue.Text = "";

            clsGameCurrentStat.CurrentBlade = clsGameCurrentStat.Player1;
            clsGameCurrentStat.WinBlade = null;
        }

        public frmGame()
        {
            InitializeComponent();

            //I do this so if I close the form using the system exit button... all forms close.
            //But when I close form using the Back button that I add manually... only the active form close.
            //The tag value will be changed to 0 when I press Back button (see the back button func).
            //so in the previous form i check if the form ahead that was closed... if the tag in it was 0...
            //That means that I exited the form ahead by pressing back button
            //if the tag in it was 1... that means I exited the form ahead by pressing back button.
            this.Tag = "1";

            ResetForm();
        }

        private bool CheckLineOfBladesButtons(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag == btn2.Tag && btn1.Tag == btn3.Tag && btn1.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade;

                btn1.BackColor = Color.Lime;
                btn2.BackColor = Color.Lime;
                btn3.BackColor = Color.Lime;
                return true;
            }

            return false;
        }

        private bool IsThereAWinner()
        {
            if (CheckLineOfBladesButtons(btnBlade1, btnBlade5, btnBlade9))
                return true;

            else if (CheckLineOfBladesButtons(btnBlade3, btnBlade5, btnBlade7))
                return true;

            else if (CheckLineOfBladesButtons(btnBlade1, btnBlade2, btnBlade3))
                return true;

            else if (CheckLineOfBladesButtons(btnBlade4, btnBlade5, btnBlade6))
                return true;

            else if (CheckLineOfBladesButtons(btnBlade7, btnBlade8, btnBlade9))
                return true;

            else if (CheckLineOfBladesButtons(btnBlade1, btnBlade4, btnBlade7))
                return true;

            else if (CheckLineOfBladesButtons(btnBlade2, btnBlade5, btnBlade8))
                return true;

            else if (CheckLineOfBladesButtons(btnBlade3, btnBlade6, btnBlade9))
                return true;

            else
                return false;
        }

        private bool IsThereEmptyBladeBoxesLeft(Panel pnlBladeBoxes)
        {
            foreach (Button btnBladeBox in pnlBladeBoxes.Controls)
            {
                if (btnBladeBox.Tag == "0")
                {
                    return true;
                }
            }

            return false;
        }

        private void DealingWithBladeButtonClickAction(Button btnBlade)
        {
            if (btnBlade.Tag == "0" && clsGameCurrentStat.CurrentBlade == 'X')
            {
                btnBlade.Tag = "1";
                btnBlade.BackgroundImage = Resources.X_Blade_Shape;
                btnBlade.Enabled = false;
            }

            else if (btnBlade.Tag == "0" && clsGameCurrentStat.CurrentBlade == 'O')
            {
                btnBlade.Tag = "2";
                btnBlade.BackgroundImage = Resources.O_Blade_Shape;
                btnBlade.Enabled = false;
            }
            else
                return;


            if (IsThereAWinner())
            {
                if (clsGameCurrentStat.WinBlade == clsGameCurrentStat.Player1)
                {
                    lblWinnerValue.Text = "Player 1";
                    MessageBox.Show("Player 1 WIN!", "Win Message", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                else if (clsGameCurrentStat.WinBlade == clsGameCurrentStat.Player2)
                {
                    lblWinnerValue.Text = "Player 2";
                    MessageBox.Show("Player 2 WIN!", "Win Message",
    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }

                lblTurnValue.Text = "";
                pnlBladeBoxes.Enabled = false;
            }
            else
            {
                if (IsThereEmptyBladeBoxesLeft(pnlBladeBoxes))
                {
                    if (clsGameCurrentStat.CurrentBlade == 'X')
                        clsGameCurrentStat.CurrentBlade = 'O';

                    else if (clsGameCurrentStat.CurrentBlade == 'O')
                        clsGameCurrentStat.CurrentBlade = 'X';

                    if (clsGameCurrentStat.CurrentBlade == clsGameCurrentStat.Player1)
                        lblTurnValue.Text = "Player 1";

                    else if (clsGameCurrentStat.CurrentBlade == clsGameCurrentStat.Player2)
                        lblTurnValue.Text = "Player 2";
                }
                else
                {
                    lblWinnerValue.Text = "Draw";
                    lblTurnValue.Text = "";
                    MessageBox.Show("DRAW!", "Draw Message",
MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    pnlBladeBoxes.Enabled = false;
                }
            }
        }

        private void btnMainMenu_Click_1(object sender, EventArgs e)
        {
            this.Tag = "1";
            this.Close();
        }

        private void btnBlade1_Click(object sender, EventArgs e)
        {
            DealingWithBladeButtonClickAction(sender as Button);
        }

        private void btnBlade2_Click(object sender, EventArgs e)
        {
            DealingWithBladeButtonClickAction(sender as Button);
        }

        private void btnBlade3_Click(object sender, EventArgs e)
        {
            DealingWithBladeButtonClickAction(sender as Button);
        }

        private void btnBlade4_Click(object sender, EventArgs e)
        {
            DealingWithBladeButtonClickAction(sender as Button);
        }

        private void btnBlade5_Click(object sender, EventArgs e)
        {
            DealingWithBladeButtonClickAction(sender as Button);
        }

        private void btnBlade6_Click(object sender, EventArgs e)
        {
            DealingWithBladeButtonClickAction(sender as Button);
        }

        private void btnBlade7_Click(object sender, EventArgs e)
        {
            DealingWithBladeButtonClickAction(sender as Button);
        }

        private void btnBlade8_Click(object sender, EventArgs e)
        {
            DealingWithBladeButtonClickAction(sender as Button);
        }

        private void btnBlade9_Click(object sender, EventArgs e)
        {
            DealingWithBladeButtonClickAction(sender as Button);
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}

