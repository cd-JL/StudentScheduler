using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Final_Project
{
	internal class UserDB
	{
		public List<Student> Students { get; set; }
		public List<Administrator> Administrators { get; set; }
		public List<Instructor> Instructors { get; set; }
		public int CurrentUserPrivilege { get; set; }
		public List<int> SessionIDs { get; set; }

		public UserDB()
		{
			Students = new List<Student>();
			Administrators = new List<Administrator>();
			Instructors = new List<Instructor>();
			SessionIDs = new List<int>();
		}

		public void CreateStudent(string firstName, string lastName, int studentId, DateTime dateAdded, int phoneNumber, string emailAddress, string secondaryEmailAddress, int emergencyContactNumber, string emergencyContactName, int healthCareNumber)
		{
			Student newStudent = new Student(firstName, lastName, studentId, dateAdded, phoneNumber, emailAddress, secondaryEmailAddress, emergencyContactNumber, emergencyContactName, healthCareNumber);

			Students.Add(newStudent);

			Console.WriteLine("Student created successfully!");
		}

		public void CreateInstructor(string firstName, string lastName, int instructorId, string facultyId, int phoneNumber, string emailAddress)
		{
			Instructor newInstructor = new Instructor(firstName, lastName, instructorId, facultyId, phoneNumber, emailAddress);

			Instructors.Add(newInstructor);

			Console.WriteLine("Instructor created successfully!");
		}

		public void CreateAdministrator(string firstName, string lastName, int adminId, int phoneNumber, string emailAddress)
		{
			Administrator newAdministrator = new Administrator(firstName, lastName, adminId, phoneNumber, emailAddress);

			Administrators.Add(newAdministrator);

			Console.WriteLine("Administrator created successfully!");
		}

		public void CreateSession(int sessionId, int id, DateTime aliveTime, int currentUserPrivilege)
		{
			SessionIDs.Add(sessionId);

			Console.WriteLine("Session created successfully!");
		}

		public void ViewUser(int ID)
		{
			Console.WriteLine($"Viewing user with ID: {ID}");
		}

		public void EditUser(int ID)
		{
			Console.WriteLine($"Editing user with ID: {ID}");
		}
	}
}
