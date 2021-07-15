namespace Tetris
{
    partial class Valdymas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Valdymas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ValdymasButton = new System.Windows.Forms.Button();
            this.Mygtukai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Mygtukai)).BeginInit();
            this.SuspendLayout();
            // 
            // ValdymasButton
            // 
            this.ValdymasButton.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.ValdymasButton, "ValdymasButton");
            this.ValdymasButton.ForeColor = System.Drawing.Color.Cyan;
            this.ValdymasButton.Name = "ValdymasButton";
            this.ValdymasButton.UseVisualStyleBackColor = false;
            this.ValdymasButton.Click += new System.EventHandler(this.ValdymasButton_Click);
            // 
            // Mygtukai
            // 
            this.Mygtukai.AllowUserToAddRows = false;
            this.Mygtukai.AllowUserToDeleteRows = false;
            this.Mygtukai.AllowUserToResizeColumns = false;
            this.Mygtukai.AllowUserToResizeRows = false;
            this.Mygtukai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Mygtukai.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mygtukai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mygtukai.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Mygtukai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mygtukai.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Mygtukai.DefaultCellStyle = dataGridViewCellStyle1;
            this.Mygtukai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Mygtukai.GridColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.Mygtukai, "Mygtukai");
            this.Mygtukai.Name = "Mygtukai";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Mygtukai.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Mygtukai.RowHeadersVisible = false;
            // 
            // Valdymas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Mygtukai);
            this.Controls.Add(this.ValdymasButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Valdymas";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Valdymas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mygtukai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ValdymasButton;
        private System.Windows.Forms.DataGridView Mygtukai;
    }
}