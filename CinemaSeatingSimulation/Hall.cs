using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    abstract class Hall
    {
<<<<<<< HEAD
        protected int seatAmount, doorAmount, startingPosition;

        protected string alp;

        //seats position and characteristic
        protected int x, y,
            height, width,
            row, col;

        protected Seat[,] seats;
        protected Door[] doors;

=======
        protected int seatAmount, doorAmount;
        protected string alp;

        //seats position and characteristic
        protected int x, y,
            height, width,
            row, col;

        protected Seat[,] seats;
        protected Door[] doors;

>>>>>>> origin/Laras
        public abstract void ConfigHall();

        public int GetSeatAmount()
        {
            return seatAmount;
        }
        public int GetDoorAmount()
        {
            return doorAmount;
        }
        public Seat[,] Seats()
        {
            return this.seats;
        }

        public Door[] Doors()
        {
            return this.doors;
        }

		public int GetRow()
		{
			return row;
		}
		public int GetColumn()
		{
			return col;
		}
	}
}
