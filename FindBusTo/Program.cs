using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			BusRoute[] allRoutes = BusRouteRepository.InitializeRoutes();

			Console.WriteLine("Where do you want to go to?");
			string location = Console.ReadLine();

			BusRoute[] routes = FindBusesTo(allRoutes, location);

			if (routes.Length > 0)
				foreach (BusRoute route in routes)
					Console.WriteLine($"You can use route {route}");
			else
				Console.WriteLine($"No routes go to {location}");
		}

		public static BusRoute[] FindBusesTo(BusRoute[] routes, string location)
		{
			return Array.FindAll(routes, route => route.Serves(location));
		}
	}
}
