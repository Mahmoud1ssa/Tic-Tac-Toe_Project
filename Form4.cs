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
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade; ;
            }

            else if (btnBlade3.Tag == btnBlade5.Tag &&
                     btnBlade3.Tag == btnBlade7.Tag &&
                     btnBlade3.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade; ;
            }

            else if (btnBlade1.Tag == btnBlade2.Tag &&
                     btnBlade1.Tag == btnBlade3.Tag &&
                     btnBlade1.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade; ;
            }

            else if (btnBlade4.Tag == btnBlade5.Tag &&
                     btnBlade4.Tag == btnBlade6.Tag &&
                     btnBlade4.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade;
            }

            else if (btnBlade7.Tag == btnBlade8.Tag &&
                     btnBlade7.Tag == btnBlade9.Tag &&
                     btnBlade7.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade; ;
            }

            else if (btnBlade1.Tag == btnBlade4.Tag &&
                     btnBlade1.Tag == btnBlade7.Tag &&
                     btnBlade1.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade; ;
            }

            else if (btnBlade2.Tag == btnBlade5.Tag &&
                     btnBlade2.Tag == btnBlade8.Tag &&
                     btnBlade2.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade; ;
            }

            else if (btnBlade3.Tag == btnBlade6.Tag &&
                     btnBlade3.Tag == btnBlade9.Tag &&
                     btnBlade3.Tag != "0")
            {
                clsGameCurrentStat.WinBlade = clsGameCurrentStat.CurrentBlade;
            }
            else
            {
                return false;
            }

            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clsGameCurrentStat.CurrentBlade == 'X' && btnBlade1.Tag == Convert.ToString(0)) 
            {
                btnBlade1.BackgroundImage = Resources.X_Blade_Shape;
                btnBlade1.Tag = "1";
            }
            else if(clsGameCurrentStat.CurrentBlade == 'O' && btnBlade1.Tag == Convert.ToString(0))
            {
                btnBlade1.BackgroundImage = Resources.O_Blade_Shape;
                btnBlade1.Tag = "1";
            }

        }
    }
}
