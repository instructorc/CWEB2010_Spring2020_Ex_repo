using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunwoody_openhouse_wpf.Models
{
	class Prospective_Student : Student
	{
		//Name	Email	Term_Start	time	number_of_visits

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
