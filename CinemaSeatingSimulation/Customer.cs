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
        private Door[,] doors;
        private Seat seatID;
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
            seatID = new Seat();
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

        public void SeatArrangement()
        {
            /*
            double middleCol = seatCol / 2;
            double middleRow = seatRow / 2;
            int from, to, col, row;
            */

            /* priority check: normal

           3 | 3 | 3 | 3 | 3
           3 | 2 | 2 | 2 | 3
           3 | 2 | 1 | 2 | 3
           3 | 2 | 2 | 2 | 3
           3 | 3 | 3 | 3 | 3

            example of 5*5 grid
            1 st priority: [3,3] -> col = Math.ceiling(seatCol/2); row = Math.ceiling(seatRow/2)
            2 nd priority: [2,2] | [2,3] | [2,4] | [3,4] | [4,4] | [4,3] | [4,2] | [3,2]
                -> col = Math.ceiling(seatCol/2) + (method a); row = Math.ceiling(seatRow/2) + (method a)
                from = -1; to = 1
                 int method a(int from, int to)
                 {
                    b = new Random.Next(from, to);
                    while(b!=from || b!=to)
                        b = new Random.Next(from, to);
                    return b;
                 }
            3 rd priority: using 2nd priority formula, from = -2; to = 2

            for(int i = 0; i < Math.ceiling(seatCol/2); i++)
            {
                from = -i
                to = i
                col = Math.ceiling(seatCol/2) + (method a(from, to));
                row = Math.ceiling(seatRow/2) + (method a(from, to));

                if (!seats[col,row] already occupied)
                {
                    seatID = seats[col,row].SeatID -> how to assign it?
                    i = Math.ceiling(seatCol/2); -> break the for statement
                }
            }

            */

            /* PROBLEMS:
                - need value of seatID whether it is filled or no -> boolean on each seatID (maybe)
                - seatID = seats[col,row].SeatID -> how to assign it?
                - disadvantage of formula: just for odd*odd grid that has the same col and row
            */


            /* priority check: child

           3 | 2 | 1 | 2 | 3
           3 | 2 | 2 | 2 | 3
           3 | 3 | 3 | 3 | 3
           4 | 4 | 4 | 4 | 4
           5 | 5 | 5 | 5 | 5

            example of 5*5 grid
            1 st priority: [1,3] -> col = i+1; row = Math.ceiling(seatRow/2)
            2 nd priority: 

                -> col = (i+1) + (method a); row = Math.ceiling(seatRow/2) + (method a)
                from = -1; to = 0
                 int method a(int from, int to)
                 {
                    b = new Random.Next(from, to);
                    while(b!=from || b!=to)
                        b = new Random.Next(from, to);
                    return b;
                 }
            3 rd priority: using 2nd priority formula, from = -2; to = 0
            for(int i = 0; i < Math.ceiling(seatCol/2); i++)
            {
                from = -i;
                to = 0;
                col = (i+1) + (method a(from, to));
                row = Math.ceiling(seatRow/2) + (method a(from, to));

                if (!seats[col,row] already occupied)
                {
                    seatID = seats[col,row].SeatID -> how to assign it?
                    i = Math.ceiling(seatCol/2); -> break the for statement
                }
            }

            */

            /*
            for (int i = 0; i < Math.Ceiling(middleCol); i++)
                {
                    from = -i;
                    if (demographic == "child")
                    {
                        to = 0;
                        col = Convert.ToInt32((i + 1) + (A(from, to)));
                    }
                    else
                    {
                        to = i;
                        col = Convert.ToInt32(Math.Ceiling(middleCol) + (A(from, to)));
                    }
                    row = Convert.ToInt32(Math.Ceiling(middleRow) + (A(from, to)));

                    if (seats[col, row] == null)
                    {
                        seatID = seats[col, row];
                        i = Convert.ToInt32(Math.Ceiling(middleCol));
                    }
                }
                */

            int col, row;

            // Ring 1
            if (customerID < (customerAmount/27))
            {
                row = rand.Next(middleRow1(), middleRow2());
                col = rand.Next(middleCol1(), middleCol2());
            }

            // Ring 2
            else if (customerID < (customerAmount/5))
            {
                row = rand.Next(middleRow1(), middleRow2()+2);
                col = rand.Next(middleCol1() - 2, middleCol2() + 2);
            }

            // Ring 3
            else if (customerID < (customerAmount/3))
            {
                row = rand.Next(middleRow1(), middleRow2() + 4);
                col = rand.Next(middleCol1() - 5, middleCol2() + 5);
            }

            // Ring 4
            else if (customerID < (customerAmount / 2))
            {
                row = rand.Next(middleRow1() - 3, middleRow2() -1);
                col = rand.Next(middleCol1() - 5, middleCol2() + 5);
            }

            // Ring 5
            else
            {
                row = rand.Next(0, seatRow);
                col = rand.Next(0, seatCol);
            }

            seatID.PosX = seats[row, col].PosX;
            seatID.PosY = seats[row, col].PosY;
        }

        public void PathFinding(int start, int goal)
        {
            
        }

        public void DoorPlacement()
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
