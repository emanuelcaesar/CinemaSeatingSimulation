using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class HallC : Hall
    {
        public override void ConfigHall()
        {
<<<<<<< HEAD
            x = 185;
=======
            x = 173;
>>>>>>> origin/Laras
            y = 70;

            height = 10;
            width = 10;

            row = 10;
            col = 14;

            alp = "";
            seatAmount = row * col;
            seats = new Seat[row, col];

            doors = new Door[2];
            doorAmount = doors.Length;

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
<<<<<<< HEAD
=======
                    if(j == (col / 2))
                    {
                        x = x + 20;
                    }
>>>>>>> origin/Laras
                    if (i > 0 && i % 2 == 0 && j == 0)
                    {
                        y = y + 5;
                    }
                    seats[i, j] = new Seat(alp + "" + (j + 1), x, y, height, width);
                    x = x + 13;
                }
<<<<<<< HEAD
                x = 185;
=======
                x = 173;
>>>>>>> origin/Laras
                y = y + 20;
            }

            doors[0] = new Door(25, 9, 5, 0);
            doors[1] = new Door(25, 9, 500, 0);
        }
    }
}
