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
        private void btnStartPvCMode_Click(object sender, EventArgs e)
        {
            //Spielerdatenblatt öffnen
            this.tabMain.SelectedTab = this.tbPgDataPvC;
        }

        private void btnStartPvCGamePvCData_Click(object sender, EventArgs e)
        {
            //Player vs. Computer
            string playerName = this.txtPlayer1NamePvCData.Text;

            //check for playername
            if (playerName == "")
            {
                MessageBox.Show("Bitte geben sie einen Namen für Spieler 1 ein!");
                return;
            }

            //check for selected AI
            if (this.cmbBxAIPvCData.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte wählen sie einen Gegner!");
                return;
            }

            this.p1 = new Human(playerName);
            this.p2 = (Player)this.cmbBxAIPvCData.SelectedItem;
            this.g = new Game(this.p1, this.p2, (int)this.numUDStickCountSettings.Value);

            //Übernehmen der Daten
            lblP1NamePvC.Text = this.p1.ident;
            lblP2NamePvC.Text = this.p2.ToString();

            this.g.gameOver += this.g_gameOverPvP;
            this.g.stickCountChanged += this.g_stickCountChangedPvC;
            this.p1.playerStartedTurn += this.p1_playerStartedTurnPvC;
            this.p2.playerStartedTurn += this.p2_playerStartedTurnPvC;

            //Öffnen des Spielfensters
            tabMain.SelectedTab = this.tbPgGamePvC;
            this.g.start();
            this.gameRunning = true;
            this.refreshSticksPvC();

            this.lblDrawnSticksP1PvC.Text = drawnSticksP1PvC.ToString();
            this.lblDrawnSticksP2PvC.Text = drawnSticksP2PvC.ToString();
        }
    }
}
