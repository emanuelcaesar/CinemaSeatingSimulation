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
<<<<<<< HEAD
		private Seat[,] seats;
		private Door[,] doors;
=======
        private Seat[,] seats;
        private Door[] doors;
>>>>>>> Laras

		private string alp;

		//seats position and characteristic
		private int x, y, 
			height, width, 
			row, col;
		//Amount of custumer
		double amount;

		private Door doorA;
		private Door doorB;
		private Scenario scenarioTest;
		public void ConfigHall()
        {
			x = 120;
			y = 90;

			height = 10;
			width = 10;

			row = 10;
			col = 22;
			amount = FormSimulation.customerCount * col * row;

			alp = "";
			seats = new Seat[row, col];
			scenarioTest = new Scenario();

			//Creating Seats Map

			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
				{
					switch (i)
					{
						case 0:
							alp = "A";
							break;
						case 1:
							alp = "B";
							break;
						case 2:
							alp = "C";
							break;
						case 3:
							alp = "D";
							break;
						case 4:
							alp = "E";
							break;
						case 5:
							alp = "F";
							break;
						case 6:
							alp = "G";
							break;
						case 7:
							alp = "H";
							break;
						case 8:
							alp = "I";
							break;
						case 9:
							alp = "J";
							break;
					}
					if (j == (col / 2))
					{
						x = x + 20;
					}
					//seatList.Add(new Seat(alp+""+(j + 1), x, y, height, width, seatColor));
					seats[i, j] = new Seat(alp + "" + (j + 1), x, y, height, width);
					x = x + 13;
					Console.WriteLine(seats[i, j]);
				}
				x = 120;
				y = y + 20;
			}
		}

        public int GetSeatAmount()
        {
            return seatAmount;
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
