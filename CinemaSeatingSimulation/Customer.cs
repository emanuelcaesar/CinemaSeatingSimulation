using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSeatingSimulation
{
    class Customer
    {
        int customerId, age, speed, seatRow, seatCol;
        string demographic;


        public Customer() { }

        public Customer(int seatRow, int seatCol)
        {
            this.seatRow = seatRow;
            this.seatCol = seatCol;
        }

        public int SeatRow
        {
            get { return this.seatRow; }
            set { seatRow = value; }
        }

        public int SeatCol
        {
            get { return this.seatCol; }
            set { seatCol = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { age = value; }
        }

        
    }

    
    

    class Child : Customer
    {

    }
    class Adult : Customer
    {

    }
    class Seniors : Customer
    {

    }
    class Teens : Customer
    {

    }
}
