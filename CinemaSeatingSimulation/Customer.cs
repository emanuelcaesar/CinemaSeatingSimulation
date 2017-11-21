using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Customer
    {
        int customerId, age, speed, seatRow, seatCol, randRow, randCol;
        string demographic;

        Random rand = new Random();

        private int middleRow1()
        {
            return (seatRow / 2) - 1;
        }
        private int middleRow2()
        {
            return (seatRow / 2) + 1;
        }

        


        public Customer() { }

        public Customer(int seatRow, int seatCol)
        {
            
        }
        private int middleCol1()
        {
            return (seatCol / 2) - 2;
        }

        private int middleCol2()
        {
            return (seatCol / 2) + 2;
        }


        /*
        double middleCol = seatCol / 2;
        double middleRow = seatRow / 2;
        int from, to, col, row;asdadasds
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
        public int Age
        {
            get { return this.age; }
            set { age = value; }
        }
    }
}
