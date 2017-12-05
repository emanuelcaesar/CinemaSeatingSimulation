using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSeatingSimulation
{
    public partial class FormSimulation : Form
    {
        
        private bool btnClicked = false;
        FormSimulationScreen formSimulation;
        Scenario scenariotest = new Scenario();
        Customer cust = new Customer();
        public static int amount;
        
        public FormSimulation()
        {
            InitializeComponent();

            EnableRB(false);
        }
        
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void FormSimulation_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(FormSimulation_FormClosing);
        }

        private void FormSimulation_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Things while closing
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            if (rbA.Checked) scenariotest.SetHall(rbA.Text);
            else if (rbB.Checked) scenariotest.SetHall(rbB.Text);
            else if (rbC.Checked) scenariotest.SetHall(rbC.Text);

            ShowFormSimulationScreen();

            btnEmergency.Enabled = true;
            btnSimulate.Enabled = false;
            btnReset.Enabled = true;

            formSimulation.timerEmergency.Enabled = false;
            timerBack.Stop();
            formSimulation.timerSimulation.Enabled = true;
            timerStart.Start();
        }

        private void ShowFormSimulationScreen()
        {
            formSimulation = new FormSimulationScreen();
            formSimulation.StartPosition = FormStartPosition.Manual;
            formSimulation.Size = pnlLayout1.Size;
            formSimulation.Location = new Point(this.Location.X + 27, this.Location.Y + 163);
            
            
            formSimulation.Show(this);

            
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            btnEmergency.Enabled = false;
            btnSimulate.Enabled = true;

            formSimulation.timerEmergency.Enabled = true;
            timerBack.Start();
            formSimulation.timerSimulation.Enabled = false;
            timerStart.Stop();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void countCustomer() //move this to scenario
        {
            
        }

        private void pnlLayout1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnEmergency.Enabled = false;
            btnSimulate.Enabled = true;
            formSimulation.Close();
            ShowFormSimulationScreen();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            //if (!(cbGenre.Text == "" || cbAge.Text == "" || cbTime.Text == ""))
            //{
            //    btnClicked = true;
            //    scenariotest.SetHall(rbA.Text);
            //    countCustomer();
            //    ShowFormSimulationScreen();
            //    btnSimulate.Enabled = true;
            //    lblChoosenLayout.Text = "Layout " + rbA.Text;

            //}
            //else
            //{
            //    rbA.Checked = false;
            //    MessageBox.Show("Please fill the scenario!");

            //}
            btnSimulate.Enabled = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            cbGenre.ResetText();
        }

        private void gbLayout_Enter(object sender, EventArgs e)
        {

        }

        private void rbB_Click(object sender, EventArgs e)
        {
            //if (!(cbGenre.Text == "" || cbAge.Text == "" || cbTime.Text == ""))
            //{
            //    btnClicked = true;
            //    scenariotest.SetHall(rbB.Text);
            //    countCustomer();
            //    ShowFormSimulationScreen();
            //    btnSimulate.Enabled = true;
            //    lblChoosenLayout.Text = "Layout " + rbB.Text;

            //}
            //else
            //{
            //    rbB.Checked = false;
            //    MessageBox.Show("Please fill the scenario!");

            //}
            btnSimulate.Enabled = true;
        }

        private void rbC_Click(object sender, EventArgs e)
        {
            //if (!(cbGenre.Text == "" || cbAge.Text == "" || cbTime.Text == ""))
            //{
            //    btnClicked = true;
            //    scenariotest.SetHall(rbC.Text);
            //    countCustomer();
            //    ShowFormSimulationScreen();
            //    btnSimulate.Enabled = true;
            //    lblChoosenLayout.Text = "Layout " + rbC.Text;

            //}
            //else
            //{
            //    rbC.Checked = false;
            //    MessageBox.Show("Please fill the scenario!");

            //}
            btnSimulate.Enabled = true;
        }

        public void setlblSeats()
        {
            lblFilledSeats.Text = "Worked";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scenariotest.CalcAmountofCustomers(this.cbTime.Text, this.cbGenre.Text, this.cbAge.Text);

            EnableRB(true);
            
        }

        private void EnableRB(bool value)
        {
            rbA.Enabled = value;
            rbB.Enabled = value;
            rbC.Enabled = value;
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            formSimulation.timerSimulation_Tick(sender, e);
        }

        private void timerBack_Tick(object sender, EventArgs e)
        {
            formSimulation.timerEmergency_Tick(sender, e);
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            btnEmergency.Enabled = true;
            btnSimulate.Enabled = false;

            formSimulation.timerEmergency.Enabled = false;
            formSimulation.timerSimulation.Enabled = false;

            formSimulation.timerSimulation.Stop();
            timerStart.Stop();
            timerBack.Stop();
            formSimulation.timerSimulation_Skip();
        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
