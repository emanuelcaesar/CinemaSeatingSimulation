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
            this.doorExit1 = new System.Windows.Forms.Panel();
            this.timerSimulation = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.Chartreuse;
            // 
            // doorExit1
            // 
            this.doorExit1.BackColor = System.Drawing.Color.Aquamarine;
            this.doorExit1.Location = new System.Drawing.Point(702, 7);
            this.doorExit1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doorExit1.Name = "doorExit1";
            this.doorExit1.Size = new System.Drawing.Size(24, 59);

            this.pnlScreen.Location = new System.Drawing.Point(110, 5);
            this.pnlScreen.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(320, 7);
            this.pnlScreen.TabIndex = 0;
            // 
            // doorExit1
            // 
            this.doorExit1.BackColor = System.Drawing.Color.Aquamarine;
            this.doorExit1.Location = new System.Drawing.Point(527, 5);
            this.doorExit1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.doorExit1.Name = "doorExit1";
            this.doorExit1.Size = new System.Drawing.Size(18, 48);

            this.doorExit1.TabIndex = 5;
            // 
            // timerSimulation
            // 
            this.timerSimulation.Interval = 20;
            this.timerSimulation.Tick += new System.EventHandler(this.timerSimulation_Tick);
            // 
            // FormLayoutTry1
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(511, 301);

            this.Controls.Add(this.doorExit1);
            this.Controls.Add(this.pnlScreen);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);

            this.Name = "FormLayoutTry1";
            this.Text = "FormLayoutTry1";
            this.Load += new System.EventHandler(this.FormLayoutTry1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScreen;
        private System.Windows.Forms.Panel doorExit1;
        public System.Windows.Forms.Timer timerSimulation;
    }
}