using System;

namespace inheritance_ex
{
    class Program
    {
        static void Main(string[] args)
        {
			Profile aProfile = new Profile("Bob","C","asdf@dunwoody.edu",23232323, "Active", "Nord Haus");


			Console.WriteLine(aProfile);

			/**PropertyAgent anAgent = new PropertyAgent();
			anAgent.FirstName = "Bri";
			anAgent.LastName = "Ch";
			anAgent.Email = "asasdf@dunwoody.edu";
			anAgent.Phone = 23233323;
			anAgent.AssociatedYearCount = "12yrs.";
			Console.WriteLine(anAgent);**/

		}

    }
	abstract class User
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public int Phone { get; set; }

		/**Constructor**/
		public User(string Fname, string Lname, string Email, int Phone)
		{
			this.FirstName = Fname;
			this.LastName = Lname;
			this.Email = Email;
			this.Phone = Phone;

		}

		public abstract void formatPhone();
		
	}

	class Profile : User //Syntax for inheritance
	{


		public string AgentStatus { get; set; }
		public string AgentCompanyName { get; set; }

		public Profile(string Fname, string Lname, string Email, int Phone, string agentstatus, string agentCompany) : base(Fname, Lname, Email, Phone)
		{

			AgentStatus = agentstatus;
			AgentCompanyName = agentCompany;
		}

		public override void formatPhone()
		{
			
		}

		public override string ToString()
		{
			return String.Format($"First Name: {FirstName} Last Name: {LastName} " +
				$"Email: {Email}  Agent Status: {AgentStatus} Agent Company: {AgentCompanyName}");
		}
	}

	/**class PropertyAgent : User
	{
		public string AssociatedYearCount { get; set; }
		public override void formatPhone()
		{
			throw new NotImplementedException();
		}
		public override string ToString()
		{
			return String.Format($"First Name: {FirstName} Last Name: {LastName} " +
				$"Email: {Email}  Years Associated with property: {AssociatedYearCount}");
		}
	}**/
}