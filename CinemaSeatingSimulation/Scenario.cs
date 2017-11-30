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
        private string genre;
        private DateTime time;
        private int age;
        //string ageCategory;
        string options;

        public void ChooseGenre(string genre2)
        {
            this.genre = genre2;
        }

        public string ChooseAge(int age)
        {
            //this.age = age;
            //if (this.age >=18)
            //{
            //    this.ageCategory = "Elder";
            //}
            return "hahaha";
        }

        public void ChooseTime()
        {
        
        }
  
        public decimal[] AssignCustomers(decimal amount)
        {
            decimal[] tempList = new decimal[4];
            if(this.genre == "Horror" && amount <= 30)
            {
                tempList[0] =  ((30*amount)/100);
                //tempList.Add(amountofselectedcustomer);
                //amountofselectedcustomer = 70 & *amount;     
            }
            return tempList;
        }

        public void StartSim()
        {

        }

        public void EmergencySim(double amount, List<System.Windows.Forms.Panel> users, List<Customer> custs, Seat[,] seatList2, Door door)
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
                    if (users[i].Left > (door.PosX + door.DWidth) / 2)
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

        }

    }
}
