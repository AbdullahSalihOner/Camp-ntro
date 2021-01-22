using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Mouse";
            product1.Price = 15;
            product1.About = "ASUS Tuf gaming";

            Product product2 = new Product();
            product2.Name = "Laptop";
            product2.Price = 57;
            product2.About = "ASUS ROG";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.About);
            }
            Console.WriteLine("-----------------------");

            Console.WriteLine();
            BoxManager boxManager = new BoxManager();
            boxManager.Add(product1);
            boxManager.Add(product2);

            boxManager.Add2("Elma", "Amasya", 8,10);
            boxManager.Add2("Armut", "Amasya", 9,5);
        }
    }
}
