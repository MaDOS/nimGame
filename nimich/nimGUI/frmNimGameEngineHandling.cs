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
        bool p1Turn, gameRunning;
        int drawnSticksP1, drawnSticksP2 = 0;

        //Zug von Spieler 1 beginnt
        void p1_playerStartedTurn(nimEngine.PlayerStartedTurnEventArgs eventArgs)
        {
            this.p1Turn = true;
            this.setp1Active();
        }

        //Zug von Spieler 2 beginnt
        void p2_playerStartedTurn(nimEngine.PlayerStartedTurnEventArgs eventArgs)
        {
            this.p1Turn = false;
            this.setp2Active();
        }

        //Sticks wurden verändert
        void g_stickCountChanged()
        {
        	switch(g.StickCount)
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
            this.refreshSticks();
        }

        //Spiel vorbei
        void g_gameOver(nimEngine.GameOverEventArgs eventArgs)
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

        void refreshSticks()
        {
        	this.lblStickCountPvP.Text = this.g.StickCount.ToString();
        }

        void setp1Active()
        {
            this.panPvPP1.BackColor = Color.LimeGreen;
            this.panPvPP2.BackColor = Color.Transparent;
        }

        void setp2Active()
        {
            this.panPvPP2.BackColor = Color.LimeGreen;
            this.panPvPP1.BackColor = Color.Transparent;
        }

        void humanTakeSticks(Human p, int stickCount)
        {
            if (!gameRunning)
            {
                return;
            }
            p.AmountNextTurn = stickCount;
            p.ReadyForTurn = true;

            if (p1Turn == true)
            {
                this.drawnSticksP1 += stickCount;
                this.lblDrawnSticksP1PvP.Text = this.drawnSticksP1.ToString();
            }
            else
            {
                this.drawnSticksP2 += stickCount;
                this.lblDrawnSticksP2PvP.Text = this.drawnSticksP2.ToString();
            }
        }

#endregion
    }
}
