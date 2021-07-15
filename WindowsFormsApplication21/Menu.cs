using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class MenuLangas : Form
    {
        public MenuLangas()
        {
            InitializeComponent();
        }
        int sunkumas;
        int points=1;
        public static  bool yravardas;
        private void StartButton_Click(object sender, EventArgs e)
        {
            Username name = new Username();
            name.ShowDialog();


            if (yravardas == false)
            { mySqlFunctions.vardas = "Nežinomas"; }
                Zaidimo_Ekranas Play = new Zaidimo_Ekranas();
                if (PowerUpSlot1.BackColor == Color.Cyan)
                {
                    Play.PowerUpSelected = 1;

                }
                else if (PowerUpSlot2.BackColor == Color.Cyan)
                {
                    Play.PowerUpSelected = 2;

                }



                Play.StartPosition = this.StartPosition;
                this.Hide();
                Play.difficulty = sunkumas;
                Play.taskas = points;
                Play.Show();

                Play.FormClosed += (s, args) => this.Show();



            
          
 

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EasyLab_Click(object sender, EventArgs e)
        {
            EasyLab.BackColor = Color.Cyan;
            NormalLab.BackColor = Color.DarkOrange;
            HardLab.BackColor= Color.DarkOrange;
            sunkumas = 0;
            points = 1;
            EasyLab.ForeColor = Color.DarkOrange;
            NormalLab.ForeColor = Color.Cyan;
            HardLab.ForeColor = Color.Cyan;
        }

        private void NormalLab_Click(object sender, EventArgs e)
        {
            EasyLab.BackColor = Color.DarkOrange;
            NormalLab.BackColor = Color.Cyan;
            HardLab.BackColor = Color.DarkOrange;
            sunkumas = 2;
            points = 5;
            EasyLab.ForeColor = Color.Cyan;
            NormalLab.ForeColor = Color.DarkOrange;
            HardLab.ForeColor = Color.Cyan;
        }

        private void HardLab_Click(object sender, EventArgs e)
        {
            sunkumas = 3;
            points = 10;
            EasyLab.BackColor = Color.DarkOrange;
            NormalLab.BackColor = Color.DarkOrange;
            HardLab.BackColor = Color.Cyan;
            EasyLab.ForeColor = Color.Cyan;
            NormalLab.ForeColor = Color.Cyan;
            HardLab.ForeColor = Color.DarkOrange;
        }

        private void PowerUpSlot1_Click(object sender, EventArgs e)
        {
            PowerUpSlot1.BackColor = Color.Cyan;
            PowerUpSlot2.BackColor = Color.DarkOrange;
            Powerup1Exp.Visible = true;
            Powerup2Exp.Visible = false;
        }

        private void PowerUpSlot2_Click(object sender, EventArgs e)
        {
            PowerUpSlot1.BackColor = Color.DarkOrange;
            PowerUpSlot2.BackColor = Color.Cyan;

            Powerup2Exp.Visible = true;
            Powerup1Exp.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Valdymas Forma = new Valdymas();
            Forma.ShowDialog();

        }

        private void BestRez_Click(object sender, EventArgs e)
        {
            BestRezultatai Top10 = new BestRezultatai();
            Top10.ShowDialog();
        }
    }
}
