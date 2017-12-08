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
    public partial class FormSimulationScreen : Form
    {
        private Scenario scenarioTest;
        public FormSimulationScreen(Scenario scenariotest)
        {
            InitializeComponent();
            scenarioTest = scenariotest;
        }
        public FormSimulationScreen()
        {
            InitializeComponent();
        }
        decimal[] agecategory;
       

        private void FormLayoutTry1_Load(object sender, EventArgs e)
        {
            scenarioTest.StartSim(this);
            agecategory = scenarioTest.AssignCustomers(Convert.ToDecimal(Scenario.amount)); 
            Label Elder = ((FormSimulation)this.Owner).lblEldersAmount;
            Label Student = ((FormSimulation)this.Owner).lblStudentAmount;
            Label Adult = ((FormSimulation)this.Owner).lblAdultAmount;
            Label Childen = ((FormSimulation)this.Owner).lblChildrenAmount;
            Adult.Text = Convert.ToString(Convert.ToString(agecategory[0]));
            Childen.Text = Convert.ToString(Convert.ToString(agecategory[1]));
            Student.Text = Convert.ToString(Convert.ToString(agecategory[2]));
            Elder.Text = Convert.ToString(Convert.ToString(agecategory[3]));

        }

        public void timerEmergency_Tick(object sender, EventArgs e)
        {
            scenarioTest.EmergencySim();
            
        }
        //scenarioTest.AssignCustomers(customer.getCustomerAmount);
        public void timerSimulation_Tick(object sender, EventArgs e)
        {
            scenarioTest.UserGoToSeat();
        }

        public void timerSimulation_Skip()
        {
            scenarioTest.SkipSim();
        }



    }
}
