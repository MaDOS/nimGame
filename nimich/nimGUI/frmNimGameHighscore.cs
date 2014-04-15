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
        private void tabMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
        	this.lstViewHighscores.Items.Clear();
            foreach (Highscoreprofile hsp in Highscoremanager.highscoreProfiles.Values)
            {
            	this.lstViewHighscores.Items.Add(new ListViewItem( new string[]{hsp.Playername, hsp.Won.ToString(), hsp.Lost.ToString(), hsp.WonPerLost.ToString()} ));
            }
        }
    }
}
