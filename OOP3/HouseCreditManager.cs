using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class HouseCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("House Credit payment plan is calculated.");
        }

        public void DoStuff()
        {
            throw new NotImplementedException();
        }
    }
}
