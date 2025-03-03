using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal interface IReporting
    {
        void InventoryReport(IProductManager warehouse);
        void RegisterOfGoodsReceipt(IProductManager warehouse, string productName, int quantity, DateTime deliveryDate);
        void RegisterOfShipmentOfGoods(IProductManager warehouse, string productName, int quantity);
    }
}
