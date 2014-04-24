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
        Player[] AIs = {    new nimEngine.AI.AI_easy(), 
                            new nimEngine.AI.AI_intermediate(),
                            new nimEngine.AI.AI_hard(),
                            new nimEngine.AI.AI_expert(),
                            new nimEngine.AI.AI_troll() };

        public frmNimGame()
        {
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
            this.cmbBxAIPvCData.Items.AddRange(AIs);
        }

        private void btnStartGameMain_Click(object sender, EventArgs e)
        {
            //Öffnen der Spielmodiauswahl
            tabMain.SelectedTab = this.tbPgGameMode;
        }

        private void btnSettingsMain_Click(object sender, EventArgs e)
        {
            //Einstellungen Öffnen
            tabMain.SelectedTab = this.tbPgSettings;
        }

        private void btnHighscoreMain_Click(object sender, EventArgs e)
        {
            //Highscore öffnen
            tabMain.SelectedTab = this.tbPgHighscore;
        }

        private void frmNimGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Highscoremanager.save();
        }

        private void frmNimGame_Load(object sender, EventArgs e)
        {
            //this.tabMain.Size = new Size(984, 743); //Tableiste Sichtbar
            this.tabMain.Size = new Size(984, 764); //Tableiste unsichtbar
            Highscoremanager.load();
        }
    }
}
