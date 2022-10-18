namespace Empty
{
    partial class ForestScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForestScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sunrise = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sunrise)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Determination Mono Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(596, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 115);
            this.label1.TabIndex = 25;
            this.label1.Text = "Does the player want to make tools or go to the village?\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.Location = new System.Drawing.Point(910, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 47);
            this.button2.TabIndex = 24;
            this.button2.Text = "Village";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(612, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 47);
            this.button1.TabIndex = 23;
            this.button1.Text = "Tools";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sunrise
            // 
            this.sunrise.Image = ((System.Drawing.Image)(resources.GetObject("sunrise.Image")));
            this.sunrise.Location = new System.Drawing.Point(584, 52);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(508, 279);
            this.sunrise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunrise.TabIndex = 22;
            this.sunrise.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(585, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 138);
            this.label2.TabIndex = 26;
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(71, 136);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(452, 362);
            this.text.TabIndex = 27;
            this.text.Text = "The player has never seen trees this tall.\r\nIs it the player that is short or is " +
    "it the trees that are tall?\r\n\r\n";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1166, 623);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Determination Mono Web", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ForestScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forest";
            ((System.ComponentModel.ISupportInitialize)(this.sunrise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox sunrise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text;
    }
}