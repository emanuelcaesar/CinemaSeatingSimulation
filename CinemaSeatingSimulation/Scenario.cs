using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Scenario
    {
        private int scenarioID, ageRating;
        private string genre;
        private DateTime time;

        public void ChooseGenre()
        {

        }

        public void ChooseAge()
        {

        }

        public void ChooseTime()
        {

        }

        public void AssignCustomers()
        {

        }

        public void StartSim()
        {

        }

        public void EmergencySim(double amount, List<System.Windows.Forms.Panel> users, List<Customer> custs, Seat[,] seatList2, Door door)
        {
            for (int i = 0; i <= amount; i++)
            {
<<<<<<< HEAD
                
                if (users[i].Top > (seatList2[custs[i].SeatRow, custs[i].SeatCol].PosY - seatList2[custs[i].SeatRow,
                            custs[i].SeatCol].SHeight))
                {
                    users[i].Top--;
                }
                else
=======

                for (j = 0; j < custs.Count(); j++)
>>>>>>> Greg
                {
                    if (users[i].Left > (door.PosX + door.DWidth) / 2)
                    {
                        users[i].Left--;
                    }
                    else
                    {
<<<<<<< HEAD
                        users[i].Top--;
=======

                        cu[filling].SeatArrangement();
                        j = -1;
>>>>>>> Greg
                    }
                }
            }
        }

        public void ResetSim()
        {

        }

        public void SkipSim()
        {

        }

    }
}
