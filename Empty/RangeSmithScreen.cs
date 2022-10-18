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
    public partial class RangeSmithScreen : Form
    {
        public RangeSmithScreen()
        {
            InitializeComponent();
        }

        private void Smith_Click(object sender, EventArgs e)
        {
            SmithScreen smithScreen = new SmithScreen();

            smithScreen.Show();

            this.Hide();
        }

        private void Range_Click(object sender, EventArgs e)
        {
            RangeScreen rangeScreen = new RangeScreen();

            rangeScreen.Show();

            this.Hide();
        }
    }
}
