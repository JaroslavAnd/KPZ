using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Product
    {
        public string Name { get; private set; }
        public string Unit { get; private set; } 
        public Money Price { get; private set; }
        public int Quantity { get; private set; }
        public DateTime LastDeliveryDate { get; private set; }

        public Product(string name, string unit, Money price, int quantity, DateTime lastDeliveryDate)
        {
            Name = name;
            Unit = unit;
            Price = price;
            Quantity = quantity;
            LastDeliveryDate = lastDeliveryDate;
        }

        public void ReducePrice(int whole, int cents)
        {
            int totalCents = Price.WholePart * 100 + Price.Cents;
            int reduction = whole * 100 + cents;
            totalCents = Math.Max(0, totalCents - reduction);
            Price = new Money(totalCents / 100, totalCents % 100, Price.Currency);
        }

        public void IncreaseQuantity(int amount, DateTime deliveryDate)
        {
            Quantity += amount;
            LastDeliveryDate = deliveryDate;
        }

        public void DecreaseQuantity(int amount)
        {
            Quantity = Math.Max(0, Quantity - amount);
        }

        public override string ToString()
        {
            return $"{Name} ({Unit}): {Price}, Кількість: {Quantity}, Остання поставка: {LastDeliveryDate.ToShortDateString()}";
        }
    }
}
