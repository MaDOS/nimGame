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
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedTab == this.tbPgHighscore)
            {
                this.lstViewHighscores.Items.Clear();
                foreach (HighscoreProfile hsp in HighscoreManager.highscoreProfiles.Values)
                {
                    this.lstViewHighscores.Items.Add(new ListViewItem(new string[] { hsp.Playername, hsp.Won.ToString(), hsp.Losses.ToString(), hsp.WonPerLost.ToString() }));
                }
            }
        }

        private void btnBacktoMainHighscore_Click(object sender, EventArgs e)
        {
            this.tabMain.SelectedTab = this.tbPgMain;
        }
    }
}
