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
    public partial class TreesScreen : Form
    {
        public TreesScreen()
        {
            InitializeComponent();
        }

        private void forest_Click(object sender, EventArgs e)
        {
            ForestScreen forestScreen = new ForestScreen();

            forestScreen.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VillageScreen villageScreen = new VillageScreen();

            villageScreen.Show();

            this.Hide();
        }
    }
}
