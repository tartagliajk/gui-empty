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
    public partial class SmithScreen : Form
    {
        public SmithScreen()
        {
            InitializeComponent();
        }

        private void Sword_Click(object sender, EventArgs e)
        {
            text.Text = ("Sharp.\nHandle.\nEasy to cut.\nBut yet so weak.");

            Globals.weapon = 3;

            PortalScreen portalScreen = new PortalScreen();

            portalScreen.Show();

            this.Hide();
        }

        private void Axe_Click(object sender, EventArgs e)
        {
            text.Text = ("Heavy.\nSlow.\nGreat damage.");

            Globals.weapon = 4;

            PortalScreen portalScreen = new PortalScreen();

            portalScreen.Show();

            this.Hide();
        }
    }
}
