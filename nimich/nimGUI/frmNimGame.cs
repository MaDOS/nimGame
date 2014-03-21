using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nimGUI
{
    public partial class frmNimGame : Form
    {
        public frmNimGame()
        {
            InitializeComponent();
        }

        private void butStartGame_Click(object sender, EventArgs e)
        {
            //Öffnen der Spielmodiauswahl
            tabMain.SelectedTab = tbPgGameMode;
        }

        private void butSettings_Click(object sender, EventArgs e)
        {
            //Einstellungen Öffnen
        }

        private void butHighscore_Click(object sender, EventArgs e)
        {
            //Highscore öffnen
        }        
    }
}
