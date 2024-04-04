using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			List<BusRoute> allRoutes = BusRouteRepository.InitializeRoutes();

			Console.WriteLine($"Before: There are {allRoutes.Count} routes:");
			foreach (BusRoute route in allRoutes)
				Console.WriteLine($"Route: {route}");

			allRoutes.RemoveAll(route => route.Origin.StartsWith("Test "));

			Console.WriteLine($"\r\nAfter: There are {allRoutes.Count} routes:");
			foreach (BusRoute route in allRoutes)
				Console.WriteLine($"Route: {route}");
		}
	}
}
