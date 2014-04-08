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
    public partial class frmNimGame : Form
    {       

        private void btnNim1PvP_Click(object sender, EventArgs e)
        {
        	if(p1TurnPvP)
        	{
                this.humanTakeSticksPvP((Human)p1, 1);
        	}
        	else
            {
                this.humanTakeSticksPvP((Human)p2, 1);
        	}
        }

        private void btnNim2PvP_Click(object sender, EventArgs e)
        {
            if (p1TurnPvP)
            {
                this.humanTakeSticksPvP((Human)p1, 2);
            }
            else
            {
                this.humanTakeSticksPvP((Human)p2, 2);
            }
        }
        
        private void btnNim3PvP_Click(object sender, EventArgs e)
        {
            if (p1TurnPvP)
            {
                this.humanTakeSticksPvP((Human)p1, 3);
            }
            else
            {
                this.humanTakeSticksPvP((Human)p2, 3);
            }
        }
        
        #region helper

        void humanTakeSticksPvP(Human p, int stickCount)
        {
            if (!gameRunning)
            {
                return;
            }
            p.AmountNextTurn = stickCount;
            p.ReadyForTurn = true;
        }

        void resetGamePvP()
        {
        	this.btnNim1PvP.Enabled = true;
        	this.btnNim2PvP.Enabled = true;
        	this.btnNim3PvP.Enabled = true;
        	this.lblDrawnSticksP1PvP.Text = "0";
        	this.lblDrawnSticksP2PvP.Text = "0";
        	this.drawnSticksP1PvP = 0;
        	this.drawnSticksP2PvP = 0;
        	this.refreshSticksPvP();
        }

        #endregion
    }
}
