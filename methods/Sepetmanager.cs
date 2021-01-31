using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class Sepetmanager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Thank you. Added into basket : " + product.Name);

        }

        public void Add2(string productName, string explanation, double price, int stockNumber)
        {
            Console.WriteLine("Thank you. Added into basket : " + productName);

        }
        

        
    }
}
