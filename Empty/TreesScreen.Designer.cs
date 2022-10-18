namespace Empty
{
    partial class TreesScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreesScreen));
            this.sunrise = new System.Windows.Forms.PictureBox();
            this.forest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sunrise)).BeginInit();
            this.SuspendLayout();
            // 
            // sunrise
            // 
            this.sunrise.Image = ((System.Drawing.Image)(resources.GetObject("sunrise.Image")));
            this.sunrise.Location = new System.Drawing.Point(329, 59);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(508, 279);
            this.sunrise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunrise.TabIndex = 16;
            this.sunrise.TabStop = false;
            // 
            // forest
            // 
            this.forest.BackColor = System.Drawing.Color.Black;
            this.forest.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forest.ForeColor = System.Drawing.Color.SeaGreen;
            this.forest.Location = new System.Drawing.Point(360, 531);
            this.forest.Name = "forest";
            this.forest.Size = new System.Drawing.Size(150, 47);
            this.forest.TabIndex = 18;
            this.forest.Text = "Forest";
            this.forest.UseVisualStyleBackColor = false;
            this.forest.Click += new System.EventHandler(this.forest_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.Location = new System.Drawing.Point(658, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 47);
            this.button2.TabIndex = 19;
            this.button2.Text = "Village";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Determination Mono Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 115);
            this.label1.TabIndex = 20;
            this.label1.Text = "Does the player either go to the village or get some trees?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(329, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 138);
            this.label2.TabIndex = 21;
            // 
            // TreesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1166, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.forest);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Determination Mono Web", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TreesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trees";
            ((System.ComponentModel.ISupportInitialize)(this.sunrise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sunrise;
        private System.Windows.Forms.Button forest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}