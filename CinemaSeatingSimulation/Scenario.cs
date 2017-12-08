﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    public class Scenario
    {
        System.Drawing.Image userlaras = (System.Drawing.Image)new System.Drawing.Bitmap(@"userlaras.png");
        private int scenarioID, ageRating;
        string genre;
        string time;
        string age;
        //string ageCategory;
        string options;
<<<<<<< HEAD
		private bool[,] mapHall;
=======
        //System.Drawing.Image userpanel = (System.Drawing.Image)new System.Drawing.Bitmap(@"user.png");
>>>>>>> master

        private Seat[,] seatList2;
        private Door[] doors;
        private Hall hall1;
        System.Windows.Forms.Panel p;

        public List<System.Windows.Forms.Panel> users = new List<System.Windows.Forms.Panel>();
        List<Customer> custs = new List<Customer>();

        private int x, y, height, width, row, col;
        private string alp;
        Random rand = new Random();

        int seatCounter = 0;

        public int randRow, randCol, randSpace;
        public static int amount;
        private int z;

        //int userspointLeft = 5;
        //int userspointTop = 0;
        private Door doorA;
        private Door doorB;
        Customer customer;
        //private 

        decimal[] agecategory;
        FormSimulationScreen fss;

        public static double customerCount;

        public Scenario()
        {

        }

        //we gonna join all the chooses
        public void ChooseGenre(string genre2)
        {
            this.genre = genre2;
        }

        public void ChooseAge(string age2)
        {
            this.age = age2;
        }

        public void ChooseTime(string time2)
        {
            this.time = time2;
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        public void CalcAmountofCustomers(string time3, string genre3, string ageRating3) //1
        {
            if (time == "Evening (18:00)" || time == "Night (21:00)")
            {
                if (genre3 == "Horror" && ageRating3 == "18+")
                {
                    customerCount = GetRandomNumber(0.7, 0.75); //percentage
                }
                else if (genre3 == "Romance")
                {
                    customerCount = GetRandomNumber(0.6, 0.8);
                }
                else
                {
                    customerCount = GetRandomNumber(0.5, 0.7);
                }
            }
            else
            {
                if (genre3 == "Horror")
                {
                    customerCount = GetRandomNumber(0, 0.1);
                }
                else if (genre3 == "Animation")
                {
                    customerCount = GetRandomNumber(0.4, 0.6);
                }
                else
                {
                    customerCount = GetRandomNumber(0.1, 0.3);
                }
            }
            ChooseAge(ageRating3);
            ChooseGenre(genre3);
            ChooseTime(time3);
        }

        public void SetHall(string hallString)
        {
            if (hallString == "A") hall1 = new HallA();
            else if (hallString == "B") hall1 = new HallB();
            else if (hallString == "C") hall1 = new HallC();
        }


        //afternoon(14:00)
        //evening(18:00)
        //night(21:00)

        public decimal[] AssignCustomers(decimal amount2) //2
        {
            decimal[] tempListofPeople = new decimal[4];
            if(age == "18+")
            {
                if (genre == "Horror")
                {
                    if (time == "Morning (10:00)")
                    {
                        tempListofPeople[0] = ((100 * amount2) / 100);
                    }
                    else if (time == "Afternoon (14:00)")
                    {
                        tempListofPeople[0] = ((70 * amount2) / 100);
                        tempListofPeople[2] = ((30 * amount2) / 100);
                    }
                    else if (time == "Evening (21:00)")
                    {
                        tempListofPeople[0] = ((100 * amount2) / 100);
                    }
                }
                else if (genre == "Comedy")
                {
                    if (time == "Morning (10:00)")
                    {
                        tempListofPeople[0] = ((100 * amount2) / 100);
                    }
                    else if (time == "Afternoon (14:00)")
                    {
                        tempListofPeople[0] = ((70 * amount2) / 100);
                        tempListofPeople[2] = ((30 * amount2) / 100);
                    }
                    else if (time == "Evening (21:00)")
                    {
                        tempListofPeople[0] = ((100 * amount2) / 100);
                    }
                }
                else if (genre == "Romance")
                {
                    if (time == "Morning (10:00)")
                    {
                        tempListofPeople[0] = ((100 * amount2) / 100);
                    }
                    else if (time == "Afternoon (14:00)")
                    {
                        tempListofPeople[0] = ((60 * amount2) / 100);
                        tempListofPeople[2] = ((40 * amount2) / 100);
                    }
                    else if (time == "Evening (21:00)")
                    {
                        tempListofPeople[0] = ((100 * amount2) / 100);
                    }
                }
                else if (genre == "Action")
                {
                    if (time == "Morning (10:00)")
                    {
                        tempListofPeople[3] = ((100 * amount2) / 100);
                    }
                    else if (time == "Afternoon (14:00)")
                    {
                        tempListofPeople[0] = ((60 * amount2) / 100);
                        tempListofPeople[3] = ((40 * amount2) / 100);
                    }
                    else if (time == "Evening (21:00)")
                    {
                        tempListofPeople[0] = ((100 * amount2) / 100);
                    }
                }

            }
            
            return tempListofPeople;
        }

        public void AssignCustSeats() //3
        {
            for (int i = 0; i < amount; i++)
            {
                customer = new Customer(i, amount, hall1);
                custs.Add(customer);
                custs[i].FindSeat();
                for (int j = 0; j < custs.Count(); j++)
                {
                    if (custs[i].SeatRow == custs[j].SeatRow && custs[i].SeatCol == custs[j].SeatCol && i != j)
                    {
                        custs[i].FindSeat();
                        j = -1;
                    }
                }
                //Console.WriteLine("custs: " + custs[i].SeatRow + "" + custs[i].SeatCol);
                //Console.WriteLine("Seat: " + seatList2[custs[i].SeatRow, custs[i].SeatCol].SeatId);
            }
        }

        public void StartSim(FormSimulationScreen fss)
        {

            //all the code from formload

            this.fss = fss;
            hall1.ConfigHall();
            seatList2 = hall1.Seats();
            doors = hall1.Doors();
            amount = Convert.ToInt32(customerCount * seatList2.GetLength(1) * seatList2.GetLength(0));

            AssignCustSeats();

            for (int i = 0; i < hall1.GetRow(); i++)
            {
                for (int j = 0; j < hall1.GetColumn(); j++)
                {
                    System.Windows.Forms.Panel p = new System.Windows.Forms.Panel();
                    p.Location = new System.Drawing.Point(seatList2[i, j].PosX, seatList2[i, j].PosY);
                    p.Size = new System.Drawing.Size(seatList2[i, j].SHeight, seatList2[i, j].SWidth);
                    p.BackColor = seatList2[i, j].SeatColor;

                    //System.Windows.Forms.Label l = new System.Windows.Forms.Label();
                    //l.Text = seatList2[i, j].SeatId;
                    //l.Font = new System.Drawing.Font("Arial", 4);
                    //l.TextAlign = System.Drawing.ContentAlignment.TopLeft;
#if DEBUG
                    p.Controls.Add(addlabel("Seats", i, j));
#endif
                    //Console.WriteLine(seatList2[i, j]);
                    fss.Controls.Add(p);
                }
            }

            for (int i = 0; i < hall1.GetDoorAmount(); i++)
            {
                System.Windows.Forms.Panel p = new System.Windows.Forms.Panel();
                p.Location = new System.Drawing.Point(doors[i].PosX, doors[i].PosY);
                p.Size = new System.Drawing.Size(doors[i].DWidth, doors[i].DHeight);
                p.BackColor = System.Drawing.Color.Purple;
                fss.Controls.Add(p);
            }
            GenerateCust();
        }

        public void GenerateCust() //4
        {
            for (int i = 0; i < amount; i++)
            {
                System.Windows.Forms.Panel pnlUser = new System.Windows.Forms.Panel();
                users.Add(pnlUser);
                users[i].Location = new System.Drawing.Point((doors[0].PosX + doors[0].DWidth) / 2, doors[0].PosY);
                users[i].BackColor = System.Drawing.Color.White;
                users[i].BackgroundImage = userlaras;
                users[i].Size = new System.Drawing.Size(9, 9);

                //System.Windows.Forms.Label lblcus = new System.Windows.Forms.Label();
                //lblcus.Text = seatList2[custs[i].SeatRow, custs[i].SeatCol].SeatId;
                //lblcus.Font = new System.Drawing.Font("Arial", 4);
                //lblcus.ForeColor = System.Drawing.Color.Black;
#if DEBUG
                //users[i].Controls.Add(addlabel("Customer", i, 0));
#endif
                fss.Controls.Add(users[i]);
                randSpace = rand.Next(11, 40);
                doors[0].PosY -= randSpace;
            }
        }

        public void EmergencySim()
        {
            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < amount; j++)
                {
                    if ((seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX + seatList2[custs[i].SeatRow, custs[i].SeatCol].SWidth + 10) >= (seatList2[custs[j].SeatRow, custs[j].SeatCol].PosX)
                                && (seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX + 10) <= (seatList2[custs[j].SeatRow, custs[j].SeatCol].PosX + seatList2[custs[j].SeatRow, custs[j].SeatCol].SWidth)
                                && (seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY + seatList2[custs[i].SeatRow, custs[i].SeatCol].SHeight + 10) >= (seatList2[custs[j].SeatRow, custs[j].SeatCol].PosY)
                                && (seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY + 10) <= (seatList2[custs[j].SeatRow, custs[j].SeatCol].PosY + seatList2[custs[j].SeatRow, custs[j].SeatCol].SHeight)
                                && i != j)
                    {
                        users[i].Top -= 0;
                        users[i].Left -= 0;
                    }
                    else
                    {
                        if (users[i].Top > (seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY - seatList2[custs[i].SeatRow,
                                custs[i].SeatCol].SHeight))
                        {
                            users[i].Top--;
                        }
                        else
                        {
                            if (users[i].Left > (doors[0].PosX + doors[0].DWidth) / 2)
                            {
                                users[i].Left--;
                            }
                            else
                            {
                                users[i].Top--;
                                if (users[i].Top == 9)
                                {
                                    //colls[h].ill--;
                                    z++;
                                    users[i].SendToBack();
                                }
                                if (users[i].Top == -3)
                                {
                                    //rowList--;
                                }
                                if (z == amount)
                                {
                                    z++;
                                    System.Windows.Forms.MessageBox.Show("Cinema is cleared");
                                }
                            }
                        }
                    }
                }
                //if (seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY == rows)
                //{
                //if (custs[i].SeatRow == h)
                //{
                //if (custs[i].SeatRow == rows)
                //{

                //}

                //if(rowList == 0)
                //{
                //    rows = custs[0].SeatRow;
                //    for (int j = 0; j < amount; j++)
                //    {
                //        if (users[j].Top > 9)
                //        {
                //            if (custs[j].SeatRow == rows)
                //            {
                //                rowList++;
                //            }
                //            else if (custs[j].SeatRow < rows)
                //            {
                //                rows = custs[j].SeatRow;
                //                rowList = 0;
                //            }
                //        }
                //    }
                //    i = -1;
                //}
            }
        }

        public void ResetSim()
        {
            //already in the form
        }

        public void SkipSim()
        {
            for (int i = 0; i < amount; i++)
            {
                System.Windows.Forms.Panel pnlUser = new System.Windows.Forms.Panel();
                users.Add(pnlUser);
                users[i].Location = new System.Drawing.Point(seatList2[custs[i].SeatRow, custs[i].SeatCol].PosX,
                    seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY);
                users[i].BackColor = System.Drawing.Color.White;
                users[i].Size = new System.Drawing.Size(11, 11);

                //System.Windows.Forms.Label lblcus = new System.Windows.Forms.Label();
                //lblcus.Text = seatList2[custs[i].SeatRow, custs[i].SeatCol].SeatId;
                //lblcus.Font = new System.Drawing.Font("Arial", 4);
                //lblcus.ForeColor = System.Drawing.Color.Black;
#if DEBUG
                users[i].Controls.Add(addlabel("Skip", i, 0));
#endif
                fss.Controls.Add(users[i]);
                users[i].BringToFront();
                System.Windows.Forms.Label seatsfiled = ((FormSimulation)fss.Owner).lblFilledSeats;
                seatsfiled.Text = Convert.ToString(i);
            }
        }

        public void ChooseHall()
        {
            //to choose which hall a b c, and iniate the hall
        }

        public void UserGoToSeat()
        {
            customer.goToSeat(amount, this.users, this.seatList2, this.custs, this.fss);
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

        private System.Windows.Forms.Label addlabel(String given, int i, int j)
        {
            String condition = given;
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            lbl.Font = new System.Drawing.Font("Arial", 4);

            if (condition == "Seats")
            {
                lbl.Text = seatList2[i, j].SeatId;
            }
            else if (condition == "Customer" || condition == "Skip")
            {
                lbl.ForeColor = System.Drawing.Color.Black;
                lbl.Text = seatList2[custs[i].SeatRow, custs[i].SeatCol].SeatId;
            }
            else lbl.Text = "";

            return lbl;
        }
    }
}
