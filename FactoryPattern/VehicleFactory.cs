using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		public static IVehicle GetVehicle(int wheelCount)
		{
			switch (wheelCount )
			{
				case 2:
					return new Motorcycle();
				case 4:
					return new CarSUV();
				default:
					return new CarSUV();
					break;
			}
			

		}

       
    }
}

