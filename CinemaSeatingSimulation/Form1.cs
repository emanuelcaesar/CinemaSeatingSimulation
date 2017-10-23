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

        public FormSimulation()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void FormSimulation_Load(object sender, EventArgs e)
        {

        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            //Call Form Layout
            FormLayoutTry1 formTry1 = new FormLayoutTry1();
            
            //this.pnlLayout1.Controls.Add(formTry1);
            formTry1.Show();
        }
    }
}
