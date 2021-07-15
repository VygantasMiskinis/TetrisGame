namespace Tetris
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
            this.Ne = new System.Windows.Forms.Button();
            this.Taip = new System.Windows.Forms.Button();
            this.Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ne
            // 
            this.Ne.BackColor = System.Drawing.Color.DarkOrange;
            this.Ne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Ne.ForeColor = System.Drawing.Color.Cyan;
            this.Ne.Location = new System.Drawing.Point(118, 144);
            this.Ne.Name = "Ne";
            this.Ne.Size = new System.Drawing.Size(106, 41);
            this.Ne.TabIndex = 1000005;
            this.Ne.Text = "Ne";
            this.Ne.UseVisualStyleBackColor = false;
            this.Ne.Click += new System.EventHandler(this.Ne_Click);
            // 
            // Taip
            // 
            this.Taip.BackColor = System.Drawing.Color.DarkOrange;
            this.Taip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Taip.ForeColor = System.Drawing.Color.Cyan;
            this.Taip.Location = new System.Drawing.Point(6, 144);
            this.Taip.Name = "Taip";
            this.Taip.Size = new System.Drawing.Size(106, 41);
            this.Taip.TabIndex = 1000006;
            this.Taip.Text = "Taip";
            this.Taip.UseVisualStyleBackColor = false;
            this.Taip.Click += new System.EventHandler(this.Taip_Click);
            // 
            // Text
            // 
            this.Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Text.ForeColor = System.Drawing.Color.Cyan;
            this.Text.Location = new System.Drawing.Point(12, 23);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(212, 81);
            this.Text.TabIndex = 1000007;
            this.Text.Text = "----";
            this.Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(231, 197);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.Taip);
            this.Controls.Add(this.Ne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOver";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ne;
        private System.Windows.Forms.Button Taip;
        private System.Windows.Forms.Label Text;
    }
}