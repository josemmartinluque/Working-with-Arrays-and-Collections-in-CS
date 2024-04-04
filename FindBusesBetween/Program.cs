using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			BusRouteRepository repository = new BusRouteRepository();

			Console.WriteLine("Where are you?");
			string startingAt = Console.ReadLine();

			Console.WriteLine("Where do you want to go to?");
			string goingTo = Console.ReadLine();

			BusRoute[] originRoutes = repository.FindBusesTo(startingAt);
			BusRoute[] destinationRoutes = repository.FindBusesTo(goingTo);

			HashSet<BusRoute> routes = new HashSet<BusRoute>(originRoutes);
			routes.IntersectWith(destinationRoutes);

			if (routes.Count > 0)
				foreach (BusRoute route in routes)
					Console.WriteLine($"You can use route {route}");
			else
				Console.WriteLine($"No routes go between {startingAt} and {goingTo}");
		}
	}
}
