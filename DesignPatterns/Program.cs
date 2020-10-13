using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Facade

            FacadeCalling();

            Console.ReadKey();
        }

        private static void FacadeCalling()
        {
            Facade.FacadeImplementation facade = new Facade.FacadeImplementation();
            facade.DrawCar();
            facade.DrawBike();
        }
    }
}
