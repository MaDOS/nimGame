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
        void butNimOnePvP_Click(object sender, EventArgs e)
        {
        	if(p1Turn)
        	{
                this.humanTakeSticks((Human)p1, 1);
        	}
        	else
            {
                this.humanTakeSticks((Human)p2, 1);
        	}
        }
        
        void butNimTwoPvP_Click(object sender, EventArgs e)
        {

            if (p1Turn)
            {
                this.humanTakeSticks((Human)p1, 2);
            }
            else
            {
                this.humanTakeSticks((Human)p2, 2);
            }
        }
        
        void butNimThreePvP_Click(object sender, EventArgs e)
        {
            if (p1Turn)
            {
                this.humanTakeSticks((Human)p1, 3);
            }
            else
            {
                this.humanTakeSticks((Human)p2, 3);
            }
        }
        
        #region helper
        void resetControlsGamePvP()
        {
        	
        }
        #endregion
    }
}
