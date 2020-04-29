using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunwoody_openhouse_wpf.Models
{
    class Alumni : Student
    {
		public string Employer { get; set; }
		public string SalaryRange { get; set; }
		public string GradYear { get; set; }

		public Alumni(string Name, string Email, string emp, string sal, string gradYear)
		{
			this.Name = Name;
			this.Email = Email;
			Employer = emp;
			SalaryRange = sal;
			GradYear = gradYear;
		}

    }
}
