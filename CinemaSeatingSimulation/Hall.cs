using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Hall
    {
<<<<<<< HEAD
        private int seatAmount, doorAmount, startingPosition;
=======
        private int x, y, height, width, row, col;
        private string alp;
        Random rand = new Random();

        public int randRow, randCol, randSpace;

        //int amount = 100 - 1;

        double amount;

        //int userspointLeft = 5;
        //int userspointTop = 0;
        private Door[] doorA;

        private int seatAmount, doorAmount, startingPosition;
        private Seat[,] seats;
        private Door[,] doors;

        public void ConfigHall()
        {
            int doorWidth = 25;
            int doorHeight = 9;
            doorA = new Door[4];
            doorA[0] = new Door(doorWidth, doorHeight, 5, 0);
            doorA[1] = new Door(doorWidth, doorHeight, 10, -5);
            doorA[2] = new Door(doorWidth, doorHeight, 50, -5);
            doorA[3] = new Door(doorWidth, doorHeight, 35, 5);

>>>>>>> Greg

        private Seat[,] seats;
        private Door[] doors;

<<<<<<< HEAD

		private string alp;
=======
                    if (j == (col / 2))
                    {
                        x = x + 20;
                    }
                    seats[i, j] = new Seat(alp + "" + (j + 1), x, y, height, width, System.Drawing.Color.Maroon);
                    x = x + 13;
                    Console.WriteLine(seats[i, j]);
                }
                x = 120;
                y = y + 20;
            }


        }
>>>>>>> Greg

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

<<<<<<< HEAD
        public Door[] Doors()
=======
        public Door[] door()
        {
            return this.doorA;

        }


        public Door[,] Doors()
>>>>>>> Greg
        {
            return this.doors;
        }

<<<<<<< HEAD
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
=======
        int hallNum;
        int seatingConfNum;

    }
}
>>>>>>> Greg
