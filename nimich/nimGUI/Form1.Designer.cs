namespace nimGUI
{
    partial class frmNimGame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbPgStart = new System.Windows.Forms.TabPage();
            this.tbPgGameMode = new System.Windows.Forms.TabPage();
            this.butStartGame = new System.Windows.Forms.Button();
            this.butSettings = new System.Windows.Forms.Button();
            this.butHighscore = new System.Windows.Forms.Button();
            this.butStartHotSeat = new System.Windows.Forms.Button();
            this.butStartComputer = new System.Windows.Forms.Button();
            this.butStartNetwork = new System.Windows.Forms.Button();
            this.tbPgGameData1 = new System.Windows.Forms.TabPage();
            this.tbPgHotSeat = new System.Windows.Forms.TabPage();
            this.labPlayerName1 = new System.Windows.Forms.Label();
            this.txtPlayerName1 = new System.Windows.Forms.TextBox();
            this.labPlayerName2 = new System.Windows.Forms.Label();
            this.txtPlayerName2 = new System.Windows.Forms.TextBox();
            this.butStartGame1 = new System.Windows.Forms.Button();
            this.labNameP1 = new System.Windows.Forms.Label();
            this.labNameP2 = new System.Windows.Forms.Label();
            this.labSticks = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tbPgStart.SuspendLayout();
            this.tbPgGameMode.SuspendLayout();
            this.tbPgGameData1.SuspendLayout();
            this.tbPgHotSeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbPgStart);
            this.tabMain.Controls.Add(this.tbPgGameMode);
            this.tabMain.Controls.Add(this.tbPgGameData1);
            this.tabMain.Controls.Add(this.tbPgHotSeat);
            this.tabMain.Location = new System.Drawing.Point(-4, -1);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(992, 767);
            this.tabMain.TabIndex = 0;
            // 
            // tbPgStart
            // 
            this.tbPgStart.Controls.Add(this.butHighscore);
            this.tbPgStart.Controls.Add(this.butSettings);
            this.tbPgStart.Controls.Add(this.butStartGame);
            this.tbPgStart.Location = new System.Drawing.Point(4, 22);
            this.tbPgStart.Name = "tbPgStart";
            this.tbPgStart.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgStart.Size = new System.Drawing.Size(984, 741);
            this.tbPgStart.TabIndex = 0;
            this.tbPgStart.Text = "Start";
            this.tbPgStart.UseVisualStyleBackColor = true;
            // 
            // tbPgGameMode
            // 
            this.tbPgGameMode.Controls.Add(this.butStartNetwork);
            this.tbPgGameMode.Controls.Add(this.butStartComputer);
            this.tbPgGameMode.Controls.Add(this.butStartHotSeat);
            this.tbPgGameMode.Location = new System.Drawing.Point(4, 22);
            this.tbPgGameMode.Name = "tbPgGameMode";
            this.tbPgGameMode.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgGameMode.Size = new System.Drawing.Size(984, 741);
            this.tbPgGameMode.TabIndex = 1;
            this.tbPgGameMode.Text = "Moduswahl";
            this.tbPgGameMode.UseVisualStyleBackColor = true;
            // 
            // butStartGame
            // 
            this.butStartGame.Location = new System.Drawing.Point(342, 193);
            this.butStartGame.Name = "butStartGame";
            this.butStartGame.Size = new System.Drawing.Size(300, 50);
            this.butStartGame.TabIndex = 0;
            this.butStartGame.Text = "Spiel starten";
            this.butStartGame.UseVisualStyleBackColor = true;
            this.butStartGame.Click += new System.EventHandler(this.butStartGame_Click);
            // 
            // butSettings
            // 
            this.butSettings.Location = new System.Drawing.Point(342, 277);
            this.butSettings.Name = "butSettings";
            this.butSettings.Size = new System.Drawing.Size(300, 50);
            this.butSettings.TabIndex = 1;
            this.butSettings.Text = "Einstellungen";
            this.butSettings.UseVisualStyleBackColor = true;
            this.butSettings.Click += new System.EventHandler(this.butSettings_Click);
            // 
            // butHighscore
            // 
            this.butHighscore.Location = new System.Drawing.Point(342, 333);
            this.butHighscore.Name = "butHighscore";
            this.butHighscore.Size = new System.Drawing.Size(300, 50);
            this.butHighscore.TabIndex = 2;
            this.butHighscore.Text = "Highscore";
            this.butHighscore.UseVisualStyleBackColor = true;
            this.butHighscore.Click += new System.EventHandler(this.butHighscore_Click);
            // 
            // butStartHotSeat
            // 
            this.butStartHotSeat.Location = new System.Drawing.Point(342, 181);
            this.butStartHotSeat.Name = "butStartHotSeat";
            this.butStartHotSeat.Size = new System.Drawing.Size(300, 50);
            this.butStartHotSeat.TabIndex = 1;
            this.butStartHotSeat.Text = "Spieler vs. Spieler";
            this.butStartHotSeat.UseVisualStyleBackColor = true;
            this.butStartHotSeat.Click += new System.EventHandler(this.butStartHotSeat_Click);
            // 
            // butStartComputer
            // 
            this.butStartComputer.Location = new System.Drawing.Point(342, 237);
            this.butStartComputer.Name = "butStartComputer";
            this.butStartComputer.Size = new System.Drawing.Size(300, 50);
            this.butStartComputer.TabIndex = 2;
            this.butStartComputer.Text = "Spieler vs. Computer";
            this.butStartComputer.UseVisualStyleBackColor = true;
            // 
            // butStartNetwork
            // 
            this.butStartNetwork.Location = new System.Drawing.Point(342, 293);
            this.butStartNetwork.Name = "butStartNetwork";
            this.butStartNetwork.Size = new System.Drawing.Size(300, 50);
            this.butStartNetwork.TabIndex = 3;
            this.butStartNetwork.Text = "Netzwerkspiel";
            this.butStartNetwork.UseVisualStyleBackColor = true;
            // 
            // tbPgGameData1
            // 
            this.tbPgGameData1.BackColor = System.Drawing.Color.White;
            this.tbPgGameData1.Controls.Add(this.butStartGame1);
            this.tbPgGameData1.Controls.Add(this.txtPlayerName2);
            this.tbPgGameData1.Controls.Add(this.labPlayerName2);
            this.tbPgGameData1.Controls.Add(this.txtPlayerName1);
            this.tbPgGameData1.Controls.Add(this.labPlayerName1);
            this.tbPgGameData1.Location = new System.Drawing.Point(4, 22);
            this.tbPgGameData1.Name = "tbPgGameData1";
            this.tbPgGameData1.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgGameData1.Size = new System.Drawing.Size(984, 741);
            this.tbPgGameData1.TabIndex = 2;
            this.tbPgGameData1.Text = "Spieler1";
            // 
            // tbPgHotSeat
            // 
            this.tbPgHotSeat.Controls.Add(this.labSticks);
            this.tbPgHotSeat.Controls.Add(this.labNameP2);
            this.tbPgHotSeat.Controls.Add(this.labNameP1);
            this.tbPgHotSeat.Location = new System.Drawing.Point(4, 22);
            this.tbPgHotSeat.Name = "tbPgHotSeat";
            this.tbPgHotSeat.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgHotSeat.Size = new System.Drawing.Size(984, 741);
            this.tbPgHotSeat.TabIndex = 3;
            this.tbPgHotSeat.Text = "HotSeat";
            this.tbPgHotSeat.UseVisualStyleBackColor = true;
            // 
            // labPlayerName1
            // 
            this.labPlayerName1.AutoSize = true;
            this.labPlayerName1.Location = new System.Drawing.Point(393, 153);
            this.labPlayerName1.Name = "labPlayerName1";
            this.labPlayerName1.Size = new System.Drawing.Size(51, 13);
            this.labPlayerName1.TabIndex = 0;
            this.labPlayerName1.Text = "Spieler 1:";
            // 
            // txtPlayerName1
            // 
            this.txtPlayerName1.Location = new System.Drawing.Point(450, 150);
            this.txtPlayerName1.Name = "txtPlayerName1";
            this.txtPlayerName1.Size = new System.Drawing.Size(153, 20);
            this.txtPlayerName1.TabIndex = 1;
            // 
            // labPlayerName2
            // 
            this.labPlayerName2.AutoSize = true;
            this.labPlayerName2.Location = new System.Drawing.Point(393, 179);
            this.labPlayerName2.Name = "labPlayerName2";
            this.labPlayerName2.Size = new System.Drawing.Size(51, 13);
            this.labPlayerName2.TabIndex = 2;
            this.labPlayerName2.Text = "Spieler 2:";
            // 
            // txtPlayerName2
            // 
            this.txtPlayerName2.Location = new System.Drawing.Point(450, 176);
            this.txtPlayerName2.Name = "txtPlayerName2";
            this.txtPlayerName2.Size = new System.Drawing.Size(153, 20);
            this.txtPlayerName2.TabIndex = 3;
            // 
            // butStartGame1
            // 
            this.butStartGame1.Location = new System.Drawing.Point(342, 225);
            this.butStartGame1.Name = "butStartGame1";
            this.butStartGame1.Size = new System.Drawing.Size(300, 50);
            this.butStartGame1.TabIndex = 4;
            this.butStartGame1.Text = "Start";
            this.butStartGame1.UseVisualStyleBackColor = true;
            this.butStartGame1.Click += new System.EventHandler(this.butStartGame1_Click);
            // 
            // labNameP1
            // 
            this.labNameP1.AutoSize = true;
            this.labNameP1.Location = new System.Drawing.Point(46, 41);
            this.labNameP1.Name = "labNameP1";
            this.labNameP1.Size = new System.Drawing.Size(45, 13);
            this.labNameP1.TabIndex = 0;
            this.labNameP1.Text = "Spieler1";
            // 
            // labNameP2
            // 
            this.labNameP2.AutoSize = true;
            this.labNameP2.Location = new System.Drawing.Point(811, 52);
            this.labNameP2.Name = "labNameP2";
            this.labNameP2.Size = new System.Drawing.Size(45, 13);
            this.labNameP2.TabIndex = 1;
            this.labNameP2.Text = "Spieler2";
            // 
            // labSticks
            // 
            this.labSticks.AutoSize = true;
            this.labSticks.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSticks.Location = new System.Drawing.Point(396, 184);
            this.labSticks.Name = "labSticks";
            this.labSticks.Size = new System.Drawing.Size(153, 108);
            this.labSticks.TabIndex = 2;
            this.labSticks.Text = "##";
            // 
            // frmNimGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.tabMain);
            this.Name = "frmNimGame";
            this.Text = "nimGame";
            this.tabMain.ResumeLayout(false);
            this.tbPgStart.ResumeLayout(false);
            this.tbPgGameMode.ResumeLayout(false);
            this.tbPgGameData1.ResumeLayout(false);
            this.tbPgGameData1.PerformLayout();
            this.tbPgHotSeat.ResumeLayout(false);
            this.tbPgHotSeat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbPgStart;
        private System.Windows.Forms.TabPage tbPgGameMode;
        private System.Windows.Forms.Button butStartGame;
        private System.Windows.Forms.Button butHighscore;
        private System.Windows.Forms.Button butSettings;
        private System.Windows.Forms.Button butStartNetwork;
        private System.Windows.Forms.Button butStartComputer;
        private System.Windows.Forms.Button butStartHotSeat;
        private System.Windows.Forms.TabPage tbPgGameData1;
        private System.Windows.Forms.TabPage tbPgHotSeat;
        private System.Windows.Forms.Button butStartGame1;
        private System.Windows.Forms.TextBox txtPlayerName2;
        private System.Windows.Forms.Label labPlayerName2;
        private System.Windows.Forms.TextBox txtPlayerName1;
        private System.Windows.Forms.Label labPlayerName1;
        private System.Windows.Forms.Label labNameP2;
        private System.Windows.Forms.Label labNameP1;
        private System.Windows.Forms.Label labSticks;
    }
}

