using System;

namespace hwEticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Asus Mouse";
            product1.Price = 280;
            product1.StockAmout = 50;

            Product product2 = new Product();
            product2.Name = "Asus Gaming Laptop";
            product2.Price = 15000;
            product2.StockAmout = 20;

            Product product3 = new Product();
            product3.Name = "Asus Keyboard";
            product3.Price = 500;
            product3.StockAmout = 40;

            Product[] products = new Product[] { product1, product2, product3 };

            Console.WriteLine("FOREACH LOOPS");

            foreach (var product in products)
            {
                Console.WriteLine(product.Name + "-->" + product.Price + " TL");
            }

            Console.WriteLine("FOR LOOPS");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name + "-->" + products[i].Price + " TL");
            }
            Console.WriteLine("WHİLE LOOPS");

            int k = 0;
            while (k < products.Length)
            {
                Console.WriteLine(products[k].Name + "-->" + products[k].Price + " TL"); ;
                k++;
            }
        

        }
    }
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int StockAmout { get; set; }
    }
}
