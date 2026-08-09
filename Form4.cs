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
        public frmGame()
        {
            InitializeComponent();
            clsGameCurrentStat.CurrentBlade = clsGameCurrentStat.Player1;
        }

        private bool IsThereAWinner()
        {
            if (btnBlade1.Tag == btnBlade5.Tag &&
                btnBlade1.Tag == btnBlade9.Tag &&
                btnBlade1.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade;

                btnBlade1.BackColor = Color.Green;
                btnBlade5.BackColor = Color.Green;
                btnBlade9.BackColor = Color.Green;
            }

            else if (btnBlade3.Tag == btnBlade5.Tag &&
                     btnBlade3.Tag == btnBlade7.Tag &&
                     btnBlade3.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade;

                btnBlade3.BackColor = Color.Green;
                btnBlade5.BackColor = Color.Green;
                btnBlade7.BackColor = Color.Green;
            }

            else if (btnBlade1.Tag == btnBlade2.Tag &&
                     btnBlade1.Tag == btnBlade3.Tag &&
                     btnBlade1.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade;

                btnBlade1.BackColor = Color.Green;
                btnBlade2.BackColor = Color.Green;
                btnBlade3.BackColor = Color.Green;
            }

            else if (btnBlade4.Tag == btnBlade5.Tag &&
                     btnBlade4.Tag == btnBlade6.Tag &&
                     btnBlade4.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade;

                btnBlade4.BackColor = Color.Green;
                btnBlade5.BackColor = Color.Green;
                btnBlade6.BackColor = Color.Green;
            }

            else if (btnBlade7.Tag == btnBlade8.Tag &&
                     btnBlade7.Tag == btnBlade9.Tag &&
                     btnBlade7.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade;

                btnBlade7.BackColor = Color.Green;
                btnBlade8.BackColor = Color.Green;
                btnBlade9.BackColor = Color.Green;

            }

            else if (btnBlade1.Tag == btnBlade4.Tag &&
                     btnBlade1.Tag == btnBlade7.Tag &&
                     btnBlade1.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade;

                btnBlade1.BackColor = Color.Green;
                btnBlade4.BackColor = Color.Green;
                btnBlade7.BackColor = Color.Green;

            }

            else if (btnBlade2.Tag == btnBlade5.Tag &&
                     btnBlade2.Tag == btnBlade8.Tag &&
                     btnBlade2.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade;

                btnBlade2.BackColor = Color.Green;
                btnBlade5.BackColor = Color.Green;
                btnBlade8.BackColor = Color.Green;
            }

            else if (btnBlade3.Tag == btnBlade6.Tag &&
                     btnBlade3.Tag == btnBlade9.Tag &&
                     btnBlade3.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade;

                btnBlade3.BackColor = Color.Green;
                btnBlade6.BackColor = Color.Green;
                btnBlade9.BackColor = Color.Green;
            }
            else
            {
                return false;
            }

            return true;
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
            }

            else if (btnBlade.Tag == "0" && clsGameCurrentStat.CurrentBlade == 'O')
            {
                btnBlade.Tag = "2";
                btnBlade.BackgroundImage = Resources.O_Blade_Shape;
            }
            else
                return;


            if (IsThereAWinner())
            {
                if (clsGameCurrentStat.WinBlade == clsGameCurrentStat.Player1)
                {
                    lblWinnerValue.Text = "Player 1";
                }
                else if (clsGameCurrentStat.WinBlade == clsGameCurrentStat.Player2)
                {
                    lblWinnerValue.Text = "Player 2";
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
                }
                else
                {
                    lblWinnerValue.Text = "Draw";
                    pnlBladeBoxes.Enabled = false;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
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
    }
}

