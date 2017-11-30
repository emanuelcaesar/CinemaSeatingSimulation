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


    }
}