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
        Player p1;
        Player p2;
        bool p1Turn;

        //Zug von Spieler 1 beginnt
        void p1_playerStartedTurn(nimEngine.PlayerStartedTurnEventArgs eventArgs)
        {
            this.p1Turn = true;
        }

        //Zug von Spieler 2 beginnt
        void p2_playerStartedTurn(nimEngine.PlayerStartedTurnEventArgs eventArgs)
        {
            this.p1Turn = false;
        }

        //Sticks wurden verändert
        void g_stickCountChanged()
        {
            this.refreshSticks(this.g.StickCount);
        }

        //Spiel vorbei
        void g_gameOver(nimEngine.GameOverEventArgs eventArgs)
        {
            if (this.p1.ident == eventArgs.winner.ident)
            {
                //spieler 1 ist gewinner
            }
            else
            {
                //gewinnt spieler 2
            }
        }

        void refreshSticks(int currentSticks)
        {
            this.labSticks.Text = currentSticks.ToString();
        }
    }
}
