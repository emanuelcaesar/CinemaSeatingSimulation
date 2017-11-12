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
        List<Panel> seats = new List<Panel>();
        int seatpointLeft = 100;
        int seatpointTop = 110;
        int userspointLeft = 0;
        int userspointTop = 0;
        int amount = 100-1;

        private void FormLayoutTry1_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = Convert.ToString(panel1.Size);


            //Adding Seats
            int rowCounter;
            int columnCounter = 0;
            for (int i = 0; i <= 100; i++)
            {
                if(i%10==0)
                {
                    columnCounter++;
                    seatpointTop = 110;
                    seatpointLeft += 15;
                    if (columnCounter == 5)
                    {
                        columnCounter = 0;
                        seatpointLeft += 40;

                    }

                }
               

                Panel pnlSeats = new Panel();
                seats.Add(pnlSeats);
                //Point UsersLocation;
                //UsersLocation.X = 0;

                
                seats[i].Left = seatpointLeft;
                seats[i].Top = seatpointTop;
                seats[i].Location = new Point(seatpointLeft, seatpointTop);
                

                seats[i].BackColor = Color.Red;
                seats[i].Size = new Size(6,6);
                this.Controls.Add(seats[i]);
                seatpointTop += 15;
            }
            /*
            //Adding Users
            for (int i=0; i<=amount; i++)
            {
                Panel pnlUser = new Panel();
                users.Add(pnlUser);
                //Point UsersLocation;
                //UsersLocation.X = 0;
                users[i].Location = new Point(userspointLeft, userspointTop);
                users[i].BackColor = Color.White;
                users[i].Size = new Size(10, 10);
                this.Controls.Add(users[i]);
                userspointTop -= 11;
                //userspointTop += 0;
            }
            */
            //Adding Users
            for (int i = 0; i <= amount; i++)
            {
                Panel pnlUser = new Panel();
                users.Add(pnlUser);
                //Point UsersLocation;
                //UsersLocation.X = 0;
                Random rnd = new Random();
                users[i].Location = new Point(userspointLeft, userspointTop);
                users[i].BackColor = Color.White;
                users[i].Size = new Size(2, 2);
                this.Controls.Add(users[i]);
                userspointTop -= 11;
                //userspointTop += 0;
            }


            //Simulation Start
            timerSimulation.Start();
        }

        private void timerSimulation_Tick(object sender, EventArgs e)
        {
            //Try1 Caesar
            for(int i=0; i<=amount; i++)
            {
                if (users[i].Top < seats[i].Top)
                {
                    users[i].Top++;
                }
                else if (users[i].Top == seats[i].Top)
                {
                    if (users[i].Left < seats[i].Left)
                        users[i].Left++;
                    else if (users[i].Left == seats[i].Left)
                    {
                        //timerSimulation.Stop();
                        seats[i].BackColor = Color.Green;
                    }

                }
            }
            //userspointTop += 11;


        }
    }
}
