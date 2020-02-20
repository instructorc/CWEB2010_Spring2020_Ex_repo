using System;

namespace lecture_example
{
    class Program
    {
        static void Main(string[] args)
        {
			string name, gender, interest;
			int age;

			Person[] people = new Person[2]; //Declares an array of objects

			Console.Beep();

			for (var i = 0; i < people.Length; i++)
			{

				//get name
				Console.WriteLine("Please enter the name:");
				name = Console.ReadLine();
				

				Console.WriteLine("Please enter age:");
				age = Convert.ToInt32(Console.ReadLine());
			

				Console.WriteLine("Please enter gender: ");
				gender = Console.ReadLine();
				

				Console.WriteLine("Please enter interest: ");
				interest = Console.ReadLine();
			

				//Instantiate a new people object instance
				people[i] = new Person(name, age, interest); //Calling the constructor

				



			}

			//Output Object instances
			for (var x = 0; x < people.Length; x++)
			{
				people[x].Greeting();
				Console.WriteLine(people[x]);
				Console.WriteLine("");
			}






			//Delcaring an person object
			//Person sarah;
			//Instantiation
			//sarah = new Person();
			//sarah.setName("Sarah");
			//sarah.setAge(500);
			//sarah.setGender("Female");
			//sarah.setInterest("Programming");

			//sarah.Greeting();
			//sarah.bio();

			//Person christian = new Person();
			//christian.setName("Christian");
			//christian.setAge(25);
			//christian.setGender("Male");
			//christian.setInterest("Robotics");

			//Console.WriteLine("");
			//christian.Greeting();
			//christian.bio();

        }
    }

	class Person
	{
		//Data Encapsulation
		public string Name { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
		public string Interest { get; set; }

		//Default Constructor
		public Person()
		{
			this.Age = 40;
		}

		/**Constructor with Parameters**/
		public Person(string Interest, string Gender, int Age, string Name)
		{
			this.Interest = Interest;
			this.Gender = Gender;
			this.Age = Age;
			this.Name = Name;
		}

		public Person(string Name, int Age, string Interest)
		{
			this.Name = Name;
			this.Age = Age;
			this.Gender = "Unknown";
			this.Interest = Interest;
		}

		//Getter and setter methods that enforce data encapsulation
		//public void setName(string name)
		//{

		//	this.name =name;
		//}

		//public string getName()
		//{
		//	return name;
		//}

		//public void setAge(int aAge)
		//{

		//	alterAge(aAge);
		//}

		//public int getAge()
		//{
		//	return age;
		//}

		//public void setGender(string gend)
		//{
		//	gender = gend;
		//}

		//public string getGender()
		//{
		//	return gender;
		//}

		//public void setInterest(string interest)
		//{
		//	this.interest = interest;
		//}

		//public string getInterest()
		//{
		//	return interest;
		//}

		//Working methods
		public void bio()
		{
			Console.WriteLine($"{Name} is {Age} years old.  They like {Interest}");
		}

		public void Greeting()
		{
			Console.WriteLine($"Hi! I'm {Name}");
		}

		public override string ToString()
		{
			return String.Format($"{Name} is {Age} years old and gender is {Gender}.  They like {Interest}");
		}



	}


}