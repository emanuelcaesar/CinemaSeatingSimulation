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

        }

        public void SkipSim()
        {

        }

    }
}
