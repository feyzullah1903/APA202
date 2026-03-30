//namespace _07_NullableEnumStruct
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}
using _07_NullableEnumStruct;
using _07_NullableEnumStruct.Enum;


class Program
{
    static void Main()
    {

        var order1 = new DrinkOrder(101, "Gulcohre", DrinkType.Coffee, DrinkSize.Medium);
        order1.DisplayOrder();
        order1.UpdateStatus(OrderStatus.Preparing);
        order1.UpdateStatus(OrderStatus.Ready);
        order1.UpdateStatus(OrderStatus.Delivered);

        var order2 = new DrinkOrder(102, "Samil", DrinkType.Tea, DrinkSize.Large);
        order2.DisplayOrder();
        order2.UpdateStatus(OrderStatus.Ready);

        var order3 = new DrinkOrder(103, "Qombay", DrinkType.Juice, DrinkSize.Small);
        order3.DisplayOrder();


        Console.WriteLine("---- DrinkType ----");
        foreach (var item in Enum.GetValues(typeof(DrinkType)))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---- DrinkSize ----");
        foreach (var item in Enum.GetValues(typeof(DrinkSize)))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---- OrderStatus ----");
        foreach (var item in Enum.GetValues(typeof(OrderStatus)))
        {
            Console.WriteLine(item);
        }


        Console.WriteLine(DrinkType.Coffee.ToString());
        Console.WriteLine(DrinkSize.Large.ToString());


        DrinkType drinkParsed = (DrinkType)Enum.Parse(typeof(DrinkType), "Tea");
        DrinkSize sizeParsed = (DrinkSize)Enum.Parse(typeof(DrinkSize), "Medium");

        Console.WriteLine(drinkParsed);
        Console.WriteLine(sizeParsed);


        Console.WriteLine("---- Statistika ----");
        Console.WriteLine("Umumi sifaris: 3");

        Console.WriteLine($"1ci sifaris: {order1.Price}");
        Console.WriteLine($"2ci sifaris: {order2.Price}");
        Console.WriteLine($"3cu sifaris: {order3.Price}");

        decimal total = order1.Price + order2.Price + order3.Price;
        Console.WriteLine($"Umumi mebleg: {total}");
    }
}
