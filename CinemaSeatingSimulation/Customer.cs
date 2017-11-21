using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Customer
    {

        int seatRow, seatCol;
        public int randRow, randCol, randSpace;
        private int x, y, height, width, row, col;

        public Customer() {
          
        }

        public Customer(int seatRow, int seatCol)
        {
            this.seatRow = seatRow;
            this.seatCol = seatCol;
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
    }

    

    class Child : Customer
    {

    }
    class Adult : Customer
    {

    }
    class Seniors : Customer
    {

    }
    class Teens : Customer
    {

    }
}
