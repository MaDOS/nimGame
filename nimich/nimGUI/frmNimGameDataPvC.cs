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
        private void butStartComputer_Click(object sender, EventArgs e)
        {
            //Spielerdatenblatt öffnen
            tabMain.SelectedTab = tabPgDataPvC;
            txtPvcComputer.Text = "Computer";
        }

        private void butStartPvc_Click(object sender, EventArgs e)
        {
            //PLayer vs. Computer

            string player = txtPvcName.Text;
            string message = "Spieler1: Bitte geben Sie ihren Namen ein!";

            if (txtPvcName.Text == "")
            {
                MessageBox.Show(message);
                return;
            }
            else
            {
                player = txtPvcName.Text;
            }

            //Spielerdaten übernehmen
            labPvcName.Text = player;

            //Öffnen des Spielfensters
            tabMain.SelectedTab = tabPgGamePvC;
        }
    }
}
