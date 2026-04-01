using _09_UpcastingDowncastingExplicitImplicit.Models;

namespace _09_UpcastingDowncastingExplicitImplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting-Downcasting
            //Dog dog = new Dog() { AverageLifetime = 23, Gender = "Male", Breed = "Poodle", Name = "Fido" };
            //Eagle eagle = new Eagle() { AverageLifetime = 15, Gender = "Female", FlySpeed = 100 };

            //Animal animal = dog; // Implicit upcasting
            //Animal animal1 = eagle;

            //// Dog dog1 = (Dog)animal; // Explicit downcasting
            //// Eagle eagle1 = (Eagle)animal;

            //Animal[] animals = { dog, eagle };
            //foreach (var animal1 in animals)
            //{
            //    //Eagle eagle1 = (Eagle) animal1;
            //    Eagle eagle1 = animal1 as Eagle;
            //    eagle1.Fly();
            //    //if (eagle1 != null) 
            //    //{
            //    //    Console.WriteLine($"This is an eagle with a fly speed of {eagle1.FlySpeed}");
            //    //}
            //    if (animal is Eagle)
            //    {
            //        Eagle eagle2 = (Eagle)animal;
            //    }
            //    else
            //    {
            //        Dog dog2 = (Dog)animal;
            //    }
            //}
            #endregion


            #region Boxing-Unboxing
            //    int a = 5;
            //    object b = a;
            //    int c=(int)b;
            //}
            //    Test test = new Test();
            //    ITest test1 = test;
            //    Test test2 = (Test)test1;

            //}
            //public struct Test() : ITest
            //{
            //    public int X { get; set; }
            //    public int Y { get; set; }
            //}
            //public interface ITest
            //{
            //    int Y { get; set; }
            //}
            #endregion

            Dollar dollar = new(200);
            Manat manat = new(170);

            Dollar dollar1 = manat;
            Console.WriteLine(dollar1.USD);
            Manat manat1 = dollar;
            Console.WriteLine(manat1.AZN);

        }
    }
}
