using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
//Xüsusiyyətlər(Properties):
//Brand - Marka(string)
//Model - Model(string)
//Year - İl(int)
//PlateNumber - Qeydiyyat nömrəsi(string)
//FuelLevel - Yanacaq səviyyəsi(double, 0 - 100 arası)


namespace _05_AbstractClassPolymorphismForEach
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }
        public double FuelLevel { get; set; }
        public int MaxSpeed { get; set; }
        public Vehicle(string brand, string model, int year, string platenumber,
            double fuellevel, int maxspeed)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.PlateNumber = platenumber;
            this.FuelLevel = 100;
            this.MaxSpeed = maxspeed;
        }
        public void ShowVehicleInfo()
        {

            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Plate Number: {PlateNumber}, Fuel Level: {FuelLevel}, Max Speed: {MaxSpeed} km/h");
        }


    }
}