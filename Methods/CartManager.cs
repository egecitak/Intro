using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class CartManager
    {
        public void Add (Product product)
        {
            Console.WriteLine(product.Name + " added to the cart");
        }

        public void Add2 (string productName, string explanation, double price)
        {
            Console.WriteLine(productName + " added to the cart");
        }
    }
}
