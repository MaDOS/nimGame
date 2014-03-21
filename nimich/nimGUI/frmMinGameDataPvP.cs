using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using nimEngine;

namespace nimGUI
{
    public partial class frmNimGame
    {
        private void butStartHotSeat_Click(object sender, EventArgs e)
        {
            //Spielerdatenblatt öffnen
            tabMain.SelectedTab = tbPgGamePvP;
        }

        private void butStartGame1_Click(object sender, EventArgs e)
        {
            string[] player = new string[2];
            string message1 = "Spieler1: Bitte geben Sie ihren Namen ein!";
            string message2 = "Spieler2: Bitte geben Sie ihren Namen ein!";

            //Speichern der Spielerdaten
            if (txtPlayerName1.Text == "")
            {
                MessageBox.Show(message1);
                return;
            }
            else
            {
                player[0] = txtPlayerName1.Text;
            }
            if (txtPlayerName2.Text == "")
            {
                MessageBox.Show(message2);
            }
            else
            {
                player[1] = txtPlayerName2.Text;
            }

            //Übernehmen der Daten
            labNameP1.Text = player[0];
            labNameP2.Text = player[1];

            this.p1 = new Human(player[0]);
            this.p2 = new Human(player[1]);
            this.g = new Game(this.p1, this.p2, this.stickCount);

            //Öffnen des Spielfensters
            tabMain.SelectedTab = tbPgHotSeat;
            this.g.start();
        }
    }
}
