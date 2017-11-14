﻿using System;
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
            countCustomer();
            if(!(comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == ""))
            {
                btnClicked = true;

                //Call Form Layout
                FormLayoutTry1 formTry1 = new FormLayoutTry1();

                //this.pnlLayout1.Controls.Add(formTry1);
                formTry1.Show();
            }
            else
            {
                MessageBox.Show("Please fill the scenario!");
            }
        }


        private void btnEmergency_Click(object sender, EventArgs e)
        {
            if (!(comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == ""))
            {
                if (btnClicked)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
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
    }
}
