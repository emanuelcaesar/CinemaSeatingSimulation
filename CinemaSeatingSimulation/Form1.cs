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
            countCustomer();
            if(!(cbGenre.Text == "" || cbAge.Text == "" || cbTime.Text == ""))
            {
                btnClicked = true;

                //Call Form Layout
                FormLayoutTry1 formTry1 = new FormLayoutTry1();

                //pnlLayout1.Controls.Add(formTry1);
                formTry1.Show();
            }
            else
            {
                MessageBox.Show("Please fill the scenario!");
            }
        }


        private void btnEmergency_Click(object sender, EventArgs e)
        {
            if (!(cbGenre.Text == "" || cbAge.Text == "" || cbTime.Text == ""))
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
            if (cbTime.Text == "Evening (18:00)" || cbTime.Text == "Night (21:00)")
            {
                if (cbGenre.Text == "Horror" && cbAge.Text == "18+")
                {
                    customerCount = GetRandomNumber(0.7, 0.75);
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
    }
}
