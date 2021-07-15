namespace Tetris
{
    partial class BestRezultatai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BestRz = new System.Windows.Forms.DataGridView();
            this.BestRez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BestRz)).BeginInit();
            this.SuspendLayout();
            // 
            // BestRz
            // 
            this.BestRz.AllowUserToAddRows = false;
            this.BestRz.AllowUserToDeleteRows = false;
            this.BestRz.AllowUserToResizeColumns = false;
            this.BestRz.AllowUserToResizeRows = false;
            this.BestRz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BestRz.BackgroundColor = System.Drawing.Color.Black;
            this.BestRz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestRz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BestRz.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BestRz.DefaultCellStyle = dataGridViewCellStyle1;
            this.BestRz.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BestRz.GridColor = System.Drawing.Color.Black;
            this.BestRz.Location = new System.Drawing.Point(29, 3);
            this.BestRz.MultiSelect = false;
            this.BestRz.Name = "BestRz";
            this.BestRz.RowHeadersVisible = false;
            this.BestRz.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BestRz.Size = new System.Drawing.Size(336, 263);
            this.BestRz.TabIndex = 0;
            // 
            // BestRez
            // 
            this.BestRez.BackColor = System.Drawing.Color.DarkOrange;
            this.BestRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BestRez.ForeColor = System.Drawing.Color.Cyan;
            this.BestRez.Location = new System.Drawing.Point(108, 272);
            this.BestRez.Name = "BestRez";
            this.BestRez.Size = new System.Drawing.Size(140, 52);
            this.BestRez.TabIndex = 16;
            this.BestRez.Text = "Atgal";
            this.BestRez.UseVisualStyleBackColor = false;
            this.BestRez.Click += new System.EventHandler(this.BestRez_Click);
            // 
            // BestRezultatai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(360, 328);
            this.Controls.Add(this.BestRez);
            this.Controls.Add(this.BestRz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BestRezultatai";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geriausi rezultatai";
            this.Load += new System.EventHandler(this.BestRezultatai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BestRz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BestRz;
        private System.Windows.Forms.Button BestRez;
    }
}