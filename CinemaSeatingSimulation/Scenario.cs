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
 
        }


    }
}