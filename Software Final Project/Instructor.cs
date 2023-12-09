using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Final_Project
{
	public class Instructor
	{
		public string FirstName { get; }
		public string LastName { get; }
		public int InstructorID { get; }
		public string FacultyID { get; }
		public int PhoneNumber { get; }
		public string EmailAddress { get; }
		public int PrivilegeLevel { get; }
		public List<string> CoursesTaught { get; }

		public Instructor(string firstName, string lastName, int instructorId, string facultyId, int phoneNumber, string emailAddress)
		{
			FirstName = firstName;
			LastName = lastName;
			InstructorID = instructorId;
			FacultyID = facultyId;
			PhoneNumber = phoneNumber;
			EmailAddress = emailAddress;
			CoursesTaught = new List<string>();
			PrivilegeLevel = 1;
		}
	}
}
