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
            this.refreshSticks();
        }

        //Spiel vorbei
        void g_gameOver(nimEngine.GameOverEventArgs eventArgs)
        {
            this.gameRunning = false;
            MessageBox.Show("Gewinner ist " + eventArgs.winner.ident);

            //if (this.p1.ident == eventArgs.winner.ident)
            //{
            //    //spieler 1 ist gewinner
            //}
            //else
            //{
            //    //gewinnt spieler 2
            //}
        }

#region helper

        void refreshSticks()
        {
        	this.labSticks.Text = this.g.StickCount.ToString();
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
                this.labPvPP1TakenSticks.Text = this.drawnSticksP1.ToString();
            }
            else
            {
                this.drawnSticksP2 += stickCount;
                this.labPvPP2TakenSticks.Text = this.drawnSticksP2.ToString();
            }
        }

#endregion
    }
}
