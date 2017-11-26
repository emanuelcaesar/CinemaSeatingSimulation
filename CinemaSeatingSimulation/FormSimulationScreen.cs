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


        List<Panel> users = new List<Panel>();
        List<Customer> custs = new List<Customer>();
        //List<Seat> seatList = new List<Seat>();

        private int x, y, height, width, row, col;
        private string alp;
        Random rand = new Random();

        public int randRow, randCol, randSpace;

        //int amount = 100 - 1;
        
        double amount;

        //int userspointLeft = 5;
        //int userspointTop = 0;
        private Door doorA;
        private Door doorB;
        private Scenario scenarioTest;
		private Seat[,] seatList2;
        private void FormLayoutTry1_Load(object sender, EventArgs e)
        {

            Hall hall1 = new Hall();
			hall1.ConfigHall();
			seatList2 = hall1.Seats();
            x = 120;
            y = 90;

            height = 10;
            width = 10;

            row = 10;
            col = 22;
            amount = FormSimulation.customerCount * col * row;

            alp = "";
            seatList2 = new Seat[row, col];

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

            /*
            for (int i = 0; i < seatList.Count; i++)
            {
                Panel p = new Panel();
                p.Location = new Point(seatList[i].PosX, seatList[i].PosY);
                p.Size = new Size(seatList[i].SHeight, seatList[i].SWidth);
                p.BackColor = seatList[i].SeatColor;
                this.Controls.Add(p);
            }
            */
            for (int i = 0; i < hall1.GetRow(); i++)
            {
                for(int j = 0; j < hall1.GetColumn(); j++)
                {
                    Panel p = new Panel();
                    p.Location = new Point(seatList2[i,j].PosX, seatList2[i, j].PosY);
                    p.Size = new Size(seatList2[i, j].SHeight, seatList2[i, j].SWidth);
                    p.BackColor = seatList2[i, j].SeatColor;
                    this.Controls.Add(p);
                }
            }
            
			//Adding Users
			/*
            Panel pnlUser = new Panel();
            //for (int i = 0; i < 20; i++) {
            randRow = rand.Next(0, row);
            randCol = rand.Next(0, col);

            users.Add(new Panel());
                users[0].Location = new Point(0, 0);
                users[0].BackColor = Color.White;
                users[0].Size = new Size(9, 9);
                this.Controls.Add(users[0]);

                //Simulation Start
                //z = i;
                timerSimulation.Start();
            // };
            //Point UsersLocation;
            //UsersLocation.X = 0;
            */

            //AddingUser
            //for (int i = 0; i <= amount; i++)
            //{
            //    randRow = rand.Next(0, row);
            //    randCol = rand.Next(0, col);
            //    custs.Add(new Customer(randRow, randCol));
            //}

            for (int i = 0; i <= amount; i++)
            {
                Panel pnlUser = new Panel();
                users.Add(pnlUser);
                //Point UsersLocation;
                //UsersLocation.X = 0;
                //Random rnd = new Random();
                users[i].Location = new Point((doorA.PosX + doorA.DWidth)/2, doorA.PosY);
                //users[i].Location = new Point(userspointLeft, userspointTop);
                users[i].BackColor = Color.White;
                users[i].Size = new Size(9, 9);
                this.Controls.Add(users[i]);
                //userspointTop -= 11;
                randSpace = rand.Next(11, 40);
                doorA.PosY -= randSpace;
                //userspointTop += 0;
            }
            newCustomer();
            

        }
        private void newCustomer()
        {
            Customer customers = new Customer(randRow, randCol);

            //List<int> availableCol = new List<int>(amount);
            //List<int> availableRow = new List<int>(amount);

            //var setCol = new HashSet<int>();
            //var setRow = new HashSet<int>();
            //var nums = new List<int>();

            int filling;
            for (filling = 0; filling <= amount; filling++)
            {
				//randCol = rand.Next(0, col);
				//randRow = rand.Next(0, row);
				//custs.Add(new Customer(randRow, randCol));

				seatArrangement(filling);
                custs.Add(new Customer(randRow, randCol));

                for (int j = 0; j < custs.Count(); j++) {
                    if (custs[filling].SeatRow == custs[j].SeatRow && custs[filling].SeatCol == custs[j].SeatCol && filling != j) {
                        seatArrangement(filling);
                        //custs.Add(new Customer(randRow, randCol));
                        custs[filling].SeatRow = randRow;
                        custs[filling].SeatCol = randCol;
                        j = -1;
                    }
                }
                
            }
        }

        private void timerEmergency_Tick(object sender, EventArgs e)
        {
           scenarioTest.EmergencySim(amount, users, custs, seatList2, doorA);
        }

        private void timerSimulation_Tick(object sender, EventArgs e)
        {
            //UserGoToSeats(); //Laras & Caesar
        }

        public void UserGoToSeats()
        {
            for (int i = 0; i <= amount; i++)
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
                                        //timerSimulation.Stop();
                                        //haga
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

        //Filling Seat
        public void seatArrangement(int filling)
        {
            if (filling < 8)
            {
                randRow = rand.Next(middleRow1(), middleRow2());
                randCol = rand.Next(middleCol1(), middleCol2());
            }
            else if (filling < 44)
            {
                randRow = rand.Next(4, 6);
                randCol = rand.Next(0, col);
                if (randCol < 10) randCol = rand.Next(0, 9);
                else if (randCol > 13) randCol = rand.Next(13, 22);
            }
            else if (filling < 88)
            {
                randRow = rand.Next(6, 8);
                randCol = rand.Next(0, col);
                if (randCol < 10) randCol = rand.Next(0, 9);
                else if (randCol > 13) randCol = rand.Next(13, 22);
                
            }
            else
            {
                randRow = rand.Next(0, row);
                randCol = rand.Next(0, col);
                //fillingSeats[randRow, randCol] = new Seat(randRow, randCol);
                //while (IsDup(fillingSeats[randRow, randCol], bookedSeats[randRow, randCol]))
                //{
                //	randRow = rand.Next(0, row);
                //	randCol = rand.Next(0, col);
                //}
                
            }
        }
		//END-----Seat Arrangement
		/*
        private void SeatPlacement(Seat s, Panel p)
        {
            p = new Panel();
            p.Location = new Point(s.PosX, s.PosY);
            p.Size = new Size(10, 10);
            p.BackColor = Color.Maroon;
            this.Controls.Add(p);

        }
        */
	}
}
