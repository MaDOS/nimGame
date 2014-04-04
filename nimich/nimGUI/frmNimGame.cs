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
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnStartGameMain_Click(object sender, EventArgs e)
        {
            //Öffnen der Spielmodiauswahl
            tabMain.SelectedTab = tbPgGameMode;
        }

        private void btnSettingsMain_Click(object sender, EventArgs e)
        {
            //Einstellungen Öffnen
        }

        private void btnHighscoreMain_Click(object sender, EventArgs e)
        {
            //Highscore öffnen
        }
    }
}
