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
    public partial class NetherScreen : Form
    {
        static string wepaonChoice;
        public NetherScreen()
        {
            InitializeComponent();
            chestsPicture.Visible = false;
            spawnerPicture.Visible = false;
            spawnerFight.Visible = false;
            next.Visible = false;
            whiteBox2.Visible = false;
            questionBox2.Visible = false;
            Lava.Visible = false;
            Dig.Visible = false;
            death.Visible = false;
            close.Visible = false;
            pigmen.Visible = false;
            arrow.Visible = false;
            tunnel.Visible = false;
            nextRoom.Visible = false;
        }

        private void Chests_Click(object sender, EventArgs e)
        {
            netherPicture.Visible = false;
            Spawner.Visible = false;
            Chests.Visible = false;
            whiteBox.Visible = false;
            question.Visible = false;
            chestsPicture.Visible = true;
            next.Visible = true;
            text.Text = ("Chestroom.\nThe player finds gold, diamonds, rubies, emeralds etc." +
                "\nBut nothing useful.\nSo it puts everything back." +
                "\nStill in need of the powder, the player walks towards the spawner." +
                "\nThe player has everything in its possession." +
                "\nNo more extra time shall be spent in vain. " +
                "\nIt decides to go back to the overworld.\n");
        }

        private void Spawner_Click(object sender, EventArgs e)
        {
            netherPicture.Visible = false;
            Spawner.Visible = false;
            Chests.Visible = false;
            whiteBox.Visible = false;
            question.Visible = false;
            text.Visible = false;
            spawnerPicture.Visible = true;
            spawnerFight.Visible = true;
            next.Visible = true;
            
            if (Globals.weapon == 1)
            {
                wepaonChoice = "Arrow in íts hand." +
                    "\nPutting it next to the bow string." +
                    "\nA sound of arrow swoshing past and into the opponents soul.";
            }if (Globals.weapon == 2)
            {
                wepaonChoice = "The arrow has been loaded." +
                    "\nThe player charge press the fire button.";
            }if (Globals.weapon == 3)
            {
                wepaonChoice = "The player rise its sword and swing it at the enemies.";
            }if (Globals.weapon == 4)
            {
                wepaonChoice = "With a hasty motion the player raises its axe and chops the opponents.";
            }
            spawnerFight.Text = ("Burning beings." +
                "\nWho gave powders." +
                "\nThe player walks with definite steps." +
                wepaonChoice + "\nLifeless powder on the ground." +
                "\nThe player picks some of it up.");
        }

        private void next_Click(object sender, EventArgs e)
        {
            spawnerPicture.Visible = false;
            spawnerFight.Visible = false;
            chestsPicture.Visible = false;
            text.Visible = false;
            next.Visible = false;
            whiteBox2.Visible = true;
            questionBox2.Visible = true;
            Lava.Visible = true;
            Dig.Visible = true;

        }

        private void Lava_Click(object sender, EventArgs e)
        {
            close.Visible = true;
            whiteBox2.Visible = false;
            questionBox2.Visible = false;
            Lava.Visible = false;
            Dig.Visible = false;
            death.Visible = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            GameOver gameOverScreen = new GameOver();

            gameOverScreen.Show();

            this.Hide();
        }

        private void Dig_Click(object sender, EventArgs e)
        {
            whiteBox2.Visible = false;
            questionBox2.Visible = false;
            Lava.Visible = false;
            Dig.Visible = false;
            pigmen.Visible = true;
            arrow.Visible = true;
            tunnel.Visible = true;
        }

        private void arrow_Click(object sender, EventArgs e)
        {
            arrow.Visible = false;
            pigmen.Text = "The player walked towards it." +
                "\nIt looked at the player with a smile and it took off its crown." +
                "\nIt held it towards the player." +
                "\nThe player bowed and the pigman put the crown on the player's head." +
                "\nIt waved a hand towards the tunnel.\n“Don’t look back,” it said." +
                "\nThe player walked through the tunnel not daring to look back." +
                "\nPurple blue light shines through the tunnel." +
                "\nThe player walks through the portal, it wanted to look back but didn’t have the courage to do it." +
                "\nInstead it took off the brown and held it closer so it could get a better view." +
                "\nOn the band inside the crown there was text." +
                "\nIt could not read it." +
                "\nIt put the crown back on its head and looked at the surroundings.\n";
            nextRoom.Visible = true;
        }

        private void nextRoom_Click(object sender, EventArgs e)
        {
            StrongholdScreen strongholdScreen = new StrongholdScreen();

            strongholdScreen.Show();

            this.Hide();
        }
    }
}
