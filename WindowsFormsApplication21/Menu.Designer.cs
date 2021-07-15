namespace Tetris
{
    partial class MenuLangas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuLangas));
            this.StartButton = new System.Windows.Forms.Button();
            this.PowerUpSlot1 = new System.Windows.Forms.PictureBox();
            this.PowerUpSlot2 = new System.Windows.Forms.PictureBox();
            this.EasyLab = new System.Windows.Forms.Label();
            this.NormalLab = new System.Windows.Forms.Label();
            this.HardLab = new System.Windows.Forms.Label();
            this.InfoLab = new System.Windows.Forms.Label();
            this.Powerup1Exp = new System.Windows.Forms.Label();
            this.Powerup2Exp = new System.Windows.Forms.Label();
            this.ValdymasButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BestRez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PowerUpSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerUpSlot2)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.DarkOrange;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.StartButton.ForeColor = System.Drawing.Color.Cyan;
            this.StartButton.Location = new System.Drawing.Point(169, 204);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(140, 49);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Pradėti";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PowerUpSlot1
            // 
            this.PowerUpSlot1.BackColor = System.Drawing.Color.DarkOrange;
            this.PowerUpSlot1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PowerUpSlot1.BackgroundImage")));
            this.PowerUpSlot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PowerUpSlot1.Location = new System.Drawing.Point(9, 33);
            this.PowerUpSlot1.Name = "PowerUpSlot1";
            this.PowerUpSlot1.Size = new System.Drawing.Size(140, 124);
            this.PowerUpSlot1.TabIndex = 4;
            this.PowerUpSlot1.TabStop = false;
            this.PowerUpSlot1.Click += new System.EventHandler(this.PowerUpSlot1_Click);
            // 
            // PowerUpSlot2
            // 
            this.PowerUpSlot2.BackColor = System.Drawing.Color.DarkOrange;
            this.PowerUpSlot2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PowerUpSlot2.BackgroundImage")));
            this.PowerUpSlot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PowerUpSlot2.Location = new System.Drawing.Point(327, 33);
            this.PowerUpSlot2.Name = "PowerUpSlot2";
            this.PowerUpSlot2.Size = new System.Drawing.Size(140, 124);
            this.PowerUpSlot2.TabIndex = 5;
            this.PowerUpSlot2.TabStop = false;
            this.PowerUpSlot2.Click += new System.EventHandler(this.PowerUpSlot2_Click);
            // 
            // EasyLab
            // 
            this.EasyLab.BackColor = System.Drawing.Color.DarkOrange;
            this.EasyLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.EasyLab.ForeColor = System.Drawing.Color.Cyan;
            this.EasyLab.Location = new System.Drawing.Point(9, 170);
            this.EasyLab.Name = "EasyLab";
            this.EasyLab.Size = new System.Drawing.Size(140, 23);
            this.EasyLab.TabIndex = 7;
            this.EasyLab.Text = "Lengvas";
            this.EasyLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EasyLab.Click += new System.EventHandler(this.EasyLab_Click);
            // 
            // NormalLab
            // 
            this.NormalLab.BackColor = System.Drawing.Color.DarkOrange;
            this.NormalLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.NormalLab.ForeColor = System.Drawing.Color.Cyan;
            this.NormalLab.Location = new System.Drawing.Point(169, 170);
            this.NormalLab.Name = "NormalLab";
            this.NormalLab.Size = new System.Drawing.Size(140, 23);
            this.NormalLab.TabIndex = 8;
            this.NormalLab.Text = "Vidutinis";
            this.NormalLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NormalLab.Click += new System.EventHandler(this.NormalLab_Click);
            // 
            // HardLab
            // 
            this.HardLab.BackColor = System.Drawing.Color.DarkOrange;
            this.HardLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.HardLab.ForeColor = System.Drawing.Color.Cyan;
            this.HardLab.Location = new System.Drawing.Point(327, 170);
            this.HardLab.Name = "HardLab";
            this.HardLab.Size = new System.Drawing.Size(140, 23);
            this.HardLab.TabIndex = 9;
            this.HardLab.Text = "Sunkus";
            this.HardLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HardLab.Click += new System.EventHandler(this.HardLab_Click);
            // 
            // InfoLab
            // 
            this.InfoLab.BackColor = System.Drawing.Color.DarkOrange;
            this.InfoLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.InfoLab.ForeColor = System.Drawing.Color.Cyan;
            this.InfoLab.Location = new System.Drawing.Point(169, 33);
            this.InfoLab.Name = "InfoLab";
            this.InfoLab.Size = new System.Drawing.Size(140, 124);
            this.InfoLab.TabIndex = 10;
            this.InfoLab.Text = "Pasirinkite žaidimo pastiprinimą ir sudėtingumo lygį";
            this.InfoLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Powerup1Exp
            // 
            this.Powerup1Exp.BackColor = System.Drawing.Color.Cyan;
            this.Powerup1Exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Powerup1Exp.ForeColor = System.Drawing.Color.DarkOrange;
            this.Powerup1Exp.Location = new System.Drawing.Point(9, 33);
            this.Powerup1Exp.Name = "Powerup1Exp";
            this.Powerup1Exp.Size = new System.Drawing.Size(140, 124);
            this.Powerup1Exp.TabIndex = 11;
            this.Powerup1Exp.Text = "Suletinamas žaidimas";
            this.Powerup1Exp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Powerup1Exp.Visible = false;
            // 
            // Powerup2Exp
            // 
            this.Powerup2Exp.BackColor = System.Drawing.Color.Cyan;
            this.Powerup2Exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Powerup2Exp.ForeColor = System.Drawing.Color.DarkOrange;
            this.Powerup2Exp.Location = new System.Drawing.Point(327, 33);
            this.Powerup2Exp.Name = "Powerup2Exp";
            this.Powerup2Exp.Size = new System.Drawing.Size(140, 124);
            this.Powerup2Exp.TabIndex = 12;
            this.Powerup2Exp.Text = "Sugriaunamos visos figuros";
            this.Powerup2Exp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Powerup2Exp.Visible = false;
            // 
            // ValdymasButton
            // 
            this.ValdymasButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ValdymasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ValdymasButton.ForeColor = System.Drawing.Color.Cyan;
            this.ValdymasButton.Location = new System.Drawing.Point(169, 259);
            this.ValdymasButton.Name = "ValdymasButton";
            this.ValdymasButton.Size = new System.Drawing.Size(140, 49);
            this.ValdymasButton.TabIndex = 13;
            this.ValdymasButton.Text = "Valdymas";
            this.ValdymasButton.UseVisualStyleBackColor = false;
            this.ValdymasButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ExitButton.ForeColor = System.Drawing.Color.Cyan;
            this.ExitButton.Location = new System.Drawing.Point(169, 372);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 49);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Išeiti";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // BestRez
            // 
            this.BestRez.BackColor = System.Drawing.Color.DarkOrange;
            this.BestRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BestRez.ForeColor = System.Drawing.Color.Cyan;
            this.BestRez.Location = new System.Drawing.Point(169, 314);
            this.BestRez.Name = "BestRez";
            this.BestRez.Size = new System.Drawing.Size(140, 52);
            this.BestRez.TabIndex = 15;
            this.BestRez.Text = "Geriausi Rezultatai";
            this.BestRez.UseVisualStyleBackColor = false;
            this.BestRez.Click += new System.EventHandler(this.BestRez_Click);
            // 
            // MenuLangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(480, 432);
            this.Controls.Add(this.BestRez);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ValdymasButton);
            this.Controls.Add(this.Powerup2Exp);
            this.Controls.Add(this.Powerup1Exp);
            this.Controls.Add(this.InfoLab);
            this.Controls.Add(this.HardLab);
            this.Controls.Add(this.NormalLab);
            this.Controls.Add(this.EasyLab);
            this.Controls.Add(this.PowerUpSlot2);
            this.Controls.Add(this.PowerUpSlot1);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuLangas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            ((System.ComponentModel.ISupportInitialize)(this.PowerUpSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerUpSlot2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox PowerUpSlot1;
        private System.Windows.Forms.PictureBox PowerUpSlot2;
        private System.Windows.Forms.Label EasyLab;
        private System.Windows.Forms.Label NormalLab;
        private System.Windows.Forms.Label HardLab;
        private System.Windows.Forms.Label InfoLab;
        private System.Windows.Forms.Label Powerup1Exp;
        private System.Windows.Forms.Label Powerup2Exp;
        private System.Windows.Forms.Button ValdymasButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BestRez;
    }
}