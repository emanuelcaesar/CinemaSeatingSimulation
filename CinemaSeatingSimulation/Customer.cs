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

        public Customer(int customerID, int customerAmount)
        {
            // Customer ID & Customer Amount
            this.customerID = customerID;
            this.customerAmount = customerAmount;

            // instantiate hall object to access the Seats and Doors
            hall = new HallC();
            hall.ConfigHall();
            seats = hall.Seats();
            doors = hall.Doors();

            // get the column and Row of the seats[,]
            seatRowCust = seats.GetLength(0) - 1; // get length from the first column [*,]
            seatColCust = seats.GetLength(1); // get length from the second column [,*]

            rand = new Random();
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
}
