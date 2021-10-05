using oop_less_4_tues_parking.models;
using System;

namespace oop_less_4_tues_parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************* Parking Application *******************");

            Driver driver = new Driver();

            driver.CreateClasses();
            driver.PopulateCarPark();


        }
    }
}
