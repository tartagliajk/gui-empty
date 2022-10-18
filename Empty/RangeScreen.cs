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
    public partial class RangeScreen : Form
    {
        public RangeScreen()
        {
            InitializeComponent();
        }

        private void Bow_Click(object sender, EventArgs e)
        {
            text.Text = ("Quick.\nEasy to use.\nPrecise.");

            //bow = 1, crossbow = 2
            Globals.weapon = 1;

            PortalScreen portalScreen = new PortalScreen();

            portalScreen.Show();

            this.Hide();
        }

        private void Crossbow_Click(object sender, EventArgs e)
        {
            text.Text = ("Slow.\nUntrustworthy.");
            Globals.weapon = 2;

            PortalScreen portalScreen = new PortalScreen();

            portalScreen.Show();

            this.Hide();
        }
    }
}

public static class Globals
{
    public static int weapon;
}
