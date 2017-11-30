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
        public FormSimulationScreen(Scenario s)
        {
            InitializeComponent();
            scenarioTest = s;

        }


        List<Panel> users = new List<Panel>();
        List<Customer> custs = new List<Customer>();
        //List<Seat> seatList = new List<Seat>();

        private int x, y, height, width, row, col;
        private string alp;
        Random rand = new Random();
        
        int seatCounter = 0;

        public int randRow, randCol, randSpace;

        //int amount = 100 - 1;
        
        int amount;

        //int userspointLeft = 5;
        //int userspointTop = 0;
        private Door doorA;
        private Door doorB;
        
        //
        Scenario scenarioTest;
        Customer customer;
		private Seat[,] seatList2;
        
        decimal[] agecategory;
     
        private void FormLayoutTry1_Load(object sender, EventArgs e)
        {

            Hall hall1 = new Hall();
			hall1.ConfigHall();
			seatList2 = hall1.Seats();

            // maks amount = 56;
            //below is the amount of Customers, and percentage (customerCount) come from Form1
            amount = Convert.ToInt32(FormSimulation.customerCount * seatList2.GetLength(1) * seatList2.GetLength(0));
            //TryMubashirCode
            
            agecategory = scenarioTest.AssignCustomers(Convert.ToDecimal(amount));
            //agecategory[] = tempList2[];
            Label Elder = ((FormSimulation)this.Owner).lblEldersAmount;
            Elder.Text = Convert.ToString(Convert.ToString(agecategory[0]));


            //amount = 55;
            //x = 120;
            //y = 90;

            //height = 10;
            //width = 10;

            //row = 10;
            //col = 22;


            //alp = "";

            //Adding Door
            doorA = new Door(25, 9, 5, 0);
            Panel pDoorA = new Panel();
            pDoorA.Location = new Point(doorA.PosX, doorA.PosY);
            pDoorA.Size = new Size(doorA.DWidth, doorA.DHeight);
            pDoorA.BackColor = Color.Blue;
            this.Controls.Add(pDoorA);

            //Adding Door 2
            doorB = new Door(25, 9, 500, 0);
            Panel pDoorB = new Panel();
            pDoorB.Location = new Point(doorB.PosX, doorB.PosY);
            pDoorB.Size = new Size(doorB.DWidth, doorB.DHeight);
            pDoorB.BackColor = Color.Purple;
            this.Controls.Add(pDoorB);

            for (int i = 0; i < hall1.GetRow(); i++)
            {
                for(int j = 0; j < hall1.GetColumn(); j++)
                {
                    Panel p = new Panel();
                    p.Location = new Point(seatList2[i,j].PosX, seatList2[i,j].PosY);
                    p.Size = new Size(seatList2[i, j].SHeight, seatList2[i, j].SWidth);
                    p.BackColor = seatList2[i, j].SeatColor;
                    this.Controls.Add(p);
                }
            }
            
			//Adding Users
            for(int i = 0; i < amount; i++)
            {
                custs.Add(new Customer(i, Convert.ToInt32(amount)));
                custs[i].FindSeat();
            }

            for (int i = 0; i < amount; i++)
            {
                Panel pnlUser = new Panel();
                users.Add(pnlUser);
                users[i].Location = new Point((doorA.PosX + doorA.DWidth)/2, doorA.PosY);
                users[i].BackColor = Color.White;
                users[i].Size = new Size(9, 9);
                this.Controls.Add(users[i]);
                randSpace = rand.Next(11, 40);
                doorA.PosY -= randSpace;
            }
            newCustomer();
            

        }
        private void newCustomer()
        {
            for (int i = 0; i < amount; i++)
            {
                customer = new Customer(i, amount);
                custs.Add(customer);
                custs[i].FindSeat();
                for (int j = 0; j < custs.Count(); j++)
                {
                    if (custs[i].SeatRow == custs[j].SeatRow && custs[i].SeatCol == custs[j].SeatCol && i != j)
                    {
                        custs[i].FindSeat();
                        j = -1;
                    }
                }
                Console.WriteLine("custs: " + custs[i].SeatRow + "" + custs[i].SeatCol);
                Console.WriteLine("Seat: "+seatList2[custs[i].SeatRow, custs[i].SeatCol].SeatId);
            }
            //scenarioTest.AssignCustomers(customer.getCustomerAmount);
        }

        private void timerEmergency_Tick(object sender, EventArgs e)
        {
            //scenarioTest.EmergencySim(amount, users, custs, seatList2, doorA);
            for (int i = 0; i < amount; i++)
            {

                if (users[i].Top > (seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY - seatList2[custs[i].SeatRow,
                            custs[i].SeatCol].SHeight))
                {
                    users[i].Top--;
                }
                else
                {
                    if (users[i].Left > (doorA.PosX + doorA.DWidth) / 2)
                    {
                        users[i].Left--;
                    }
                    else
                    {
                        users[i].Top--;
                    }
                }
            }

        }

        private void timerSimulation_Tick(object sender, EventArgs e)
        {
            UserGoToSeats();
            
        }

        public void UserGoToSeats()

        {
            for (int i = 0; i < amount; i++)
            {
                if(users[i].Top < 50)
                {
                    users[i].Top++;
                }
                else
                {
                    if (seatList2[custs[i].SeatRow, custs[i].SeatCol].SeatId.Substring(0, 1).Equals("A"))
                    {
                        if(users[i].Left < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX)
                        {
                            users[i].Left++;
                        }
                        else
                        {
                            if(users[i].Top < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY)
                            {
                                users[i].Top++;
                            }
                            else
                            {
                                users[i].BringToFront();
                            }
                        }
                    }
                    else if (users[i].Left < 268 && users[i].Top == 50)
                    {
                        users[i].Left++;
                    }
                    else
                    {
                        if (users[i].Top < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY - seatList2[custs[i].SeatRow, custs[i].SeatCol].SHeight)
                        {
                            users[i].Top++;
                        }
                        else
                        {
                            if (users[i].Left < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX)
                                users[i].Left++;
                            else if (users[i].Left > seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX)
                            {
                                users[i].Left--;
                            }
                            else if (users[i].Left == seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX)
                            {
                                //timerSimulation.Stop();
                                while (users[i].Top < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY)
                                {
                                    users[i].Top++;
                                    if (users[i].Top == seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY)
                                    {
                                        users[i].BringToFront();
                                        seatCounter++;
                                        Label test = ((FormSimulation)this.Owner).lblFilledSeats;
                                        test.Text = Convert.ToString(seatCounter);
                                        //timerSimulation.Stop();
                                    }
                                }
                            }

                        }
                    }
                }
              
            }

        }

		//START-----Seats Arrangement
		//inner Circle
		private int middleRow1()
		{
			return (row / 2) - 1;
		}
		private int middleRow2()
		{
			return (row / 2) + 1;
		}
		private int middleCol1()
		{
			return (col / 2) - 2;
		}

		private int middleCol2()
		{
			return (col / 2) + 2;
		}
	}
}
