using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_less_4_tues_parking.models
{
    public class Driver
    {

   
        public Driver()
        {
            Console.WriteLine("Starting Driver Class");
        }

        public void CreateClasses()
        {

            Carpark carpark = new Carpark();
            Console.WriteLine(carpark.ToString());

            Customer customer = new Customer();
            Console.WriteLine(customer.ToString());

            CarparkCharge carparkcharge = new CarparkCharge();
            Console.WriteLine(carparkcharge.ToString());
        }



        public void PopulateCarPark()
        {
            Console.WriteLine("PopulateCarPark");
            Carpark carpark = new Carpark();

            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();
            Customer c4 = new Customer();
            Customer c5 = new Customer();

            carpark.listOfCustomers.Add(c1);
            carpark.listOfCustomers.Add(c2);
            carpark.listOfCustomers.Add(c3);
            carpark.listOfCustomers.Add(c4);
            carpark.listOfCustomers.Add(c5);

            carpark.CalculateCharges();

        }
    }
}
