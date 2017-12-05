using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    public class Scenario
    {
        private int scenarioID, ageRating;
        string genre;
        string time;
        int age;
        //string ageCategory;
        string options;
        System.Drawing.Image userpanel = (System.Drawing.Image)new System.Drawing.Bitmap(@"user.png");

        private Seat[,] seatList2;
        private Door[] doors;
        private Hall hall1;
        System.Windows.Forms.Panel p;

        List<System.Windows.Forms.Panel> users = new List<System.Windows.Forms.Panel>();
        List<Customer> custs = new List<Customer>();

        private int x, y, height, width, row, col;
        private string alp;
        Random rand = new Random();

        int seatCounter = 0;

        public int randRow, randCol, randSpace;
        private int amount;

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

        public void ChooseAge(int age2)
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

        public void CalcAmountofCustomers(string time, string genre, string ageRating) //1
        {
            if (time == "Evening (18:00)" || time == "Night (21:00)")
            {
                if (genre == "Horror" && ageRating == "18+")
                {
                    customerCount = GetRandomNumber(0.7, 0.75); //percentage
                }
                else if (genre == "Romance")
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
                if (genre == "Horror")
                {
                    customerCount = GetRandomNumber(0, 0.1);
                }
                else if (genre == "Animation")
                {
                    customerCount = GetRandomNumber(0.4, 0.6);
                }
                else
                {
                    customerCount = GetRandomNumber(0.1, 0.3);
                }
            }
            ChooseAge(age);
            ChooseGenre(genre);
            ChooseTime(time);
        }

        public void SetHall(string hallString)
        {
            if (hallString == "A") hall1 = new HallA();
            else if (hallString == "B") hall1 = new HallB();
            else if (hallString == "C") hall1 = new HallC();
        }

        public decimal[] AssignCustomers(decimal amount) //2
        {
            decimal[] tempListofPeople = new decimal[4];
<<<<<<< HEAD
            if(genre == "Horror" || amount <= 30)
            {
                tempListofPeople[0] =  10; //templist[0] is elder for example
                System.Windows.Forms.MessageBox.Show(genre);
                //Console.WriteLine(this.genre);
                //tempList.Add(amountofselectedcustomer);
                //amountofselectedcustomer = 70 & *amount;     
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
                Console.WriteLine("custs: " + custs[i].SeatRow + "" + custs[i].SeatCol);
                Console.WriteLine("Seat: " + seatList2[custs[i].SeatRow, custs[i].SeatCol].SeatId);
            }
        }

        public void GenerateCust() //4
        {
            for (int i = 0; i < amount; i++)
            {
                System.Windows.Forms.Panel pnlUser = new System.Windows.Forms.Panel();
                users.Add(pnlUser);
                users[i].Location = new System.Drawing.Point((doors[0].PosX + doors[0].DWidth) / 2, doors[0].PosY);
                //users[i].BackColor = System.Drawing.Color.White;
                users[i].Size = new System.Drawing.Size(9, 9);
                users[i].BackgroundImage = userpanel;
                fss.Controls.Add(users[i]);
                randSpace = rand.Next(11, 40);
                doors[0].PosY -= randSpace;
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

        public void EmergencySim()
        {
            for (int i = 0; i < amount; i++)
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
                    }
                }
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
                users[i].Size = new System.Drawing.Size(9, 9);
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
            customer.goToSeat(this.amount, this.users, this.seatList2, this.custs, this.fss);
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
    }
}
