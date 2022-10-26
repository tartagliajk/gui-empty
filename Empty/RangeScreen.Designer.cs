namespace Empty
{
    partial class RangeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangeScreen));
            this.text = new System.Windows.Forms.Label();
            this.Crossbow = new System.Windows.Forms.Button();
            this.Bow = new System.Windows.Forms.Button();
            this.sunrise = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sunrise)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Determination Mono Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(39, 89);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(487, 393);
            this.text.TabIndex = 25;
            this.text.Text = "steps. steps. steps.\r\nBow meets air.\r\nTsurune.\r\nThe player hears the arrow being " +
    "released.\r\nCutting through air.\r\nThe villager says something.\r\nWords that don\'t " +
    "mean anything.\r\nThe player points…";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Crossbow
            // 
            this.Crossbow.BackColor = System.Drawing.Color.Black;
            this.Crossbow.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crossbow.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Crossbow.Location = new System.Drawing.Point(916, 416);
            this.Crossbow.Name = "Crossbow";
            this.Crossbow.Size = new System.Drawing.Size(150, 47);
            this.Crossbow.TabIndex = 24;
            this.Crossbow.Text = "Crossbow";
            this.Crossbow.UseVisualStyleBackColor = false;
            this.Crossbow.Click += new System.EventHandler(this.Crossbow_Click);
            // 
            // Bow
            // 
            this.Bow.BackColor = System.Drawing.Color.Black;
            this.Bow.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bow.ForeColor = System.Drawing.Color.SeaGreen;
            this.Bow.Location = new System.Drawing.Point(646, 416);
            this.Bow.Name = "Bow";
            this.Bow.Size = new System.Drawing.Size(150, 47);
            this.Bow.TabIndex = 23;
            this.Bow.Text = "Bow";
            this.Bow.UseVisualStyleBackColor = false;
            this.Bow.Click += new System.EventHandler(this.Bow_Click);
            // 
            // sunrise
            // 
            this.sunrise.Image = ((System.Drawing.Image)(resources.GetObject("sunrise.Image")));
            this.sunrise.Location = new System.Drawing.Point(595, 95);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(508, 279);
            this.sunrise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunrise.TabIndex = 22;
            this.sunrise.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 416);
            this.label2.TabIndex = 26;
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Font = new System.Drawing.Font("Determination Mono Web", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(1062, 580);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(108, 45);
            this.next.TabIndex = 27;
            this.next.Text = "next";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // RangeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1166, 623);
            this.Controls.Add(this.next);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Crossbow);
            this.Controls.Add(this.Bow);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Determination Mono Web", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RangeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RangeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.sunrise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button Crossbow;
        private System.Windows.Forms.Button Bow;
        private System.Windows.Forms.PictureBox sunrise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label next;
    }
}