
namespace InsSS_Server_Manager
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_GLST = new System.Windows.Forms.TextBox();
            this.textBox_GameStats = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textField_server = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button_mods = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverBrowseDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonStartServer = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox_scenario = new System.Windows.Forms.ListBox();
            this.listBox_map = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox_randomMap = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_aiDifficulty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_maxBots = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_minBots = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_serverName = new System.Windows.Forms.TextBox();
            this.textBox_maxPlayers = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.checkBox_changeRandom = new System.Windows.Forms.CheckBox();
            this.listBox_changeScenario = new System.Windows.Forms.ListBox();
            this.listBox_changeMap = new System.Windows.Forms.ListBox();
            this.button_config = new System.Windows.Forms.Button();
            this.button_ini = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnClick_About);
            // 
            // textBox_GLST
            // 
            this.textBox_GLST.Location = new System.Drawing.Point(395, 19);
            this.textBox_GLST.Name = "textBox_GLST";
            this.textBox_GLST.Size = new System.Drawing.Size(220, 20);
            this.textBox_GLST.TabIndex = 3;
            this.textBox_GLST.Text = "GLST Token";
            // 
            // textBox_GameStats
            // 
            this.textBox_GameStats.Location = new System.Drawing.Point(395, 45);
            this.textBox_GameStats.Name = "textBox_GameStats";
            this.textBox_GameStats.Size = new System.Drawing.Size(220, 20);
            this.textBox_GameStats.TabIndex = 4;
            this.textBox_GameStats.Text = "GameStats Token";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(395, 71);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(220, 20);
            this.textBox_Password.TabIndex = 5;
            this.textBox_Password.Text = "Password";
            // 
            // textField_server
            // 
            this.textField_server.Location = new System.Drawing.Point(6, 24);
            this.textField_server.Name = "textField_server";
            this.textField_server.ReadOnly = true;
            this.textField_server.Size = new System.Drawing.Size(535, 20);
            this.textField_server.TabIndex = 16;
            this.textField_server.Text = "Navigate to InsurgencyServer.exe (Typically steamapps\\common\\sandstorm_server) ";
            this.textField_server.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClick_ServerBrowse);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button_mods);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.textBox_GLST);
            this.groupBox1.Controls.Add(this.textBox_GameStats);
            this.groupBox1.Location = new System.Drawing.Point(6, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 102);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Settings";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 27;
            this.button4.Text = "Mutators";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnClick_Mutators);
            // 
            // button_mods
            // 
            this.button_mods.Enabled = false;
            this.button_mods.Location = new System.Drawing.Point(6, 59);
            this.button_mods.Name = "button_mods";
            this.button_mods.Size = new System.Drawing.Size(100, 30);
            this.button_mods.TabIndex = 25;
            this.button_mods.Text = "Manage Mods";
            this.button_mods.UseVisualStyleBackColor = true;
            this.button_mods.Click += new System.EventHandler(this.OnClick_ManageMods);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(331, 22);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(58, 13);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Get Token";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnClick_GetGLST);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(331, 48);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 13);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get Token";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnClick_GetGameStats);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Server Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "GameStats Token (EXP)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "GLST Token (Server Browser visibility)";
            // 
            // serverBrowseDialog
            // 
            this.serverBrowseDialog.FileName = "InsurgencyServer.exe";
            this.serverBrowseDialog.Filter = "Server Executable|InsurgencyServer.exe";
            this.serverBrowseDialog.Title = "Navigate to InsurgencyServer.exe";
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.Enabled = false;
            this.buttonStartServer.Location = new System.Drawing.Point(615, 366);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(150, 50);
            this.buttonStartServer.TabIndex = 19;
            this.buttonStartServer.Text = "Start\r\nServer";
            this.buttonStartServer.UseVisualStyleBackColor = true;
            this.buttonStartServer.Click += new System.EventHandler(this.OnClick_StartServer);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Thread_StartServer);
            // 
            // listBox_scenario
            // 
            this.listBox_scenario.FormattingEnabled = true;
            this.listBox_scenario.Location = new System.Drawing.Point(6, 24);
            this.listBox_scenario.Name = "listBox_scenario";
            this.listBox_scenario.Size = new System.Drawing.Size(140, 186);
            this.listBox_scenario.TabIndex = 21;
            this.listBox_scenario.SelectedIndexChanged += new System.EventHandler(this.OnClick_ScenarioSelect);
            // 
            // listBox_map
            // 
            this.listBox_map.FormattingEnabled = true;
            this.listBox_map.Location = new System.Drawing.Point(152, 24);
            this.listBox_map.Name = "listBox_map";
            this.listBox_map.Size = new System.Drawing.Size(140, 186);
            this.listBox_map.TabIndex = 22;
            this.listBox_map.SelectedIndexChanged += new System.EventHandler(this.OnClick_MapSelect);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.checkBox_randomMap);
            this.groupBox5.Controls.Add(this.listBox_scenario);
            this.groupBox5.Controls.Add(this.listBox_map);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(298, 246);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Map Settings";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(76, 219);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.Text = "Night";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.OnClick_LightingChange);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 219);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.Text = "Day";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.OnClick_LightingChange);
            // 
            // checkBox_randomMap
            // 
            this.checkBox_randomMap.AutoSize = true;
            this.checkBox_randomMap.Location = new System.Drawing.Point(170, 219);
            this.checkBox_randomMap.Name = "checkBox_randomMap";
            this.checkBox_randomMap.Size = new System.Drawing.Size(103, 17);
            this.checkBox_randomMap.TabIndex = 23;
            this.checkBox_randomMap.Text = "Randomise Map";
            this.checkBox_randomMap.UseVisualStyleBackColor = true;
            this.checkBox_randomMap.CheckedChanged += new System.EventHandler(this.OnClick_RandomiseMap);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textField_server);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(6, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 50);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insurgency Sandstorm Server Directory";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 22);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(12, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 430);
            this.tabControl1.TabIndex = 32;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.On_TabChange);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.linkLabel3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label_version);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.buttonStartServer);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(29, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(771, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server Launcher";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(536, 180);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(217, 13);
            this.linkLabel3.TabIndex = 37;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Support the development of this app!";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnClick_Paypal);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "by Yang aka TechRodent";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_version.Location = new System.Drawing.Point(607, 76);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(59, 18);
            this.label_version.TabIndex = 34;
            this.label_version.Text = "v1.0.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 50);
            this.label1.TabIndex = 33;
            this.label1.Text = "Insurgency Sandstorm\r\nServer Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InsSS_Server_Manager.Properties.Resources.InsurgencyServer_101__2_1;
            this.pictureBox1.Location = new System.Drawing.Point(327, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 192);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(29, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(771, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Game Settings";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox_aiDifficulty);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.textBox_maxBots);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textBox_minBots);
            this.groupBox6.Location = new System.Drawing.Point(6, 112);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(422, 97);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Co-op Settings";
            // 
            // textBox_aiDifficulty
            // 
            this.textBox_aiDifficulty.Location = new System.Drawing.Point(86, 19);
            this.textBox_aiDifficulty.Name = "textBox_aiDifficulty";
            this.textBox_aiDifficulty.Size = new System.Drawing.Size(220, 20);
            this.textBox_aiDifficulty.TabIndex = 25;
            this.textBox_aiDifficulty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_FloatFilter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "AI Difficulty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Min Bots";
            // 
            // textBox_maxBots
            // 
            this.textBox_maxBots.Location = new System.Drawing.Point(86, 45);
            this.textBox_maxBots.Name = "textBox_maxBots";
            this.textBox_maxBots.Size = new System.Drawing.Size(220, 20);
            this.textBox_maxBots.TabIndex = 21;
            this.textBox_maxBots.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_NumberFilter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Max Bots";
            // 
            // textBox_minBots
            // 
            this.textBox_minBots.Location = new System.Drawing.Point(86, 71);
            this.textBox_minBots.Name = "textBox_minBots";
            this.textBox_minBots.Size = new System.Drawing.Size(220, 20);
            this.textBox_minBots.TabIndex = 23;
            this.textBox_minBots.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_NumberFilter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_config);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button_ini);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox_serverName);
            this.groupBox4.Controls.Add(this.textBox_maxPlayers);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 87);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Game Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Server Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Max Players";
            // 
            // textBox_serverName
            // 
            this.textBox_serverName.Location = new System.Drawing.Point(86, 19);
            this.textBox_serverName.Name = "textBox_serverName";
            this.textBox_serverName.Size = new System.Drawing.Size(220, 20);
            this.textBox_serverName.TabIndex = 19;
            // 
            // textBox_maxPlayers
            // 
            this.textBox_maxPlayers.Location = new System.Drawing.Point(86, 45);
            this.textBox_maxPlayers.Name = "textBox_maxPlayers";
            this.textBox_maxPlayers.Size = new System.Drawing.Size(220, 20);
            this.textBox_maxPlayers.TabIndex = 25;
            this.textBox_maxPlayers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_NumberFilter);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(29, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Server";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.checkBox_changeRandom);
            this.groupBox3.Controls.Add(this.listBox_changeScenario);
            this.groupBox3.Controls.Add(this.listBox_changeMap);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 246);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Map Change";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(76, 219);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(50, 17);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.Text = "Night";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(26, 219);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(44, 17);
            this.radioButton4.TabIndex = 24;
            this.radioButton4.Text = "Day";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // checkBox_changeRandom
            // 
            this.checkBox_changeRandom.AutoSize = true;
            this.checkBox_changeRandom.Location = new System.Drawing.Point(170, 219);
            this.checkBox_changeRandom.Name = "checkBox_changeRandom";
            this.checkBox_changeRandom.Size = new System.Drawing.Size(103, 17);
            this.checkBox_changeRandom.TabIndex = 23;
            this.checkBox_changeRandom.Text = "Randomise Map";
            this.checkBox_changeRandom.UseVisualStyleBackColor = true;
            // 
            // listBox_changeScenario
            // 
            this.listBox_changeScenario.FormattingEnabled = true;
            this.listBox_changeScenario.Location = new System.Drawing.Point(6, 24);
            this.listBox_changeScenario.Name = "listBox_changeScenario";
            this.listBox_changeScenario.Size = new System.Drawing.Size(140, 186);
            this.listBox_changeScenario.TabIndex = 21;
            this.listBox_changeScenario.SelectedIndexChanged += new System.EventHandler(this.OnClick_ScenarioSelect);
            // 
            // listBox_changeMap
            // 
            this.listBox_changeMap.FormattingEnabled = true;
            this.listBox_changeMap.Location = new System.Drawing.Point(152, 24);
            this.listBox_changeMap.Name = "listBox_changeMap";
            this.listBox_changeMap.Size = new System.Drawing.Size(140, 186);
            this.listBox_changeMap.TabIndex = 22;
            // 
            // button_config
            // 
            this.button_config.Enabled = false;
            this.button_config.Location = new System.Drawing.Point(312, 49);
            this.button_config.Name = "button_config";
            this.button_config.Size = new System.Drawing.Size(120, 30);
            this.button_config.TabIndex = 31;
            this.button_config.Text = "Open Config Folder";
            this.button_config.UseVisualStyleBackColor = true;
            this.button_config.Click += new System.EventHandler(this.OnClick_cfgFolder);
            // 
            // button_ini
            // 
            this.button_ini.Enabled = false;
            this.button_ini.Location = new System.Drawing.Point(312, 13);
            this.button_ini.Name = "button_ini";
            this.button_ini.Size = new System.Drawing.Size(120, 30);
            this.button_ini.TabIndex = 32;
            this.button_ini.Text = "Open Ini Folder";
            this.button_ini.UseVisualStyleBackColor = true;
            this.button_ini.Click += new System.EventHandler(this.OnClick_iniDir);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsSS Server Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExitForm);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_GLST;
        private System.Windows.Forms.TextBox textBox_GameStats;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textField_server;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog serverBrowseDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStartServer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox_scenario;
        private System.Windows.Forms.ListBox listBox_map;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox_randomMap;
        private System.Windows.Forms.Button button_mods;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox checkBox_changeRandom;
        private System.Windows.Forms.ListBox listBox_changeScenario;
        private System.Windows.Forms.ListBox listBox_changeMap;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_serverName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_minBots;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_maxBots;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_maxPlayers;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_aiDifficulty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_config;
        private System.Windows.Forms.Button button_ini;
    }
}

