using System;

namespace animal_ex
{
    class Program
    {
        static void Main(string[] args)
        {
			Animal aAnimal = new Animal("Tiger", 3);

			Console.WriteLine(aAnimal);
            
        }
    }
	class Animal
	{

		public string Type { get; set; }
		public int NumberOfLegs { get; set; }
		public string Category { get; private set; }

		//Default Constructor
		public Animal()
		{

		}

		public Animal(string Type, int legCount)
		{
			this.Type = Type;
			NumberOfLegs = legCount;
			determineAnimal(NumberOfLegs);
		}

		//Working Method - This working method will determine category of animal based on number of legs
		private void determineAnimal(int count)
		{
			//Logic 
			if (count == 0)
			{
				Category = "Fish";
			}
			else if (count == 1)
			{
				Category = "Bug";
			}
			else if (count == 2)
			{
				Category = "Bird";
			}
			else
			{
				Category = "Alien";
			}
		}

		public override string ToString()
		{
			return String.Format($"Type: {Type} Number of Legs: {NumberOfLegs} Category: {Category}");
		}
	}
}