using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing credit payment plan is calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
