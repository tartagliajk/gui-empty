using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Empty
{
    public partial class ForestScreen : Form
    {
        public ForestScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VillageScreen villageScreen = new VillageScreen();

            villageScreen.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text.Text = "Picaxe? Shovel? Hoe?\nSomehow the player still remembers how to create them.\nThe player looks at the creation…\nTurns it…\nThe player decides to explore a bit but it doesn't find anything useful.\nIt looks up to the sky.\nIt’s getting late.\nHeads towards the village.\n";
        }

    }
}
