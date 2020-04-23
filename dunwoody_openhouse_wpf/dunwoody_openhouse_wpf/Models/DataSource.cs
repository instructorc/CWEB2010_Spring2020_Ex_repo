using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunwoody_openhouse_wpf.Models
{
    class DataSource
    {
		//DECLARATIONS
		const string PATH = @"C:\Users\fulchr\Desktop\CWEB2010_Spring2020\Console_Dunwoody_Openhouse\Console_Dunwoody_Openhouse\prospective_student.csv";

		//FileStream input;
		//StreamReader read;
		string line;
		string[] data;
		List<Prospective_Student> prospectList; //Global


		/**Mehod that reads the data into my program **/
		public List<Prospective_Student> readData()
		{
			string line;
			string[] data;
			List<Prospective_Student> prospectList = null; //Local
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
					Console.WriteLine(prospectList[prospectList.Count - 1]);

					//line = read.ReadLine(); //primer


				}

				read.Dispose();
				input.Dispose();

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			return prospectList;

		}//End of readData() method

		public void writeData(List<Prospective_Student> prospectList)
		{
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

		}//End of writeData
	}
}
