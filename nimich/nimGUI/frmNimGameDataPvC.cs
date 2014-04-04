using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nimGUI
{
    public partial class frmNimGame
    {
        private void btnStartPvCMode_Click(object sender, EventArgs e)
        {
            //Spielerdatenblatt öffnen
            
        }

        private void btnStartPvCGamePvCData_Click(object sender, EventArgs e)
        {
            //Player vs. Computer

            string player = txtPlayer1NamePvCData.Text;
            string message = "Spieler1: Bitte geben Sie ihren Namen ein!";

            if (txtPlayer1NamePvCData.Text == "")
            {
                MessageBox.Show(message);
                return;
            }
            else
            {
                player = txtPlayer1NamePvCData.Text;
            }

            //TODO: Spielerdaten übernehmen

            //Öffnen des Spielfensters
            tabMain.SelectedTab = tabPgGamePvC;
        }
    }
}
