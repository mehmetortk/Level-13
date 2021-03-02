using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_13
{
    public class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added to the cart: "+product.Name);
        }

    }
}



