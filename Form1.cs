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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();

            //I do this so if I close the form using the system exit button... all forms close.
            //But when I close form using the Back button that I add manually... only the active form close.
            //The tag value will be changed to 0 when I press Back button (see the back button func).
            //so in the previous form i check if the form ahead that was closed... if the tag in it was 0...
            //That means that I exited the form ahead by pressing back button
            //if the tag in it was 1... that means I exited the form ahead by pressing back button.
            this.Tag = "1";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Tag = "0";
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmChooseBlade frmChooseBlade = new frmChooseBlade();
            this.Hide();
            frmChooseBlade.ShowDialog();

            this.Show();
        }
    }
}
