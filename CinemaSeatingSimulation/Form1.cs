using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSeatingSimulation
{
    public partial class FormSimulation : Form
    {

        private bool btnClicked = false;
        private FormSimulationScreen formSimulation;
        private Scenario scenariotest = new Scenario();
        //Customer cust = new Customer();
        public static bool emergencyEnable;
        System.Drawing.Point initialLocation;
        //public static double amount;

        public FormSimulation()
        {
            InitializeComponent();

            EnableRB(false);
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Text = null;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void FormSimulation_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(FormSimulation_FormClosing);
            this.CenterToScreen();
            initialLocation = this.Location;
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
            btnSkip.Enabled = true;
            emergencyEnable = false;

            formSimulation.timerEmergency.Enabled = false;
            timerBack.Stop();
            formSimulation.timerSimulation.Enabled = true;
            timerStart.Start();
        }

        private void ShowFormSimulationScreen()
        {
            formSimulation = new FormSimulationScreen(scenariotest);
            formSimulation.StartPosition = FormStartPosition.Manual;
            formSimulation.Size = pnlLayout1.Size;
            formSimulation.Location = new Point(this.Location.X + 20, this.Location.Y + 134);

            formSimulation.Show(this);
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            btnEmergency.Enabled = false;
            btnSimulate.Enabled = true;
            btnSkip.Enabled = false;

            formSimulation.timerEmergency.Enabled = true;
            timerBack.Start();
            formSimulation.timerSimulation.Enabled = false;
            timerStart.Stop();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // checkBtnScenario();
        }

        public void countCustomer() //move this to scenario
        {

        }

        private void pnlLayout1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            if (!(cbGenre.Text == "" || cbAge.Text == "" || cbTime.Text == ""))
            {
                btnClicked = true;
                scenariotest.SetHall(rbA.Text);
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
            if (!(cbGenre.Text == "" || cbAge.Text == "" || cbTime.Text == ""))
            {
                btnClicked = true;
                scenariotest.SetHall(rbB.Text);
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
            btnSimulate.Enabled = true;
        }

        private void rbC_Click(object sender, EventArgs e)
        {
            if (!(cbGenre.Text == "" || cbAge.Text == "" || cbTime.Text == ""))
            {
                btnClicked = true;
                scenariotest.SetHall(rbC.Text);
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
            btnSimulate.Enabled = true;
        }

        public void setlblSeats()
        {
            lblFilledSeats.Text = "Worked";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (cbTime.SelectedIndex > -1 && cbAge.SelectedIndex > -1 && cbGenre.SelectedIndex > -1)
            {
                DialogResult dialogResult = MessageBox.Show("Option selected are: \n" + "- " + cbGenre.Text + "\n- " + cbTime.Text + "\n- " + cbAge.Text + "\nContinue?", "Scenario Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    scenariotest.CalcAmountofCustomers(this.cbTime.Text, this.cbGenre.Text, this.cbAge.Text);
                    //MessageBox.Show("Amount of customers calculated!");
                    EnableRB(true);
                }
                else if (dialogResult == DialogResult.No)
                {
                    EnableRB(false);
                    MessageBox.Show("Cancelled! Please choose again!");
                }
            }
            else
                MessageBox.Show("Please choose correctly");





        }

        private void ResetAll()
        {
            cbGenre.SelectedIndex =
            cbTime.SelectedIndex = cbAge.SelectedIndex = -1;
            lblAdultAmount.Text = "";
            lblChildrenAmount.Text = "";
            lblEldersAmount.Text = "";
            lblStudentAmount.Text = "";
            lblChoosenLayout.Text = "";
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            lblFilledSeats.Text = "0";
            btnEmergency.Enabled = false;
            btnSimulate.Enabled = true;
            btnSkip.Enabled = false;
            formSimulation.timerSimulation.Stop();
            ShowFormSimulationScreen();
            timerStart.Stop();
            formSimulation.timerEmergency.Stop();
            timerBack.Stop();
            emergencyEnable = false;
            MessageBox.Show("Reset Done!");
            formSimulation.Hide();
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

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checkBtnScenario();
        }

        private void checkBtnScenario()
        {
            if (cbGenre.SelectedIndex > -1 || cbAge.SelectedIndex > -1 || cbTime.SelectedIndex > -1)
            {
                button2.Enabled = true;
            }
            button2.Enabled = false;
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] listOfSave = new string[11];
            listOfSave[0] = "Results of the Simulation";
            listOfSave[1] = Convert.ToString(cbAge.SelectedIndex);
            listOfSave[2] = Convert.ToString(cbGenre.SelectedIndex);
            listOfSave[3] = Convert.ToString(cbTime.SelectedIndex);
            listOfSave[4] = lblAdultAmount.Text;
            listOfSave[5] = lblChildrenAmount.Text;
            listOfSave[6] = lblStudentAmount.Text;
            listOfSave[7] = lblEldersAmount.Text;
            listOfSave[8] = rbA.Text;
            listOfSave[9] = rbB.Text;
            listOfSave[10] = rbC.Text;
            //List<RadioButton> radioButton = new List<RadioButton>();
            Boolean[] radioButton = new Boolean[3];
            radioButton[0] = rbA.Checked;
            radioButton[1] = rbB.Checked;
            radioButton[2] = rbC.Checked;


            scenariotest.SaveScenario(saveFileDialog1, listOfSave, radioButton);

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = @"C:\Documents";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.Filter = "sim files (*.sim)|*.txt|All files (*.*)|*.*";

            List<ComboBox> cbList = new List<ComboBox>();
            cbList.Add(cbGenre);
            cbList.Add(cbAge);
            cbList.Add(cbTime);
            List<RadioButton> rbList = new List<RadioButton>();
            rbList.Add(rbA);
            rbList.Add(rbB);
            rbList.Add(rbC);

            scenariotest.LoadScenario(openFileDialog1, cbList, rbList);

        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Documents";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.Filter = "sim files (.sim)|.txt|All files (.)|*.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines;

                List<string> list = new List<string>();
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    string line;
                    int counter = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        System.Console.WriteLine(line);
                        counter++;
                        System.Console.WriteLine(counter);
                        if (counter == 2)
                        {
                            if (line == "0")
                                cbGenre.SelectedIndex = 0;
                            if (line == "1")
                                cbGenre.SelectedIndex = 1;
                            if (line == "2")
                                cbGenre.SelectedIndex = 2;
                            if (line == "3")
                                cbGenre.SelectedIndex = 3;
                            if (line == "4")
                                cbGenre.SelectedIndex = 4;
                        }

                        if (counter == 3)
                        {
                            if (line == "0")
                            {
                                cbAge.SelectedIndex = 0;
                            }
                            if (line == "1")
                            {
                                cbAge.SelectedIndex = 1;
                            }
                            if (line == "2")
                            {
                                cbAge.SelectedIndex = 2;
                            }
                        }

                        if (counter == 4)
                        {
                            if (line == "0")
                            {
                                cbTime.SelectedIndex = 0;
                            }
                            if (line == "1")
                            {
                                cbTime.SelectedIndex = 1;
                            }
                            if (line == "2")
                            {
                                cbTime.SelectedIndex = 2;
                            }
                            if (line == "3")
                            {
                                cbTime.SelectedIndex = 3;
                            }
                        }

                       
                    }
                }

            }
            MessageBox.Show("Configuration loaded!");
        }

        private void FormSimulation_LocationChanged(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
