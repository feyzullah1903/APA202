using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
//DoorsCount - Qapı sayı(int)
//TrunkCapacity - Baqaj tutumu(litr, int)
//IsAutomatic - Avtomat sürət qutusu(bool)
//MaxSpeed - Maksimum sürət(km / saat, int)

namespace _05_AbstractClassPolymorphismForEach
{
    internal class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public int TrunkCapacity { get; set; }
        public bool IsAutomatic { get; set; }

        public Car(string brand, string model, int year, string platenumber, double fuellevel, int maxspeed, int doorscount, int trunkcapacity, bool isautomatic
           ) : base(brand, model, year, platenumber, fuellevel, maxspeed)
        {
            this.DoorsCount = doorscount;
            this.TrunkCapacity = trunkcapacity;
            this.IsAutomatic = isautomatic;
        }
        public void ShowCarInfo()
        {
            ShowVehicleInfo();
            Console.WriteLine($"Doors{DoorsCount}  Trunkcapacity{TrunkCapacity}   Masin Avtomatdirmi?{IsAutomatic} ");
        }
        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 8 * 1.50;
        }
    }

}