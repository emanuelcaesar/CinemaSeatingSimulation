﻿namespace CinemaSeatingSimulation
{
   partial class FormSimulationScreen
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
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.timerSimulation = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerEmergency = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.Chartreuse;
            this.pnlScreen.Location = new System.Drawing.Point(99, 5);
            this.pnlScreen.Margin = new System.Windows.Forms.Padding(1);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(350, 7);
            this.pnlScreen.TabIndex = 0;
            // 
            // timerSimulation
            // 
            this.timerSimulation.Enabled = true;
            this.timerSimulation.Interval = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 650);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1408, 20);
            this.textBox1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(27, 614);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 7;
            // 
            // timerEmergency
            // 
            this.timerEmergency.Tick += new System.EventHandler(this.timerEmergency_Tick);
            // 
            // FormSimulationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(550, 292);
            this.Controls.Add(this.pnlScreen);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormSimulationScreen";
            this.Text = "FormSimulationScreen";
            this.Load += new System.EventHandler(this.FormLayoutTry1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScreen;
        public System.Windows.Forms.Timer timerSimulation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Timer timerEmergency;
    }
}