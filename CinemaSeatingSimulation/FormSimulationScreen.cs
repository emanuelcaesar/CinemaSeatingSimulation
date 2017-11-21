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
        Seat[,] seatList2;
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

        private void FormLayoutTry1_Load(object sender, EventArgs e)
        {

            //Adding Seats Position
            /*
            Seat seatB1 = new Seat("B1", 120, 120);
            Seat seatB2 = new Seat("B2", 133, 120);
            Seat seatB3 = new Seat("B3", 146, 120);
            Seat seatB4 = new Seat("B4", 159, 120);
            Seat seatB5 = new Seat("B5", 172, 120);
            Seat seatB6 = new Seat("B6", 185, 120);
            Seat seatB7 = new Seat("B7", 198, 120);
            Seat seatB8 = new Seat("B8", 211, 120);
            Seat seatB9 = new Seat("B9", 224, 120);
            Seat seatB10 = new Seat("B10", 237, 120);

            Seat seatB11 = new Seat("B11", 263, 120);
            Seat seatB12 = new Seat("B12", 276, 120);
            Seat seatB13 = new Seat("B13", 289, 120);
            Seat seatB14 = new Seat("B14", 302, 120);
            Seat seatB15 = new Seat("B15", 315, 120);
            Seat seatB16 = new Seat("B16", 328, 120);
            Seat seatB17 = new Seat("B17", 341, 120);
            Seat seatB18 = new Seat("B18", 354, 120);
            Seat seatB19 = new Seat("B19", 367, 120);
            Seat seatB20 = new Seat("B20", 380, 120);

            Seat seatC1 = new Seat("C1", 120, 140);
            Seat seatC2 = new Seat("C2", 133, 140);
            Seat seatC3 = new Seat("C3", 146, 140);
            Seat seatC4 = new Seat("C4", 159, 140);
            Seat seatC5 = new Seat("C5", 172, 140);
            Seat seatC6 = new Seat("C6", 185, 140);
            Seat seatC7 = new Seat("C7", 198, 140);
            Seat seatC8 = new Seat("C8", 211, 140);
            Seat seatC9 = new Seat("C9", 224, 140);
            Seat seatC10 = new Seat("C10", 237, 140);

            Seat seatC11 = new Seat("C11", 263, 140);
            Seat seatC12 = new Seat("C12", 276, 140);
            Seat seatC13 = new Seat("C13", 289, 140);
            Seat seatC14 = new Seat("C14", 302, 140);
            Seat seatC15 = new Seat("C15", 315, 140);
            Seat seatC16 = new Seat("C16", 328, 140);
            Seat seatC17 = new Seat("C17", 341, 140);
            Seat seatC18 = new Seat("C18", 354, 140);
            Seat seatC19 = new Seat("C19", 367, 140);
            Seat seatC20 = new Seat("C20", 380, 140);

            Seat seatD1 = new Seat("D1", 120, 160);
            Seat seatD2 = new Seat("D2", 133, 160);
            Seat seatD3 = new Seat("D3", 146, 160);
            Seat seatD4 = new Seat("D4", 159, 160);
            Seat seatD5 = new Seat("D5", 172, 160);
            Seat seatD6 = new Seat("D6", 185, 160);
            Seat seatD7 = new Seat("D7", 198, 160);
            Seat seatD8 = new Seat("D8", 211, 160);
            Seat seatD9 = new Seat("D9", 224, 160);
            Seat seatD10 = new Seat("D10", 237, 160);
        
            Seat seatD11 = new Seat("D11", 263, 160);
            Seat seatD12 = new Seat("D12", 276, 160);
            Seat seatD13 = new Seat("D13", 289, 160);
            Seat seatD14 = new Seat("D14", 302, 160);
            Seat seatD15 = new Seat("D15", 315, 160);
            Seat seatD16 = new Seat("D16", 328, 160);
            Seat seatD17 = new Seat("D17", 341, 160);
            Seat seatD18 = new Seat("D18", 354, 160);
            Seat seatD19 = new Seat("D19", 367, 160);
            Seat seatD20 = new Seat("D20", 380, 160);

            Seat seatE1 = new Seat("E1", 120, 180);
            Seat seatE2 = new Seat("E2", 133, 180);
            Seat seatE3 = new Seat("E3", 146, 180);
            Seat seatE4 = new Seat("E4", 159, 180);
            Seat seatE5 = new Seat("E5", 172, 180);
            Seat seatE6 = new Seat("E6", 185, 180);
            Seat seatE7 = new Seat("E7", 198, 180);
            Seat seatE8 = new Seat("E8", 211, 180);
            Seat seatE9 = new Seat("E9", 224, 180);
            Seat seatE10 = new Seat("E10", 237, 180);

            Seat seatE11 = new Seat("E11", 263, 180);
            Seat seatE12 = new Seat("E12", 276, 180);
            Seat seatE13 = new Seat("E13", 289, 180);
            Seat seatE14 = new Seat("E14", 302, 180);
            Seat seatE15 = new Seat("E15", 315, 180);
            Seat seatE16 = new Seat("E16", 328, 180);
            Seat seatE17 = new Seat("E17", 341, 180);
            Seat seatE18 = new Seat("E18", 354, 180);
            Seat seatE19 = new Seat("E19", 367, 180);
            Seat seatE20 = new Seat("E20", 380, 180);
            */

            

            x = 120;
            y = 90;

            height = 10;
            width = 10;

            row = 10;
            col = 22;
            amount = FormSimulation.customerCount * col * row;

            alp = "";
            seatList2 = new Seat[row, col];
            scenarioTest = new Scenario();

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

            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    switch (i)
                    {
                        case 0:
                            alp = "A";
                            break;
                        case 1:
                            alp = "B";
                            break;
                        case 2:
                            alp = "C";
                            break;
                        case 3:
                            alp = "D";
                            break;
                        case 4:
                            alp = "E";
                            break;
                        case 5:
                            alp = "F";
                            break;
                        case 6:
                            alp = "G";
                            break;
                        case 7:
                            alp = "H";
                            break;
                        case 8:
                            alp = "I";
                            break;
                        case 9:
                            alp = "J";
                            break;
                    }
                    if(j == (col/2))
                    {
                        x = x + 20;
                    }
                    //seatList.Add(new Seat(alp+""+(j + 1), x, y, height, width, seatColor));
                    seatList2[i, j] = new Seat(alp + "" + (j + 1), x, y, height, width, Color.Maroon);
                    x = x + 13;
                    Console.WriteLine(seatList2[i, j]);
                }
                x = 120;
                y = y + 20;
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
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Panel p = new Panel();
                    p.Location = new Point(seatList2[i, j].PosX, seatList2[i, j].PosY);
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
            
            UserGoToSeats(); //Laras & Caesar
        }

        public void UserGoToSeats()
        {


            //Try1 Caesar
            
            /*
            for (int i = 0; i <= amount; i++)
            {
                if (users[i].Top < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY - seatList2[custs[i].SeatRow, custs[i].SeatCol].SHeight)
                {
                    users[i].Top++;
                }
                else if (users[i].Top == seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY - seatList2[custs[i].SeatRow, custs[i].SeatCol].SHeight)
                {
                    if (users[i].Left < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX)
                        users[i].Left++;

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
                            }
                        }
                    }

                }
            }
            */






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
