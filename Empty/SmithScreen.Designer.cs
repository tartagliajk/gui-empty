namespace Empty
{
    partial class SmithScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmithScreen));
            this.text = new System.Windows.Forms.Label();
            this.Axe = new System.Windows.Forms.Button();
            this.Sword = new System.Windows.Forms.Button();
            this.sunrise = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sunrise)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Determination Mono Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(57, 114);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(487, 393);
            this.text.TabIndex = 30;
            this.text.Text = "steps. steps. steps.\r\nMetal meets metal.\r\nThe player hears loud clings.\r\nThe vill" +
    "ager says something.\r\nWords that don\'t mean anything.\r\nThe player points…";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Axe
            // 
            this.Axe.BackColor = System.Drawing.Color.Black;
            this.Axe.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Axe.ForeColor = System.Drawing.Color.Tan;
            this.Axe.Location = new System.Drawing.Point(934, 441);
            this.Axe.Name = "Axe";
            this.Axe.Size = new System.Drawing.Size(150, 47);
            this.Axe.TabIndex = 29;
            this.Axe.Text = "Axe";
            this.Axe.UseVisualStyleBackColor = false;
            this.Axe.Click += new System.EventHandler(this.Axe_Click);
            // 
            // Sword
            // 
            this.Sword.BackColor = System.Drawing.Color.Black;
            this.Sword.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sword.ForeColor = System.Drawing.Color.Orange;
            this.Sword.Location = new System.Drawing.Point(664, 441);
            this.Sword.Name = "Sword";
            this.Sword.Size = new System.Drawing.Size(150, 47);
            this.Sword.TabIndex = 28;
            this.Sword.Text = "Sword";
            this.Sword.UseVisualStyleBackColor = false;
            this.Sword.Click += new System.EventHandler(this.Sword_Click);
            // 
            // sunrise
            // 
            this.sunrise.Image = ((System.Drawing.Image)(resources.GetObject("sunrise.Image")));
            this.sunrise.Location = new System.Drawing.Point(613, 120);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(508, 279);
            this.sunrise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunrise.TabIndex = 27;
            this.sunrise.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 416);
            this.label2.TabIndex = 31;
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Font = new System.Drawing.Font("Determination Mono Web", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(1061, 579);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(108, 45);
            this.next.TabIndex = 32;
            this.next.Text = "next";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // SmithScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1166, 623);
            this.Controls.Add(this.next);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Axe);
            this.Controls.Add(this.Sword);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Determination Mono Web", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SmithScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "smith";
            ((System.ComponentModel.ISupportInitialize)(this.sunrise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button Axe;
        private System.Windows.Forms.Button Sword;
        private System.Windows.Forms.PictureBox sunrise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label next;
    }
}