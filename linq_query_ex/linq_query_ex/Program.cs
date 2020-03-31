using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_query_ex
{
	class Program
	{
		static void Main(string[] args)
		{
			//Two dimensional array
			double[,] price = { { 350, 390, 435 }, { 400, 440, 480 }, { 475, 530, 575 } };

			string[,] selection = { { "Snickers", "Twix", "Mars" }, { "Skittles", "Mars", "Sour Patch Kids" }, { "Mars", "Mars", "Trident" } };

			List<Candy> candyList = new List<Candy>();
			//Iterate through the multi-Array and populate the list
			for (var i = 0; i < 3; i++)
			{
				for (var x = 0; x < 3; x++)
				{
					Candy aCandy = new Candy(selection[i, x], price[i, x]);
					candyList.Add(aCandy);
					//Console.WriteLine("{0} goes for {1}", selection[i, x], price[i, x].ToString("c"));
				}
			}
			//LINQ Query Syntax to select all candies greater than 450 using query syntax
			var candyOverQuery = (from candy in candyList
								 where candy.name.Contains("S")
								 where candy.price >= 415
								 orderby candy.name
								 select candy).ToList();

			//Iterate through each instance and output candy group along with count
			//candyOverQuery.ForEach(x => Console.WriteLine(x));
			//LINQ Query syntax to select all candies greater than 415 and starts with 'S' and order
			var newQueriedList = candyList.Where<Candy>(x => x.price > 415).Where<Candy>(x => x.name.StartsWith("S")).Select(x => x).OrderBy(x => x.name).ToList();

			//LINQ Query syntax to select all candies greater than 450 using method syntax
			var candyOverMethod = candyList.Where<Candy>(x => x.price >= 400 && x.price <=500).Select(x => x).OrderBy(x => x.name).ToList();
			//Outputing the LINQ Method Syntax
			newQueriedList.ForEach(x => Console.WriteLine(x.ToString()));

		}
	}
	public class Candy
	{
		public string name { get; set; }
		public double price { get; set; }

		public Candy(string name, double price)
		{
			this.name = name;
			this.price = price;
		}

		public override string ToString()
		{
			return String.Format("The name of the candy is " + name + " the price for this candy " + price);
		}

	}
}