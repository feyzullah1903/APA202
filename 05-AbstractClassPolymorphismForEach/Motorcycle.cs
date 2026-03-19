using _05_AbstractClassPolymorphismForEach;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
//Motorcycle Sinfi
//Vehicle - dən miras alır

//Əlavə Xüsusiyyətlər:
//EngineCapacity - Mühərrik həcmi(cc, int)
//HasSidecar - Əlavə oturacaq(bool)
//MaxSpeed - Maksimum sürət(km / saat, int)
//Type - Növ(string: "Sport", "Cruiser", "Touring")

//Constructor:
//base keyword istifadə edin
//this keyword ilə sahələri təyin edin

//Metodlar:
//ShowMotorcycleInfo() - Motosiklet məlumatlarını göstərir
//CalculateFuelCost(double distance) - Yanacaq xərcini qaytarır:
//Sərfiyyat: 4 litr / 100 km
//1 litr yanacaq: 1.50 AZN
//Formula: (distance / 100) × 4 × 1.50

namespace _05_AbstractClassPolymorphismForEach
{
    public class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public bool HasSidecar { get; set; }
        public string Type { get; set; }
        public string MotorcycleInfo { get; set; }
        public Motorcycle(string brand, string model, int year, string platenumber,
            double fuellevel, int maxspeed, int enginecapacity, bool hassidecar, string type, string motorcycleinfo)
            : base(brand, model, year, platenumber, fuellevel, maxspeed)
        {
            this.EngineCapacity = enginecapacity;
            this.HasSidecar = hassidecar;
            this.Type = type;
            this.MotorcycleInfo = motorcycleinfo;
        }
        public void ShowMotorcycleInfo()
        {
            ShowVehicleInfo();
            Console.WriteLine($"Engine Capacity: {EngineCapacity} cc, Has Sidecar: {HasSidecar}, Type: {Type}");
        }
        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 4 * 1.50;
        }

    }
}