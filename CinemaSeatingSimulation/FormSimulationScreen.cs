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
        public FormSimulationScreen()
        {
            InitializeComponent();
        }
        decimal[] agecategory;
        Scenario scenarioTest = new Scenario();

        private void FormLayoutTry1_Load(object sender, EventArgs e)
        {
            scenarioTest.StartSim(this);
            agecategory = scenarioTest.AssignCustomers(Convert.ToDecimal(FormSimulation.amount)); 
            Label Elder = ((FormSimulation)this.Owner).lblEldersAmount;
            Elder.Text = Convert.ToString(Convert.ToString(agecategory[0]));

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



=======
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
>>>>>>> origin/Laras
    }
}
