using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Customer
    {
        private int customerID, speed, seatRow, seatCol, scenarioID, customerAmount, seatRowCust, seatColCust;
        private string demographic;
        private Hall hall;
        private Seat[,] seats;
        private Door[] doors;
        private Random rand;
        int seatCounter = 0;

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
                if (users[i].Top < 50)
                {
<<<<<<< HEAD
                    users[i].Top+= rand.Next(1,5);
=======
                    users[i].Top++;
>>>>>>> Feter2
                }
                else
                {
                    if (seatList2[custs[i].SeatRow, custs[i].SeatCol].SeatId.Substring(0, 1).Equals("A"))
                    {
                        if (users[i].Left < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX)
                        {
<<<<<<< HEAD
                            users[i].Left += rand.Next(1, 2);
=======
                            users[i].Left++;
>>>>>>> Feter2
                        }
                        else
                        {
                            if (users[i].Top < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY)
                            {
<<<<<<< HEAD
                                users[i].Top += rand.Next(1, 2);
=======
                                users[i].Top++;
>>>>>>> Feter2
                            }
                            else
                            {
                                users[i].BringToFront();
                            }
                        }
                    }
                    else if (users[i].Left < 268 && users[i].Top == 50)
                    {
<<<<<<< HEAD
                        users[i].Left += rand.Next(1, 2);
=======
                        users[i].Left++;
>>>>>>> Feter2
                    }
                    else
                    {
                        if (users[i].Top < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY - seatList2[custs[i].SeatRow, custs[i].SeatCol].SHeight)
                        {
<<<<<<< HEAD
                            users[i].Top += rand.Next(1, 2);
=======
                            users[i].Top++;
>>>>>>> Feter2
                        }
                        else
                        {
                            if (users[i].Left < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX)
<<<<<<< HEAD
                                users[i].Left += rand.Next(1, 2);
=======
                                users[i].Left++;
>>>>>>> Feter2
                            else if (users[i].Left > seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX)
                            {
                                users[i].Left--;
                            }
                            else if (users[i].Left == seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX)
                            {
                                //timerSimulation.Stop();
                                while (users[i].Top < seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY)
                                {
<<<<<<< HEAD
                                    users[i].Top += rand.Next(1, 2);
=======
                                    users[i].Top++;
>>>>>>> Feter2
                                    if (users[i].Top == seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY)
                                    {
                                        users[i].BringToFront();
                                        seatCounter++;
                                        System.Windows.Forms.Label test = ((FormSimulation)fss.Owner).lblFilledSeats;
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
    }

    

    //class Child : Customer
    //{

    //}
    //class Adult : Customer
    //{

    //}
    //class Seniors : Customer
    //{

    //}
    //class Teens : Customer
    //{

    //}
}
