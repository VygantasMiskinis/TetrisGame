namespace Tetris
{
    partial class Zaidimo_Ekranas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zaidimo_Ekranas));
            this.Game = new System.Windows.Forms.Timer(this.components);
            this.Zaidimo_Laukas = new System.Windows.Forms.PictureBox();
            this.KitaFiguraPicture = new System.Windows.Forms.PictureBox();
            this.TimeNum = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.ScoreNum = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ComboTimer = new System.Windows.Forms.Timer(this.components);
            this.PowerUpSlot1 = new System.Windows.Forms.PictureBox();
            this.PowerUpTimer = new System.Windows.Forms.Timer(this.components);
            this.SekantiFiguraText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboMeter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Zaidimo_Laukas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitaFiguraPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerUpSlot1)).BeginInit();
            this.SuspendLayout();
            // 
            // Game
            // 
            this.Game.Interval = 500;
            this.Game.Tick += new System.EventHandler(this.Game_Tick);
            // 
            // Zaidimo_Laukas
            // 
            this.Zaidimo_Laukas.BackColor = System.Drawing.Color.Transparent;
            this.Zaidimo_Laukas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Zaidimo_Laukas.Location = new System.Drawing.Point(147, 77);
            this.Zaidimo_Laukas.Name = "Zaidimo_Laukas";
            this.Zaidimo_Laukas.Size = new System.Drawing.Size(250, 375);
            this.Zaidimo_Laukas.TabIndex = 0;
            this.Zaidimo_Laukas.TabStop = false;
            // 
            // KitaFiguraPicture
            // 
            this.KitaFiguraPicture.BackColor = System.Drawing.Color.Transparent;
            this.KitaFiguraPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.KitaFiguraPicture.Location = new System.Drawing.Point(12, 273);
            this.KitaFiguraPicture.Name = "KitaFiguraPicture";
            this.KitaFiguraPicture.Size = new System.Drawing.Size(94, 94);
            this.KitaFiguraPicture.TabIndex = 1;
            this.KitaFiguraPicture.TabStop = false;
            // 
            // TimeNum
            // 
            this.TimeNum.AutoSize = true;
            this.TimeNum.BackColor = System.Drawing.Color.Black;
            this.TimeNum.Font = new System.Drawing.Font("AcmeFont", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeNum.ForeColor = System.Drawing.Color.Cyan;
            this.TimeNum.Location = new System.Drawing.Point(222, 20);
            this.TimeNum.Name = "TimeNum";
            this.TimeNum.Size = new System.Drawing.Size(79, 35);
            this.TimeNum.TabIndex = 4;
            this.TimeNum.Text = "2:30";
            // 
            // ScoreText
            // 
            this.ScoreText.BackColor = System.Drawing.Color.Black;
            this.ScoreText.Font = new System.Drawing.Font("AcmeFont", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.ForeColor = System.Drawing.Color.Cyan;
            this.ScoreText.Location = new System.Drawing.Point(13, 370);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(94, 33);
            this.ScoreText.TabIndex = 5;
            this.ScoreText.Text = "Taškai";
            this.ScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreNum
            // 
            this.ScoreNum.BackColor = System.Drawing.Color.Transparent;
            this.ScoreNum.Font = new System.Drawing.Font("AcmeFont", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreNum.ForeColor = System.Drawing.Color.Cyan;
            this.ScoreNum.Location = new System.Drawing.Point(13, 403);
            this.ScoreNum.Name = "ScoreNum";
            this.ScoreNum.Size = new System.Drawing.Size(93, 23);
            this.ScoreNum.TabIndex = 999999;
            this.ScoreNum.Text = "--;--";
            this.ScoreNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // ComboTimer
            // 
            this.ComboTimer.Interval = 1000;
            this.ComboTimer.Tick += new System.EventHandler(this.ComboTimer_Tick);
            // 
            // PowerUpSlot1
            // 
            this.PowerUpSlot1.BackColor = System.Drawing.Color.Black;
            this.PowerUpSlot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PowerUpSlot1.Location = new System.Drawing.Point(12, 77);
            this.PowerUpSlot1.Name = "PowerUpSlot1";
            this.PowerUpSlot1.Size = new System.Drawing.Size(94, 94);
            this.PowerUpSlot1.TabIndex = 1000001;
            this.PowerUpSlot1.TabStop = false;
            // 
            // PowerUpTimer
            // 
            this.PowerUpTimer.Interval = 1000;
            this.PowerUpTimer.Tick += new System.EventHandler(this.PowerUpTimer_Tick);
            // 
            // SekantiFiguraText
            // 
            this.SekantiFiguraText.BackColor = System.Drawing.Color.Black;
            this.SekantiFiguraText.Font = new System.Drawing.Font("AcmeFont", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SekantiFiguraText.ForeColor = System.Drawing.Color.Cyan;
            this.SekantiFiguraText.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SekantiFiguraText.Location = new System.Drawing.Point(13, 194);
            this.SekantiFiguraText.Name = "SekantiFiguraText";
            this.SekantiFiguraText.Size = new System.Drawing.Size(93, 47);
            this.SekantiFiguraText.TabIndex = 1000002;
            this.SekantiFiguraText.Text = "Sekanti Figura";
            this.SekantiFiguraText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("AcmeFont", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 1000003;
            this.label1.Text = "Pastiprinimas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboMeter
            // 
            this.ComboMeter.BackColor = System.Drawing.Color.Black;
            this.ComboMeter.Font = new System.Drawing.Font("AcmeFont", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboMeter.ForeColor = System.Drawing.Color.Cyan;
            this.ComboMeter.Location = new System.Drawing.Point(12, 449);
            this.ComboMeter.Name = "ComboMeter";
            this.ComboMeter.Size = new System.Drawing.Size(106, 89);
            this.ComboMeter.TabIndex = 1000004;
            this.ComboMeter.Text = "2x";
            this.ComboMeter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComboMeter.Visible = false;
            // 
            // Zaidimo_Ekranas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 579);
            this.Controls.Add(this.ComboMeter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SekantiFiguraText);
            this.Controls.Add(this.KitaFiguraPicture);
            this.Controls.Add(this.Zaidimo_Laukas);
            this.Controls.Add(this.PowerUpSlot1);
            this.Controls.Add(this.ScoreNum);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.TimeNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zaidimo_Ekranas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Zaidimo_Ekranas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Zaidimo_Ekranas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Zaidimo_Laukas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitaFiguraPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerUpSlot1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Game;
        private System.Windows.Forms.PictureBox Zaidimo_Laukas;
        private System.Windows.Forms.PictureBox KitaFiguraPicture;
        private System.Windows.Forms.Label TimeNum;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label ScoreNum;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer ComboTimer;
        private System.Windows.Forms.PictureBox PowerUpSlot1;
        private System.Windows.Forms.Timer PowerUpTimer;
        private System.Windows.Forms.Label SekantiFiguraText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ComboMeter;
    }
}

