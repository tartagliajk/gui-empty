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
    public partial class VillageScreen : Form
    {
        public VillageScreen()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            RangeSmithScreen rangeSmithScreen = new RangeSmithScreen();

            rangeSmithScreen.Show();

            this.Hide();
        }
    }
}
