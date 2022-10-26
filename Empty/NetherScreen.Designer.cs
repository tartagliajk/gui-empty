namespace Empty
{
    partial class NetherScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetherScreen));
            this.question = new System.Windows.Forms.Label();
            this.Chests = new System.Windows.Forms.Button();
            this.Spawner = new System.Windows.Forms.Button();
            this.whiteBox = new System.Windows.Forms.Label();
            this.netherPicture = new System.Windows.Forms.PictureBox();
            this.text = new System.Windows.Forms.Label();
            this.chestsPicture = new System.Windows.Forms.PictureBox();
            this.spawnerPicture = new System.Windows.Forms.PictureBox();
            this.spawnerFight = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Label();
            this.questionBox2 = new System.Windows.Forms.Label();
            this.Dig = new System.Windows.Forms.Button();
            this.Lava = new System.Windows.Forms.Button();
            this.whiteBox2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.death = new System.Windows.Forms.Label();
            this.pigmen = new System.Windows.Forms.Label();
            this.arrow = new System.Windows.Forms.Button();
            this.nextRoom = new System.Windows.Forms.Button();
            this.tunnel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.netherPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chestsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tunnel)).BeginInit();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.Font = new System.Drawing.Font("Determination Mono Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(48, 391);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(487, 115);
            this.question.TabIndex = 29;
            this.question.Text = "Does the player want to go to the spawner or explore chests?";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chests
            // 
            this.Chests.BackColor = System.Drawing.Color.Black;
            this.Chests.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chests.ForeColor = System.Drawing.Color.Crimson;
            this.Chests.Location = new System.Drawing.Point(366, 542);
            this.Chests.Name = "Chests";
            this.Chests.Size = new System.Drawing.Size(150, 47);
            this.Chests.TabIndex = 28;
            this.Chests.Text = "Chests";
            this.Chests.UseVisualStyleBackColor = false;
            this.Chests.Click += new System.EventHandler(this.Chests_Click);
            // 
            // Spawner
            // 
            this.Spawner.BackColor = System.Drawing.Color.Black;
            this.Spawner.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spawner.ForeColor = System.Drawing.Color.SlateGray;
            this.Spawner.Location = new System.Drawing.Point(68, 542);
            this.Spawner.Name = "Spawner";
            this.Spawner.Size = new System.Drawing.Size(160, 47);
            this.Spawner.TabIndex = 27;
            this.Spawner.Text = "Spawner";
            this.Spawner.UseVisualStyleBackColor = false;
            this.Spawner.Click += new System.EventHandler(this.Spawner_Click);
            // 
            // whiteBox
            // 
            this.whiteBox.BackColor = System.Drawing.Color.White;
            this.whiteBox.Location = new System.Drawing.Point(37, 380);
            this.whiteBox.Name = "whiteBox";
            this.whiteBox.Size = new System.Drawing.Size(508, 138);
            this.whiteBox.TabIndex = 30;
            // 
            // netherPicture
            // 
            this.netherPicture.BackColor = System.Drawing.Color.White;
            this.netherPicture.Image = ((System.Drawing.Image)(resources.GetObject("netherPicture.Image")));
            this.netherPicture.Location = new System.Drawing.Point(40, 49);
            this.netherPicture.Name = "netherPicture";
            this.netherPicture.Size = new System.Drawing.Size(505, 294);
            this.netherPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.netherPicture.TabIndex = 31;
            this.netherPicture.TabStop = false;
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(632, 103);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(443, 426);
            this.text.TabIndex = 32;
            this.text.Text = resources.GetString("text.Text");
            // 
            // chestsPicture
            // 
            this.chestsPicture.BackColor = System.Drawing.Color.White;
            this.chestsPicture.Image = ((System.Drawing.Image)(resources.GetObject("chestsPicture.Image")));
            this.chestsPicture.Location = new System.Drawing.Point(40, 167);
            this.chestsPicture.Name = "chestsPicture";
            this.chestsPicture.Size = new System.Drawing.Size(505, 294);
            this.chestsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chestsPicture.TabIndex = 33;
            this.chestsPicture.TabStop = false;
            // 
            // spawnerPicture
            // 
            this.spawnerPicture.BackColor = System.Drawing.Color.White;
            this.spawnerPicture.Image = ((System.Drawing.Image)(resources.GetObject("spawnerPicture.Image")));
            this.spawnerPicture.Location = new System.Drawing.Point(40, 167);
            this.spawnerPicture.Name = "spawnerPicture";
            this.spawnerPicture.Size = new System.Drawing.Size(505, 294);
            this.spawnerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spawnerPicture.TabIndex = 34;
            this.spawnerPicture.TabStop = false;
            // 
            // spawnerFight
            // 
            this.spawnerFight.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spawnerFight.Location = new System.Drawing.Point(597, 180);
            this.spawnerFight.Name = "spawnerFight";
            this.spawnerFight.Size = new System.Drawing.Size(463, 281);
            this.spawnerFight.TabIndex = 35;
            this.spawnerFight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Font = new System.Drawing.Font("Determination Mono Web", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(1056, 568);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(108, 45);
            this.next.TabIndex = 36;
            this.next.Text = "next";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // questionBox2
            // 
            this.questionBox2.Font = new System.Drawing.Font("Determination Mono Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBox2.Location = new System.Drawing.Point(360, 256);
            this.questionBox2.Name = "questionBox2";
            this.questionBox2.Size = new System.Drawing.Size(487, 115);
            this.questionBox2.TabIndex = 39;
            this.questionBox2.Text = "Does it bridge over the lava or does the player dig its way through?";
            this.questionBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dig
            // 
            this.Dig.BackColor = System.Drawing.Color.Black;
            this.Dig.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dig.ForeColor = System.Drawing.Color.Crimson;
            this.Dig.Location = new System.Drawing.Point(678, 407);
            this.Dig.Name = "Dig";
            this.Dig.Size = new System.Drawing.Size(150, 47);
            this.Dig.TabIndex = 38;
            this.Dig.Text = "Dig";
            this.Dig.UseVisualStyleBackColor = false;
            this.Dig.Click += new System.EventHandler(this.Dig_Click);
            // 
            // Lava
            // 
            this.Lava.BackColor = System.Drawing.Color.Black;
            this.Lava.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lava.ForeColor = System.Drawing.Color.SlateGray;
            this.Lava.Location = new System.Drawing.Point(380, 407);
            this.Lava.Name = "Lava";
            this.Lava.Size = new System.Drawing.Size(150, 47);
            this.Lava.TabIndex = 37;
            this.Lava.Text = "Lava";
            this.Lava.UseVisualStyleBackColor = false;
            this.Lava.Click += new System.EventHandler(this.Lava_Click);
            // 
            // whiteBox2
            // 
            this.whiteBox2.BackColor = System.Drawing.Color.White;
            this.whiteBox2.Location = new System.Drawing.Point(349, 245);
            this.whiteBox2.Name = "whiteBox2";
            this.whiteBox2.Size = new System.Drawing.Size(508, 138);
            this.whiteBox2.TabIndex = 40;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Determination Mono Web", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1056, 568);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(108, 45);
            this.close.TabIndex = 41;
            this.close.Text = "next";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // death
            // 
            this.death.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.death.Location = new System.Drawing.Point(323, 180);
            this.death.Name = "death";
            this.death.Size = new System.Drawing.Size(544, 252);
            this.death.TabIndex = 42;
            this.death.Text = "One block, Two blocks, Three blocks, Four blocks.\r\nMisplaced. \r\nIt falls from its" +
    " own creation. \r\n“Failure” it thought as the lava wrapped around it. \r\n“Back to " +
    "black”\r\nDeath";
            this.death.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pigmen
            // 
            this.pigmen.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pigmen.Location = new System.Drawing.Point(12, 35);
            this.pigmen.Name = "pigmen";
            this.pigmen.Size = new System.Drawing.Size(691, 534);
            this.pigmen.TabIndex = 43;
            this.pigmen.Text = resources.GetString("pigmen.Text");
            // 
            // arrow
            // 
            this.arrow.BackColor = System.Drawing.Color.Black;
            this.arrow.Font = new System.Drawing.Font("Determination Mono Web", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrow.Location = new System.Drawing.Point(806, 532);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(150, 53);
            this.arrow.TabIndex = 44;
            this.arrow.Text = "-->";
            this.arrow.UseVisualStyleBackColor = false;
            this.arrow.Click += new System.EventHandler(this.arrow_Click);
            // 
            // nextRoom
            // 
            this.nextRoom.BackColor = System.Drawing.Color.Black;
            this.nextRoom.Font = new System.Drawing.Font("Determination Mono Web", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextRoom.Location = new System.Drawing.Point(806, 532);
            this.nextRoom.Name = "nextRoom";
            this.nextRoom.Size = new System.Drawing.Size(150, 53);
            this.nextRoom.TabIndex = 45;
            this.nextRoom.Text = "-->";
            this.nextRoom.UseVisualStyleBackColor = false;
            this.nextRoom.Click += new System.EventHandler(this.nextRoom_Click);
            // 
            // tunnel
            // 
            this.tunnel.Image = ((System.Drawing.Image)(resources.GetObject("tunnel.Image")));
            this.tunnel.Location = new System.Drawing.Point(678, 113);
            this.tunnel.Name = "tunnel";
            this.tunnel.Size = new System.Drawing.Size(470, 270);
            this.tunnel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tunnel.TabIndex = 46;
            this.tunnel.TabStop = false;
            // 
            // NetherScreen
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1160, 611);
            this.Controls.Add(this.tunnel);
            this.Controls.Add(this.nextRoom);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.pigmen);
            this.Controls.Add(this.death);
            this.Controls.Add(this.close);
            this.Controls.Add(this.questionBox2);
            this.Controls.Add(this.Dig);
            this.Controls.Add(this.Lava);
            this.Controls.Add(this.next);
            this.Controls.Add(this.spawnerFight);
            this.Controls.Add(this.spawnerPicture);
            this.Controls.Add(this.chestsPicture);
            this.Controls.Add(this.text);
            this.Controls.Add(this.netherPicture);
            this.Controls.Add(this.question);
            this.Controls.Add(this.Chests);
            this.Controls.Add(this.Spawner);
            this.Controls.Add(this.whiteBox);
            this.Controls.Add(this.whiteBox2);
            this.Font = new System.Drawing.Font("Determination Mono Web", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NetherScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.netherPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chestsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tunnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button Chests;
        private System.Windows.Forms.Button Spawner;
        private System.Windows.Forms.Label whiteBox;
        private System.Windows.Forms.PictureBox netherPicture;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.PictureBox chestsPicture;
        private System.Windows.Forms.PictureBox spawnerPicture;
        private System.Windows.Forms.Label spawnerFight;
        private System.Windows.Forms.Label next;
        private System.Windows.Forms.Label questionBox2;
        private System.Windows.Forms.Button Dig;
        private System.Windows.Forms.Button Lava;
        private System.Windows.Forms.Label whiteBox2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label death;
        private System.Windows.Forms.Label pigmen;
        private System.Windows.Forms.Button arrow;
        private System.Windows.Forms.Button nextRoom;
        private System.Windows.Forms.PictureBox tunnel;
    }
}