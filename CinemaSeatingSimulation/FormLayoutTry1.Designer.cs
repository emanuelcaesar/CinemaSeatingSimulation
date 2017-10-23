namespace CinemaSeatingSimulation
{
    partial class FormLayoutTry1
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
            this.seatA1 = new System.Windows.Forms.Panel();
            this.seatA2 = new System.Windows.Forms.Panel();
            this.seatA4 = new System.Windows.Forms.Panel();
            this.seatA3 = new System.Windows.Forms.Panel();
            this.doorExit1 = new System.Windows.Forms.Panel();
            this.timerSimulation = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.Chartreuse;
            this.pnlScreen.Location = new System.Drawing.Point(294, 13);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(853, 17);
            this.pnlScreen.TabIndex = 0;
            // 
            // seatA1
            // 
            this.seatA1.BackColor = System.Drawing.Color.Maroon;
            this.seatA1.Location = new System.Drawing.Point(294, 142);
            this.seatA1.Name = "seatA1";
            this.seatA1.Size = new System.Drawing.Size(30, 30);
            this.seatA1.TabIndex = 1;
            // 
            // seatA2
            // 
            this.seatA2.BackColor = System.Drawing.Color.Maroon;
            this.seatA2.Location = new System.Drawing.Point(340, 142);
            this.seatA2.Name = "seatA2";
            this.seatA2.Size = new System.Drawing.Size(30, 30);
            this.seatA2.TabIndex = 2;
            // 
            // seatA4
            // 
            this.seatA4.BackColor = System.Drawing.Color.Maroon;
            this.seatA4.Location = new System.Drawing.Point(434, 142);
            this.seatA4.Name = "seatA4";
            this.seatA4.Size = new System.Drawing.Size(30, 30);
            this.seatA4.TabIndex = 4;
            // 
            // seatA3
            // 
            this.seatA3.BackColor = System.Drawing.Color.Maroon;
            this.seatA3.Location = new System.Drawing.Point(385, 142);
            this.seatA3.Name = "seatA3";
            this.seatA3.Size = new System.Drawing.Size(30, 30);
            this.seatA3.TabIndex = 3;
            // 
            // doorExit1
            // 
            this.doorExit1.BackColor = System.Drawing.Color.Aquamarine;
            this.doorExit1.Location = new System.Drawing.Point(1405, 13);
            this.doorExit1.Name = "doorExit1";
            this.doorExit1.Size = new System.Drawing.Size(48, 115);
            this.doorExit1.TabIndex = 5;
            // 
            // timerSimulation
            // 
            this.timerSimulation.Interval = 20;
            this.timerSimulation.Tick += new System.EventHandler(this.timerSimulation_Tick);
            // 
            // FormLayoutTry1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1465, 717);
            this.Controls.Add(this.doorExit1);
            this.Controls.Add(this.seatA4);
            this.Controls.Add(this.seatA2);
            this.Controls.Add(this.seatA3);
            this.Controls.Add(this.seatA1);
            this.Controls.Add(this.pnlScreen);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLayoutTry1";
            this.Text = "FormLayoutTry1";
            this.Load += new System.EventHandler(this.FormLayoutTry1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScreen;
        private System.Windows.Forms.Panel seatA1;
        private System.Windows.Forms.Panel seatA2;
        private System.Windows.Forms.Panel seatA4;
        private System.Windows.Forms.Panel seatA3;
        private System.Windows.Forms.Panel doorExit1;
        public System.Windows.Forms.Timer timerSimulation;
    }
}