﻿namespace CinemaSeatingSimulation
{
    partial class FormSimulation
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
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.gbPanel = new System.Windows.Forms.GroupBox();
            this.tabLayout = new System.Windows.Forms.TabControl();
            this.tabLayout1 = new System.Windows.Forms.TabPage();
            this.pnlLayout1 = new System.Windows.Forms.Panel();
            this.gbControlPanel = new System.Windows.Forms.GroupBox();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbScreeningPanel = new System.Windows.Forms.GroupBox();
            this.panel129 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbAge = new System.Windows.Forms.ComboBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbLayout = new System.Windows.Forms.GroupBox();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.panel134 = new System.Windows.Forms.Panel();
            this.lblChoosenLayout = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblEldersAmount = new System.Windows.Forms.Label();
            this.lblInfantAmount = new System.Windows.Forms.Label();
            this.lblChildrenAmount = new System.Windows.Forms.Label();
            this.lblAdultAmount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.lblFilledSeats = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.timerBack = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbPanel.SuspendLayout();
            this.tabLayout.SuspendLayout();
            this.tabLayout1.SuspendLayout();
            this.gbControlPanel.SuspendLayout();
            this.gbScreeningPanel.SuspendLayout();
            this.panel129.SuspendLayout();
            this.gbLayout.SuspendLayout();
            this.panel134.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightBlue;
            this.panelHeader.Controls.Add(this.btnLoad);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnSave);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(866, 56);
            this.panelHeader.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightBlue;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(749, 8);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(102, 36);
            this.btnLoad.TabIndex = 160;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(4, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(492, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CINEMA SEATING SIMULATION";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(640, 8);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 36);
            this.btnSave.TabIndex = 159;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 58);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(244, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Enabled = false;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.Enabled = false;
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.Enabled = false;
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panelDivider
            // 
            this.panelDivider.BackColor = System.Drawing.Color.LightBlue;
            this.panelDivider.Location = new System.Drawing.Point(0, 86);
            this.panelDivider.Margin = new System.Windows.Forms.Padding(2);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(862, 4);
            this.panelDivider.TabIndex = 2;
            // 
            // gbPanel
            // 
            this.gbPanel.Controls.Add(this.tabLayout);
            this.gbPanel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPanel.Location = new System.Drawing.Point(10, 93);
            this.gbPanel.Margin = new System.Windows.Forms.Padding(2);
            this.gbPanel.Name = "gbPanel";
            this.gbPanel.Padding = new System.Windows.Forms.Padding(2);
            this.gbPanel.Size = new System.Drawing.Size(605, 333);
            this.gbPanel.TabIndex = 0;
            this.gbPanel.TabStop = false;
            this.gbPanel.Text = "Simulation Panel";
            // 
            // tabLayout
            // 
            this.tabLayout.Controls.Add(this.tabLayout1);
            this.tabLayout.Location = new System.Drawing.Point(5, 17);
            this.tabLayout.Margin = new System.Windows.Forms.Padding(2);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.SelectedIndex = 0;
            this.tabLayout.Size = new System.Drawing.Size(594, 312);
            this.tabLayout.TabIndex = 3;
            // 
            // tabLayout1
            // 
            this.tabLayout1.BackColor = System.Drawing.Color.Black;
            this.tabLayout1.Controls.Add(this.pnlLayout1);
            this.tabLayout1.Location = new System.Drawing.Point(4, 21);
            this.tabLayout1.Margin = new System.Windows.Forms.Padding(2);
            this.tabLayout1.Name = "tabLayout1";
            this.tabLayout1.Padding = new System.Windows.Forms.Padding(2);
            this.tabLayout1.Size = new System.Drawing.Size(586, 287);
            this.tabLayout1.TabIndex = 0;
            this.tabLayout1.Text = "Hall";
            // 
            // pnlLayout1
            // 
            this.pnlLayout1.Location = new System.Drawing.Point(0, 0);
            this.pnlLayout1.Margin = new System.Windows.Forms.Padding(1);
            this.pnlLayout1.Name = "pnlLayout1";
            this.pnlLayout1.Size = new System.Drawing.Size(587, 287);
            this.pnlLayout1.TabIndex = 0;
            this.pnlLayout1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLayout1_Paint);
            // 
            // gbControlPanel
            // 
            this.gbControlPanel.Controls.Add(this.btnEmergency);
            this.gbControlPanel.Controls.Add(this.btnSkip);
            this.gbControlPanel.Controls.Add(this.btnSimulate);
            this.gbControlPanel.Controls.Add(this.btnReset);
            this.gbControlPanel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControlPanel.Location = new System.Drawing.Point(9, 426);
            this.gbControlPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbControlPanel.Name = "gbControlPanel";
            this.gbControlPanel.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbControlPanel.Size = new System.Drawing.Size(606, 61);
            this.gbControlPanel.TabIndex = 148;
            this.gbControlPanel.TabStop = false;
            this.gbControlPanel.Text = "Control Panel";
            // 
            // btnEmergency
            // 
            this.btnEmergency.BackColor = System.Drawing.Color.Crimson;
            this.btnEmergency.Enabled = false;
            this.btnEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmergency.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergency.ForeColor = System.Drawing.Color.White;
            this.btnEmergency.Location = new System.Drawing.Point(155, 18);
            this.btnEmergency.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(142, 36);
            this.btnEmergency.TabIndex = 9;
            this.btnEmergency.Text = "Emergency";
            this.btnEmergency.UseVisualStyleBackColor = false;
            this.btnEmergency.Click += new System.EventHandler(this.btnEmergency_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.LightBlue;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(304, 18);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(142, 36);
            this.btnSkip.TabIndex = 10;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSimulate
            // 
            this.btnSimulate.BackColor = System.Drawing.Color.Turquoise;
            this.btnSimulate.Enabled = false;
            this.btnSimulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimulate.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulate.ForeColor = System.Drawing.Color.White;
            this.btnSimulate.Location = new System.Drawing.Point(6, 18);
            this.btnSimulate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(142, 36);
            this.btnSimulate.TabIndex = 7;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = false;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightBlue;
            this.btnReset.Enabled = false;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(454, 18);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 36);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbScreeningPanel
            // 
            this.gbScreeningPanel.Controls.Add(this.panel129);
            this.gbScreeningPanel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbScreeningPanel.Location = new System.Drawing.Point(618, 93);
            this.gbScreeningPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbScreeningPanel.Name = "gbScreeningPanel";
            this.gbScreeningPanel.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbScreeningPanel.Size = new System.Drawing.Size(234, 206);
            this.gbScreeningPanel.TabIndex = 149;
            this.gbScreeningPanel.TabStop = false;
            this.gbScreeningPanel.Text = "Screening Panel";
            // 
            // panel129
            // 
            this.panel129.BackColor = System.Drawing.Color.Linen;
            this.panel129.Controls.Add(this.button2);
            this.panel129.Controls.Add(this.cbTime);
            this.panel129.Controls.Add(this.cbAge);
            this.panel129.Controls.Add(this.cbGenre);
            this.panel129.Controls.Add(this.label5);
            this.panel129.Controls.Add(this.label4);
            this.panel129.Controls.Add(this.label3);
            this.panel129.Controls.Add(this.label2);
            this.panel129.Location = new System.Drawing.Point(10, 38);
            this.panel129.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel129.Name = "panel129";
            this.panel129.Size = new System.Drawing.Size(213, 157);
            this.panel129.TabIndex = 140;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(122, 118);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 27);
            this.button2.TabIndex = 159;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbTime
            // 
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "Morning (10:00)",
            "Afternoon (14:00)",
            "Evening (18:00)",
            "Night (21:00)"});
            this.cbTime.Location = new System.Drawing.Point(54, 92);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(141, 20);
            this.cbTime.TabIndex = 157;
            // 
            // cbAge
            // 
            this.cbAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAge.FormattingEnabled = true;
            this.cbAge.Items.AddRange(new object[] {
            "AL",
            "12",
            "18"});
            this.cbAge.Location = new System.Drawing.Point(54, 68);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(141, 20);
            this.cbAge.TabIndex = 156;
            this.cbAge.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbGenre
            // 
            this.cbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "Horror",
            "Comedy",
            "Romance",
            "Action",
            "Animation"});
            this.cbGenre.Location = new System.Drawing.Point(54, 43);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(141, 20);
            this.cbGenre.TabIndex = 155;
            this.cbGenre.SelectedIndexChanged += new System.EventHandler(this.cbGenre_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 143;
            this.label5.Text = "Time:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 142;
            this.label4.Text = "Age:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 141;
            this.label3.Text = "Genre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 140;
            this.label2.Text = "Type of Movie:";
            // 
            // gbLayout
            // 
            this.gbLayout.Controls.Add(this.rbB);
            this.gbLayout.Controls.Add(this.rbA);
            this.gbLayout.Controls.Add(this.rbC);
            this.gbLayout.Controls.Add(this.label16);
            this.gbLayout.Controls.Add(this.panel134);
            this.gbLayout.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLayout.Location = new System.Drawing.Point(618, 304);
            this.gbLayout.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbLayout.Name = "gbLayout";
            this.gbLayout.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbLayout.Size = new System.Drawing.Size(125, 122);
            this.gbLayout.TabIndex = 150;
            this.gbLayout.TabStop = false;
            this.gbLayout.Text = "Layout";
            this.gbLayout.Enter += new System.EventHandler(this.gbLayout_Enter);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Enabled = false;
            this.rbB.Location = new System.Drawing.Point(46, 85);
            this.rbB.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(32, 17);
            this.rbB.TabIndex = 150;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.Click += new System.EventHandler(this.rbB_Click);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(10, 85);
            this.rbA.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(32, 17);
            this.rbA.TabIndex = 149;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            this.rbA.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Enabled = false;
            this.rbC.Location = new System.Drawing.Point(82, 85);
            this.rbC.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(32, 17);
            this.rbC.TabIndex = 146;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.Click += new System.EventHandler(this.rbC_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 18);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 19);
            this.label16.TabIndex = 145;
            this.label16.Text = "Choosen Layout:";
            // 
            // panel134
            // 
            this.panel134.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel134.Controls.Add(this.lblChoosenLayout);
            this.panel134.Location = new System.Drawing.Point(11, 38);
            this.panel134.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel134.Name = "panel134";
            this.panel134.Size = new System.Drawing.Size(102, 30);
            this.panel134.TabIndex = 144;
            // 
            // lblChoosenLayout
            // 
            this.lblChoosenLayout.AutoSize = true;
            this.lblChoosenLayout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoosenLayout.Location = new System.Drawing.Point(5, 2);
            this.lblChoosenLayout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoosenLayout.Name = "lblChoosenLayout";
            this.lblChoosenLayout.Size = new System.Drawing.Size(0, 25);
            this.lblChoosenLayout.TabIndex = 152;
            this.lblChoosenLayout.Click += new System.EventHandler(this.label15_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.label11);
            this.gbStatus.Controls.Add(this.label12);
            this.gbStatus.Controls.Add(this.label21);
            this.gbStatus.Controls.Add(this.label22);
            this.gbStatus.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(749, 304);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbStatus.Size = new System.Drawing.Size(70, 122);
            this.gbStatus.TabIndex = 151;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 157;
            this.label11.Text = "Elders:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 156;
            this.label12.Text = "Infant:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 40);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 155;
            this.label21.Text = "Children:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(8, 20);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 154;
            this.label22.Text = "Adult:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblEldersAmount);
            this.groupBox5.Controls.Add(this.lblInfantAmount);
            this.groupBox5.Controls.Add(this.lblChildrenAmount);
            this.groupBox5.Controls.Add(this.lblAdultAmount);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(822, 304);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Size = new System.Drawing.Size(29, 122);
            this.groupBox5.TabIndex = 158;
            this.groupBox5.TabStop = false;
            // 
            // lblEldersAmount
            // 
            this.lblEldersAmount.AutoSize = true;
            this.lblEldersAmount.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEldersAmount.Location = new System.Drawing.Point(8, 86);
            this.lblEldersAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEldersAmount.Name = "lblEldersAmount";
            this.lblEldersAmount.Size = new System.Drawing.Size(11, 13);
            this.lblEldersAmount.TabIndex = 157;
            this.lblEldersAmount.Text = "/";
            this.lblEldersAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfantAmount
            // 
            this.lblInfantAmount.AutoSize = true;
            this.lblInfantAmount.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfantAmount.Location = new System.Drawing.Point(8, 62);
            this.lblInfantAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfantAmount.Name = "lblInfantAmount";
            this.lblInfantAmount.Size = new System.Drawing.Size(11, 13);
            this.lblInfantAmount.TabIndex = 156;
            this.lblInfantAmount.Text = "/";
            this.lblInfantAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChildrenAmount
            // 
            this.lblChildrenAmount.AutoSize = true;
            this.lblChildrenAmount.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildrenAmount.Location = new System.Drawing.Point(8, 40);
            this.lblChildrenAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildrenAmount.Name = "lblChildrenAmount";
            this.lblChildrenAmount.Size = new System.Drawing.Size(11, 13);
            this.lblChildrenAmount.TabIndex = 155;
            this.lblChildrenAmount.Text = "/";
            this.lblChildrenAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdultAmount
            // 
            this.lblAdultAmount.AutoSize = true;
            this.lblAdultAmount.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultAmount.Location = new System.Drawing.Point(8, 21);
            this.lblAdultAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdultAmount.Name = "lblAdultAmount";
            this.lblAdultAmount.Size = new System.Drawing.Size(11, 13);
            this.lblAdultAmount.TabIndex = 154;
            this.lblAdultAmount.Text = "/";
            this.lblAdultAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label23);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 29);
            this.panel1.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.LightBlue;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(309, 6);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(251, 13);
            this.label23.TabIndex = 158;
            this.label23.Text = "Copyright EJ-Caesar-Davin-Laras-Feter-Mubashir";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilledSeats
            // 
            this.lblFilledSeats.AutoSize = true;
            this.lblFilledSeats.Location = new System.Drawing.Point(8, 29);
            this.lblFilledSeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilledSeats.Name = "lblFilledSeats";
            this.lblFilledSeats.Size = new System.Drawing.Size(13, 13);
            this.lblFilledSeats.TabIndex = 159;
            this.lblFilledSeats.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblFilledSeats);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(749, 430);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(102, 57);
            this.groupBox1.TabIndex = 160;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 160;
            this.label6.Text = "Seats Filled";
            // 
            // timerStart
            // 
            this.timerStart.Interval = 5;
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // timerBack
            // 
            this.timerBack.Interval = 5;
            this.timerBack.Tick += new System.EventHandler(this.timerBack_Tick);
            // 
            // FormSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbLayout);
            this.Controls.Add(this.gbScreeningPanel);
            this.Controls.Add(this.gbControlPanel);
            this.Controls.Add(this.gbPanel);
            this.Controls.Add(this.panelDivider);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormSimulation";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Seating Simulation v1.9 RC";
            this.Load += new System.EventHandler(this.FormSimulation_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbPanel.ResumeLayout(false);
            this.tabLayout.ResumeLayout(false);
            this.tabLayout1.ResumeLayout(false);
            this.gbControlPanel.ResumeLayout(false);
            this.gbScreeningPanel.ResumeLayout(false);
            this.panel129.ResumeLayout(false);
            this.panel129.PerformLayout();
            this.gbLayout.ResumeLayout(false);
            this.gbLayout.PerformLayout();
            this.panel134.ResumeLayout(false);
            this.panel134.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panelDivider;
        private System.Windows.Forms.GroupBox gbPanel;
        private System.Windows.Forms.GroupBox gbControlPanel;
        private System.Windows.Forms.Button btnEmergency;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbScreeningPanel;
        private System.Windows.Forms.Panel panel129;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbLayout;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel134;
        private System.Windows.Forms.Label lblChoosenLayout;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblInfantAmount;
        private System.Windows.Forms.Label lblChildrenAmount;
        private System.Windows.Forms.Label lblAdultAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbAge;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TabControl tabLayout;
        private System.Windows.Forms.TabPage tabLayout1;
        private System.Windows.Forms.Panel pnlLayout1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblFilledSeats;
        public System.Windows.Forms.Label lblEldersAmount;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Timer timerBack;
        private System.Windows.Forms.Timer timer1;
    }
}

