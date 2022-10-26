namespace Empty
{
    partial class RangeSmithScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.Range = new System.Windows.Forms.Button();
            this.Smith = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Determination Mono Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 115);
            this.label1.TabIndex = 25;
            this.label1.Text = "Does the player go to the weapon smith or the archer range?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Range
            // 
            this.Range.BackColor = System.Drawing.Color.Black;
            this.Range.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Range.ForeColor = System.Drawing.Color.Crimson;
            this.Range.Location = new System.Drawing.Point(659, 375);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(150, 47);
            this.Range.TabIndex = 24;
            this.Range.Text = "Range";
            this.Range.UseVisualStyleBackColor = false;
            this.Range.Click += new System.EventHandler(this.Range_Click);
            // 
            // Smith
            // 
            this.Smith.BackColor = System.Drawing.Color.Black;
            this.Smith.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smith.ForeColor = System.Drawing.Color.SlateGray;
            this.Smith.Location = new System.Drawing.Point(361, 375);
            this.Smith.Name = "Smith";
            this.Smith.Size = new System.Drawing.Size(150, 47);
            this.Smith.TabIndex = 23;
            this.Smith.Text = "Smith";
            this.Smith.UseVisualStyleBackColor = false;
            this.Smith.Click += new System.EventHandler(this.Smith_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(330, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 138);
            this.label2.TabIndex = 26;
            // 
            // RangeSmithScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1166, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Range);
            this.Controls.Add(this.Smith);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Determination Mono Web", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RangeSmithScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RangeSmith";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Range;
        private System.Windows.Forms.Button Smith;
        private System.Windows.Forms.Label label2;
    }
}