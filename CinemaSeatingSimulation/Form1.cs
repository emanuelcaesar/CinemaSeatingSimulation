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
        private double customerCount;


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

        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedText == "Evening(18:00)" && comboBox3.SelectedText == "Night(21:00)")
            {
                if (comboBox1.SelectedText == "Horror" && comboBox2.SelectedText == "18 +")
                {
                    customerCount = GetRandomNumber(0.7, 0.75);
                }
                else if (comboBox1.SelectedText == "Romance")
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
                if (comboBox1.SelectedText == "Horror") 
                {
                    customerCount = GetRandomNumber(0, 0.1);
                }
                else if (comboBox1.SelectedText == "Animation")
                {
                    customerCount = GetRandomNumber(0.4, 0.6);
                }
                else
                {
                    customerCount = GetRandomNumber(0.1, 0.3);
                }
            }

            //amount = customerCount * col * row



            //Call Form Layout
            FormLayoutTry1 formTry1 = new FormLayoutTry1();
            
            //this.pnlLayout1.Controls.Add(formTry1);
            formTry1.Show();
        }
    }
}
