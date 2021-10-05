using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_less_4_tues_parking.models
{
    public class CarparkCharge
    {
        public CarparkCharge()
        {
            Console.WriteLine("Starting CarparkCharge Class");
        }

        public override string ToString()
        {
            return "---------------------CarparkCharge";
        }

        public int CalculateCharge(int hoursParked)
        {
            int minimumFee = 2;

            return hoursParked * 2;

        }
    }
}
