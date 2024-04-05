using System;

namespace Pluralsight.ArraysCollections.Demos
{
    public class BusRouteRepository
	{
		private readonly BusRoute[] _allRoutes;
		public BusRouteRepository()
		{
			_allRoutes = new BusRoute[] {
				new BusRoute(40, new string[] {
					"Morecambe", "Lancaster", "Garstang", "Preston" }),
				new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" }),
				new BusRoute(100, new string[] { "University", "Lancaster", "Morecambe" }),
				new BusRoute(555, new string[] {
					"Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" }),
				new BusRoute(5, new string[] { "Overton", "Morecambe", "Carnforth"})
			};

			// Multidimensional Array
			//string[,] timesRoute5 = 
			//{
			//	{ "15:40", "16:40", "17:40", "18:40" },
			//	{ "16:08", "17:08", "18:08", "19:08" },
			//	{ "16:35", "17:35", "18:35", "19:35" }
			//};

			// Jagged Array. Only works if it's the last one that is missing values
			string[][] timesRoute5 = {
				["15:40", "16:40", "17:40", "18:40", "19:40"],
				["16:08", "17:08", "18:08", "19:08", "20:08"],
				["16:35", "17:35", "18:35", "19:35"]
			};
			BusTimesRoute5 = new BusTimes(
				Array.Find(_allRoutes, x => x.Number == 5), timesRoute5);
		}
		public BusTimes BusTimesRoute5 { get; }

		public BusRoute[] FindBusesTo(string location)
		{
			return Array.FindAll(_allRoutes, route => route.Serves(location));
		}
		public BusRoute[] FindBusesBetween(string location1, string location2)
		{
			return Array.FindAll(_allRoutes,
				route => route.Serves(location1) && route.Serves(location2));
		}
	}
}
