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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            IntroScreen introScreen = new IntroScreen();

            introScreen.Show();

            this.Hide();
        }

        private void LoadCredits(object sender, EventArgs e)
        {
            CreditsScreen creditScreen = new CreditsScreen();

            creditScreen.Show();

            this.Hide();
        }

    }
}
