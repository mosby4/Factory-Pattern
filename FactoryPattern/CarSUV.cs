using System;
using System.Runtime.ConstrainedExecution;

namespace FactoryPattern
{
    public class CarSUV : IVehicle
    {
        public CarSUV()
        {
            Console.WriteLine("Great choice.");
        }
        public void Drive()
        {
            Console.WriteLine("Building a new car!");
            Console.WriteLine("Lets get started.");
        }
}
}

