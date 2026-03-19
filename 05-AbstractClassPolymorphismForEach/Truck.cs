using _05_AbstractClassPolymorphismForEach;
using System;
using System.Collections.Generic;
using System.Text;
//Vehicle - dən miras alır

//Əlavə Xüsusiyyətlər:
//CargoCapacity - Yük tutumu(ton, double)
//AxleCount - Ox sayı(int, məsələn: 2, 3, 4)
//CurrentLoad - Cari yük(ton, double)
//MaxSpeed - Maksimum sürət(km / saat, int)

//Constructor:
//base keyword istifadə edin

//Metodlar:
//ShowTruckInfo() - Yük maşını məlumatlarını göstərir
//LoadCargo(double weight) - Yük yükləyir (tutumu yoxlayır)
//CalculateFuelCost(double distance) - Yanacaq xərcini qaytarır:
//Əsas sərfiyyat: 25 litr / 100 km
//Yük hər ton üçün: +2 litr / 100 km
//1 litr yanacaq: 1.80 AZN
//Formula: (distance / 100) × (25 + CurrentLoad × 2) × 1.80

namespace _05_AbstractClassPolymorphismForEach
{
    public class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }
        public Truck(string brand, string model, int year, string platenumber,
            double fuellevel, int maxspeed, double cargocapacity, int axlecount, double currentload) : base(brand, model, year, platenumber, fuellevel, maxspeed)
        {
            this.CargoCapacity = cargocapacity;
            this.AxleCount = axlecount;
            this.CurrentLoad = currentload;
        }
        public void ShowTruckInfo()
        {
            ShowVehicleInfo();
            Console.WriteLine($"Cargo Capacity: {CargoCapacity} tons, Axle Count: {AxleCount}, Current Load: {CurrentLoad} tons");
        }
        public void LoadCargo(double weight)
        {
            if (CurrentLoad + weight <= CargoCapacity)
            {
                CurrentLoad += weight;
                Console.WriteLine("Yük qoyuldu");
            }
            else
            {
                Console.WriteLine("Tutum heddiden coxdur");
            }
        }

        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * (25 + CurrentLoad * 2) * 1.8;
        }



    }
}