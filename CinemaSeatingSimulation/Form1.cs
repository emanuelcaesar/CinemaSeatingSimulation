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
            //countCustomer();
            if(!(comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == ""))
            {
                btnClicked = true;
                countCustomer();
                ShowFormSimulationScreen();

                formSimulation.timerSimulation.Start();
                formSimulation.timerEmergency.Stop();
            }
            else
            {
                MessageBox.Show("Please fill the scenario!");
            }
        }

        private void ShowFormSimulationScreen()
        {
            formSimulation = new FormSimulationScreen();
            formSimulation.TopLevel = false;
            this.pnlLayout1.Controls.Add(formSimulation);
            formSimulation.Show();
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            if (!(comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == ""))
            {
                if (btnClicked)
                {
                    //FormSimulationScreen fss = new FormSimulationScreen();
                    formSimulation.timerSimulation.Stop();
                    formSimulation.timerEmergency.Start();
                    
                }
                else
                {
                    MessageBox.Show("Please Simulate first!");
                }
            }
            else
            {
                MessageBox.Show("Please fill the scenario!");
            }  
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void countCustomer()
        {
            if (comboBox3.Text == "Evening (18:00)" || comboBox3.Text == "Night (21:00)")
            {
                if (comboBox1.Text == "Horror" && comboBox2.Text == "18+")
                {
                    customerCount = GetRandomNumber(0.7, 0.75);
                }
                else if (comboBox1.Text == "Romance")
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
                if (comboBox1.Text == "Horror")
                {
                    customerCount = GetRandomNumber(0, 0.1);
                }
                else if (comboBox1.Text == "Animation")
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
            formSimulation.Close();
            ShowFormSimulationScreen();
        }
    }
}
