﻿using System;
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
        private void btnStartPvPMode_Click(object sender, EventArgs e)
        {
            //Spielerdatenblatt öffnen
            tabMain.SelectedTab = tbPgGamePvP;
        }

        private void btnStartPvPGamePvPData_Click(object sender, EventArgs e)
        {
            string[] player = new string[2];
            string message1 = "Spieler1: Bitte geben Sie ihren Namen ein!";
            string message2 = "Spieler2: Bitte geben Sie ihren Namen ein!";

            //Speichern der Spielerdaten
            if (txtPlayerName1PvPData.Text == "")
            {
                MessageBox.Show(message1);
                return;
            }
            else
            {
                player[0] = txtPlayerName1PvPData.Text;
            }
            if (txtPlayerName2PvPData.Text == "")
            {
                MessageBox.Show(message2);
            }
            else
            {
                player[1] = txtPlayerName2PvPData.Text;
            }

            //Übernehmen der Daten
            lblP1NamePvP.Text = player[0];
            lblP2NamePvP.Text = player[1];

            this.p1 = new Human(player[0]);
            this.p2 = new Human(player[1]);
            this.g = new Game(this.p1, this.p2, (int)this.numUDStickCountSettings.Value);
            
            this.g.gameOver += this.g_gameOver;
            this.g.stickCountChanged += this.g_stickCountChanged;
            this.p1.playerStartedTurn += this.p1_playerStartedTurn;
            this.p2.playerStartedTurn += this.p2_playerStartedTurn;

            //Öffnen des Spielfensters
            tabMain.SelectedTab = tbPgPvP;
            this.g.start();
            this.gameRunning = true;
            this.refreshSticks();

            this.lblDrawnSticksP1Pvp.Text = drawnSticksP1.ToString();
            this.lblDrawnSticksP2PvP.Text = drawnSticksP2.ToString();
        }
    }
}
