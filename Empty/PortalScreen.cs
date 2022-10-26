using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empty
{
    public partial class PortalScreen : Form
    {
        public PortalScreen()
        {
            InitializeComponent();
        }

        private void arrow_Click(object sender, EventArgs e)
        {
            text.Text = ("Risk? Yes.\nThe player runs towards the portal.\nOver the guards it goes.\nInto the portal it goes.");
        }

        private void next_Click(object sender, EventArgs e)
        {
            NetherScreen netherScreen = new NetherScreen();

            netherScreen.Show();

            this.Hide();
        }
    }
}
