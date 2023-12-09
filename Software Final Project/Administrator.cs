using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Final_Project
{
	public class Administrator
	{
		public string FirstName { get; }
		public string LastName { get; }
		public int AdminID { get; }
		public int PhoneNumber { get; }
		public string EmailAddress { get; }
		public int PrivilegeLevel { get; }

		public Administrator(string firstName, string lastName, int adminId, int phoneNumber, string emailAddress)
		{
			FirstName = firstName;
			LastName = lastName;
			AdminID = adminId;
			PhoneNumber = phoneNumber;
			EmailAddress = emailAddress;
			PrivilegeLevel = 1;
		}
	}
}
