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
        void ButNimOneClick(object sender, EventArgs e)
        {
        	if(p1Turn)
        	{
        		((Human)this.p1).AmountNextTurn = 1;
        		((Human)this.p1).ReadyForTurn = true;
        	}
        	else
        	{
        		((Human)this.p2).AmountNextTurn = 1;
        		((Human)this.p2).ReadyForTurn = true;
        	}
        }
        
        void ButNimTwoClick(object sender, EventArgs e)
        {
        	if(p1Turn)
        	{
        		((Human)this.p1).AmountNextTurn = 2;
        		((Human)this.p1).ReadyForTurn = true;
        	}
        	else
        	{
        		((Human)this.p2).AmountNextTurn = 2;
        		((Human)this.p2).ReadyForTurn = true;
        	}
        }
        
        void ButNimThreeClick(object sender, EventArgs e)
        {
        	if(p1Turn)
        	{
        		((Human)this.p1).AmountNextTurn = 3;
        		((Human)this.p1).ReadyForTurn = true;
        	}
        	else
        	{
        		((Human)this.p2).AmountNextTurn = 3;
        		((Human)this.p2).ReadyForTurn = true;
        	}
        }
	}
}
