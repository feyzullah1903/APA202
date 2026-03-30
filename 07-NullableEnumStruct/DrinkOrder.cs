using _07_NullableEnumStruct.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07_NullableEnumStruct
{
    internal class DrinkOrder
    {

        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DrinkType Drink { get; set; }
        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }
        public DrinkOrder(int orderNumber, string customerName, DrinkType drink, DrinkSize size)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
            Status = OrderStatus.New;
            Price = CalculatePrice();

        }
        public decimal CalculatePrice()
        {
            decimal price = 0;

            switch (Drink)
            {
                case DrinkType.Coffee:
                    switch (Size)
                    {
                        case DrinkSize.Small: price = 3; break;
                        case DrinkSize.Medium: price = 4; break;
                        case DrinkSize.Large: price = 5; break;
                    }
                    break;

                case DrinkType.Tea:
                    switch (Size)
                    {
                        case DrinkSize.Small: price = 2; break;
                        case DrinkSize.Medium: price = 3; break;
                        case DrinkSize.Large: price = 4; break;
                    }
                    break;

                case DrinkType.Juice:
                    switch (Size)
                    {
                        case DrinkSize.Small: price = 4; break;
                        case DrinkSize.Medium: price = 5; break;
                        case DrinkSize.Large: price = 6; break;
                    }
                    break;

                case DrinkType.Water:
                    switch (Size)
                    {
                        case DrinkSize.Small: price = 1; break;
                        case DrinkSize.Medium: price = 1.5m; break;
                        case DrinkSize.Large: price = 2; break;
                    }
                    break;
            }

            return price;
        }
        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Sifaris {OrderNumber} statusu: {newStatus}");
        }

        public void DisplayOrder()
        {
            
            Console.WriteLine($"Sifari snomresi: {OrderNumber}");
            Console.WriteLine($"Musteri: {CustomerName}");
            Console.WriteLine($"Icki: {Drink}");
            Console.WriteLine($"olcuu: {Size}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Qiymet: {Price}");
            Console.WriteLine();
        }




    }

}
