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
        Game g;
        Player p1, p2;
        bool gameRunning;
        int startStickCount;

        #region PVP

        bool p1TurnPvP;
        int drawnSticksP1PvP, drawnSticksP2PvP = 0;

        //Zug von Spieler 1 beginnt
        void p1_playerStartedTurnPvP(nimEngine.PlayerStartedTurnEventArgs eventArgs)
        {
            this.p1TurnPvP = true;
            this.setp1ActivePvP();
        }

        //Zug von Spieler 2 beginnt
        void p2_playerStartedTurnPvP(nimEngine.PlayerStartedTurnEventArgs eventArgs)
        {
            this.p1TurnPvP = false;
            this.setp2ActivePvP();
        }

        //Sticks wurden verändert
        void g_stickCountChangedPvP(nimEngine.StickCountChangedEventArgs eventArgs)
        {
            if (this.p1TurnPvP)
            {
                this.drawnSticksP1PvP += eventArgs.Diff;
            }
            else
            {
                this.drawnSticksP2PvP += eventArgs.Diff;
            }
            switch (g.StickCount)
            {
                case 2:
                    this.btnNim3PvP.Enabled = false;
                    break;
                case 1:
                    this.btnNim3PvP.Enabled = false;
                    this.btnNim2PvP.Enabled = false;
                    break;
                default:
                    this.btnNim2PvP.Enabled = true;
                    this.btnNim3PvP.Enabled = true;
                    break;

            }
            this.refreshSticksPvP();
        }

        //Spiel vorbei
        void g_gameOverPvP(nimEngine.GameOverEventArgs eventArgs)
        {
            gameRunning = false;
            string winner = eventArgs.winner.ident;
            string loser = eventArgs.loser.ident;

            MessageBox.Show(eventArgs.winner.ident + " hat gewonnen!");

            Highscoremanager.addWin(winner);
            Highscoremanager.addLoss(loser);

            this.tabMain.SelectedTab = this.tbPgHighscore;
        }

            #region helper

            void refreshSticksPvP()
            {
                this.lblDrawnSticksP1PvP.Text = this.drawnSticksP1PvP.ToString();
                this.lblDrawnSticksP2PvP.Text = this.drawnSticksP2PvP.ToString();
                this.lblStickCountPvP.Text = this.g.StickCount.ToString();
            }

            void setp1ActivePvP()
            {
                this.panP1PvP.BackColor = Color.LimeGreen;
                this.panP2PvP.BackColor = Color.Transparent;
            }

            void setp2ActivePvP()
            {
                this.panP2PvP.BackColor = Color.LimeGreen;
                this.panP1PvP.BackColor = Color.Transparent;
            }

            #endregion

        #endregion

        #region PVC

        int drawnSticksP1PvC, drawnSticksP2PvC = 0;
        bool p1TurnPvC = false;

        //Zug von Spieler 1 beginnt
        void p1_playerStartedTurnPvC(nimEngine.PlayerStartedTurnEventArgs eventArgs)
        {
            this.p1TurnPvC = true;
            this.setp1ActivePvC();
        }

        //Zug von Spieler 2 beginnt
        void p2_playerStartedTurnPvC(nimEngine.PlayerStartedTurnEventArgs eventArgs)
        {
            this.p1TurnPvC = false;
            this.setp2ActivePvC();
        }

        //Sticks wurden verändert
        void g_stickCountChangedPvC(nimEngine.StickCountChangedEventArgs eventArgs)
        {
            if (this.p1TurnPvC)
            {
                this.drawnSticksP1PvC += eventArgs.Diff;
            }
            else
            {
                this.drawnSticksP2PvC += eventArgs.Diff;
            }
            switch (g.StickCount)
            {
                case 2:
                    this.btnNim3PvC.Enabled = false;
                    break;
                case 1:
                    this.btnNim3PvC.Enabled = false;
                    this.btnNim2PvC.Enabled = false;
                    break;
                default:
                    this.btnNim2PvC.Enabled = true;
                    this.btnNim3PvC.Enabled = true;
                    break;

            }
            this.refreshSticksPvC();
        }

        //Spiel vorbei
        void g_gameOverPvC(nimEngine.GameOverEventArgs eventArgs)
        {
            gameRunning = false;
            string winner = eventArgs.winner.ident;
            string loser = eventArgs.loser.ident;

            MessageBox.Show(eventArgs.winner.ident + " hat gewonnen!");

            Highscoremanager.addWin(winner);
            Highscoremanager.addLoss(loser);

            this.tabMain.SelectedTab = this.tbPgHighscore;
        }

            #region helper

            void refreshSticksPvC()
            {
                this.lblDrawnSticksP1PvC.Text = this.drawnSticksP1PvC.ToString();
                this.lblDrawnSticksP2PvC.Text = this.drawnSticksP2PvC.ToString();
                this.lblStickCountPvC.Text = this.g.StickCount.ToString();
            }

            void setp1ActivePvC()
            {
                this.panP1PvC.BackColor = Color.LimeGreen;
                this.panP2PvC.BackColor = Color.Transparent;
            }

            void setp2ActivePvC()
            {
                this.panP2PvC.BackColor = Color.LimeGreen;
                this.panP1PvC.BackColor = Color.Transparent;
            }

            #endregion

        #endregion

    }
}
