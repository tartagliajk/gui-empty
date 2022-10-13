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
    public partial class SpawnScreen : Form
    {
        public SpawnScreen()
        {
            InitializeComponent();
        }

        private void arrow_Click(object sender, EventArgs e)
        {
            text.Text = "The player looks around.\nThe player spots a village from a distance.";

        }

        private void next_Click(object sender, EventArgs e)
        {
            TreesScreen treesScreen = new TreesScreen();

            treesScreen.Show();

            this.Hide();
        }
    }
}
