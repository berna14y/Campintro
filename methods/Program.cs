using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Apple";
            double price = 15;
            string explanation = "Amasya apple";

            string[] fruits = new string[] { "Apple", "Watermelon" };

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Explanation = "Amasya Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır Watermelon";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("........................");

            }

            Console.WriteLine("........Methods..........");
            Sepetmanager sepetmanager = new Sepetmanager();
            sepetmanager.Add(product1);
            sepetmanager.Add(product2);

            sepetmanager.Add2("Pear", "Green pear", 12, 10);
            sepetmanager.Add2("Apple", "Green apple", 12, 9);
            sepetmanager.Add2("Watermelon", "Diyarbakır watermelon", 12, 8);


        }
    }
}
