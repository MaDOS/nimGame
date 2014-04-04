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
        void g_stickCountChangedPvP()
        {
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
            this.gameRunning = false;
            this.lblWinner.Text = "Gewinner: " + eventArgs.winner.ident;
            this.tabMain.SelectedTab = this.tbPgGameOver;

            this.btnNim1PvP.Enabled = false;
            this.btnNim2PvP.Enabled = false;
            this.btnNim3PvP.Enabled = false;
            this.resetGamePvP();
        }

            #region helper

            void refreshSticksPvP()
            {
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

        //Zug von Spieler 1 beginnt
        void p1_playerStartedTurnPvC(nimEngine.PlayerStartedTurnEventArgs eventArgs)
        {
            this.setp1ActivePvC();
        }

        //Zug von Spieler 2 beginnt
        void p2_playerStartedTurnPvC(nimEngine.PlayerStartedTurnEventArgs eventArgs)
        {
            this.setp2ActivePvC();
        }

        //Sticks wurden verändert
        void g_stickCountChangedPvC()
        {
            this.refreshSticksPvC();
        }

        //Spiel vorbei
        void g_gameOverPvC(nimEngine.GameOverEventArgs eventArgs)
        {
            gameRunning = false;
            MessageBox.Show(eventArgs.winner.ident);
        }

            #region helper

            void refreshSticksPvC()
            {
                this.lblStickCountPvC.Text = this.g.StickCount.ToString();
            }

            void setp1ActivePvC()
            {
                this.panP1PvP.BackColor = Color.LimeGreen;
                this.panP2PvP.BackColor = Color.Transparent;
            }

            void setp2ActivePvC()
            {
                this.panP2PvP.BackColor = Color.LimeGreen;
                this.panP1PvP.BackColor = Color.Transparent;
            }

            #endregion

        #endregion

    }
}
