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
        Customer customer = new Customer();

        public void AssignCustomer() {
            //Customer customers = new Customer(randRow, randCol);
            //custs.Add(new Customer(randRow, randCol));
            int filling, j;
            for (filling = 0; filling <= amount; filling++)
            {
                custs.Add(new Customer(custId, Convert.ToInt32(amount)));
                customer.seatArrangement(filling);
                for (j = 0; j < custs.Count(); j++)
                {
                    if (custs[filling]. == custs[j].SeatRow && 
                        custs[filling].SeatCol == custs[j].SeatCol && filling != j)
                    {
                        
                        //custs.Add(new Customer(randRow, randCol));
                        //custs[filling].SeatRow = randRow;
                        //custs[filling].SeatCol = randCol;
                        j = -1;
                    }
                }

            }

        }
        

    }
}
