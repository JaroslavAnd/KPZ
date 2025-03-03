using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Reporting : IReporting
    {
        public void InventoryReport(IProductManager warehouse)
        {
            Console.WriteLine("Інвентаризація складу:");
            var products = warehouse.ListProducts(); 
            foreach (var product in products)  
            {
                Console.WriteLine(product);
            }
        }

        public void RegisterOfGoodsReceipt(IProductManager warehouse, string productName, int quantity, DateTime deliveryDate)
        {
            var product = warehouse.FindProduct(productName);
            if (product != null)
            {
                product.IncreaseQuantity(quantity, deliveryDate);
                Console.WriteLine($"Надходження: {quantity} {product.Unit} {productName} додано на склад");
            }
        }

        public void RegisterOfShipmentOfGoods(IProductManager warehouse, string productName, int quantity)
        {
            var product = warehouse.FindProduct(productName);
            if (product != null && product.Quantity >= quantity)
            {
                product.DecreaseQuantity(quantity);
                Console.WriteLine($"Відвантаження: {quantity} {product.Unit} {productName} відправлено зі складу");
            }
            else
            {
                Console.WriteLine($"Помилка: недостатньо {productName} на складі!");
            }
        }
    }

}
