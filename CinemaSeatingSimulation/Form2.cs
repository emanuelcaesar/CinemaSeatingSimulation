using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSeatingSimulation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<Panel> users = new List<Panel>();
        List<Customer> custs = new List<Customer>();

        Seat[,] seatList2;
        private int x, y, height, width, row, col;
        private string alp;

        

        Random rand = new Random();
        public int randRow, randCol, randSpace;
        int amount = 100 - 1;

        private Door doorA;

        private void Form2_Load(object sender, EventArgs e)
        {
            x = 120;
            y = 90;

            height = 10;
            width = 10;

            row = 10;
            col = 22;

            alp = "";
            seatList2 = new Seat[row, col];

            //Adding Door
            doorA = new Door(25, 9, 5, 0);
            Panel pDoorA = new Panel();
            pDoorA.Location = new Point(doorA.PosX, doorA.PosY);
            pDoorA.Size = new Size(doorA.DWidth, doorA.DHeight);
            pDoorA.BackColor = Color.Blue;
            this.Controls.Add(pDoorA);

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

                    seatList2[i, j] = new Seat(alp + "" + (j + 1), x, y, height, width, Color.Maroon);
                    x = x + 13;
                }
                x = 120;
                y = y + 20;
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Panel p = new Panel();
                    p.Location = new Point(seatList2[i, j].PosX, seatList2[i, j].PosY);
                    p.Size = new Size(seatList2[i, j].SHeight, seatList2[i, j].SWidth);
                    p.BackColor = seatList2[i, j].SeatColor;
                    this.Controls.Add(p);
                }
            }

            newCustomer();

            for (int i = 0; i <= amount; i++)
            {
                Panel pnlUser = new Panel();
                users.Add(pnlUser);

                users[i].Location = new Point(seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX, 
                    seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY);

                users[i].BackColor = Color.White;
                users[i].Size = new Size(9, 9);
                
                this.Controls.Add(users[i]);
                users[i].BringToFront();

                pDoorA.BringToFront();
            }

            
            timer1.Start();
        }

        private void newCustomer()
        {

            Customer customers = new Customer(randRow, randCol);
            
            int filling, j;
            for (filling = 0; filling <= amount; filling++)
            {

                if (filling < 8)
                {
                    randRow = rand.Next(middleRow1(), middleRow2());
                    randCol = rand.Next(middleCol1(), middleCol2());
                    custs.Add(new Customer(randRow, randCol));
                }
                else if (filling < 44)
                {
                    randRow = rand.Next(4, 6);
                    randCol = rand.Next(0, col);
                    if (randCol < 10) randCol = rand.Next(0, 9);
                    else if (randCol > 13) randCol = rand.Next(13, 22);
                    custs.Add(new Customer(randRow, randCol));
                }
                else if (filling < 88)
                {
                    randRow = rand.Next(6, 8);
                    randCol = rand.Next(0, col);
                    if (randCol < 10) randCol = rand.Next(0, 9);
                    else if (randCol > 13) randCol = rand.Next(13, 22);
                    custs.Add(new Customer(randRow, randCol));
                }
                else
                {
                    randRow = rand.Next(0, row);
                    randCol = rand.Next(0, col);
                    custs.Add(new Customer(randRow, randCol));
                }

                for (j = 0; j < custs.Count(); j++)
                {
                    if (custs[filling].SeatRow == custs[j].SeatRow && custs[filling].SeatCol == custs[j].SeatCol && filling != j)
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
                        else
                        {
                            randCol = rand.Next(0, col);
                            randRow = rand.Next(0, row);
                        }

                        custs[filling].SeatRow = randRow;
                        custs[filling].SeatCol = randCol;
                        j = -1;
                    }
                }

            }
        }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= amount; i++)
            {
                
                if(users[i].Top > (seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY - seatList2[custs[i].SeatRow, custs[i].SeatCol].SHeight))
                {
                    users[i].Top--;
                }
                else
                {
                    if(users[i].Left > (doorA.PosX + doorA.DWidth) / 2)
                    {
                        users[i].Left--;
                    }
                    else
                    {
                        users[i].Top--;
                    }
                }
            }
        }
    }
}
