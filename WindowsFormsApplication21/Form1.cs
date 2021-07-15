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
    public partial class Zaidimo_Ekranas : Form
    {
        public Zaidimo_Ekranas()
        {
            InitializeComponent();
        }
        public int ValdomaFigura = -1;
        Label[][] figuros = new Label[1000][];
        int[] FiguruSeka = new int[7];
       
         int powerUpAvailible =0;//kai atitikti reikalavimai gauti powerup cia rodomas turimas powerup kuri jau galima naudoti
        Label[] KurAtsiras = new Label[4];
     
      public int PowerUpSelected = 0;// 0 kai nebera 1,2,3... atitinkamai kaip pasirinkta start menu
             int PowerUpOnTime = 0;//1 power upui skaciuojamas suletintas laikas
        public int difficulty=0;
        int off1=0;
        int off2=0;

        int PX;
        int savePow=0;
        int minutes = 2;
        int sekundes = 30;
        int plotis = 11;//kiek figuru telpa horizontaliai
        int aukstis = 20;//kiek telpa figuru vertikaliai
        int PY;
        public int taskas=1;
        int Padetis = 0;
        int Tipas;
        int figuraSekoje=0; //kelinta figura yra 7 figuru sekoje
        int dydis = 22;
        int combo_multiplier=1;
        int score = 0;        
        int comboTime = 20    ;//x sekundziu po kuriu dingsta combo
        int Border = 20;
        int gap = 10;
        Label screenBord = new Label();
        Label PowerUpBord = new Label();
        Label KitaFiguraBord = new Label();
        int tarpas = 2;
        GameOver ggg = new GameOver();
       
            

       

     
        Random random = new Random();
        private void Zaidimo_Ekranas_Load(object sender, EventArgs e)
        {
           
            this.FormClosed += (s, args) => ggg.Show();
            savePow = PowerUpSelected;

            #region    issidestymas

            Zaidimo_Laukas.Width = dydis*plotis+tarpas*(plotis-1) ;
             Zaidimo_Laukas.Height = dydis *aukstis + tarpas * (aukstis - 1);

            PowerUpSlot1.Left = Zaidimo_Laukas.Left - Border - gap-PowerUpSlot1.Width;
            PowerUpSlot1.Top = Zaidimo_Laukas.Top;

            SekantiFiguraText.Top = PowerUpSlot1.Top + gap*3 + KitaFiguraPicture.Height;
            SekantiFiguraText.Left= PowerUpSlot1.Left;

            KitaFiguraPicture.Top = SekantiFiguraText.Top + gap*3+SekantiFiguraText.Height;
            KitaFiguraPicture.Left = SekantiFiguraText.Left;
            KitaFiguraPicture.Width = PowerUpSlot1.Width;

            ScoreText.Top = KitaFiguraPicture.Top + KitaFiguraPicture.Height + gap * 3;
            ScoreText.Left = KitaFiguraPicture.Left;
            ScoreText.Width = KitaFiguraBord.Width;
            ScoreNum.Left = ScoreText.Left;
            ScoreNum.Top = ScoreText.Top + ScoreText.Height + gap;
            ScoreNum.Width = ScoreText.Width;

            Controls.Add(screenBord);
            Controls.Add(KitaFiguraBord);
            Controls.Add(PowerUpBord);

            borders(screenBord, Zaidimo_Laukas);
            borders(KitaFiguraBord, KitaFiguraPicture);
          
            borders(PowerUpBord, PowerUpSlot1);
            #endregion
            grid();
           

            
            for (int i = 0; i < KurAtsiras.Length; i++)
            {

                KurAtsiras[i] = new Label();
                Controls.Add(KurAtsiras[i]);
                KurAtsiras[i].BackColor = Color.Cyan;
                KurAtsiras[i].Visible = false;
                KurAtsiras[i].Height = dydis;
                KurAtsiras[i].Width = dydis;
                KurAtsiras[i].BringToFront();
            }





          

            powerUp(PowerUpSelected);
        
            RandomFiguros();
            naujaFigura();




          
            Game.Enabled = true;
            GameTimer.Enabled = true;
            
        }
     void grid ()
        { 
                 int gridX = ((Zaidimo_Laukas.Width + 2) / (dydis + tarpas)) - 1;

                int gridY = ((Zaidimo_Laukas.Height + 2) / (dydis + tarpas)) - 1;
                int posY = Zaidimo_Laukas.Top + dydis;
                int posx = Zaidimo_Laukas.Left + dydis;

                Label[] gridYAxis = new Label[gridY];
                Label[] gridXAxis = new Label[gridX];
                for (int y = 0; y < gridYAxis.Length; y++)
                {
                    gridYAxis[y] = new Label();
                    Controls.Add(gridYAxis[y]);
                    gridYAxis[y].BackColor = Color.DimGray;
                    gridYAxis[y].Height = tarpas;
                    gridYAxis[y].Width = Zaidimo_Laukas.Width;
                    gridYAxis[y].Top = posY;
                    gridYAxis[y].Left = Zaidimo_Laukas.Left;
                    gridYAxis[y].BringToFront();
                    posY += dydis + tarpas;

                }
                for (int x = 0; x < gridXAxis.Length; x++)
                {
                    gridXAxis[x] = new Label();
                    Controls.Add(gridXAxis[x]);
                    gridXAxis[x].BackColor = Color.DimGray;
                    gridXAxis[x].Height = Zaidimo_Laukas.Height;
                    gridXAxis[x].Width = tarpas;
                    gridXAxis[x].Top = Zaidimo_Laukas.Top;
                    gridXAxis[x].Left = posx;
                    gridXAxis[x].BringToFront();
                    posx += dydis + tarpas;

                }

            
       
        }
   
        public void borders(Control _border,Control framed)
        {
            _border.Width = framed.Width + Border;
            _border.Height = framed.Height + Border;
            _border.Top = framed.Top - Border / 2;
            _border.Left = framed.Left - Border / 2;
             _border.BackColor = Color.DarkOrange;
          

        }

      
        private void Game_Tick(object sender, EventArgs e)
        {
 arYraLinija();
            Gameover();


           


            if (Game.Enabled) {
                Kritimas(figuros[ValdomaFigura], figuros,  Zaidimo_Laukas); KurKrentaFigura();
            }

            
        
          
            Refresh();
        }
        public void restart()
        {
            Game.Enabled = false;
            GameTimer.Enabled = false;
            ComboTimer.Enabled = false;
            PowerUpTimer.Enabled = false;
            Game.Interval = 500;
            GameTimer.Interval = 1000;
            ComboTimer.Interval = 1000;
          
            combo_multiplier = 0;
            PowerUpSelected = savePow;
            ScoreNum.Text = "--;--";
            minutes = 2;
            sekundes = 30;
            powerUpAvailible = 0;
            
            for (int i = 0; i < figuros.Length; i++)
            {
                if (figuros[i] != null)
                {
                    for (int x = 0; x < figuros[i].Length; x++)
                    {

                        if (figuros[i][x] != null)
                        {
                            Controls.Remove(figuros[i][x]); figuros[i][x] = null;

                        }



                    }
                }
            }
            ValdomaFigura = -1;
            naujaFigura();
            Game.Enabled = true;
            GameTimer.Enabled = true;
        }

        public void KurKrentaFigura()
        { 
            for (int i=0;i<4;i++)
            {
                KurAtsiras[i].Visible = false;
                KurAtsiras[i].Top = figuros[ValdomaFigura][i].Top;
                KurAtsiras[i].Left = figuros[ValdomaFigura][i].Left;
                KurAtsiras[i].Visible = true;
            }
            staigusKritimas(KurAtsiras);

        }
        private void Zaidimo_Ekranas_KeyDown(object sender, KeyEventArgs e)
        { int posukiusk = 0;

            switch (e.KeyCode)
            {

                case Keys.Escape:
                    Game.Enabled = false;
                    GameTimer.Enabled = false;
                    if (ComboTimer.Enabled)
                    { ComboTimer.Enabled = false;off1 = 1; }
                    if (PowerUpTimer.Enabled)
                    { PowerUpTimer.Enabled = false; off2 = 1; }
                    GameOver Pause = new GameOver();
                    GameOver.message = "Žaidimas sustabdytas.\r\nAr norite jį pratęsti";
                    Pause.ShowDialog();
                    Pause.Close();
                    switch(GameOver.Answer)
                 
                    {
                        case 0: this.Close();break;
                        case 1:
                            Game.Enabled = true;
                            GameTimer.Enabled = true;
                            if (off1 == 1)
                            { ComboTimer.Enabled = true; off1 = 0; }
                            if (off2 == 1)
                            { PowerUpTimer.Enabled = true; off2 = 0; }
                break;

                    
                                                                         


                    }
                    break;
                case Keys.R:
                    UsePowerUp();
                    break;
                case Keys.E:
                    if (Tipas == 0 || Tipas >= 3)
                    {
                       
                        posukiusk = 4;
                    }
                    else if (Tipas == 1) { posukiusk = 2; }
                    padetiesKeitimas("Desine", posukiusk);
                    
                    Atvaizduoti(figuros[ValdomaFigura], Tipas, Padetis, Color.HotPink, dydis, figuros[ValdomaFigura][0].Left, figuros[ValdomaFigura][0].Top);
                    if (ArGalimaSukti()==false)
                    {
                        padetiesKeitimas("Kaire", posukiusk);
                        Atvaizduoti(figuros[ValdomaFigura], Tipas, Padetis, Color.HotPink, dydis, figuros[ValdomaFigura][0].Left, figuros[ValdomaFigura][0].Top);
                    }
                    KurKrentaFigura();

                    break;
                case Keys.Q:
                   
                    if (Tipas == 0 || Tipas >= 3)
                    {

                        posukiusk = 4;
                    }
                    else if (Tipas == 1) { posukiusk = 2; }
 padetiesKeitimas("Kaire", posukiusk);
            Atvaizduoti(figuros[ValdomaFigura], Tipas, Padetis, Color.HotPink, dydis, figuros[ValdomaFigura][0].Left, figuros[ValdomaFigura][0].Top);
                    if (ArGalimaSukti() == false)
                    {
                        padetiesKeitimas("Desine", posukiusk);
                        Atvaizduoti(figuros[ValdomaFigura], Tipas, Padetis, Color.HotPink, dydis, figuros[ValdomaFigura][0].Left, figuros[ValdomaFigura][0].Top);
                    }
                    KurKrentaFigura();
                    break;
                case Keys.W:
                    staigusKritimas(figuros[ValdomaFigura]);

                    break;



                   
                case Keys.A:
                    Valdymas("Kaire", figuros[ValdomaFigura], figuros,  Zaidimo_Laukas, ValdomaFigura);
                    KurKrentaFigura();
                    break;

                case Keys.D:
                    Valdymas("Desine", figuros[ValdomaFigura], figuros,  Zaidimo_Laukas, ValdomaFigura);
                    KurKrentaFigura();
                    break;
                case Keys.S:
                    PY++;
                    Valdymas("Apacia", figuros[ValdomaFigura], figuros,  Zaidimo_Laukas, ValdomaFigura);
                    KurKrentaFigura();
                    break;
            }
        }

        public void staigusKritimas(Label[] figura)
        {
            for (int i = 0; i < figura.Length; i++)
            {
               figura[i].Visible = false;

            }
          

            while (ArNeraApacioje(figura, figuros, Zaidimo_Laukas))
            { Kritimas(figura, figuros, Zaidimo_Laukas); }
            for (int i = 0; i < figura.Length; i++)
            {
                figura[i].Visible = true;

            }


        }

        public bool ArGalimaSukti()
        {
            for (int i = 0; i < figuros[ValdomaFigura].Length; i++)
            {

                if (figuros[ValdomaFigura][i].Top >= Zaidimo_Laukas.Top+ Zaidimo_Laukas.Height || figuros[ValdomaFigura][i].Top < Zaidimo_Laukas.Top || figuros[ValdomaFigura][i].Left < Zaidimo_Laukas.Left || figuros[ValdomaFigura][i].Left + figuros[ValdomaFigura][i].Width > Zaidimo_Laukas.Left +Zaidimo_Laukas.Width)
                {
                    return false;
                }

            }
            for (int i = 0; i < figuros[ValdomaFigura].Length; i++)
            {
                for (int x = 0; x < figuros.Length; x++)
                {
                    if (figuros[x] != null)
                    {
                        if (x != ValdomaFigura)
                        {
                            for (int z = 0; z < figuros[x].Length; z++)
                            {

                                if (figuros[x][z] != null)
                                {
                                    if (figuros[ValdomaFigura][i].Top == figuros[x][z].Top && figuros[ValdomaFigura][i].Left == figuros[x][z].Left) { return false; }
                                }

                            }
                        }
                    }
                }

            }




            return true;
        }
        public void RandomFiguros() //sukuriama 7 figuru seka
        {
            for (int i = 0; i < FiguruSeka.Length; i++)
            {
                FiguruSeka[i] = 7;
 
            }
            for (int i=0;i<FiguruSeka.Length;i++)

            {
                int KitaFigura = random.Next(0, 7);   
                if (FiguruSeka.Contains(KitaFigura))
                { i--; }
                else { FiguruSeka[i] = KitaFigura;  }

            }
            

        }

        public void naujaFigura()
        {
         

            Padetis = 0;
Tipas = FiguruSeka[figuraSekoje];
            if (figuraSekoje < 6)
            { 
                figuraSekoje++;
               
            }


         
         else
            {

                RandomFiguros();
            
                figuraSekoje = 0;
               
            }
           
           switch (FiguruSeka[figuraSekoje])
                
                {
                    case 0: KitaFiguraPicture.Image = Image.FromFile(@"figuros\Figura0.png"); break;
                    case 1: KitaFiguraPicture.Image = Image.FromFile(@"figuros\Figura1.png"); break;
                    case 2: KitaFiguraPicture.Image = Image.FromFile(@"figuros\Figura2.png"); break;
                    case 3: KitaFiguraPicture.Image = Image.FromFile(@"figuros\Figura3.png"); break;
                    case 4: KitaFiguraPicture.Image = Image.FromFile(@"figuros\Figura4.png"); break;
                    case 5: KitaFiguraPicture.Image = Image.FromFile(@"figuros\Figura5.png"); break;
                    case 6: KitaFiguraPicture.Image = Image.FromFile(@"figuros\Figura6.png"); break;
                    case 7: KitaFiguraPicture.Image = Image.FromFile(@"figuros\Figura7.png"); break;


                }
               
           
        



            ValdomaFigura += 1;
         


            figuros[ValdomaFigura] = new Label[4];
            for (int i = 0; i < figuros[ValdomaFigura].Length; i++)
            {
                figuros[ValdomaFigura][i] = new Label();
            }
            for (int i = 0; i < figuros[ValdomaFigura].Length; i++)
            {
                Controls.Add(figuros[ValdomaFigura][i]);
                figuros[ValdomaFigura][i].BringToFront();
            }
           
            PX = Zaidimo_Laukas.Left+(((Zaidimo_Laukas.Width+tarpas) / (dydis+tarpas) - 1) / 2 * (dydis+tarpas));
            PY = Zaidimo_Laukas.Top + dydis + tarpas;

            Atvaizduoti(figuros[ValdomaFigura], Tipas, Padetis, Color.HotPink, dydis, PX, PY);
            KurKrentaFigura();
        }
        public void padetiesKeitimas(string Kryptis, int posukiuSk)
        {
            switch (Kryptis)
            {
                case "Desine":

                    switch (posukiuSk)
                    {
                        case 2:
                            if (Padetis == 0) { Padetis = 1; }
                            else if (Padetis == 1) { Padetis = 0; }
                            break;
                        case 4:
                            switch (Padetis)
                            {
                                case 0: Padetis = 1; break;
                                case 1: Padetis = 2; break;
                                case 2: Padetis = 3; break;
                                case 3: Padetis = 0; break;
                            }
                            break;

                    }
                    break;
                case "Kaire":

                    switch (posukiuSk)
                    {
                        case 2:
                            if (Padetis == 0) { Padetis = 1; }
                            else if (Padetis == 1) { Padetis = 0; }
                            break;
                        case 4:
                            switch (Padetis)
                            {
                                case 0: Padetis = 3; break;
                                case 1: Padetis = 0; break;
                                case 2: Padetis = 1; break;
                                case 3: Padetis = 2; break;
                                    
                            } 
                            break;
                          
                    }
                    break;

            }



        }

    


        public void Atvaizduoti(Label[] _l,
            int _figurosTipas, int _figurosPadetis,
            Color _bgColor, int _dydis, int _x, int _y)
        {
            for (int i = 0; i < _l.Length; i++)
            {
                _l[i].Visible = false;

            }
            switch (_figurosTipas)
            {
                case 0: // Z tipo figura

                    switch (_figurosPadetis)
                    {
                        case 0: 
                            _l[0].BackColor = _bgColor;
                            _l[0].Width = _dydis;
                            _l[0].Height = _dydis;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                           

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top;
                            _l[1].Left = _l[0].Left + _l[0].Width + tarpas;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top - _l[0].Height - tarpas;
                            _l[2].Left = _l[0].Left;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top;
                            _l[3].Left = _l[2].Left - _l[2].Width - tarpas;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;

                            break;
                        case 1: 
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                            _l[0].Width = _dydis; _l[0].Height = _dydis;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top + _l[0].Height + tarpas;
                            _l[1].Left = _l[0].Left;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top;
                            _l[2].Left = _l[0].Left + _l[0].Width +tarpas;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor; 
                            _l[3].Top = _l[2].Top - _l[2].Height - tarpas;
                            _l[3].Left = _l[2].Left;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;
                            
                            break;
                       
                        case 2:
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                            _l[0].Width = _dydis; _l[0].Height = _dydis;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top;
                            _l[1].Left = _l[0].Left - _l[0].Width - tarpas;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top + _l[0].Height + tarpas;
                            _l[2].Left = _l[0].Left;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top;
                            _l[3].Left = _l[2].Left + _l[2].Width + tarpas;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;
                            break;
                        case 3:
                            _l[0].Width = _dydis;
                            _l[0].Height = _dydis;
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                        
                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top - _l[0].Height - tarpas;
                            _l[1].Left = _l[0].Left;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top;
                            _l[2].Left = _l[0].Left - _l[0].Width - tarpas;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                      

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top+_l[2].Height+tarpas;
                            _l[3].Left = _l[2].Left;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;
                            break;


                       
                    }
                    break;


                case 1:    //pagalys      
                    switch (_figurosPadetis)
                    {
                        case 0:

                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                            _l[0].Width = _dydis; _l[0].Height = _dydis;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top;
                            _l[1].Left = _l[0].Left - _l[0].Width - tarpas;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top;
                            _l[2].Left = _l[0].Left + _l[0].Width + tarpas;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top;
                            _l[3].Left = _l[2].Left + _l[2].Width + tarpas;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;

                            break;
                        case 1:
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                            _l[0].Width = _dydis; _l[0].Height = _dydis;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top - _dydis - tarpas;
                            _l[1].Left = _l[0].Left;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top + _l[0].Height + tarpas;
                            _l[2].Left = _l[0].Left;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top + _dydis + tarpas;
                            _l[3].Left = _l[2].Left;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;
                            break;
                            



                    }

                    break;
                case 2:  //kubas

                    _l[0].BackColor = _bgColor;
                    _l[0].Top = _y;
                    _l[0].Left = _x;
                    _l[0].Width = _dydis;
                    _l[0].Height = _dydis;

                    _l[1].BackColor = _bgColor;
                    _l[1].Top = _l[0].Top;
                    _l[1].Left = _l[0].Left + _l[0].Width + tarpas;
                    _l[1].Width = _dydis; _l[1].Height = _dydis;

                    _l[2].BackColor = _bgColor;
                    _l[2].Top = _l[1].Top + _l[1].Height + tarpas;
                    _l[2].Left = _l[1].Left;
                    _l[2].Width = _dydis; _l[2].Height = _dydis;

                    _l[3].BackColor = _bgColor;
                    _l[3].Top = _l[2].Top;
                    _l[3].Left = _l[2].Left - _l[2].Width - tarpas;
                    _l[3].Width = _dydis; _l[3].Height = _dydis;




                    break;
                 case 3://z i kita puse
                    switch (Padetis)
                    {
                        case 0:
                            _l[0].BackColor = _bgColor;
                            _l[0].Width = _dydis;
                            _l[0].Height = _dydis;
                            _l[0].Top = _y;
                            _l[0].Left = _x;


                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top;
                            _l[1].Left = _l[0].Left - _l[0].Width - tarpas;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top - _l[0].Height - tarpas;
                            _l[2].Left = _l[0].Left;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top;
                            _l[3].Left = _l[2].Left + _l[2].Width + tarpas;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;

                            break;
                        case 1:
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                            _l[0].Width = _dydis; _l[0].Height = _dydis;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top - _l[0].Height - tarpas;
                            _l[1].Left = _l[0].Left;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top;
                            _l[2].Left = _l[0].Left + _l[0].Width + tarpas;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top + _l[2].Height + tarpas;
                            _l[3].Left = _l[2].Left;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;

                            break;

                        case 2:
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                            _l[0].Width = _dydis; _l[0].Height = _dydis;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top;
                            _l[1].Left = _l[0].Left + _l[0].Width + tarpas;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top + _l[0].Height + tarpas;
                            _l[2].Left = _l[0].Left;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top;
                            _l[3].Left = _l[2].Left - _l[2].Width - tarpas;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;
                            break;
                        case 3:
                            _l[0].Width = _dydis;
                            _l[0].Height = _dydis;
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top + _l[0].Height + tarpas;
                            _l[1].Left = _l[0].Left;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top;
                            _l[2].Left = _l[0].Left - _l[0].Width - tarpas;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;



                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top - _l[2].Height - tarpas;
                            _l[3].Left = _l[2].Left;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;
                            break;


                    }

                    break;

                case 4: //L form
                    switch (Padetis)
                    {
                        case 0:
                            _l[0].BackColor = _bgColor;
                            _l[0].Width = _dydis;
                            _l[0].Height = _dydis;
                            _l[0].Top = _y;
                            _l[0].Left = _x;


                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top;
                            _l[1].Left = _l[0].Left + _l[0].Width + tarpas;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top;
                            _l[2].Left = _l[0].Left - _l[0].Width - tarpas;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top - _l[2].Height - tarpas;
                            _l[3].Left = _l[2].Left;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;

                            break;
                        case 1:
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                            _l[0].Width = _dydis; _l[0].Height = _dydis;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top + _l[0].Height + tarpas;
                            _l[1].Left = _l[0].Left;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top - _l[0].Height - tarpas;
                            _l[2].Left = _l[0].Left;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top;
                            _l[3].Left = _l[2].Left + _l[2].Width + tarpas;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;

                            break;

                        case 2:
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                            _l[0].Width = _dydis; _l[0].Height = _dydis;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top;
                            _l[1].Left = _l[0].Left - _l[0].Width - tarpas;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top;
                            _l[2].Left = _l[0].Left + _l[0].Width + tarpas;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top + _l[2].Height + tarpas;
                            _l[3].Left = _l[2].Left;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;
                            break;
                        case 3:
                            _l[0].Width = _dydis;
                            _l[0].Height = _dydis;
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top - _l[0].Height - tarpas;
                            _l[1].Left = _l[0].Left;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top =_l[0].Top + _l[0].Height + tarpas;
                            _l[2].Left = _l[0].Left;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top;
                            _l[3].Left = _l[2].Left - _l[2].Width - tarpas;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;
                            break;


                    }
                    break;
                case 5: //L form i kita puse
                    switch (Padetis)
                    {
                        case 0:
                            _l[0].BackColor = _bgColor;
                            _l[0].Width = _dydis;
                            _l[0].Height = _dydis;
                            _l[0].Top = _y;
                            _l[0].Left = _x;


                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top;
                            _l[1].Left = _l[0].Left - _l[0].Width - tarpas;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top;
                            _l[2].Left = _l[0].Left + _l[0].Width + tarpas;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top - _l[2].Height - tarpas;
                            _l[3].Left = _l[2].Left;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;

                            break;
                        case 1:
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                            _l[0].Width = _dydis; _l[0].Height = _dydis;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top - _l[0].Height - tarpas;
                            _l[1].Left = _l[0].Left;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top + _l[0].Height + tarpas;
                            _l[2].Left = _l[0].Left;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top;
                            _l[3].Left = _l[2].Left + _l[2].Width + tarpas;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;

                            break;

                        case 2:
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                            _l[0].Width = _dydis; _l[0].Height = _dydis;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top;
                            _l[1].Left = _l[0].Left + _l[0].Width + tarpas;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top;
                            _l[2].Left = _l[0].Left - _l[0].Width - tarpas;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top + _l[2].Height + tarpas;
                            _l[3].Left = _l[2].Left;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;
                            break;
                        case 3:
                            _l[0].Width = _dydis;
                            _l[0].Height = _dydis;
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top + _l[0].Height + tarpas;
                            _l[1].Left = _l[0].Left;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top - _l[0].Height - tarpas;
                            _l[2].Left = _l[0].Left;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[2].Top;
                            _l[3].Left = _l[2].Left - _l[2].Width - tarpas;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;
                            break;


                    }
                    break;
                case 6: //L form i kita puse
                    switch (Padetis)
                    {
                        case 0:
                            _l[0].BackColor = _bgColor;
                            _l[0].Width = _dydis;
                            _l[0].Height = _dydis;
                            _l[0].Top = _y;
                            _l[0].Left = _x;


                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top;
                            _l[1].Left = _l[0].Left - _l[0].Width - tarpas;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top;
                            _l[2].Left = _l[0].Left + _l[0].Width + tarpas;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[0].Top - _l[0].Height - tarpas;
                            _l[3].Left = _l[0].Left;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;

                            break;
                        case 1:
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                            _l[0].Width = _dydis; _l[0].Height = _dydis;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top - _l[0].Height - tarpas;
                            _l[1].Left = _l[0].Left;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top + _l[0].Height + tarpas;
                            _l[2].Left = _l[0].Left;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[0].Top;
                            _l[3].Left = _l[0].Left + _l[0].Width + tarpas;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;

                            break;

                        case 2:
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;
                            _l[0].Width = _dydis; _l[0].Height = _dydis;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top;
                            _l[1].Left = _l[0].Left + _l[0].Width + tarpas;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top;
                            _l[2].Left = _l[0].Left - _l[0].Width - tarpas;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[0].Top + _l[0].Height + tarpas;
                            _l[3].Left = _l[0].Left;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;
                            break;
                        case 3:
                            _l[0].Width = _dydis;
                            _l[0].Height = _dydis;
                            _l[0].BackColor = _bgColor;
                            _l[0].Top = _y;
                            _l[0].Left = _x;

                            _l[1].BackColor = _bgColor;
                            _l[1].Top = _l[0].Top + _l[0].Height + tarpas;
                            _l[1].Left = _l[0].Left;
                            _l[1].Width = _dydis; _l[1].Height = _dydis;

                            _l[2].BackColor = _bgColor;
                            _l[2].Top = _l[0].Top - _l[0].Height - tarpas;
                            _l[2].Left = _l[0].Left;
                            _l[2].Width = _dydis; _l[2].Height = _dydis;

                            _l[3].BackColor = _bgColor;
                            _l[3].Top = _l[0].Top;
                            _l[3].Left = _l[0].Left - _l[0].Width - tarpas;
                            _l[3].Width = _dydis; _l[3].Height = _dydis;
                            break;


                    }
                    break;
            }
            for (int i = 0; i < _l.Length; i++)
            {
               _l[i].Visible = true;

            }
        }
        public void Valdymas(string kryptis, Label[] labeliai, Label[][] visi_kubai, PictureBox Zaidimo_langas, int aktyviFigura)
        { for (int i=0; i< labeliai.Length;i++)
            {
                labeliai[i].Visible = false;

            }
            switch (kryptis)
            {
                case "Desine":

                    if (arNeraSone(kryptis))
                    {
                        for (int i = 0; i < labeliai.Length; i++)
                        { labeliai[i].Left += labeliai[i].Width + tarpas; }
                    }


                    break;
                case "Kaire":
                    if (arNeraSone(kryptis))
                    {
                        for (int i = 0; i < labeliai.Length; i++)
                        { labeliai[i].Left -= labeliai[i].Width + tarpas; }
                    }
                    break;
                case "Apacia":
                    //tam kad pro apacia nepralystu kubleiai tikrinami visi o tik tada leidziama jiem judet


                    if (ArNeraApacioje(labeliai, visi_kubai, Zaidimo_langas))
                    {
                        
                        for (int i = 0; i < labeliai.Length; i++)
                        {
                            labeliai[i].Visible = false;   
                            labeliai[i].Top += labeliai[i].Height + tarpas;
                            labeliai[i].Visible = true;

                        }
                    }
                    break;


            }
            for (int i = 0; i < labeliai.Length; i++)
            {
                labeliai[i].Visible = true;

            }
        }

        public void Kritimas(Label[] _l, Label[][] visi_kubai, PictureBox zaidimo_langas)

        {
            if (ArNeraApacioje(_l, visi_kubai, zaidimo_langas))
            {
                for (int i = 0; i < _l.Length; i++)
                {
                    _l[i].Visible = false;
                    _l[i].Top += _l[i].Height + tarpas;
                    _l[i].Visible = true;
                }
                  
            }

            else
            {
                if (figuros[ValdomaFigura] == _l)
                { naujaFigura(); }
               
            }



        }
        public bool ArNeraApacioje(Label[] _l, Label[][] visi_kubai, PictureBox zaidimo_langas)
        {
            int y = 0;//patikrinami visi, o ne vienas

            for (int i = 0; i < _l.Length; i++)
            {
                if (_l[i].Top + _l[i].Height < Zaidimo_Laukas.Top+ Zaidimo_Laukas.Height) { y++; }

            }
            for (int i = 0; i < _l.Length; i++)
            {
                for (int x = 0; x < visi_kubai.Length; x++)
                {
                    if (visi_kubai[x] != null)
                    {
                        if (visi_kubai[x] !=_l&&x!=ValdomaFigura)
                        {
                            for (int z = 0; z < visi_kubai[x].Length; z++)
                            {

                                if (visi_kubai[x][z] != null)
                                {
                                    if (_l[i].Top + _l[i].Height + tarpas == visi_kubai[x][z].Top && _l[i].Left == visi_kubai[x][z].Left) { return false; }
                                }

                            }
                        }
                    }
                }

            }

            if (y == 4)
            {
                return true;
            }

            return false;

        }
    
        public void arYraLinija()
        {
            int LinNum = 0;
            for (int i = 0; i < figuros.Length; i++)
            {

                if (i != ValdomaFigura && figuros[i] != null)
                {

                    for (int z = 0; z < figuros[i].Length; z++)
                    {
                        int[] pakirsti1 = new int[( Zaidimo_Laukas.Width + tarpas) / (dydis+tarpas)];
                        int[] pakirsti2 = new int[( Zaidimo_Laukas.Width + tarpas) /(dydis+tarpas)];

                        LinNum = 0;

                        for (int x = 0; x < figuros.Length; x++)
                        {
                            if (x != ValdomaFigura && figuros[x] != null)
                            {

                                for (int y = 0; y < figuros[x].Length; y++)

                                {
                                    if (figuros[i][z] != null && figuros[x][y] != null && figuros[i][z] != figuros[x][y])
                                    {
                                        if (figuros[i][z].Top == figuros[x][y].Top)
                                        {

                                            pakirsti1[LinNum] = x;
                                            pakirsti2[LinNum] = y;

                                            LinNum++;

                                            #region linijos naikinimas 
                                            if (LinNum == ((Zaidimo_Laukas.Width + tarpas) / (dydis + tarpas))-1) 
                                            {
                                                LinNum = 0;
                                                int aukstis = figuros[i][z].Top;

                                                figuros[i][z].Visible = false;
                                                Controls.Remove(figuros[i][z]);
                                                figuros[i][z] = null;
                                                int k = 0;
                                                     combo();
                                               score += taskas*combo_multiplier;
                                           
                                                ScoreNum.Text = score.ToString();
                                                while (k < pakirsti1.Length)
                                                {

                                                    if (figuros[pakirsti1[k]][pakirsti2[k]] != null)
                                                    {
                                                        figuros[pakirsti1[k]][pakirsti2[k]].Visible = false;
                                                        Controls.Remove(figuros[pakirsti1[k]][pakirsti2[k]]);
                                                        figuros[pakirsti1[k]][pakirsti2[k]] = null;

                                                    }
                                                    k++;
                                                }
                                                pakirsti1 = null;
                                                pakirsti2 = null;
                                                for (int m = 0; m < figuros.Length; m++)
                                                {
                                                    if (figuros[m] != null)
                                                    {
                                                        for (int l = 0; l < figuros[m].Length; l++)
                                                        {
                                                            if (figuros[m][l] != null)
                                                            {

                                                                if (figuros[m][l].Top < aukstis)
                                                                { figuros[m][l].Top += figuros[m][l].Height + tarpas; }
                                                            }

                                                        }
                                                    }
                                                }

                                            }
                                            #endregion

                                        }
                                    }

                                }
                            }
                        }


                    }

                }
            }



        }
        public bool arNeraSone(string Kryptis)
        {
            switch (Kryptis)
            {

                #region Desine
                case "Desine":
                    for (int i = 0; i < figuros[ValdomaFigura].Length; i++)
                    {
                        if (figuros[ValdomaFigura][i].Left + figuros[ValdomaFigura][i].Width + tarpas >= Zaidimo_Laukas.Left+ Zaidimo_Laukas.Width)
                        {
                            return false;

                        }
                    }
                    for (int i = 0; i < figuros[ValdomaFigura].Length; i++)
                    {
                        for (int x = 0; x < figuros.Length; x++)
                        {
                            if (figuros[x] != null)
                            {

                                for (int z = 0; z < figuros[x].Length; z++)
                                {
                                    if (figuros[ValdomaFigura][i] != figuros[x][z] && ValdomaFigura != x && figuros[ValdomaFigura][i] != null && figuros[x][z] != null)
                                    {
                                        if (figuros[ValdomaFigura][i].Left + figuros[ValdomaFigura][i].Width + tarpas == figuros[x][z].Left && figuros[ValdomaFigura][i].Top == figuros[x][z].Top)

                                        {
                                            return false;
                                        }
                                    }
                                }
                            }
                        }

                    }



                    break;
                #endregion
                #region Kaire
                case "Kaire":
                    for (int i = 0; i < figuros[ValdomaFigura].Length; i++)
                    {
                        if (figuros[ValdomaFigura][i].Left - tarpas <= Zaidimo_Laukas.Left)
                        {
                            return false;

                        }
                    }
                    for (int i = 0; i < figuros[ValdomaFigura].Length; i++)
                    {
                        for (int x = 0; x < figuros.Length; x++)
                        {
                            if (figuros[x] != null)
                            {

                                for (int z = 0; z < figuros[x].Length; z++)
                                {
                                    if (figuros[ValdomaFigura][i] != figuros[x][z] && ValdomaFigura != x && figuros[ValdomaFigura][i] != null && figuros[x][z] != null)
                                    {
                                        if (figuros[ValdomaFigura][i].Left - figuros[ValdomaFigura][i].Width - tarpas == figuros[x][z].Left && figuros[ValdomaFigura][i].Top == figuros[x][z].Top)

                                        {
                                            return false;
                                        }
                                    }
                                }
                            }
                        }

                    }




                    break;
                    #endregion
            }




            return true;
        }
        public void Gameover()
        {
           
            for (int i = 0; i < figuros.Length; i++)
            {
                if (figuros[i] != null)
                {
                    for (int x = 0; x < figuros[i].Length; x++)
                    {
                        if (figuros[i][x] != null)
                        {
                            if (figuros[i][x].Top <= Zaidimo_Laukas.Top && i != ValdomaFigura || minutes == 0&&sekundes==0)
                            {
                                Game.Enabled = false;
                                GameTimer.Enabled = false;
                                ComboTimer.Enabled = false;
                                PowerUpTimer.Enabled = false;
                                GameOver GG = new GameOver();
                                GameOver.message = string.Format("Žaidimas baigtas.\r\nPasiektas rezultatas: {0}\r\nAr norite žaisti iš naujo",score);
                                if (score != 0)
                                { if (String.IsNullOrEmpty(mySqlFunctions.vardas) == false) { mySqlFunctions.saveGameData(mySqlFunctions.vardas, score); } }
                                GG.ShowDialog();
                                GG.Close();
                                switch (GameOver.Answer)

                                {
                                    case 0: this.Close(); break;
                                    case 1:restart();break;
                                      
                                 


                                }


                            }

                        }


                    }
                }

               
            }

        }
        public void combo()
        {
            if (ComboTimer.Enabled == false)
            {
                ComboTimer.Enabled = true;
                comboTime = 20;
            }
          
            else
            {
                
                combo_multiplier *= 2;
                
                ComboMeter.Text = string.Format("{0}X", combo_multiplier);
                ComboMeter.Visible = true;
                if (combo_multiplier==1)
                {
                    ComboMeter.ForeColor = Color.DarkOrange;


                }
                if (combo_multiplier == 1)
                {
                    ComboMeter.ForeColor = Color.Red;
                }
                
            }
            if (PowerUpSelected != 0)
            {
                switch (PowerUpSelected)
                {
                    case 1: if (combo_multiplier == 2) { ;PowerUpSelected = 0;powerUpAvailible = 1; PowerUpSlot1.Image = Image.FromFile(@"texturos\SlowTime.png"); } break;
                    case 2: if (combo_multiplier == 2) { ; PowerUpSelected = 0; powerUpAvailible = 2; PowerUpSlot1.Image = Image.FromFile(@"texturos\destroyAll.png"); } break;
                 
                }

            }


            

        }
        public void UsePowerUp()
        {
            switch(powerUpAvailible)
            {
                case 1:  Game.Interval *= 2; GameTimer.Interval *= 2; ComboTimer.Interval *= 2;   powerUpAvailible = 0; PowerUpOnTime = 0;PowerUpTimer.Enabled = true; PowerUpBord.BackColor = Color.Cyan; break; //slow down time
                case 2:  clearScreen();  ValdomaFigura = -1; naujaFigura(); PowerUpSlot1.Image = null; PowerUpSlot1.BackColor = Color.LightGray; break; //sugriauna visas figuras ekrane
        

            }

        }
        public void clearScreen()
        {
            int mm = 0;
            for (int i=0;i<figuros.Length;i++)
            {
                if (figuros[i] != null)
                {
                    for (int x = 0; x < figuros[i].Length; x++)
                    {

                        if (figuros[i][x] != null) { Controls.Remove(figuros[i][x]); figuros[i][x] = null;

                            mm++;
                            if (mm == 1)
                            { score += taskas * combo_multiplier; ScoreNum.Text = score.ToString(); } }



                    }
                }
            }
          
            PowerUpSlot1.BackColor = Color.Gray;
            PowerUpBord.BackColor = Color.DarkOrange;
            ScoreNum.Text = score.ToString();

        }
     public void powerUp(int pwrup)
        {
           
             switch (pwrup)
            {case 1:
                    PowerUpSlot1.Image = Image.FromFile(@"texturos\SlowTimeGray.png");
                   
                    break;

            case 2:
                    PowerUpSlot1.Image = Image.FromFile(@"texturos\destroyAllGray.png");

                    break;
                default: PowerUpSlot1.BackColor = Color.Gray; break;

            }
         


        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Game.Interval -= difficulty;
            sekundes--;
            if (sekundes<0)
            {
                minutes--;
                sekundes =59 ;


            }
            if (sekundes < 10)
            { TimeNum.Text = string.Format("{0}:0{1}", minutes, sekundes); }
            else
            {
                TimeNum.Text = string.Format("{0}:{1}", minutes, sekundes);
            }

        }

        private void ComboTimer_Tick(object sender, EventArgs e)
        {
            comboTime--;
            if (comboTime<=0)
            {
                ComboTimer.Enabled = false;
                combo_multiplier = 1;
                ComboMeter.Visible = false;
                ComboMeter.ForeColor = Color.Cyan;
           

            }


        }

        private void PowerUpTimer_Tick(object sender, EventArgs e)
        {
            PowerUpOnTime++;
            if (PowerUpOnTime>=5)
            {
             Game.Interval /= 2;GameTimer.Interval /= 2;ComboTimer.Interval /= 2;  PowerUpTimer.Enabled =false;
                PowerUpSlot1.Image = null;
                PowerUpSlot1.BackColor = Color.DimGray;
                PowerUpBord.BackColor = Color.DarkOrange;
         

            }

        }

      
         
               
        
    }

}


























