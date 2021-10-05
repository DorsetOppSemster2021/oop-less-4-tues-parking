using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_less_4_tues_parking.models
{
    public class Carpark
    {

        public List<Customer> listOfCustomers = new List<Customer>();

        public Carpark()
        {
            Console.WriteLine("Starting Carpark Class");
        }

        public override string ToString()
        {
            return "---------------------Carpark";
        }

        public void CalculateCharges()
        {

            foreach(Customer currentCustomer in listOfCustomers)
            {
                Console.WriteLine("Calculating Charges");

            }

        }
    }
}
