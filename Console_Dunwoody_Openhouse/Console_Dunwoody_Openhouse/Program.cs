using System;
using System.Collections.Generic;
using System.IO;

namespace Console_Dunwoody_Openhouse
{
    class Program
    {
        static void Main(string[] args)
        {

			//DECLARATIONS
			const string PATH = @"C:\Users\fulchr\Desktop\CWEB2010_Spring2020\Console_Dunwoody_Openhouse\Console_Dunwoody_Openhouse\prospective_student.csv";

			//FileStream input;
			//StreamReader read;
			string line;
			string[] data;
			List<Prospective_Student> prospectList = null;

			try
			{
				FileStream input = new FileStream(PATH, FileMode.Open, FileAccess.Read);
				StreamReader read = new StreamReader(input);
				line = read.ReadLine(); //primer
				prospectList = new List<Prospective_Student>();

				//Looping structure that's going to read in all of my records
				while (!read.EndOfStream)
				{
					//Our objective is to read in the records and create object instances
					data = read.ReadLine().Split(',');
					prospectList.Add(new Prospective_Student(data[0], data[1], data[2], data[3], Convert.ToInt32(data[4])));
					Console.WriteLine(prospectList[prospectList.Count-1]);

					//line = read.ReadLine(); //primer


				}

				read.Dispose();
				input.Dispose();

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			//Add a new Object instance
			prospectList.Add(new Prospective_Student("Khali", "khali@dunwoody.edu", "Fall 2018", "Day", 1));


			//Write to a file
			FileStream output = new FileStream(PATH, FileMode.Create, FileAccess.Write);
			StreamWriter write = new StreamWriter(output);
			write.WriteLine("Name,Email,Term_Start,time_of_day,number_of_visits");

			foreach (Prospective_Student x in prospectList)
			{
				//Write out each record
				write.WriteLine($"{x.Name},{x.Email},{x.StartTerm},{x.Time},{x.NumberOfVisits.ToString()}");
			}

			write.Dispose();
			output.Dispose();


		}
    }

	class Prospective_Student
	{
		//Name	Email	Term_Start	time	number_of_visits
		public string Name { get; set; }
		public string Email { get; set; }
		public string StartTerm { get; set; }
		public string Time { get; set; }
		public int NumberOfVisits { get; set; }

		public Prospective_Student(string name, string email, string startTerm, string time, int numOfVisits)
		{
			Name = name;
			Email = email;
			StartTerm = startTerm;
			Time = time;
			NumberOfVisits = numOfVisits;
		}

		//Define a toString method 
		public override string ToString()
		{
			return String.Format($"Welcome, {Name}, Data: Email {Email}, Start Term: {StartTerm}, Time Format: {Time}, Number of visits to Dunwoody {NumberOfVisits}");
		}


	}
}