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
    public partial class IntroScreen : Form
    {
        public IntroScreen()
        {
            InitializeComponent();
        }

        private void IntroScreen_Load(object sender, EventArgs e)
        {

        }

        private void arrow_Click(object sender, EventArgs e)
        {
            text.Text = "Everything is simply being built up." +
                "Now it's the player's time to either set the player's footprint or to be forgotten.";
        }

        private void next_Click(object sender, EventArgs e)
        {
            SpawnScreen spawnScreen = new SpawnScreen();

            spawnScreen.Show();

            this.Hide();
        }

        private void text_Click(object sender, EventArgs e)
        {

        }

    }
}
