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
            this.butHighscore = new System.Windows.Forms.Button();
            this.butSettings = new System.Windows.Forms.Button();
            this.butStartGame = new System.Windows.Forms.Button();
            this.tbPgGameMode = new System.Windows.Forms.TabPage();
            this.butStartNetwork = new System.Windows.Forms.Button();
            this.butStartComputer = new System.Windows.Forms.Button();
            this.butStartHotSeat = new System.Windows.Forms.Button();
            this.tbPgGamePvP = new System.Windows.Forms.TabPage();
            this.butStartGame1 = new System.Windows.Forms.Button();
            this.txtPlayerName2 = new System.Windows.Forms.TextBox();
            this.labPlayerName2 = new System.Windows.Forms.Label();
            this.txtPlayerName1 = new System.Windows.Forms.TextBox();
            this.labPlayerName1 = new System.Windows.Forms.Label();
            this.tbPgHotSeat = new System.Windows.Forms.TabPage();
            this.butNimThree = new System.Windows.Forms.Button();
            this.butNimTwo = new System.Windows.Forms.Button();
            this.butNimOne = new System.Windows.Forms.Button();
            this.labSticks = new System.Windows.Forms.Label();
            this.labPvPP2Name = new System.Windows.Forms.Label();
            this.labPvPP1Name = new System.Windows.Forms.Label();
            this.tabPgDataPvC = new System.Windows.Forms.TabPage();
            this.butStartPvc = new System.Windows.Forms.Button();
            this.txtPvcComputer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPvcName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPgGamePvC = new System.Windows.Forms.TabPage();
            this.butPvcNimThree = new System.Windows.Forms.Button();
            this.butPvcNimTwo = new System.Windows.Forms.Button();
            this.butPvcNimOne = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labPvcComputer = new System.Windows.Forms.Label();
            this.labPvcName = new System.Windows.Forms.Label();
            this.tabPgDataNetwork = new System.Windows.Forms.TabPage();
            this.tabPgNetwork = new System.Windows.Forms.TabPage();
            this.tabPgSettings = new System.Windows.Forms.TabPage();
            this.labStickCountSetting = new System.Windows.Forms.Label();
            this.numUDStickCount = new System.Windows.Forms.NumericUpDown();
            this.panPvPP1 = new System.Windows.Forms.Panel();
            this.panPvPP2 = new System.Windows.Forms.Panel();
            this.labPvPP1TakenSticks = new System.Windows.Forms.Label();
            this.labPvPP2TakenSticks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tbPgStart.SuspendLayout();
            this.tbPgGameMode.SuspendLayout();
            this.tbPgGamePvP.SuspendLayout();
            this.tbPgHotSeat.SuspendLayout();
            this.tabPgDataPvC.SuspendLayout();
            this.tabPgGamePvC.SuspendLayout();
            this.tabPgSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDStickCount)).BeginInit();
            this.panPvPP1.SuspendLayout();
            this.panPvPP2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbPgStart);
            this.tabMain.Controls.Add(this.tbPgGameMode);
            this.tabMain.Controls.Add(this.tbPgGamePvP);
            this.tabMain.Controls.Add(this.tbPgHotSeat);
            this.tabMain.Controls.Add(this.tabPgDataPvC);
            this.tabMain.Controls.Add(this.tabPgGamePvC);
            this.tabMain.Controls.Add(this.tabPgDataNetwork);
            this.tabMain.Controls.Add(this.tabPgNetwork);
            this.tabMain.Controls.Add(this.tabPgSettings);
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
            // butStartNetwork
            // 
            this.butStartNetwork.Location = new System.Drawing.Point(342, 293);
            this.butStartNetwork.Name = "butStartNetwork";
            this.butStartNetwork.Size = new System.Drawing.Size(300, 50);
            this.butStartNetwork.TabIndex = 3;
            this.butStartNetwork.Text = "Netzwerkspiel";
            this.butStartNetwork.UseVisualStyleBackColor = true;
            this.butStartNetwork.Click += new System.EventHandler(this.butStartNetwork_Click);
            // 
            // butStartComputer
            // 
            this.butStartComputer.Location = new System.Drawing.Point(342, 237);
            this.butStartComputer.Name = "butStartComputer";
            this.butStartComputer.Size = new System.Drawing.Size(300, 50);
            this.butStartComputer.TabIndex = 2;
            this.butStartComputer.Text = "Spieler vs. Computer";
            this.butStartComputer.UseVisualStyleBackColor = true;
            this.butStartComputer.Click += new System.EventHandler(this.butStartComputer_Click);
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
            // tbPgGamePvP
            // 
            this.tbPgGamePvP.BackColor = System.Drawing.Color.White;
            this.tbPgGamePvP.Controls.Add(this.butStartGame1);
            this.tbPgGamePvP.Controls.Add(this.txtPlayerName2);
            this.tbPgGamePvP.Controls.Add(this.labPlayerName2);
            this.tbPgGamePvP.Controls.Add(this.txtPlayerName1);
            this.tbPgGamePvP.Controls.Add(this.labPlayerName1);
            this.tbPgGamePvP.Location = new System.Drawing.Point(4, 22);
            this.tbPgGamePvP.Name = "tbPgGamePvP";
            this.tbPgGamePvP.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgGamePvP.Size = new System.Drawing.Size(984, 741);
            this.tbPgGamePvP.TabIndex = 2;
            this.tbPgGamePvP.Text = "PvP-Data";
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
            // txtPlayerName2
            // 
            this.txtPlayerName2.Location = new System.Drawing.Point(450, 176);
            this.txtPlayerName2.Name = "txtPlayerName2";
            this.txtPlayerName2.Size = new System.Drawing.Size(153, 20);
            this.txtPlayerName2.TabIndex = 3;
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
            // txtPlayerName1
            // 
            this.txtPlayerName1.Location = new System.Drawing.Point(450, 150);
            this.txtPlayerName1.Name = "txtPlayerName1";
            this.txtPlayerName1.Size = new System.Drawing.Size(153, 20);
            this.txtPlayerName1.TabIndex = 1;
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
            // tbPgHotSeat
            // 
            this.tbPgHotSeat.Controls.Add(this.label6);
            this.tbPgHotSeat.Controls.Add(this.panPvPP2);
            this.tbPgHotSeat.Controls.Add(this.panPvPP1);
            this.tbPgHotSeat.Controls.Add(this.butNimThree);
            this.tbPgHotSeat.Controls.Add(this.butNimTwo);
            this.tbPgHotSeat.Controls.Add(this.butNimOne);
            this.tbPgHotSeat.Controls.Add(this.labSticks);
            this.tbPgHotSeat.Location = new System.Drawing.Point(4, 22);
            this.tbPgHotSeat.Name = "tbPgHotSeat";
            this.tbPgHotSeat.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgHotSeat.Size = new System.Drawing.Size(984, 741);
            this.tbPgHotSeat.TabIndex = 3;
            this.tbPgHotSeat.Text = "HotSeat";
            this.tbPgHotSeat.UseVisualStyleBackColor = true;
            // 
            // butNimThree
            // 
            this.butNimThree.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNimThree.Location = new System.Drawing.Point(392, 407);
            this.butNimThree.Name = "butNimThree";
            this.butNimThree.Size = new System.Drawing.Size(200, 50);
            this.butNimThree.TabIndex = 7;
            this.butNimThree.Text = "Nim drei!";
            this.butNimThree.UseVisualStyleBackColor = true;
            this.butNimThree.Click += new System.EventHandler(this.ButNimThreeClick);
            // 
            // butNimTwo
            // 
            this.butNimTwo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNimTwo.Location = new System.Drawing.Point(392, 351);
            this.butNimTwo.Name = "butNimTwo";
            this.butNimTwo.Size = new System.Drawing.Size(200, 50);
            this.butNimTwo.TabIndex = 6;
            this.butNimTwo.Text = "Nim zwei!";
            this.butNimTwo.UseVisualStyleBackColor = true;
            this.butNimTwo.Click += new System.EventHandler(this.ButNimTwoClick);
            // 
            // butNimOne
            // 
            this.butNimOne.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNimOne.Location = new System.Drawing.Point(392, 295);
            this.butNimOne.Name = "butNimOne";
            this.butNimOne.Size = new System.Drawing.Size(200, 50);
            this.butNimOne.TabIndex = 5;
            this.butNimOne.Text = "Nim eins!";
            this.butNimOne.UseVisualStyleBackColor = true;
            this.butNimOne.Click += new System.EventHandler(this.ButNimOneClick);
            // 
            // labSticks
            // 
            this.labSticks.AutoSize = true;
            this.labSticks.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSticks.Location = new System.Drawing.Point(417, 136);
            this.labSticks.Name = "labSticks";
            this.labSticks.Size = new System.Drawing.Size(153, 108);
            this.labSticks.TabIndex = 2;
            this.labSticks.Text = "##";
            // 
            // labPvPP2Name
            // 
            this.labPvPP2Name.AutoSize = true;
            this.labPvPP2Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPvPP2Name.Location = new System.Drawing.Point(5, 28);
            this.labPvPP2Name.Name = "labPvPP2Name";
            this.labPvPP2Name.Size = new System.Drawing.Size(71, 22);
            this.labPvPP2Name.TabIndex = 1;
            this.labPvPP2Name.Text = "Spieler2";
            // 
            // labPvPP1Name
            // 
            this.labPvPP1Name.AutoSize = true;
            this.labPvPP1Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPvPP1Name.Location = new System.Drawing.Point(5, 28);
            this.labPvPP1Name.Name = "labPvPP1Name";
            this.labPvPP1Name.Size = new System.Drawing.Size(71, 22);
            this.labPvPP1Name.TabIndex = 0;
            this.labPvPP1Name.Text = "Spieler1";
            // 
            // tabPgDataPvC
            // 
            this.tabPgDataPvC.Controls.Add(this.butStartPvc);
            this.tabPgDataPvC.Controls.Add(this.txtPvcComputer);
            this.tabPgDataPvC.Controls.Add(this.label1);
            this.tabPgDataPvC.Controls.Add(this.txtPvcName);
            this.tabPgDataPvC.Controls.Add(this.label2);
            this.tabPgDataPvC.Location = new System.Drawing.Point(4, 22);
            this.tabPgDataPvC.Name = "tabPgDataPvC";
            this.tabPgDataPvC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgDataPvC.Size = new System.Drawing.Size(984, 741);
            this.tabPgDataPvC.TabIndex = 4;
            this.tabPgDataPvC.Text = "PvC-Data";
            this.tabPgDataPvC.UseVisualStyleBackColor = true;
            // 
            // butStartPvc
            // 
            this.butStartPvc.Location = new System.Drawing.Point(342, 383);
            this.butStartPvc.Name = "butStartPvc";
            this.butStartPvc.Size = new System.Drawing.Size(300, 50);
            this.butStartPvc.TabIndex = 9;
            this.butStartPvc.Text = "Start";
            this.butStartPvc.UseVisualStyleBackColor = true;
            this.butStartPvc.Click += new System.EventHandler(this.butStartPvc_Click);
            // 
            // txtPvcComputer
            // 
            this.txtPvcComputer.Location = new System.Drawing.Point(450, 334);
            this.txtPvcComputer.Name = "txtPvcComputer";
            this.txtPvcComputer.ReadOnly = true;
            this.txtPvcComputer.Size = new System.Drawing.Size(153, 20);
            this.txtPvcComputer.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Spieler 2:";
            // 
            // txtPvcName
            // 
            this.txtPvcName.Location = new System.Drawing.Point(450, 308);
            this.txtPvcName.Name = "txtPvcName";
            this.txtPvcName.Size = new System.Drawing.Size(153, 20);
            this.txtPvcName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spieler 1:";
            // 
            // tabPgGamePvC
            // 
            this.tabPgGamePvC.Controls.Add(this.butPvcNimThree);
            this.tabPgGamePvC.Controls.Add(this.butPvcNimTwo);
            this.tabPgGamePvC.Controls.Add(this.butPvcNimOne);
            this.tabPgGamePvC.Controls.Add(this.label3);
            this.tabPgGamePvC.Controls.Add(this.labPvcComputer);
            this.tabPgGamePvC.Controls.Add(this.labPvcName);
            this.tabPgGamePvC.Location = new System.Drawing.Point(4, 22);
            this.tabPgGamePvC.Name = "tabPgGamePvC";
            this.tabPgGamePvC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgGamePvC.Size = new System.Drawing.Size(984, 741);
            this.tabPgGamePvC.TabIndex = 5;
            this.tabPgGamePvC.Text = "PvC";
            this.tabPgGamePvC.UseVisualStyleBackColor = true;
            // 
            // butPvcNimThree
            // 
            this.butPvcNimThree.Location = new System.Drawing.Point(414, 430);
            this.butPvcNimThree.Name = "butPvcNimThree";
            this.butPvcNimThree.Size = new System.Drawing.Size(200, 50);
            this.butPvcNimThree.TabIndex = 13;
            this.butPvcNimThree.Text = "Nim drei!";
            this.butPvcNimThree.UseVisualStyleBackColor = true;
            // 
            // butPvcNimTwo
            // 
            this.butPvcNimTwo.Location = new System.Drawing.Point(414, 374);
            this.butPvcNimTwo.Name = "butPvcNimTwo";
            this.butPvcNimTwo.Size = new System.Drawing.Size(200, 50);
            this.butPvcNimTwo.TabIndex = 12;
            this.butPvcNimTwo.Text = "Nim zwei!";
            this.butPvcNimTwo.UseVisualStyleBackColor = true;
            // 
            // butPvcNimOne
            // 
            this.butPvcNimOne.Location = new System.Drawing.Point(414, 318);
            this.butPvcNimOne.Name = "butPvcNimOne";
            this.butPvcNimOne.Size = new System.Drawing.Size(200, 50);
            this.butPvcNimOne.TabIndex = 11;
            this.butPvcNimOne.Text = "Nim eins!";
            this.butPvcNimOne.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 108);
            this.label3.TabIndex = 10;
            this.label3.Text = "##";
            // 
            // labPvcComputer
            // 
            this.labPvcComputer.AutoSize = true;
            this.labPvcComputer.Location = new System.Drawing.Point(852, 75);
            this.labPvcComputer.Name = "labPvcComputer";
            this.labPvcComputer.Size = new System.Drawing.Size(52, 13);
            this.labPvcComputer.TabIndex = 9;
            this.labPvcComputer.Text = "Computer";
            // 
            // labPvcName
            // 
            this.labPvcName.AutoSize = true;
            this.labPvcName.Location = new System.Drawing.Point(87, 64);
            this.labPvcName.Name = "labPvcName";
            this.labPvcName.Size = new System.Drawing.Size(45, 13);
            this.labPvcName.TabIndex = 8;
            this.labPvcName.Text = "Spieler1";
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
            this.tabPgSettings.Controls.Add(this.labStickCountSetting);
            this.tabPgSettings.Controls.Add(this.numUDStickCount);
            this.tabPgSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPgSettings.Name = "tabPgSettings";
            this.tabPgSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgSettings.Size = new System.Drawing.Size(984, 741);
            this.tabPgSettings.TabIndex = 8;
            this.tabPgSettings.Text = "Settings";
            this.tabPgSettings.UseVisualStyleBackColor = true;
            // 
            // labStickCountSetting
            // 
            this.labStickCountSetting.Location = new System.Drawing.Point(35, 19);
            this.labStickCountSetting.Name = "labStickCountSetting";
            this.labStickCountSetting.Size = new System.Drawing.Size(100, 23);
            this.labStickCountSetting.TabIndex = 1;
            this.labStickCountSetting.Text = "Hölzchenanzahl";
            // 
            // numUDStickCount
            // 
            this.numUDStickCount.Location = new System.Drawing.Point(141, 17);
            this.numUDStickCount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUDStickCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUDStickCount.Name = "numUDStickCount";
            this.numUDStickCount.Size = new System.Drawing.Size(120, 20);
            this.numUDStickCount.TabIndex = 0;
            this.numUDStickCount.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // panPvPP1
            // 
            this.panPvPP1.Controls.Add(this.label4);
            this.panPvPP1.Controls.Add(this.labPvPP1TakenSticks);
            this.panPvPP1.Controls.Add(this.labPvPP1Name);
            this.panPvPP1.Location = new System.Drawing.Point(3, 3);
            this.panPvPP1.Name = "panPvPP1";
            this.panPvPP1.Size = new System.Drawing.Size(242, 706);
            this.panPvPP1.TabIndex = 8;
            // 
            // panPvPP2
            // 
            this.panPvPP2.Controls.Add(this.label5);
            this.panPvPP2.Controls.Add(this.labPvPP2TakenSticks);
            this.panPvPP2.Controls.Add(this.labPvPP2Name);
            this.panPvPP2.Location = new System.Drawing.Point(739, 3);
            this.panPvPP2.Name = "panPvPP2";
            this.panPvPP2.Size = new System.Drawing.Size(242, 706);
            this.panPvPP2.TabIndex = 9;
            // 
            // labPvPP1TakenSticks
            // 
            this.labPvPP1TakenSticks.AutoSize = true;
            this.labPvPP1TakenSticks.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPvPP1TakenSticks.Location = new System.Drawing.Point(9, 211);
            this.labPvPP1TakenSticks.Name = "labPvPP1TakenSticks";
            this.labPvPP1TakenSticks.Size = new System.Drawing.Size(74, 65);
            this.labPvPP1TakenSticks.TabIndex = 10;
            this.labPvPP1TakenSticks.Text = "##";
            // 
            // labPvPP2TakenSticks
            // 
            this.labPvPP2TakenSticks.AutoSize = true;
            this.labPvPP2TakenSticks.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPvPP2TakenSticks.Location = new System.Drawing.Point(3, 211);
            this.labPvPP2TakenSticks.Name = "labPvPP2TakenSticks";
            this.labPvPP2TakenSticks.Size = new System.Drawing.Size(74, 65);
            this.labPvPP2TakenSticks.TabIndex = 11;
            this.labPvPP2TakenSticks.Text = "##";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "gezogene Sticks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "gezogene Sticks:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Anzahl Sticks";
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
            this.tbPgStart.ResumeLayout(false);
            this.tbPgGameMode.ResumeLayout(false);
            this.tbPgGamePvP.ResumeLayout(false);
            this.tbPgGamePvP.PerformLayout();
            this.tbPgHotSeat.ResumeLayout(false);
            this.tbPgHotSeat.PerformLayout();
            this.tabPgDataPvC.ResumeLayout(false);
            this.tabPgDataPvC.PerformLayout();
            this.tabPgGamePvC.ResumeLayout(false);
            this.tabPgGamePvC.PerformLayout();
            this.tabPgSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUDStickCount)).EndInit();
            this.panPvPP1.ResumeLayout(false);
            this.panPvPP1.PerformLayout();
            this.panPvPP2.ResumeLayout(false);
            this.panPvPP2.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.NumericUpDown numUDStickCount;
        private System.Windows.Forms.Label labStickCountSetting;
        private System.Windows.Forms.TabPage tabPgSettings;

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
        private System.Windows.Forms.TabPage tbPgGamePvP;
        private System.Windows.Forms.TabPage tbPgHotSeat;
        private System.Windows.Forms.Button butStartGame1;
        private System.Windows.Forms.TextBox txtPlayerName2;
        private System.Windows.Forms.Label labPlayerName2;
        private System.Windows.Forms.TextBox txtPlayerName1;
        private System.Windows.Forms.Label labPlayerName1;
        private System.Windows.Forms.Label labPvPP2Name;
        private System.Windows.Forms.Label labPvPP1Name;
        private System.Windows.Forms.Label labSticks;
        private System.Windows.Forms.Button butNimThree;
        private System.Windows.Forms.Button butNimTwo;
        private System.Windows.Forms.Button butNimOne;
        private System.Windows.Forms.TabPage tabPgDataPvC;
        private System.Windows.Forms.Button butStartPvc;
        private System.Windows.Forms.TextBox txtPvcComputer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPvcName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPgGamePvC;
        private System.Windows.Forms.Button butPvcNimThree;
        private System.Windows.Forms.Button butPvcNimTwo;
        private System.Windows.Forms.Button butPvcNimOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labPvcComputer;
        private System.Windows.Forms.Label labPvcName;
        private System.Windows.Forms.TabPage tabPgDataNetwork;
        private System.Windows.Forms.TabPage tabPgNetwork;
        private System.Windows.Forms.Panel panPvPP1;
        private System.Windows.Forms.Panel panPvPP2;
        private System.Windows.Forms.Label labPvPP2TakenSticks;
        private System.Windows.Forms.Label labPvPP1TakenSticks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

