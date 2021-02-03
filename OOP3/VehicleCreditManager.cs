using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            //you can write any code here.
            Console.WriteLine("Vehicle credit payment plan is calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
