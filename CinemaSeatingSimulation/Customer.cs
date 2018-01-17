using System;
using System.Collections.Generic;

namespace CinemaSeatingSimulation
{
    abstract class Customer
    {
        protected int customerID, seatRow, seatCol, scenarioID, customerAmount, seatRowCust, seatColCust;
        protected string demographic;
        protected Hall hall;
        protected Seat[,] seats;
        protected Door[] doors;
        protected Random rand;
        protected int seatCounter = 0;
        protected int speed = 1;
        protected System.Drawing.Image userPict = (System.Drawing.Image)new System.Drawing.Bitmap(@"userLaras.png");
        FormSimulation fs;
        FormSimulationScreen fss;


        public Customer(int customerID, int customerAmount, Hall hallChosen)
        {
            // Customer ID & Customer Amount
            this.customerID = customerID;
            this.customerAmount = customerAmount;

            // instantiate hall object to access the Seats and Doors
            hall = hallChosen;
            hall.ConfigHall();
            seats = hall.Seats();
            doors = hall.Doors();

            // get the column and Row of the seats[,]
            seatRowCust = seats.GetLength(0); // get length from the first column [*,]
            seatColCust = seats.GetLength(1); // get length from the second column [,*]

            rand = new Random();

        }
        public Customer()
        {

        }

        public int SeatRow
        {
            get { return this.seatRow; }
            set { seatRow = value; }
        }

        public int SeatCol
        {
            get { return this.seatCol; }
            set { seatCol = value; }
        }

        public void goToSeat(int amount, List<System.Windows.Forms.Panel> users, Seat[,] seatList2, List<Customer> custs, FormSimulationScreen fss)
        {
            for (int i = 0; i < amount; i++)
            {
                if (users[i].Top < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY - seatList2[custs[i].SeatRow, custs[i].SeatCol].SHeight)
                {
                    if (i != 0 && users[i].Bottom >= users[i - 1].Top && users[i].Left >= users[i - 1].Left)
                    {
                        users[i].Top += 0;
                    }
                    else
                    {
                        users[i].Top += custs[i].Speed;
                    }
                }
                else
                {
                    if (users[i].Left < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX)
                        users[i].Left += 1;
                    else if (users[i].Left == seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX)
                    {
                        //fss.timerSimulation.Stop();
                       
                        while (users[i].Top < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY)
                        {
                            users[i].Top += 1;
                            if (users[i].Top == seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY)
                            {
                                users[i].BringToFront();
                                seatCounter++;
                                System.Windows.Forms.Label test = ((FormSimulation)fss.Owner).lblFilledSeats;
                                test.Text = Convert.ToString(seatCounter);
                                
                                //fss.timerSimulation.Stop();

                                if (i == amount - 1)
                                {
                                    FormSimulation.emergencyEnable = true;
                                    System.Windows.Forms.Timer timerSim = ((FormSimulation)fss.Owner).timer1;
                                    timerSim.Stop();
                                    //flag end timer when customer all seated
                                }
                            }
                        }
                    }

                }
            }
            

        }

        public void FindSeat()
        {

            int col, row;

            // Ring 1
            if (customerID < 8)
            {
                row = rand.Next(middleRow1(), middleRow2());
                col = rand.Next(middleCol1(), middleCol2());
            }
            // Ring 2
            else if (customerID < 32)
            {
                row = rand.Next(middleRow1(), middleRow2() + 2);
                col = rand.Next(middleCol1() - 2, middleCol2() + 2);
            }
            // Ring 3
            else if (customerID < 84)
            {
                row = rand.Next(middleRow1(), middleRow2() + 4);
                col = rand.Next(middleCol1() - 5, middleCol2() + 5);
            }
            // Ring 4
            else if (customerID < 126)
            {
                row = rand.Next(middleRow1() - 3, middleRow2() - 1);
                col = rand.Next(middleCol1() - 5, middleCol2() + 5);

            }
            else
            {
                row = rand.Next(0, seatRowCust);
                col = rand.Next(0, seatColCust);
            }
            seatRow = row;
            seatCol = col;
        }

        public int getCustomerAmount()
        {
            return customerAmount;
        }

        public void PathFinding(int start, int goal)
        {

        }
        public void FindDoor()
        {

        }
        private int middleRow1()
        {
            return (seatRowCust / 2) - 1;
        }
        private int middleRow2()
        {
            return (seatRowCust / 2) + 1;
        }
        private int middleCol1()
        {
            return (seatColCust / 2) - 2;
        }
        private int middleCol2()
        {
            return (seatColCust / 2) + 2;
        }
        
        public int Speed
        {
            get { return this.speed; }
        }
        public System.Drawing.Image UserPict
        {
            get { return this.userPict; }
        }
    }



    class Children : Customer
    {
        public Children(int customerID, int customerAmount, Hall hallChosen)
            : base(customerID, customerAmount, hallChosen)
        {
            speed = 2;
            userPict = (System.Drawing.Image)new System.Drawing.Bitmap(@"userChildren.png");
        }
    }
    class Student : Customer
    {
        public Student(int customerID, int customerAmount, Hall hallChosen)
            : base(customerID, customerAmount, hallChosen)
        {
            speed = 2;
            userPict = (System.Drawing.Image)new System.Drawing.Bitmap(@"userStudent.png");
        }
    }
    class Adult : Customer
    {
        public Adult(int customerID, int customerAmount, Hall hallChosen)
            : base(customerID, customerAmount, hallChosen)
        {
            speed = 1;
            userPict = (System.Drawing.Image)new System.Drawing.Bitmap(@"userAdult.png");
        }
    }
    class Elder : Customer
    {
        public Elder(int customerID, int customerAmount, Hall hallChosen)
            : base(customerID, customerAmount, hallChosen)
        {
            speed = 1;
            userPict = (System.Drawing.Image)new System.Drawing.Bitmap(@"userElder.png");
        }
    }
}
