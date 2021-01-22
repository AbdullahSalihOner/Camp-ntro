using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BoxManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added to box :" + product.Name);
        }

        public void Add2(string name,string about,double price,int stockAmount)
        {
            Console.WriteLine("Added to box :" + name);
        }
    }
}
