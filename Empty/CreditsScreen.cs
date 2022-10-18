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
    public partial class CreditsScreen : Form
    {
        public CreditsScreen()
        {
            InitializeComponent();
        }

        private void LoadStartScreen(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();

            startScreen.Show();

            this.Hide();
        }
    }
}
