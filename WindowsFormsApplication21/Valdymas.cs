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
    public partial class Valdymas : Form
    {
        public Valdymas()
        {
            InitializeComponent();
        }

        private void Valdymas_Load(object sender, EventArgs e)
        {
            Mygtukai.Columns.Add("Mygtukas", "Mygtukas");
            Mygtukai.Columns.Add("Funkcija", "Funkcija");
            Mygtukai.Rows.Add("A","Figūra pajudinama į kairę");
            Mygtukai.Rows.Add("D", "Figūra pajudinama į dešinę");
            Mygtukai.Rows.Add("S", "Figūra pajudinama į apačią");
            Mygtukai.Rows.Add("W", "Figūra atsiranda apačioje");
            Mygtukai.Rows.Add("Q", "Figūra vartoma prieš laikrodžio rodyklę");
            Mygtukai.Rows.Add("E", "Figūra vartoma pagal laikrodžio rodyklę");
            Mygtukai.Rows.Add("R", "Panaudojamas pastiprinimas");
            Mygtukai.Rows.Add("Esc", "Sustabdo žaidimą");

            Mygtukai.Columns[1].Width = 400;


        }

        private void ValdymasButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
