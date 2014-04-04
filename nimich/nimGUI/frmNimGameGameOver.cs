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
        void BtnBackToMainGameOverClick(object sender, System.EventArgs e)
        {
        	this.tabMain.SelectedTab = this.tbPgMain;
        }
	}
}
