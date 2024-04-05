using System;

namespace Pluralsight.ArraysCollections.Demos
{
    class Program
	{
		static void Main(string[] args)
		{
			BusRouteRepository repository = new BusRouteRepository();

			BusTimes times5 = repository.BusTimesRoute5;
			BusRoute route5 = times5.Route;

			for (int iPlace = 0; iPlace < route5.PlacesServed.Length; iPlace++)
			{
				Console.Write(route5.PlacesServed[iPlace].PadRight(12));

				foreach (string time in times5.Times[iPlace])
					Console.Write(time + " ");
				Console.WriteLine();
			}
		}
	}
}
