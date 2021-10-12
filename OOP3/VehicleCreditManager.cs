using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehile Credit payment plan is calculated.");
        }

        public void DoStuff()
        {
            throw new NotImplementedException();
        }
    }
}
