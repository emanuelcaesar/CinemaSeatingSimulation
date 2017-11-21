using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Hall
    {

        private int seatAmount, doorAmount, startingPosition;
        private Seat[,] seats;
        private Door[,] doors;

        public void ConfigHall()
        {

        }

        public int GetSeatAmount()
        {
            return seatAmount;
        }
        public Seat[,] Seats()
        {
            return this.seats;
        }

        public Door[,] Doors()
        {
            return this.doors;
        }

        int hallNum;
        int seatingConfNum;

    }
}
