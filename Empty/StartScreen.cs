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

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }


        private void Title_Click_1(object sender, EventArgs e)
        {

        }

        private void LoadGame(object sender, EventArgs e)
        {
            IntroScreen introScreen = new IntroScreen();

            introScreen.Show();

            this.Hide();
        }

        private void LoadCredits(object sender, EventArgs e)
        {
            Credits creditScreen = new Credits();

            creditScreen.Show();

            this.Hide();
        }

    }
}
