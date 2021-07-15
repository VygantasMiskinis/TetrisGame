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
    public partial class Username : Form
    {
        bool paspaustas = false;
        public Username()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySqlFunctions.vardas = Vardelis.Text;
            MenuLangas meniu = new MenuLangas();
            if (String.IsNullOrEmpty(Vardelis.Text)==false)
            { MenuLangas.yravardas = true;this.Close(); }
            else
            {
                label1.Text = "Jeigu neįvesite vardo rezultatas nebus saugojamas";
                if (paspaustas) { this.Close(); }
                 paspaustas = true;
              
            }
          
           
           
        }

        private void Username_Load(object sender, EventArgs e)
        {
            bool paspaustas = false;
        }
    }
}
