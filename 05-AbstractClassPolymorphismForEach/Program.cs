using System.Diagnostics;
using System.Threading.Channels;

namespace _05_AbstractClassPolymorphismForEach
{
    public class Program
    {

        public static void Main()
        {
            //////CAR////////
            //        Birinci: Mercedes E200, 2023, 4 qapı, 500L baqaj, Avtomat, 220 km/s
            //İkinci: BMW 320i, 2022, 4 qapı, 480L baqaj, Avtomat, 235 km/s
            //Üçüncü: Toyota Camry, 2021, 4 qapı, 524L baqaj, Avtomat, 210 km/s

            Car _car = new Car("Mercedes", "E200", 2023, "59-AB-111", 100, 220, 4, 500, false);
            Car _car1 = new Car("BMW", "320i", 2022, "77-ZZ-777", 100, 235, 4, 480, true);
            Car _car2 = new Car("Toyota", "Camry", 2021, "49-BB-279", 100, 210, 4, 524, true);

            //        2. 2 Motorcycle obyekti yaradın:
            //Birinci: Yamaha R1, 2023, 998cc, Sport, yox sidecar, 299 km/s
            //İkinci: Harley-Davidson, 2022, 1868cc, Cruiser, var sidecar, 180 km/s

            ///////MOTORCYCLE//////// 
            Motorcycle _motorcycle = new Motorcycle("Yamaha", "R1", 2023, "10-DD-444", 100, 299, 998, false,
                "Sport", "Yamaha R1 yaris motosu");
            Motorcycle _motorcycle1 = new Motorcycle("Harley-Davidson", "Street Glide", 2022, "77-EE-555", 100, 180, 1868, true,
                "Cruiser", "Harley-Davidson S Enkelerin motosu.");

            //         2 Truck obyekti yaradın:
            //Birinci: MAN TGX, 2020, 18 ton tutum, 3 ox, 12 ton yük, 120 km/s
            //İkinci: Volvo FH16, 2021, 25 ton tutum, 4 ox, 18 ton yük, 110 km/s

            /////TRUCK////////
            Truck _truck = new Truck("Man", "Tgx", 2020, "77-FF-666", 100, 120, 25, 4, 10);
            Truck _truck1 = new Truck("Scania", "FH16", 2021, "70-FM-777", 100, 110, 30, 6, 15);


            _car.ShowCarInfo(); Console.WriteLine(_car.CalculateFuelCost(500));
            _car1.ShowCarInfo(); Console.WriteLine(_car1.CalculateFuelCost(500));
            _car1.ShowCarInfo(); Console.WriteLine(_car2.CalculateFuelCost(500));

            _motorcycle.ShowMotorcycleInfo(); Console.WriteLine(_motorcycle.CalculateFuelCost(300));
            _motorcycle1.ShowMotorcycleInfo(); Console.WriteLine(_motorcycle1.CalculateFuelCost(300));


            _truck.ShowTruckInfo(); Console.WriteLine(_truck.CalculateFuelCost(800));
            _truck1.ShowTruckInfo(); Console.WriteLine(_truck1.CalculateFuelCost(800));

            Console.WriteLine("\n=== Load Cargo ===");
            _truck.LoadCargo(5);
            Console.WriteLine(_truck.CalculateFuelCost(800));

            // Statistikalar
            int total = 7;

            double avgSpeed = (220 + 235 + 210 + 299 + 180 + 120 + 110) / 7.0;
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average Speed: {avgSpeed}");

            double maxFuel =
                Math.Max(_car.CalculateFuelCost(500),
                Math.Max(_car.CalculateFuelCost(500),
                Math.Max(_car2.CalculateFuelCost(500),
                Math.Max(_car2.CalculateFuelCost(300),
                Math.Max(_motorcycle1.CalculateFuelCost(300),
                Math.Max(_truck.CalculateFuelCost(800), _truck1.CalculateFuelCost(800)))))));

            Console.WriteLine($"Max Fuel Cost: {maxFuel}");
        }
    }
}