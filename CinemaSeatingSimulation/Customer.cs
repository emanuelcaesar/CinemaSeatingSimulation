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
