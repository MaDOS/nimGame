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

        private void btnNim1PvC_Click(object sender, EventArgs e)
        {
            this.humanTakeSticksPvC(1);
        }

        private void btnNim2PvC_Click(object sender, EventArgs e)
        {
            this.humanTakeSticksPvC(2);
        }

        private void btnNim3PvC_Click(object sender, EventArgs e)
        {
            this.humanTakeSticksPvC(3);
        }

        #region helper

        void humanTakeSticksPvC(int stickCount)
        {
            if (!gameRunning)
            {
                return;
            }

            ((Human)p1).AmountNextTurn = stickCount;
            ((Human)p1).ReadyForTurn = true;
        }

        void resetGamePvC()
        {
            this.btnNim1PvC.Enabled = true;
            this.btnNim2PvC.Enabled = true;
            this.btnNim3PvC.Enabled = true;
            this.lblDrawnSticksP1PvC.Text = "0";
            this.lblDrawnSticksP2PvC.Text = "0";
            this.drawnSticksP1PvC = 0;
            this.drawnSticksP2PvC = 0;
            this.refreshSticksPvC();
        }

        #endregion
    }
}
