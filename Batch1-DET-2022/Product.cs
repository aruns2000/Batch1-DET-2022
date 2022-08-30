using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Product
    {
        string Name;
        double Price;

        public Product()
        {
            Name = "Arun";

            Price = 100;
        }
        public Product(string Nam, double Pri)
        {
            Name = Nam;

            Price = Pri;
        }

        public double getDiscount()
        {
            return this.Price * .10;
        }

    }
    public class TestProduct
    {
        public static void Main()
        {
            Product product = new Product();
            Product product1 = new Product("Arun",1000);
            Console.WriteLine(product1.getDiscount());
            Console.WriteLine(product.getDiscount());
        }
    }
}
