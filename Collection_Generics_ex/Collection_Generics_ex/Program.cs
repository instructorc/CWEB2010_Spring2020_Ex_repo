using System;
using System.Collections.Generic;

namespace Collection_Generics_ex
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = 0;
			int row, column;
			string userSelection;
			//Single dimensional array that held the row names
			string[] candyNames = { "Bars", "Sweets", "Gum" };
			string[] columnNames = { "Row 1", "Row 2", "Row 3" };
			//Two dimensional array
			double[,] price = {
								 {350, 390, 435},
								 {400, 440, 480},
								 {475, 530, 575}
							  };

			string[,] selection = {
									 {"Snickers", "Twix", "Mars"},
									 {"Skittles", "Starburst", "Sour Patch Kids"},
									 {"Big Red", "Winter fresh", "Trident"}
								  };
			List<Candy> candyList = new List<Candy>();
			List<Candy> selectedCandy = new List<Candy>();

			//Iterate through the multi-Array and populate the list
			Console.WriteLine($"\t\t\t{columnNames[0]} \t\t\t {columnNames[1]}  \t\t\t {columnNames[2]}");
			for (var i = 0; i < 3; i++) //Outer loop
			{
				Console.Write($"{candyNames[i]} \t\t" );
				for (var x = 0; x < 3; x++) //Inner Loop
				{
					Candy aCandy = new Candy(selection[i, x], price[i, x]);
					candyList.Add(aCandy);
					Console.Write($"\t {selection[i, x]} \t");

					//Console.WriteLine("{0} goes for {1}", selection[i, x], price[i, x].ToString("c"));
					//Console.Write(aCandy);
				}
			}

			Console.WriteLine("Please enter the candy row");
			row = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter the candy column");
			column = Convert.ToInt32(Console.ReadLine());
			userSelection = selection[row, column];

			//Decrement through the list and find the object with value "Snickers" for the name property
			for (var i = candyList.Count - 1; i >= 0; i--)
			{
				if (candyList[i].name.Contains(userSelection))
				{
					selectedCandy.Add(candyList[i]);
					candyList.RemoveAt(i);
					

				}
			}

			//for (var i = 0; i < candyList.Count; i++){

			//	if (candyList[i].name.Contains("Snickers"))
			//	{
			//		candyList.RemoveAt(i);
			//	}
			//}
			Console.WriteLine("After this line, no candy objects should print");
			

			//Output the list using lambda Expression
			candyList.ForEach(x => Console.WriteLine(x.ToString()));
			Console.WriteLine("");
			Console.WriteLine("These are the selected candies");
			selectedCandy.ForEach(x => Console.WriteLine(x.ToString()));
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