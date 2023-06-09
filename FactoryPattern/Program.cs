namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your dream vehicle builder.");
            Console.WriteLine("How many tires do you want your vehicle to have?");
            var customerRequset = int.Parse(Console.ReadLine());

            var newRide = VehicleFactory.GetVehicle( customerRequset );
            newRide.Drive();
            
        }
    }
}
/*Create an Interface named IVehicle that has a stubbed out public void Drive method
Create 2 new public classes that will conform to IVehicle
Example) Car, Motorcycle, BigRig
These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”)
Now we will make our static VehicleFactory class
It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
Call this functionality in the Main method*/
