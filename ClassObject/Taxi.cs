using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    public class Taxi
    {
        public bool OnDuty;
        public string DriverName;
        public int NumPassenger;

        public void TaxiInfo()
        {
            Console.WriteLine("Nama : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty);
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
