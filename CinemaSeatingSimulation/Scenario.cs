using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Scenario
    {
        List<Customer> custs = new List<Customer>();
        Random rand = new Random();
        public int randRow, randCol;
        int row, col;
        int custId;
        double amount;
        Customer[] cu;

        public void AssignCustomer()
        {
            //Customer customers = new Customer(randRow, randCol);
            //custs.Add(new Customer(randRow, randCol));
            cu = new Customer[Convert.ToInt32(amount)];
            int filling, j;
            for (filling = 0; filling <= amount; filling++)
            {
                
                for (j = 0; j < custs.Count(); j++)
                {
                    cu[filling] = new Customer(custId, Convert.ToInt32(amount));
                    if (cu[filling].SeatRow == custs[j].SeatRow &&
                        custs[filling].SeatCol == custs[j].SeatCol && filling != j)
                    {
                        
                        cu[filling].SeatArrangement();
                        j = -1;
                    }
                }

            }

        }

<<<<<<< HEAD
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
=======
>>>>>>> Greg

    }
}