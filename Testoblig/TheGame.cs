using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using obligatoriskOppgaveDel1;

namespace battleShipWars
{
    public partial class TheGame : Form
    {

        public TheGame()
        {

            InitializeComponent();
        }

        // Punkt til torpedo, båt1, båt2, båt3
        private Point torpedo;
        private Point torpedoBase;
        private Point battleShip;
        private Point battleShip1;
        private Point battleShip2;

        //Definerer rektangler av båtene og torpedoen
        private Rectangle boat1;
        private Rectangle torpedoEllipse;
        private Rectangle torpedoBaseRectangel;
        private Rectangle boat2;
        private Rectangle boat3;
        //Image vkt;


        // Boolean-verdi som bruker for båtens rettning
        private Boolean boatDir = false;
        private Boolean boatDir2 = false;
        private Boolean boatDir3 = false;
        private Boolean torpedoDir = false;

        // Font verdi
        private Font fnt;

        // int varriabel for poeng
        private int poeng;
        // int verdi for spilletid
        private int gameTimerTicker;

        // Spilletid satt til 60 sekunder
        private int gameTime = 60;

        // Instansierer lagringsstien - filen 
        private string path = @"E:\Highscore.txt";

        private string introTekst;

        // int verdier for x og y (horrisontal og vertikal rettning)
        private int x;
        private int y;



        // Metode for å kalle på et annet form (Spillerregistering)
        private void userInput()
        {

            Form playerInput = new Spillerregistering();
            //Spillerregistering.Show();
            playerInput.Owner = this;

            //Bytter dette viduet forran alt annet
            playerInput.ShowDialog();
        }

        // Hva som skjer når form'et loader
        private void Form1_Load(object sender, EventArgs e)
        {
            // Setter poeng ved start til 0
            poeng = 0;
           
            //Bakgrunnsfarge i spill-vinduet
            BackColor = Color.Aqua;
            // Definerer fonten som skal brukes i spillet
            fnt = new Font("Arial", 12, FontStyle.Bold);

            userInput();
            // Console.WriteLine("Navnet er " + labelPlayerName.Text + "du er registrert");

            introTekst = "Trykk Space for å starte spillet, og lade torpedoen!";

            // Skjuler 'spiller' - labelen 
            labelPlayerName.Visible = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Setter størrelsen på vinduet
            Size size = new Size(800, 600);

            // Dette clientvinduet
            this.ClientSize = size;

            // Midtstiller x koordinatene
            x = this.ClientRectangle.Width/2;
            y = this.ClientRectangle.Height;

            // Stopper timeren til torpedoen, slik at den ikke blir avfyrt før SPACE er trykket
            torpedoTimer.Enabled = false;

            //Console.WriteLine("Navnet er " + labelPlayerName.Text + "du er registrert test 2");

        }


        // Torpedo - timer
        private void tmrMoving_Tick(object sender, EventArgs e)
        {

            // Hvis retningen ikke er satt til torpedoen
            if (!torpedoDir)
            {

                torpedo.Y = torpedo.Y - 20;
            }

            // Hvis torpedo sin Y-verdi er mindre enn vinduets størrelse --> Satt tilbake til start
            if (torpedo.Y > this.ClientRectangle.Height - 45)
            {

                torpedoDir = !torpedoDir;
            }
            else if (torpedo.Y < 0)
            {

                //Console.WriteLine("Stop torpedo");
                torpedoTimer.Enabled = false;
                torpedo.Y = this.ClientRectangle.Height;
            }

            Invalidate();
        }

        //Timer for båt nr. 1
        private void timer1_Tick(object sender, EventArgs e)
        {

            // sjekker om retningen til båten er satt
            if (!boatDir)
            {

                battleShip.X = battleShip.X + 6;

            }

            else
            {

                battleShip.X = battleShip.X - 6;
            }

            //Sjekk om båten treffer veggen
            if (battleShip.X > this.ClientRectangle.Width - 45)
            {

                boatDir = !boatDir;
            }

            // Hvis båten x koordinat er mindre en 0, sett båtens retning = false
            else if (battleShip.X < 0)
            {

                boatDir = false;
            }

            // Hvis torpedoen treffer båten - legg til poeng og send båten tilbake til veggen
            if (torpedoEllipse.IntersectsWith(boat1))
            {

                poeng += 20;
                battleShip.X = this.ClientRectangle.Width - 45;
                // Sender torpedoen tilbake til start
                torpedo.Y = this.ClientRectangle.Height;
                //Stopper torpedoen slik at den ikke starter rett etter et treff
                torpedoTimer.Enabled = false;
            }

            Invalidate();
        }

        // Timer for bår nr. 2
        private void timer2_Tick(object sender, EventArgs e)
        {

            // Hvis retningen på båten ikke er satt 
            if (!boatDir2)
            {

                battleShip1.X = battleShip1.X + 5;

            }
            // hvis ikke gjør dette :
            else
            {

                battleShip1.X = battleShip1.X - 5;
            }

            // Sjekker om torpedoen treffer flaten til boat 2 --> lager til 10 poeng ved treff
            if (torpedoEllipse.IntersectsWith(boat2))
            {

                poeng += 10;
                //Setter den aktuelle båten tilbake til en av sidene
                battleShip1.X = this.ClientRectangle.Width - 45;

                // Sender torpedoen tilbake til start
                torpedo.Y = this.ClientRectangle.Height;

                //Stopper torpedoen slik at den ikke starter rett etter et treff
                torpedoTimer.Enabled = false;

            }

            // Sjekker om båten treffer veggen --> hvis dette skjer snu retning
            if (battleShip1.X > this.ClientRectangle.Width - 45)
            {

                boatDir2 = !boatDir2;
            }
            else if (battleShip1.X < 0)
            {

                boatDir2 = false;
            }

            Invalidate();

        }

        // Timer for båt nr. 3
        private void timer3_Tick(object sender, EventArgs e)
        {
            // sjekker om retningen til båten er satt
            if (!boatDir3)
            {
                battleShip2.X = battleShip2.X + 6;
            }

            else
            {

                battleShip2.X = battleShip2.X - 6;
            }

            //Sjekk om båten treffer veggen
            if (battleShip2.X > this.ClientRectangle.Width - 45)
            {

                boatDir3 = !boatDir3;
            }

            // Hvis båtens x koordinat er mindre en 0, sett båtens retning = false
            else if (battleShip2.X < 0)
            {

                boatDir3 = false;
            }

            // Hvis torpedoen treffer båten - legg til poeng og send båten tilbake til veggen
            if (torpedoEllipse.IntersectsWith(boat3))
            {

                poeng += 5;
                battleShip2.X = this.ClientRectangle.Width - 45;
                // Sender torpedoen tilbake til start
                torpedo.Y = this.ClientRectangle.Height;
                //Stopper torpedoen slik at den ikke starter rett etter et treff
                torpedoTimer.Enabled = false;
            }

            Invalidate();
        }

        // Her tegnes grafikken (båtene, torpedoen og "torpedobasen"
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Graphics picture = e.Graphics;

            // Brush som velger farge på båtene og torpedon
           // Brush battleShipBrush = new SolidBrush(Color.Blue);
            // Brush battleShipBrush1 = new SolidBrush(Color.Yellow);
            // Brush torpedoBrush = new SolidBrush(Color.Purple);
            Brush torpedoBaseBrush = new SolidBrush(Color.Black);

            //For å tegne inn poeng, introText og gameTime
            SolidBrush poengBrush = new SolidBrush(Color.Gray);
            SolidBrush introTextBrush = new SolidBrush(Color.Gray);
            SolidBrush gameTimerBrush = new SolidBrush(Color.Gray);

            g.DrawString(poeng.ToString(), fnt, poengBrush, 10, 10);
            g.DrawString(introTekst, fnt, introTextBrush, 250, +150);
            g.DrawString(gameTimerTicker.ToString(), fnt, gameTimerBrush, 750, +10);

            // Brush'es for poeng, introText på spillet og spilletiden
          /*  poengBrush.Color = Color.LightSeaGreen;
            introTextBrush.Color = Color.Black;
            gameTimerBrush.Color = Color.LightSeaGreen;*/

            // boat1 = new rectangle (battleship.X, Y , størrelse, størrelse) (eksempel)
            boat1 = new Rectangle(battleShip.X, battleShip.Y + 135, 50, 15);
            boat2 = new Rectangle(battleShip1.X, battleShip1.Y + 235, 40, 15);
            boat3 = new Rectangle(battleShip2.X, battleShip2.Y + 335, 40, 15);

            // Grafikken som tegner torpedoellipsen og "basen" den bli skutt ut i fra 
            torpedoEllipse = new Rectangle(torpedo.X + ClientRectangle.Width/2 - 5, torpedo.Y - 60, 20, 60);
            torpedoBaseRectangel = new Rectangle(torpedoBase.X + ClientRectangle.Width/2 - 20, torpedoBase.Y + 580, 70,
                30);

            //Tegner torpedoen -logoen fra png fil
            g.DrawImage(new Bitmap("torpedo.png"), torpedo.X + ClientRectangle.Width/2 - 5, torpedo.Y - 70, 35, 70);

            //Tegner hbv -logoen, hive-logo og hit-logo fra png fil
            g.DrawImage(new Bitmap("hbv.png"), battleShip.X, battleShip.Y - 100 + 200, 50, 50);
            g.DrawImage(new Bitmap("hive.png"), battleShip1.X, battleShip1.Y + 100 + 100, 40, 50);
            g.DrawImage(new Bitmap("hit.png"), battleShip2.X, battleShip2.Y + 300, 40, 50);

            // Fyller rektangelene ('boat1', 'boat3', 'boat3') med en transparent farge
            g.FillRectangle(Brushes.Transparent, boat1);
            g.FillRectangle(Brushes.Transparent, boat2);
            g.FillRectangle(Brushes.Transparent, boat3);

            // Fyller rektangelet med fargen og størrelsen som er definert av 'Brushes' (blir transparent) og 'torpedoEllipse' 
            g.FillRectangle(torpedoBaseBrush, torpedoBaseRectangel);
            g.FillEllipse(Brushes.Transparent, torpedoEllipse);

            
        }

        // Funksjoner som reagerer på trykk
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Reagerer når space tasten blir trykket
            if (e.KeyCode == Keys.Space)
            {

                // Starter alle timere og tømmer introtekst-varriabelen
                torpedoTimer.Enabled = true;
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
                gameTimer.Enabled = true;
                
                // Styrer intervallet slik at det blir korrekt ifht ett sekund
                gameTimer.Interval = 1000;
               
                // Setter introText blank
                introTekst = "";

                highScore.Visible = false;
                exitGame.Visible = false;
                HighScoreLabel.Visible = false;


                this.Refresh();
            }
        }

        // Spilletimer som setter spilletiden du spiller
        private void gameTimer_Tick(object sender, EventArgs e)
        {

            // Teller ned fra forhåndsdefinert tid
            gameTime --;

            //Setter int-verriabelen gametimerTicker lik gameTime som gir sekundene
            gameTimerTicker = gameTime;

            //Hvis spilletiden har gått ut, stopp timere, sett spilletiden tilbake til 60 sekunder, vis "gameover" - melding og skriv resultatet til fil
            if (gameTime <= 0)
            {

                torpedoTimer.Enabled = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                gameTimer.Enabled = false;

                
                gameTime = 60;
                torpedo.Y = this.ClientRectangle.Height;
                introTekst = "Tiden er ute, " + labelPlayerName.Text + " du fikk " + poeng + " poeng!" +
                             Environment.NewLine +
                             " trykk 'space' for å starte spille på nytt";

                // StreamWriter muliggjør det å skrive til en txt-fil direkte fra spillet
                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.Write("Spiller: " + labelPlayerName.Text + "," + poeng + "poeng" + Environment.NewLine);
                    Console.WriteLine("Spiller sitt navn er " + labelPlayerName.Text + ",");
                }
                highScore.Visible = true;
                poeng = 0;
               
                //Console.WriteLine("Spiller sitt navn er " + label2.Text);
                string line;
                HighScoreLabel.Visible = true;

                StreamReader highScoreStreamer = new StreamReader(path);
                if ((line = highScoreStreamer.ReadLine()) != null)
                {
                    highScore.Text = highScoreStreamer.ReadToEnd();
                    string[] spiller = line.Split(',');
                    Array.Sort(spiller);
                }

                exitGame.Visible = true;

            }

   
            this.Refresh();
        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}