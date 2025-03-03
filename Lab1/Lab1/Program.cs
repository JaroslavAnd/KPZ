using Lab1;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Money price1 = new Money(7, 50, "UAH");
        Product apple = new Product("Яблуко", "кг", price1, 50, DateTime.Now);

        Money price2 = new Money(15, 00, "UAH");
        Product potato = new Product("Картопля", "кг", price2, 25, DateTime.Now);

        IProductManager warehouse = new Warehouse();
        warehouse.AddProduct(apple);
        warehouse.AddProduct(potato);

        IReporting report = new Reporting();

        Console.WriteLine("Початковий стан складу:");
        report.InventoryReport(warehouse);

        apple.ReducePrice(1, 20);
        potato.ReducePrice(3, 50);

        Console.WriteLine("Після зниження цін:");
        report.InventoryReport(warehouse);

        report.RegisterOfGoodsReceipt(warehouse, "Яблуко", 50, DateTime.Now);
        report.RegisterOfShipmentOfGoods(warehouse, "Картопля", 20);

        Console.WriteLine("Після надходження та відвантаження товарів:");
        report.InventoryReport(warehouse);
    }
}