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
        public static double customerCount;
        private bool btnClicked = false;
        FormSimulationScreen formSimulation;
        


        public FormSimulation()
        {
            InitializeComponent();
        }
        
        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void FormSimulation_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(FormSimulation_FormClosing);
            //ShowFormSimulationScreen();
        }

        private void FormSimulation_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Things while closing
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            btnEmergency.Enabled = true;
            btnSimulate.Enabled = false;
            btnReset.Enabled = true;
            formSimulation.timerEmergency.Stop();
            formSimulation.timerSimulation.Start();
        }

        private void ShowFormSimulationScreen()
        {
            formSimulation = new FormSimulationScreen();
            //formSimulation.MdiParent = this;
            //formSimulation.TopLevel = false;
            // this.pnlLayout1.Controls.Add(formSimulation);
            formSimulation.StartPosition = FormStartPosition.Manual;

            //formSimulation.Location = new Point(100, 100);
            formSimulation.Size = pnlLayout1.Size;
            formSimulation.Location = new Point(this.Location.X + 27, this.Location.Y + 163);
            
            formSimulation.Show(this);

            
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            btnEmergency.Enabled = false;
            btnSimulate.Enabled = true;
            formSimulation.timerSimulation.Stop();
            formSimulation.timerEmergency.Start();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void countCustomer()
        {
            if (cbTime.Text == "Evening (18:00)" || cbTime.Text == "Night (21:00)")
            {
                if (cbGenre.Text == "Horror" && cbAge.Text == "18+")
                {
                    customerCount = GetRandomNumber(0.7, 0.75); //percentage
                }
                else if (cbGenre.Text == "Romance")
                {
                    customerCount = GetRandomNumber(0.6, 0.8);
                }
                else
                {
                    customerCount = GetRandomNumber(0.5, 0.7);
                }
            }
            else
            {
                if (cbGenre.Text == "Horror")
                {
                    customerCount = GetRandomNumber(0, 0.1);
                }
                else if (cbGenre.Text == "Animation")
                {
                    customerCount = GetRandomNumber(0.4, 0.6);
                }
                else
                {
                    customerCount = GetRandomNumber(0.1, 0.3);
                }
            }
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
            if (!(cbGenre.Text == "" || cbAge.Text == "" || cbTime.Text == ""))
            {
                btnClicked = true;
                countCustomer();
                ShowFormSimulationScreen();
                btnSimulate.Enabled = true;
                lblChoosenLayout.Text = "Layout " + rbA.Text;
            }
            else
            {
                rbA.Checked = false;
                MessageBox.Show("Please fill the scenario!");

            }
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
            if (!(cbGenre.Text == "" || cbAge.Text == "" || cbTime.Text == ""))
            {
                btnClicked = true;
                countCustomer();
                ShowFormSimulationScreen();
                btnSimulate.Enabled = true;
                lblChoosenLayout.Text = "Layout " + rbB.Text;
            }
            else
            {
                rbB.Checked = false;
                MessageBox.Show("Please fill the scenario!");

            }
        }

        private void rbC_Click(object sender, EventArgs e)
        {
            if (!(cbGenre.Text == "" || cbAge.Text == "" || cbTime.Text == ""))
            {
                btnClicked = true;
                countCustomer();
                ShowFormSimulationScreen();
                btnSimulate.Enabled = true;
                lblChoosenLayout.Text = "Layout " + rbC.Text;
            }
            else
            {
                rbC.Checked = false;
                MessageBox.Show("Please fill the scenario!");

            }
        }

        public void setlblSeats()
        {
            lblFilledSeats.Text = "Worked";
        }
    }
}
