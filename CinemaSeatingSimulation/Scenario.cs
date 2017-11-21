using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Scenario
    {
<<<<<<< HEAD
        List<Customer> custs = new List<Customer>();
        Random rand = new Random();
        public int randRow, randCol;
        int row, col;
        int custId;
        double amount;
        Customer customer = new Customer();

        public void AssignCustomer() {
            //Customer customers = new Customer(randRow, randCol);
            //custs.Add(new Customer(randRow, randCol));
            int filling, j;
            for (filling = 0; filling <= amount; filling++)
            {
                

                for (j = 0; j < custs.Count(); j++)
                {
                    if (custs[filling].SeatRow == custs[j].SeatRow && custs[filling].SeatCol == custs[j].SeatCol && filling != j)
                    {
                        custs.Add(new Customer(custId, Convert.ToInt32(amount)));
                        //custs.Add(new Customer(randRow, randCol));
                        //custs[filling].SeatRow = randRow;
                        //custs[filling].SeatCol = randCol;
                        j = -1;
                    }
                }

            }

        }
        
=======
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

        public void EmergencySim()
        {

        }

        public void ResetSim()
        {

        }

        public void SkipSim()
        {

        }
>>>>>>> master

    }
}
