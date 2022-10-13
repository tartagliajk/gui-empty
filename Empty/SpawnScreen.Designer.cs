namespace Empty
{
    partial class SpawnScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpawnScreen));
            this.arrow = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arrow
            // 
            this.arrow.BackColor = System.Drawing.Color.Black;
            this.arrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrow.BackgroundImage")));
            this.arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.arrow.ForeColor = System.Drawing.Color.Transparent;
            this.arrow.Location = new System.Drawing.Point(743, 374);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(93, 24);
            this.arrow.TabIndex = 10;
            this.arrow.UseVisualStyleBackColor = false;
            this.arrow.Click += new System.EventHandler(this.arrow_Click);
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Determination Mono Web", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(339, 239);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(486, 116);
            this.text.TabIndex = 9;
            this.text.Text = "Sunrise…something the player hasn\'t experienced in ages.\r\nSomething so beautiful " +
    "but yet so wrong.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(328, 230);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(508, 138);
            this.textBox1.TabIndex = 8;
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Font = new System.Drawing.Font("Determination Mono Web", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(1082, 582);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(83, 35);
            this.next.TabIndex = 11;
            this.next.Text = "next";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // SpawnScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1164, 615);
            this.Controls.Add(this.next);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.text);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Determination Mono Web", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SpawnScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button arrow;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label next;
    }
}