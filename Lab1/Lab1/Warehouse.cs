using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Warehouse : IProductManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(string productName, int quantity)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                product.DecreaseQuantity(quantity);
            }
        }

        public Product FindProduct(string name)
        {
            return products.Find(p => p.Name == name);
        }

        public List<Product> ListProducts()  
        {
            return products;
        }
    }
}
