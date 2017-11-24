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
        private int[,] seats, doors;

        public void ConfigHall()
        {

        }

        public int GetSeatAmount()
        {
            return seatAmount;
        }
        public int[,] Seats()
        {
            return this.seats;
        }

        public int[,] Doors()
        {
            return this.doors;
        }
    }
}
