using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Customer
    {
        Random rand = new Random();

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
        int seatRow, seatCol;
        public int randRow, randCol, randSpace;
        private int x, y, height, width, row, col;

        public Customer()
        {

        }

        public Customer(int seatRow, int seatCol)
        {
            this.seatRow = seatRow;
            this.seatCol = seatCol;
        }
    }

}
