﻿using System;
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
        private void btnBackToMainSettings_Click(object sender, EventArgs e)
        {
            this.tabMain.SelectedTab = this.tbPgMain;
        }

        private void numUDStickCountSettings_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.settingsProfile.StickCount = (int)this.numUDStickCountSettings.Value;
        }
	}
}
