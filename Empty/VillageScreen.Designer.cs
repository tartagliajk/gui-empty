namespace Empty
{
    partial class VillageScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VillageScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sunrise)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Determination Mono Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 280);
            this.label1.TabIndex = 25;
            this.label1.Text = "…\r\n…\r\n…\r\nSunrise.\r\nThe player stands.\r\nThe village bell starts to ring.\r\nr i n g " +
    "  r i n g \r\nVillagers walk out from the house.\r\nReady to work, ready to repeat t" +
    "heir daily chores.";
            // 
            // sunrise
            // 
            this.sunrise.Image = ((System.Drawing.Image)(resources.GetObject("sunrise.Image")));
            this.sunrise.Location = new System.Drawing.Point(575, 27);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(541, 262);
            this.sunrise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunrise.TabIndex = 22;
            this.sunrise.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(481, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 303);
            this.label2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Determination Mono Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 368);
            this.label3.TabIndex = 27;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(508, 391);
            this.label4.TabIndex = 28;
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Font = new System.Drawing.Font("Determination Mono Web", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(1086, 589);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(83, 35);
            this.next.TabIndex = 29;
            this.next.Text = "next";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // VillageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1166, 623);
            this.Controls.Add(this.next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Determination Mono Web", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "VillageScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "village";
            ((System.ComponentModel.ISupportInitialize)(this.sunrise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox sunrise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label next;
    }
}