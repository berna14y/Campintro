using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Name = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.Id = 1;
            customer1.TcNo = "1234567890";

            //Kodlama.io

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.TaxNo = "1234567890";
            customer2.CompanyName = "Kodlama.io";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
