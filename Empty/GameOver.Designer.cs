﻿namespace Empty
{
    partial class GameOver
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
            this.end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.BackColor = System.Drawing.Color.Black;
            this.end.Font = new System.Drawing.Font("Determination Mono Web", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.ForeColor = System.Drawing.Color.Red;
            this.end.Location = new System.Drawing.Point(191, 154);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(307, 71);
            this.end.TabIndex = 0;
            this.end.Text = "Game Over";
            this.end.UseVisualStyleBackColor = false;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 394);
            this.Controls.Add(this.end);
            this.Font = new System.Drawing.Font("Determination Mono Web", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button end;
    }
}