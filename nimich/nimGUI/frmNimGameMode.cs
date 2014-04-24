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
        private void btnBackToMainMode_Click(object sender, EventArgs e)
        {
            this.tabMain.SelectedTab = this.tbPgMain;
        }

        private void btnStartPvPMode_Click(object sender, EventArgs e)
        {
            //Spielerdatenblatt öffnen
            tabMain.SelectedTab = tbPgGamePvP;
        }

        private void btnStartPvCMode_Click(object sender, EventArgs e)
        {
            //Spielerdatenblatt öffnen
            this.tabMain.SelectedTab = this.tbPgDataPvC;
        }

        private void btnStartNetMode_Click(object sender, EventArgs e)
        {
            //Spielerdatenblatt öffnen
            tabMain.SelectedTab = tbPgDataNetwork;
        }
    }
}
