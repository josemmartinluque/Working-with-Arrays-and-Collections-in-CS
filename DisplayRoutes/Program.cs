using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			BusRoute route40 = new BusRoute(40, "Morecambe", "Preston");
			BusRoute route42 = new BusRoute(42, "Lancaster", "Blackpool");

			BusRoute[] routes = new BusRoute[4];

			routes[0] = route40;
			routes[1] = route42;
			routes[2] = new BusRoute(100, "University", "Morecambe");
			routes[3] = new BusRoute(555, "Lancaster", "Keswick");

			Console.WriteLine("Looking up individual elements:");
			Console.WriteLine($"The third route is {routes[2]}");
			BusRoute lastRoute = routes[^1];  // or routes[routes.Length-1];
			Console.WriteLine($"The last route is {lastRoute}");

			Console.WriteLine("\r\nEnumerating with for");
			for (int i = 0; i < routes.Length; i++)
				Console.WriteLine($"{i}: {routes[i]}");

			//foreach (BusRoute route in routes)
			//	Console.WriteLine(route);
		}
	}
}
