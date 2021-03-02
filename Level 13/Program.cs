using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_13
{
    class Program
    {
        static void Main(string[] args)
        {
            CartManager cartManager = new CartManager();
            Product product1 = new Product { Id = 1, Name = "Apple", Cost = 1.5, Type = "Turkish apple", StockAmount = 20};
            Product product2 = new Product { Id = 2, Name = "Hazelnut", Cost = 10, Type = "Blacksea coast Turkish hazelnut"
                ,StockAmount = 23 };
            Product product3 = new Product { Id = 3, Name = "Kiwi", Cost = 3, Type = "Brazilian kiwi", StockAmount = 21 };
            Product product4 = new Product { Id = 4, Name = "Cinnamon", Cost = 2, Type = "Indian cinnamon", StockAmount = 25 };
            Product[] products = new Product[] { product1, product2,product3,product4 };
            foreach (Product Canlar in products)
            {
                Console.WriteLine("Product Id: {0}", Canlar.Id);
                Console.WriteLine("Product Name: {0}", Canlar.Name);
                Console.WriteLine("Product Price: {0}$", Canlar.Cost);
                Console.WriteLine("Product Type: {0}", Canlar.Type);
                Console.WriteLine("Product Stock amount: {0}", Canlar.StockAmount);
                Console.WriteLine("---------------------------------------");

                cartManager.Add(Canlar);
                Console.WriteLine("_______________________________________________");
                
                
                
                
            }
           
            
            Console.ReadKey();
        }
    }
}