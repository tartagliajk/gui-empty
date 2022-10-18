namespace Empty
{
    partial class IntroScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroScreen));
            this.loading = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.arrow = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loading
            // 
            this.loading.Dock = System.Windows.Forms.DockStyle.Top;
            this.loading.Font = new System.Drawing.Font("Determination Mono Web", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading.Location = new System.Drawing.Point(0, 0);
            this.loading.Name = "loading";
            this.loading.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.loading.Size = new System.Drawing.Size(1164, 156);
            this.loading.TabIndex = 0;
            this.loading.Text = "Loading...";
            this.loading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(330, 286);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(486, 108);
            this.text.TabIndex = 3;
            this.text.Text = "The world is loading.\r\nEvery block is being placed.\r\nTrees and oceans are creatin" +
    "g.";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrow
            // 
            this.arrow.BackColor = System.Drawing.Color.Black;
            this.arrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrow.BackgroundImage")));
            this.arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.arrow.ForeColor = System.Drawing.Color.Transparent;
            this.arrow.Location = new System.Drawing.Point(734, 408);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(93, 24);
            this.arrow.TabIndex = 4;
            this.arrow.UseVisualStyleBackColor = false;
            this.arrow.Click += new System.EventHandler(this.arrow_Click);
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Font = new System.Drawing.Font("Determination Mono Web", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(1081, 580);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(108, 45);
            this.next.TabIndex = 5;
            this.next.Text = "next";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(316, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 130);
            this.label2.TabIndex = 22;
            // 
            // IntroScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1164, 615);
            this.Controls.Add(this.next);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.text);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Determination Mono Web", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IntroScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntroScreen";
            this.Load += new System.EventHandler(this.IntroScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button arrow;
        private System.Windows.Forms.Label next;
        private System.Windows.Forms.Label label2;
    }
}