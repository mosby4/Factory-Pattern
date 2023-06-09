using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
		public Motorcycle()
		{
            Console.WriteLine("Oh we have a dare devil.");
		}
        public void Drive()
        {
            Console.WriteLine("Building a new motorcycle!");
            Console.WriteLine("Cool, I would advise you to wear a helmet at all times.");
        }
    }
}


