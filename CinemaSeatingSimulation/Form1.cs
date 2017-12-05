using System;
using System.IO;
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
        public static bool emergencyEnable;
        List<Customer> custList = new List<Customer>();
        
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

            //btnEmergency.Enabled = true;
            btnSimulate.Enabled = false;
            btnReset.Enabled = true;
            emergencyEnable = false;

            formSimulation.timerEmergency.Enabled = false;
            timerBack.Stop();
            formSimulation.timerSimulation.Enabled = true;
            timerStart.Start();
            //if(custList.Count() <= 0)
            //{
            //    btnEmergency.Enabled = true;
            //}
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
            btnSimulate.Enabled = true;
        }

        private void rbC_Click(object sender, EventArgs e)
        {
            btnSimulate.Enabled = true;
        }

        public void setlblSeats()
        {
            lblFilledSeats.Text = "Worked";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(cbGenre.Text == "" || cbAge.Text == "" || cbTime.Text == ""))
            {
                scenariotest.CalcAmountofCustomers(this.cbTime.Text, this.cbGenre.Text, this.cbAge.Text);
                EnableRB(true);
            }
            else
            {
                MessageBox.Show("Please fill the scenario!");
            }
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
            if (emergencyEnable)
            {
                btnEmergency.Enabled = true;
            }
        }

        private void timerBack_Tick(object sender, EventArgs e)
        {
            formSimulation.timerEmergency_Tick(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }
    }
}
