using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Money
    {
        public int WholePart { get; private set; } 
        public int Cents { get; private set; } 
        public string Currency { get; private set; } 

        public Money(int wholePart, int cents, string currency)
        {
            WholePart = wholePart;
            Cents = cents;
            Currency = currency;
        }

        public void SetAmount(int whole, int cents)
        {
            WholePart = whole;
            Cents = cents;
        }

        public override string ToString()
        {
            return $"{WholePart}.{Cents:D2} {Currency}";
        }
    }
}
