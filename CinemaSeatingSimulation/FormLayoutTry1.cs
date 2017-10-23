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
    public partial class FormLayoutTry1 : Form
    {
        public FormLayoutTry1()
        {
            InitializeComponent();
        }

        List<Panel> users = new List<Panel>();

        private void FormLayoutTry1_Load(object sender, EventArgs e)
        {
           
            //Adding Users
            
            Panel pnlUser = new Panel();
            users.Add(pnlUser);
            //Point UsersLocation;
            //UsersLocation.X = 0;
            users[0].Location = new Point(0, 0);
            users[0].BackColor = Color.White;
            users[0].Size = new Size(10, 10);
            this.Controls.Add(users[0]);

            //Simulation Start
            timerSimulation.Start();
        }

        private void timerSimulation_Tick(object sender, EventArgs e)
        {
            //users[0].Left--;
            if(users[0].Top < seatA1.Top)
                users[0].Top++;
            else if(users[0].Top == seatA1.Top)
            {
                if (users[0].Left < seatA1.Left)
                    users[0].Left++;
                else if (users[0].Left == seatA1.Left)
                {
                    timerSimulation.Stop();
                    seatA1.BackColor = Color.Green;
                }
                    
            }
                
        }
    }
}
