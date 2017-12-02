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

        Random rand = new Random();

        public int randRow, randCol, randSpace;

        //int amount = 100 - 1;
        
        int amount;

        //int userspointLeft = 5;
        //int userspointTop = 0;
        private Door doorA;
        private Door doorB;
        private Scenario scenarioTest;
		private Seat[,] seatList2;
        private Door[] doors;
        private void FormLayoutTry1_Load(object sender, EventArgs e)
        {

            Hall hall1 = new HallC();
			hall1.ConfigHall();
			seatList2 = hall1.Seats();
            doors = hall1.Doors();

            // maks amount = 56;
            amount = Convert.ToInt32(FormSimulation.customerCount * seatList2.GetLength(1) * seatList2.GetLength(0));
            
            //x = 120;
            //y = 90;

            //height = 10;
            //width = 10;

            //row = 10;
            //col = 22;
            

            //alp = "";
            
            ////Adding Door
            //doorA = new Door(25, 9, 5, 0);
            //Panel pDoorA = new Panel();
            //pDoorA.Location = new Point(doorA.PosX, doorA.PosY);
            //pDoorA.Size = new Size(doorA.DWidth, doorA.DHeight);
            //pDoorA.BackColor = Color.Blue;
            //this.Controls.Add(pDoorA);

            ////Adding Door 2
            //doorB = new Door(25, 9, 500, 0);
            //Panel pDoorB = new Panel();
            //pDoorB.Location = new Point(doorB.PosX, doorB.PosY);
            //pDoorB.Size = new Size(doorB.DWidth, doorB.DHeight);
            //pDoorB.BackColor = Color.Purple;
            //this.Controls.Add(pDoorB);

            for(int i = 0; i<hall1.GetDoorAmount(); i++)
            {
                Panel p = new Panel();
                p.Location = new Point(doors[i].PosX, doors[i].PosY);
                p.Size = new Size(doors[i].DWidth, doors[i].DHeight);
                p.BackColor = Color.Purple;
                this.Controls.Add(p);
            }

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
                    p.Location = new Point(seatList2[i,j].PosX, seatList2[i,j].PosY);
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

            for (int i = 0; i < amount; i++)
            {
                Panel pnlUser = new Panel();
                users.Add(pnlUser);
                //Point UsersLocation;
                //UsersLocation.X = 0;
                //Random rnd = new Random();
                users[i].Location = new Point((doors[0].PosX + doors[0].DWidth)/2, doors[0].PosY);
                //users[i].Location = new Point(userspointLeft, userspointTop);
                users[i].BackColor = Color.White;
                users[i].Size = new Size(9, 9);
                this.Controls.Add(users[i]);
                //userspointTop -= 11;
                randSpace = rand.Next(11, 40);
                doors[0].PosY -= randSpace;
                //userspointTop += 0;
            }
            newCustomer();
            

        }
        private void newCustomer()
        {
            //Customer customers = new Customer(randRow, randCol);

            //List<int> availableCol = new List<int>(amount);
            //List<int> availableRow = new List<int>(amount);

            //var setCol = new HashSet<int>();
            //var setRow = new HashSet<int>();
            //var nums = new List<int>();

            for (int i = 0; i < amount; i++)
            {
                //randCol = rand.Next(0, col);
                //randRow = rand.Next(0, row);
                //custs.Add(new Customer(randRow, randCol));

                //seatArrangement(filling);
                custs.Add(new Customer(i, amount));

                //for (int j = 0; j < custs.Count(); j++)
                //{
                //    if (custs[filling].SeatRow == custs[j].SeatRow && custs[filling].SeatCol == custs[j].SeatCol && filling != j)
                //    {
                //        seatArrangement(filling);
                //        //custs.Add(new Customer(randRow, randCol));
                //        custs[filling].SeatRow = randRow;
                //        custs[filling].SeatCol = randCol;
                //        j = -1;
                //    }
                //}

                custs[i].FindSeat();

                for (int j = 0; j < custs.Count(); j++)
                {
                    if (custs[i].SeatRow == custs[j].SeatRow && custs[i].SeatCol == custs[j].SeatCol && i != j)
                    {
                        custs[i].FindSeat();
                        //custs.Add(new Customer(randRow, randCol));
                        j = -1;
                    }
                }
                Console.WriteLine("custs: " + custs[i].SeatRow + "" + custs[i].SeatCol);
                Console.WriteLine("Seat: "+seatList2[custs[i].SeatRow, custs[i].SeatCol].SeatId);
            }
        }

        private void timerEmergency_Tick(object sender, EventArgs e)
        {
           scenarioTest.EmergencySim(amount, users, custs, seatList2, doors[0]);
        }

        private void timerSimulation_Tick(object sender, EventArgs e)
        {
            UserGoToSeats(); //Laras & Caesar
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
	}
}
