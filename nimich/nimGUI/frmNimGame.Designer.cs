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
        	this.tbPgMain = new System.Windows.Forms.TabPage();
        	this.btnHighscoreMain = new System.Windows.Forms.Button();
        	this.btnSettingsMain = new System.Windows.Forms.Button();
        	this.btnStartGameMain = new System.Windows.Forms.Button();
        	this.tbPgGameMode = new System.Windows.Forms.TabPage();
        	this.btnStartNetMode = new System.Windows.Forms.Button();
        	this.btnStartPvCMode = new System.Windows.Forms.Button();
        	this.btnStartPvPMode = new System.Windows.Forms.Button();
        	this.tbPgGamePvP = new System.Windows.Forms.TabPage();
        	this.btnStartPvPGamePvPData = new System.Windows.Forms.Button();
        	this.txtPlayerName2PvPData = new System.Windows.Forms.TextBox();
        	this.lblPlayer2NamePvPDataDesc = new System.Windows.Forms.Label();
        	this.txtPlayerName1PvPData = new System.Windows.Forms.TextBox();
        	this.lblPlayer1NamePvPDataDesc = new System.Windows.Forms.Label();
        	this.tbPgPvP = new System.Windows.Forms.TabPage();
        	this.lblStickCountPvPDesc = new System.Windows.Forms.Label();
        	this.panPvPP2 = new System.Windows.Forms.Panel();
        	this.lblDrawnSticksP2PvPDesc = new System.Windows.Forms.Label();
        	this.lblDrawnSticksP2PvP = new System.Windows.Forms.Label();
        	this.lblP2NamePvP = new System.Windows.Forms.Label();
        	this.panPvPP1 = new System.Windows.Forms.Panel();
        	this.lblDrawnSticksP1PvPDesc = new System.Windows.Forms.Label();
        	this.lblDrawnSticksP1PvP = new System.Windows.Forms.Label();
        	this.lblP1NamePvP = new System.Windows.Forms.Label();
        	this.btnNim3PvP = new System.Windows.Forms.Button();
        	this.btnNim2PvP = new System.Windows.Forms.Button();
        	this.btnNim1PvP = new System.Windows.Forms.Button();
        	this.lblStickCountPvP = new System.Windows.Forms.Label();
        	this.tbPgDataPvC = new System.Windows.Forms.TabPage();
        	this.cmbBxAIPvCData = new System.Windows.Forms.ComboBox();
        	this.btnStartPvCGamePvCData = new System.Windows.Forms.Button();
        	this.lblPlayer2NamePvCDataDesc = new System.Windows.Forms.Label();
        	this.txtPlayer1NamePvCData = new System.Windows.Forms.TextBox();
        	this.lblPlayer1NamePvCDataDesc = new System.Windows.Forms.Label();
        	this.tabPgGamePvC = new System.Windows.Forms.TabPage();
        	this.tabPgDataNetwork = new System.Windows.Forms.TabPage();
        	this.tabPgNetwork = new System.Windows.Forms.TabPage();
        	this.tabPgSettings = new System.Windows.Forms.TabPage();
        	this.lblStickCountSettingsDesc = new System.Windows.Forms.Label();
        	this.numUDStickCountSettings = new System.Windows.Forms.NumericUpDown();
        	this.tbPgGameOver = new System.Windows.Forms.TabPage();
        	this.btnBackToMainGameOver = new System.Windows.Forms.Button();
        	this.lblWinner = new System.Windows.Forms.Label();
        	this.tabMain.SuspendLayout();
        	this.tbPgMain.SuspendLayout();
        	this.tbPgGameMode.SuspendLayout();
        	this.tbPgGamePvP.SuspendLayout();
        	this.tbPgPvP.SuspendLayout();
        	this.panPvPP2.SuspendLayout();
        	this.panPvPP1.SuspendLayout();
        	this.tbPgDataPvC.SuspendLayout();
        	this.tabPgSettings.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numUDStickCountSettings)).BeginInit();
        	this.tbPgGameOver.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// tabMain
        	// 
        	this.tabMain.Controls.Add(this.tbPgMain);
        	this.tabMain.Controls.Add(this.tbPgGameMode);
        	this.tabMain.Controls.Add(this.tbPgGamePvP);
        	this.tabMain.Controls.Add(this.tbPgPvP);
        	this.tabMain.Controls.Add(this.tbPgDataPvC);
        	this.tabMain.Controls.Add(this.tabPgGamePvC);
        	this.tabMain.Controls.Add(this.tabPgDataNetwork);
        	this.tabMain.Controls.Add(this.tabPgNetwork);
        	this.tabMain.Controls.Add(this.tabPgSettings);
        	this.tabMain.Controls.Add(this.tbPgGameOver);
        	this.tabMain.Location = new System.Drawing.Point(-4, -1);
        	this.tabMain.Name = "tabMain";
        	this.tabMain.SelectedIndex = 0;
        	this.tabMain.Size = new System.Drawing.Size(992, 767);
        	this.tabMain.TabIndex = 0;
        	// 
        	// tbPgMain
        	// 
        	this.tbPgMain.Controls.Add(this.btnHighscoreMain);
        	this.tbPgMain.Controls.Add(this.btnSettingsMain);
        	this.tbPgMain.Controls.Add(this.btnStartGameMain);
        	this.tbPgMain.Location = new System.Drawing.Point(4, 22);
        	this.tbPgMain.Name = "tbPgMain";
        	this.tbPgMain.Padding = new System.Windows.Forms.Padding(3);
        	this.tbPgMain.Size = new System.Drawing.Size(984, 741);
        	this.tbPgMain.TabIndex = 0;
        	this.tbPgMain.Text = "Main";
        	this.tbPgMain.UseVisualStyleBackColor = true;
        	// 
        	// btnHighscoreMain
        	// 
        	this.btnHighscoreMain.Location = new System.Drawing.Point(342, 333);
        	this.btnHighscoreMain.Name = "btnHighscoreMain";
        	this.btnHighscoreMain.Size = new System.Drawing.Size(300, 50);
        	this.btnHighscoreMain.TabIndex = 2;
        	this.btnHighscoreMain.Text = "Highscore";
        	this.btnHighscoreMain.UseVisualStyleBackColor = true;
        	this.btnHighscoreMain.Click += new System.EventHandler(this.btnHighscoreMain_Click);
        	// 
        	// btnSettingsMain
        	// 
        	this.btnSettingsMain.Location = new System.Drawing.Point(342, 277);
        	this.btnSettingsMain.Name = "btnSettingsMain";
        	this.btnSettingsMain.Size = new System.Drawing.Size(300, 50);
        	this.btnSettingsMain.TabIndex = 1;
        	this.btnSettingsMain.Text = "Einstellungen";
        	this.btnSettingsMain.UseVisualStyleBackColor = true;
        	this.btnSettingsMain.Click += new System.EventHandler(this.btnSettingsMain_Click);
        	// 
        	// btnStartGameMain
        	// 
        	this.btnStartGameMain.Location = new System.Drawing.Point(342, 193);
        	this.btnStartGameMain.Name = "btnStartGameMain";
        	this.btnStartGameMain.Size = new System.Drawing.Size(300, 50);
        	this.btnStartGameMain.TabIndex = 0;
        	this.btnStartGameMain.Text = "Spiel starten";
        	this.btnStartGameMain.UseVisualStyleBackColor = true;
        	this.btnStartGameMain.Click += new System.EventHandler(this.btnStartGameMain_Click);
        	// 
        	// tbPgGameMode
        	// 
        	this.tbPgGameMode.Controls.Add(this.btnStartNetMode);
        	this.tbPgGameMode.Controls.Add(this.btnStartPvCMode);
        	this.tbPgGameMode.Controls.Add(this.btnStartPvPMode);
        	this.tbPgGameMode.Location = new System.Drawing.Point(4, 22);
        	this.tbPgGameMode.Name = "tbPgGameMode";
        	this.tbPgGameMode.Padding = new System.Windows.Forms.Padding(3);
        	this.tbPgGameMode.Size = new System.Drawing.Size(984, 741);
        	this.tbPgGameMode.TabIndex = 1;
        	this.tbPgGameMode.Text = "Moduswahl";
        	this.tbPgGameMode.UseVisualStyleBackColor = true;
        	// 
        	// btnStartNetMode
        	// 
        	this.btnStartNetMode.Location = new System.Drawing.Point(342, 293);
        	this.btnStartNetMode.Name = "btnStartNetMode";
        	this.btnStartNetMode.Size = new System.Drawing.Size(300, 50);
        	this.btnStartNetMode.TabIndex = 3;
        	this.btnStartNetMode.Text = "Netzwerkspiel";
        	this.btnStartNetMode.UseVisualStyleBackColor = true;
        	this.btnStartNetMode.Click += new System.EventHandler(this.btnStartNetMode_Click);
        	// 
        	// btnStartPvCMode
        	// 
        	this.btnStartPvCMode.Location = new System.Drawing.Point(342, 237);
        	this.btnStartPvCMode.Name = "btnStartPvCMode";
        	this.btnStartPvCMode.Size = new System.Drawing.Size(300, 50);
        	this.btnStartPvCMode.TabIndex = 2;
        	this.btnStartPvCMode.Text = "Spieler vs. Computer";
        	this.btnStartPvCMode.UseVisualStyleBackColor = true;
        	this.btnStartPvCMode.Click += new System.EventHandler(this.btnStartPvCMode_Click);
        	// 
        	// btnStartPvPMode
        	// 
        	this.btnStartPvPMode.Location = new System.Drawing.Point(342, 181);
        	this.btnStartPvPMode.Name = "btnStartPvPMode";
        	this.btnStartPvPMode.Size = new System.Drawing.Size(300, 50);
        	this.btnStartPvPMode.TabIndex = 1;
        	this.btnStartPvPMode.Text = "Spieler vs. Spieler";
        	this.btnStartPvPMode.UseVisualStyleBackColor = true;
        	this.btnStartPvPMode.Click += new System.EventHandler(this.btnStartPvPMode_Click);
        	// 
        	// tbPgGamePvP
        	// 
        	this.tbPgGamePvP.BackColor = System.Drawing.Color.White;
        	this.tbPgGamePvP.Controls.Add(this.btnStartPvPGamePvPData);
        	this.tbPgGamePvP.Controls.Add(this.txtPlayerName2PvPData);
        	this.tbPgGamePvP.Controls.Add(this.lblPlayer2NamePvPDataDesc);
        	this.tbPgGamePvP.Controls.Add(this.txtPlayerName1PvPData);
        	this.tbPgGamePvP.Controls.Add(this.lblPlayer1NamePvPDataDesc);
        	this.tbPgGamePvP.Location = new System.Drawing.Point(4, 22);
        	this.tbPgGamePvP.Name = "tbPgGamePvP";
        	this.tbPgGamePvP.Padding = new System.Windows.Forms.Padding(3);
        	this.tbPgGamePvP.Size = new System.Drawing.Size(984, 741);
        	this.tbPgGamePvP.TabIndex = 2;
        	this.tbPgGamePvP.Text = "PvP-Data";
        	// 
        	// btnStartPvPGamePvPData
        	// 
        	this.btnStartPvPGamePvPData.Location = new System.Drawing.Point(342, 225);
        	this.btnStartPvPGamePvPData.Name = "btnStartPvPGamePvPData";
        	this.btnStartPvPGamePvPData.Size = new System.Drawing.Size(300, 50);
        	this.btnStartPvPGamePvPData.TabIndex = 4;
        	this.btnStartPvPGamePvPData.Text = "Start";
        	this.btnStartPvPGamePvPData.UseVisualStyleBackColor = true;
        	this.btnStartPvPGamePvPData.Click += new System.EventHandler(this.btnStartPvPGamePvPData_Click);
        	// 
        	// txtPlayerName2PvPData
        	// 
        	this.txtPlayerName2PvPData.Location = new System.Drawing.Point(450, 176);
        	this.txtPlayerName2PvPData.Name = "txtPlayerName2PvPData";
        	this.txtPlayerName2PvPData.Size = new System.Drawing.Size(153, 20);
        	this.txtPlayerName2PvPData.TabIndex = 3;
        	// 
        	// lblPlayer2NamePvPDataDesc
        	// 
        	this.lblPlayer2NamePvPDataDesc.AutoSize = true;
        	this.lblPlayer2NamePvPDataDesc.Location = new System.Drawing.Point(393, 179);
        	this.lblPlayer2NamePvPDataDesc.Name = "lblPlayer2NamePvPDataDesc";
        	this.lblPlayer2NamePvPDataDesc.Size = new System.Drawing.Size(51, 13);
        	this.lblPlayer2NamePvPDataDesc.TabIndex = 2;
        	this.lblPlayer2NamePvPDataDesc.Text = "Spieler 2:";
        	// 
        	// txtPlayerName1PvPData
        	// 
        	this.txtPlayerName1PvPData.Location = new System.Drawing.Point(450, 150);
        	this.txtPlayerName1PvPData.Name = "txtPlayerName1PvPData";
        	this.txtPlayerName1PvPData.Size = new System.Drawing.Size(153, 20);
        	this.txtPlayerName1PvPData.TabIndex = 1;
        	// 
        	// lblPlayer1NamePvPDataDesc
        	// 
        	this.lblPlayer1NamePvPDataDesc.AutoSize = true;
        	this.lblPlayer1NamePvPDataDesc.Location = new System.Drawing.Point(393, 153);
        	this.lblPlayer1NamePvPDataDesc.Name = "lblPlayer1NamePvPDataDesc";
        	this.lblPlayer1NamePvPDataDesc.Size = new System.Drawing.Size(51, 13);
        	this.lblPlayer1NamePvPDataDesc.TabIndex = 0;
        	this.lblPlayer1NamePvPDataDesc.Text = "Spieler 1:";
        	// 
        	// tbPgPvP
        	// 
        	this.tbPgPvP.Controls.Add(this.lblStickCountPvPDesc);
        	this.tbPgPvP.Controls.Add(this.panPvPP2);
        	this.tbPgPvP.Controls.Add(this.panPvPP1);
        	this.tbPgPvP.Controls.Add(this.btnNim3PvP);
        	this.tbPgPvP.Controls.Add(this.btnNim2PvP);
        	this.tbPgPvP.Controls.Add(this.btnNim1PvP);
        	this.tbPgPvP.Controls.Add(this.lblStickCountPvP);
        	this.tbPgPvP.Location = new System.Drawing.Point(4, 22);
        	this.tbPgPvP.Name = "tbPgPvP";
        	this.tbPgPvP.Padding = new System.Windows.Forms.Padding(3);
        	this.tbPgPvP.Size = new System.Drawing.Size(984, 741);
        	this.tbPgPvP.TabIndex = 3;
        	this.tbPgPvP.Text = "PvP";
        	this.tbPgPvP.UseVisualStyleBackColor = true;
        	// 
        	// lblStickCountPvPDesc
        	// 
        	this.lblStickCountPvPDesc.AutoSize = true;
        	this.lblStickCountPvPDesc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblStickCountPvPDesc.Location = new System.Drawing.Point(443, 124);
        	this.lblStickCountPvPDesc.Name = "lblStickCountPvPDesc";
        	this.lblStickCountPvPDesc.Size = new System.Drawing.Size(112, 22);
        	this.lblStickCountPvPDesc.TabIndex = 13;
        	this.lblStickCountPvPDesc.Text = "Anzahl Sticks";
        	// 
        	// panPvPP2
        	// 
        	this.panPvPP2.Controls.Add(this.lblDrawnSticksP2PvPDesc);
        	this.panPvPP2.Controls.Add(this.lblDrawnSticksP2PvP);
        	this.panPvPP2.Controls.Add(this.lblP2NamePvP);
        	this.panPvPP2.Location = new System.Drawing.Point(739, 3);
        	this.panPvPP2.Name = "panPvPP2";
        	this.panPvPP2.Size = new System.Drawing.Size(242, 706);
        	this.panPvPP2.TabIndex = 9;
        	// 
        	// lblDrawnSticksP2PvPDesc
        	// 
        	this.lblDrawnSticksP2PvPDesc.AutoSize = true;
        	this.lblDrawnSticksP2PvPDesc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblDrawnSticksP2PvPDesc.Location = new System.Drawing.Point(5, 204);
        	this.lblDrawnSticksP2PvPDesc.Name = "lblDrawnSticksP2PvPDesc";
        	this.lblDrawnSticksP2PvPDesc.Size = new System.Drawing.Size(132, 22);
        	this.lblDrawnSticksP2PvPDesc.TabIndex = 12;
        	this.lblDrawnSticksP2PvPDesc.Text = "gezogene Sticks:";
        	// 
        	// lblDrawnSticksP2PvP
        	// 
        	this.lblDrawnSticksP2PvP.AutoSize = true;
        	this.lblDrawnSticksP2PvP.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblDrawnSticksP2PvP.Location = new System.Drawing.Point(3, 211);
        	this.lblDrawnSticksP2PvP.Name = "lblDrawnSticksP2PvP";
        	this.lblDrawnSticksP2PvP.Size = new System.Drawing.Size(74, 65);
        	this.lblDrawnSticksP2PvP.TabIndex = 11;
        	this.lblDrawnSticksP2PvP.Text = "##";
        	// 
        	// lblP2NamePvP
        	// 
        	this.lblP2NamePvP.AutoSize = true;
        	this.lblP2NamePvP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblP2NamePvP.Location = new System.Drawing.Point(5, 28);
        	this.lblP2NamePvP.Name = "lblP2NamePvP";
        	this.lblP2NamePvP.Size = new System.Drawing.Size(71, 22);
        	this.lblP2NamePvP.TabIndex = 1;
        	this.lblP2NamePvP.Text = "Spieler2";
        	// 
        	// panPvPP1
        	// 
        	this.panPvPP1.Controls.Add(this.lblDrawnSticksP1PvPDesc);
        	this.panPvPP1.Controls.Add(this.lblDrawnSticksP1PvP);
        	this.panPvPP1.Controls.Add(this.lblP1NamePvP);
        	this.panPvPP1.Location = new System.Drawing.Point(3, 3);
        	this.panPvPP1.Name = "panPvPP1";
        	this.panPvPP1.Size = new System.Drawing.Size(242, 706);
        	this.panPvPP1.TabIndex = 8;
        	// 
        	// lblDrawnSticksP1PvPDesc
        	// 
        	this.lblDrawnSticksP1PvPDesc.AutoSize = true;
        	this.lblDrawnSticksP1PvPDesc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblDrawnSticksP1PvPDesc.Location = new System.Drawing.Point(5, 204);
        	this.lblDrawnSticksP1PvPDesc.Name = "lblDrawnSticksP1PvPDesc";
        	this.lblDrawnSticksP1PvPDesc.Size = new System.Drawing.Size(132, 22);
        	this.lblDrawnSticksP1PvPDesc.TabIndex = 11;
        	this.lblDrawnSticksP1PvPDesc.Text = "gezogene Sticks:";
        	// 
        	// lblDrawnSticksP1PvP
        	// 
        	this.lblDrawnSticksP1PvP.AutoSize = true;
        	this.lblDrawnSticksP1PvP.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblDrawnSticksP1PvP.Location = new System.Drawing.Point(9, 211);
        	this.lblDrawnSticksP1PvP.Name = "lblDrawnSticksP1PvP";
        	this.lblDrawnSticksP1PvP.Size = new System.Drawing.Size(74, 65);
        	this.lblDrawnSticksP1PvP.TabIndex = 10;
        	this.lblDrawnSticksP1PvP.Text = "##";
        	// 
        	// lblP1NamePvP
        	// 
        	this.lblP1NamePvP.AutoSize = true;
        	this.lblP1NamePvP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblP1NamePvP.Location = new System.Drawing.Point(5, 28);
        	this.lblP1NamePvP.Name = "lblP1NamePvP";
        	this.lblP1NamePvP.Size = new System.Drawing.Size(71, 22);
        	this.lblP1NamePvP.TabIndex = 0;
        	this.lblP1NamePvP.Text = "Spieler1";
        	// 
        	// btnNim3PvP
        	// 
        	this.btnNim3PvP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnNim3PvP.Location = new System.Drawing.Point(392, 407);
        	this.btnNim3PvP.Name = "btnNim3PvP";
        	this.btnNim3PvP.Size = new System.Drawing.Size(200, 50);
        	this.btnNim3PvP.TabIndex = 7;
        	this.btnNim3PvP.Text = "Nim drei!";
        	this.btnNim3PvP.UseVisualStyleBackColor = true;
        	this.btnNim3PvP.Click += new System.EventHandler(this.butNimThreePvP_Click);
        	// 
        	// btnNim2PvP
        	// 
        	this.btnNim2PvP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnNim2PvP.Location = new System.Drawing.Point(392, 351);
        	this.btnNim2PvP.Name = "btnNim2PvP";
        	this.btnNim2PvP.Size = new System.Drawing.Size(200, 50);
        	this.btnNim2PvP.TabIndex = 6;
        	this.btnNim2PvP.Text = "Nim zwei!";
        	this.btnNim2PvP.UseVisualStyleBackColor = true;
        	this.btnNim2PvP.Click += new System.EventHandler(this.butNimTwoPvP_Click);
        	// 
        	// btnNim1PvP
        	// 
        	this.btnNim1PvP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnNim1PvP.Location = new System.Drawing.Point(392, 295);
        	this.btnNim1PvP.Name = "btnNim1PvP";
        	this.btnNim1PvP.Size = new System.Drawing.Size(200, 50);
        	this.btnNim1PvP.TabIndex = 5;
        	this.btnNim1PvP.Text = "Nim eins!";
        	this.btnNim1PvP.UseVisualStyleBackColor = true;
        	this.btnNim1PvP.Click += new System.EventHandler(this.butNimOnePvP_Click);
        	// 
        	// lblStickCountPvP
        	// 
        	this.lblStickCountPvP.AutoSize = true;
        	this.lblStickCountPvP.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblStickCountPvP.Location = new System.Drawing.Point(417, 136);
        	this.lblStickCountPvP.Name = "lblStickCountPvP";
        	this.lblStickCountPvP.Size = new System.Drawing.Size(153, 108);
        	this.lblStickCountPvP.TabIndex = 2;
        	this.lblStickCountPvP.Text = "##";
        	// 
        	// tbPgDataPvC
        	// 
        	this.tbPgDataPvC.Controls.Add(this.cmbBxAIPvCData);
        	this.tbPgDataPvC.Controls.Add(this.btnStartPvCGamePvCData);
        	this.tbPgDataPvC.Controls.Add(this.lblPlayer2NamePvCDataDesc);
        	this.tbPgDataPvC.Controls.Add(this.txtPlayer1NamePvCData);
        	this.tbPgDataPvC.Controls.Add(this.lblPlayer1NamePvCDataDesc);
        	this.tbPgDataPvC.Location = new System.Drawing.Point(4, 22);
        	this.tbPgDataPvC.Name = "tbPgDataPvC";
        	this.tbPgDataPvC.Padding = new System.Windows.Forms.Padding(3);
        	this.tbPgDataPvC.Size = new System.Drawing.Size(984, 741);
        	this.tbPgDataPvC.TabIndex = 4;
        	this.tbPgDataPvC.Text = "PvC-Data";
        	this.tbPgDataPvC.UseVisualStyleBackColor = true;
        	// 
        	// cmbBxAIPvCData
        	// 
        	this.cmbBxAIPvCData.FormattingEnabled = true;
        	this.cmbBxAIPvCData.Location = new System.Drawing.Point(450, 334);
        	this.cmbBxAIPvCData.Name = "cmbBxAIPvCData";
        	this.cmbBxAIPvCData.Size = new System.Drawing.Size(153, 21);
        	this.cmbBxAIPvCData.TabIndex = 10;
        	// 
        	// btnStartPvCGamePvCData
        	// 
        	this.btnStartPvCGamePvCData.Location = new System.Drawing.Point(342, 383);
        	this.btnStartPvCGamePvCData.Name = "btnStartPvCGamePvCData";
        	this.btnStartPvCGamePvCData.Size = new System.Drawing.Size(300, 50);
        	this.btnStartPvCGamePvCData.TabIndex = 9;
        	this.btnStartPvCGamePvCData.Text = "Start";
        	this.btnStartPvCGamePvCData.UseVisualStyleBackColor = true;
        	this.btnStartPvCGamePvCData.Click += new System.EventHandler(this.btnStartPvCGamePvCData_Click);
        	// 
        	// lblPlayer2NamePvCDataDesc
        	// 
        	this.lblPlayer2NamePvCDataDesc.AutoSize = true;
        	this.lblPlayer2NamePvCDataDesc.Location = new System.Drawing.Point(393, 337);
        	this.lblPlayer2NamePvCDataDesc.Name = "lblPlayer2NamePvCDataDesc";
        	this.lblPlayer2NamePvCDataDesc.Size = new System.Drawing.Size(51, 13);
        	this.lblPlayer2NamePvCDataDesc.TabIndex = 7;
        	this.lblPlayer2NamePvCDataDesc.Text = "Spieler 2:";
        	// 
        	// txtPlayer1NamePvCData
        	// 
        	this.txtPlayer1NamePvCData.Location = new System.Drawing.Point(450, 308);
        	this.txtPlayer1NamePvCData.Name = "txtPlayer1NamePvCData";
        	this.txtPlayer1NamePvCData.Size = new System.Drawing.Size(153, 20);
        	this.txtPlayer1NamePvCData.TabIndex = 6;
        	// 
        	// lblPlayer1NamePvCDataDesc
        	// 
        	this.lblPlayer1NamePvCDataDesc.AutoSize = true;
        	this.lblPlayer1NamePvCDataDesc.Location = new System.Drawing.Point(393, 311);
        	this.lblPlayer1NamePvCDataDesc.Name = "lblPlayer1NamePvCDataDesc";
        	this.lblPlayer1NamePvCDataDesc.Size = new System.Drawing.Size(51, 13);
        	this.lblPlayer1NamePvCDataDesc.TabIndex = 5;
        	this.lblPlayer1NamePvCDataDesc.Text = "Spieler 1:";
        	// 
        	// tabPgGamePvC
        	// 
        	this.tabPgGamePvC.Location = new System.Drawing.Point(4, 22);
        	this.tabPgGamePvC.Name = "tabPgGamePvC";
        	this.tabPgGamePvC.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPgGamePvC.Size = new System.Drawing.Size(984, 741);
        	this.tabPgGamePvC.TabIndex = 5;
        	this.tabPgGamePvC.Text = "PvC";
        	this.tabPgGamePvC.UseVisualStyleBackColor = true;
        	// 
        	// tabPgDataNetwork
        	// 
        	this.tabPgDataNetwork.Location = new System.Drawing.Point(4, 22);
        	this.tabPgDataNetwork.Name = "tabPgDataNetwork";
        	this.tabPgDataNetwork.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPgDataNetwork.Size = new System.Drawing.Size(984, 741);
        	this.tabPgDataNetwork.TabIndex = 6;
        	this.tabPgDataNetwork.Text = "Net-Data";
        	this.tabPgDataNetwork.UseVisualStyleBackColor = true;
        	// 
        	// tabPgNetwork
        	// 
        	this.tabPgNetwork.Location = new System.Drawing.Point(4, 22);
        	this.tabPgNetwork.Name = "tabPgNetwork";
        	this.tabPgNetwork.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPgNetwork.Size = new System.Drawing.Size(984, 741);
        	this.tabPgNetwork.TabIndex = 7;
        	this.tabPgNetwork.Text = "Network";
        	this.tabPgNetwork.UseVisualStyleBackColor = true;
        	// 
        	// tabPgSettings
        	// 
        	this.tabPgSettings.Controls.Add(this.lblStickCountSettingsDesc);
        	this.tabPgSettings.Controls.Add(this.numUDStickCountSettings);
        	this.tabPgSettings.Location = new System.Drawing.Point(4, 22);
        	this.tabPgSettings.Name = "tabPgSettings";
        	this.tabPgSettings.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPgSettings.Size = new System.Drawing.Size(984, 741);
        	this.tabPgSettings.TabIndex = 8;
        	this.tabPgSettings.Text = "Settings";
        	this.tabPgSettings.UseVisualStyleBackColor = true;
        	// 
        	// lblStickCountSettingsDesc
        	// 
        	this.lblStickCountSettingsDesc.Location = new System.Drawing.Point(35, 19);
        	this.lblStickCountSettingsDesc.Name = "lblStickCountSettingsDesc";
        	this.lblStickCountSettingsDesc.Size = new System.Drawing.Size(100, 23);
        	this.lblStickCountSettingsDesc.TabIndex = 1;
        	this.lblStickCountSettingsDesc.Text = "Hölzchenanzahl";
        	// 
        	// numUDStickCountSettings
        	// 
        	this.numUDStickCountSettings.Location = new System.Drawing.Point(141, 17);
        	this.numUDStickCountSettings.Maximum = new decimal(new int[] {
        	        	        	200,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numUDStickCountSettings.Minimum = new decimal(new int[] {
        	        	        	5,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numUDStickCountSettings.Name = "numUDStickCountSettings";
        	this.numUDStickCountSettings.Size = new System.Drawing.Size(120, 20);
        	this.numUDStickCountSettings.TabIndex = 0;
        	this.numUDStickCountSettings.Value = new decimal(new int[] {
        	        	        	13,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	// 
        	// tbPgGameOver
        	// 
        	this.tbPgGameOver.Controls.Add(this.lblWinner);
        	this.tbPgGameOver.Controls.Add(this.btnBackToMainGameOver);
        	this.tbPgGameOver.Location = new System.Drawing.Point(4, 22);
        	this.tbPgGameOver.Name = "tbPgGameOver";
        	this.tbPgGameOver.Padding = new System.Windows.Forms.Padding(3);
        	this.tbPgGameOver.Size = new System.Drawing.Size(984, 741);
        	this.tbPgGameOver.TabIndex = 9;
        	this.tbPgGameOver.Text = "Game Over";
        	this.tbPgGameOver.UseVisualStyleBackColor = true;
        	// 
        	// btnBackToMainGameOver
        	// 
        	this.btnBackToMainGameOver.Location = new System.Drawing.Point(6, 117);
        	this.btnBackToMainGameOver.Name = "btnBackToMainGameOver";
        	this.btnBackToMainGameOver.Size = new System.Drawing.Size(75, 23);
        	this.btnBackToMainGameOver.TabIndex = 0;
        	this.btnBackToMainGameOver.Text = "Hauptmenü";
        	this.btnBackToMainGameOver.UseVisualStyleBackColor = true;
        	this.btnBackToMainGameOver.Click += new System.EventHandler(this.BtnBackToMainGameOverClick);
        	// 
        	// lblWinner
        	// 
        	this.lblWinner.Location = new System.Drawing.Point(12, 14);
        	this.lblWinner.Name = "lblWinner";
        	this.lblWinner.Size = new System.Drawing.Size(100, 23);
        	this.lblWinner.TabIndex = 1;
        	this.lblWinner.Text = "Gewinner:";
        	// 
        	// frmNimGame
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(984, 742);
        	this.Controls.Add(this.tabMain);
        	this.Name = "frmNimGame";
        	this.Text = "nimGame";
        	this.tabMain.ResumeLayout(false);
        	this.tbPgMain.ResumeLayout(false);
        	this.tbPgGameMode.ResumeLayout(false);
        	this.tbPgGamePvP.ResumeLayout(false);
        	this.tbPgGamePvP.PerformLayout();
        	this.tbPgPvP.ResumeLayout(false);
        	this.tbPgPvP.PerformLayout();
        	this.panPvPP2.ResumeLayout(false);
        	this.panPvPP2.PerformLayout();
        	this.panPvPP1.ResumeLayout(false);
        	this.panPvPP1.PerformLayout();
        	this.tbPgDataPvC.ResumeLayout(false);
        	this.tbPgDataPvC.PerformLayout();
        	this.tabPgSettings.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.numUDStickCountSettings)).EndInit();
        	this.tbPgGameOver.ResumeLayout(false);
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnBackToMainGameOver;
        private System.Windows.Forms.TabPage tbPgGameOver;
        private System.Windows.Forms.ComboBox cmbBxAIPvCData;
        private System.Windows.Forms.NumericUpDown numUDStickCountSettings;
        private System.Windows.Forms.Label lblStickCountSettingsDesc;
        private System.Windows.Forms.TabPage tabPgSettings;

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbPgMain;
        private System.Windows.Forms.TabPage tbPgGameMode;
        private System.Windows.Forms.Button btnStartGameMain;
        private System.Windows.Forms.Button btnHighscoreMain;
        private System.Windows.Forms.Button btnSettingsMain;
        private System.Windows.Forms.Button btnStartNetMode;
        private System.Windows.Forms.Button btnStartPvCMode;
        private System.Windows.Forms.Button btnStartPvPMode;
        private System.Windows.Forms.TabPage tbPgGamePvP;
        private System.Windows.Forms.TabPage tbPgPvP;
        private System.Windows.Forms.Button btnStartPvPGamePvPData;
        private System.Windows.Forms.TextBox txtPlayerName2PvPData;
        private System.Windows.Forms.Label lblPlayer2NamePvPDataDesc;
        private System.Windows.Forms.TextBox txtPlayerName1PvPData;
        private System.Windows.Forms.Label lblPlayer1NamePvPDataDesc;
        private System.Windows.Forms.Label lblP2NamePvP;
        private System.Windows.Forms.Label lblP1NamePvP;
        private System.Windows.Forms.Label lblStickCountPvP;
        private System.Windows.Forms.Button btnNim3PvP;
        private System.Windows.Forms.Button btnNim2PvP;
        private System.Windows.Forms.Button btnNim1PvP;
        private System.Windows.Forms.TabPage tbPgDataPvC;
        private System.Windows.Forms.Button btnStartPvCGamePvCData;
        private System.Windows.Forms.Label lblPlayer2NamePvCDataDesc;
        private System.Windows.Forms.TextBox txtPlayer1NamePvCData;
        private System.Windows.Forms.Label lblPlayer1NamePvCDataDesc;
        private System.Windows.Forms.TabPage tabPgGamePvC;
        private System.Windows.Forms.TabPage tabPgDataNetwork;
        private System.Windows.Forms.TabPage tabPgNetwork;
        private System.Windows.Forms.Panel panPvPP1;
        private System.Windows.Forms.Panel panPvPP2;
        private System.Windows.Forms.Label lblDrawnSticksP2PvP;
        private System.Windows.Forms.Label lblDrawnSticksP1PvP;
        private System.Windows.Forms.Label lblDrawnSticksP2PvPDesc;
        private System.Windows.Forms.Label lblDrawnSticksP1PvPDesc;
        private System.Windows.Forms.Label lblStickCountPvPDesc;
        
    }
}

