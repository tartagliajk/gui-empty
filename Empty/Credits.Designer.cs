namespace Empty
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            this.thanks = new System.Windows.Forms.Label();
            this.CreditText = new System.Windows.Forms.Label();
            this.DuckPicture = new System.Windows.Forms.PictureBox();
            this.CreditPictureText = new System.Windows.Forms.Label();
            this.Homebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DuckPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // thanks
            // 
            this.thanks.Dock = System.Windows.Forms.DockStyle.Top;
            this.thanks.Font = new System.Drawing.Font("Determination Mono Web", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanks.Location = new System.Drawing.Point(0, 0);
            this.thanks.Name = "thanks";
            this.thanks.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.thanks.Size = new System.Drawing.Size(1164, 84);
            this.thanks.TabIndex = 0;
            this.thanks.Text = "Thanks for playing !";
            this.thanks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreditText
            // 
            this.CreditText.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditText.Location = new System.Drawing.Point(566, 156);
            this.CreditText.Name = "CreditText";
            this.CreditText.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.CreditText.Size = new System.Drawing.Size(555, 296);
            this.CreditText.TabIndex = 1;
            this.CreditText.Text = "A game by: Nina\r\n\r\nInspired by Minecraft && Undertale\r\n\r\nSpecial thanks to \r\n- Te" +
    "chnoblade ♛\r\n- Dottore (for exprementing on kids)\r\n- Tartaglia (for the funds :D" +
    ")";
            this.CreditText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DuckPicture
            // 
            this.DuckPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DuckPicture.BackgroundImage")));
            this.DuckPicture.InitialImage = null;
            this.DuckPicture.Location = new System.Drawing.Point(88, 113);
            this.DuckPicture.Name = "DuckPicture";
            this.DuckPicture.Size = new System.Drawing.Size(401, 394);
            this.DuckPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DuckPicture.TabIndex = 2;
            this.DuckPicture.TabStop = false;
            // 
            // CreditPictureText
            // 
            this.CreditPictureText.AutoSize = true;
            this.CreditPictureText.Font = new System.Drawing.Font("Determination Mono Web", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditPictureText.Location = new System.Drawing.Point(66, 510);
            this.CreditPictureText.Name = "CreditPictureText";
            this.CreditPictureText.Size = new System.Drawing.Size(449, 21);
            this.CreditPictureText.TabIndex = 3;
            this.CreditPictureText.Text = "Picture credits goes to the original artist\r\n";
            // 
            // Homebutton
            // 
            this.Homebutton.BackColor = System.Drawing.Color.Black;
            this.Homebutton.Font = new System.Drawing.Font("Determination Mono Web", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homebutton.ForeColor = System.Drawing.Color.White;
            this.Homebutton.Location = new System.Drawing.Point(789, 480);
            this.Homebutton.Name = "Homebutton";
            this.Homebutton.Size = new System.Drawing.Size(103, 39);
            this.Homebutton.TabIndex = 4;
            this.Homebutton.Text = "Back";
            this.Homebutton.UseVisualStyleBackColor = false;
            this.Homebutton.Click += new System.EventHandler(this.LoadStartScreen);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1164, 615);
            this.Controls.Add(this.Homebutton);
            this.Controls.Add(this.CreditPictureText);
            this.Controls.Add(this.DuckPicture);
            this.Controls.Add(this.CreditText);
            this.Controls.Add(this.thanks);
            this.Font = new System.Drawing.Font("Determination Mono Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Credits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits";
            ((System.ComponentModel.ISupportInitialize)(this.DuckPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thanks;
        private System.Windows.Forms.Label CreditText;
        private System.Windows.Forms.PictureBox DuckPicture;
        private System.Windows.Forms.Label CreditPictureText;
        private System.Windows.Forms.Button Homebutton;
    }
}