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

        public CarparkCharge carparkCharge = new CarparkCharge();

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
                int calculatedCharge = carparkCharge.CalculateCharge(currentCustomer.hoursParked);
                Console.WriteLine($"Calculating Charges for {currentCustomer.carRegistration} : {currentCustomer.hoursParked} hours parked costs {calculatedCharge}");

            }

        }
    }
}
