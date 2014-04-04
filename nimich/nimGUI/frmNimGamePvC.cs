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
            if (p1TurnPvP)
            {
                this.humanTakeSticksPvC(1);
            }
        }

        private void btnNim2PvC_Click(object sender, EventArgs e)
        {
            if (p1TurnPvP)
            {
                this.humanTakeSticksPvC(2);
            }
        }

        private void btnNim3PvC_Click(object sender, EventArgs e)
        {
            if (p1TurnPvP)
            {
                this.humanTakeSticksPvC(3);
            }
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


            this.drawnSticksP1PvC += stickCount;
            this.lblDrawnSticksP1PvC.Text = this.drawnSticksP1PvC.ToString();
        }

        #endregion
    }
}
