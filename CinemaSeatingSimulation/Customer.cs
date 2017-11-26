using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Customer
    {
        private int customerID, speed, seatRow, seatCol, scenarioID, customerAmount;
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
            hall = new Hall();
            seats = hall.Seats();
            doors = hall.Doors();

            // get the column and Row of the seats[,]
            seatCol = seats.GetLength(0); // get length from the first column [*,]
            seatRow = seats.GetLength(1); // get length from the second column [,*]

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
            if (customerID < (customerAmount / 27))
            {
                row = rand.Next(middleRow1(), middleRow2());
                col = rand.Next(middleCol1(), middleCol2());
            }

            // Ring 2
            else if (customerID < (customerAmount / 5))
            {
                row = rand.Next(middleRow1(), middleRow2() + 2);
                col = rand.Next(middleCol1() - 2, middleCol2() + 2);
            }

            // Ring 3
            else if (customerID < (customerAmount / 3))
            {
                row = rand.Next(middleRow1(), middleRow2() + 4);
                col = rand.Next(middleCol1() - 5, middleCol2() + 5);
            }

            // Ring 4
            else if (customerID < (customerAmount / 2))
            {
                row = rand.Next(middleRow1() - 3, middleRow2() - 1);
                col = rand.Next(middleCol1() - 5, middleCol2() + 5);
            }

            // Ring 5
            else
            {
                row = rand.Next(0, seatRow);
                col = rand.Next(0, seatCol);
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

        /*
        public int A(int from, int to)
        {
            int b = rand.Next(from, to);
            while (b != from || b != to)
            {
                b = rand.Next(from, to);
            }

            return b;
        }
        */

        private int middleRow1()
        {
            return (seatRow / 2) - 1;
        }
        private int middleRow2()
        {
            return (seatRow / 2) + 1;
        }
        private int middleCol1()
        {
            return (seatCol / 2) - 2;
        }

        private int middleCol2()
        {
            return (seatCol / 2) + 2;
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
