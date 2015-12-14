using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obligatoriskOppgaveDel1
{
    public partial class Spillerregistering : Form
    {
        
        public Spillerregistering()
        {
            InitializeComponent();
        }

    // Når 'registrer spiller' knappen trykkes sjekkes det om textboxen er tom eller om det er noe i den
        private void registrerBrukerKnapp(object sender, EventArgs e)
        {
            if (textboxPlayerName.Text.Length == 0 || textboxPlayerName.Text == "")
            {
                error();
            }
            else
            {
                sucsess();
            }
           
        }
       
        // Fyrer opp error melding hvis textfeltet er tomt
        private void error()
        {
            // viser errormeldingen
            errorMessageLabel.Visible = true;

            // skjuler suksessmeldingen
            sucsessMessageLabel.Visible = false;
            
            errorMessageLabel.Text = "Du har ikke fylt inn noe i 'Spiller-boksen'," + Environment.NewLine + "vennligst fyll inn spiller navn under ";
        }

        // Kjører suksess melding hvis noe er skrivd inn og sender deg videre til spillet 
        private void sucsess()
        {
            Label user = ((battleShipWars.TheGame)this.Owner).labelPlayerName;
            user.Text = textboxPlayerName.Text;
            sucsessMessageLabel.Text = "Takk! :D";
            button2.Enabled = true;
           
             
        }

        private void playerInput_Load(object sender, EventArgs e)
        {

            button2.Enabled = false;
            errorMessageLabel.Visible = false;
            sucsessMessageLabel.Visible = true;
            sucsessMessageLabel.Text = "Venligst fyll inn spillerens navn under";
        }

        // knapp som lukker dialogboksen og starter spillet
        private void startGameBtn(object sender, EventArgs e)
        {
            if (textboxPlayerName.Text.Length == 0 || textboxPlayerName.Text == "")
            {
                error();
                
            }
            else
            {
                this.Dispose();
                
            }
            
        }

       
    }
}
