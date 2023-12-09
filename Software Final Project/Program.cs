using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Final_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
			
				UserDB userDB = new UserDB();

				userDB.CreateInstructor("John", "Doe", 101, "Faculty123", 1234567890, "john@example.com");

				userDB.CreateAdministrator("Alice", "Smith", 201, 987654321, "alice@example.com");

				userDB.CreateStudent("Emma", "Johnson", 301, DateTime.Now, 555666777, "emma@example.com", "emma.secondary@example.com", 999888777, "Mary Johnson", 123456);

				userDB.CreateSession(1, 101, DateTime.Now, (int)UserPrivilege.Admin);

				CourseDB courseDB = new CourseDB();

				courseDB.CreateCourse(UserPrivilege.Admin, "Math", 501, "101");

				courseDB.DeleteCourse(UserPrivilege.Instructor, 501);

				ScheduleDB scheduleDB = new ScheduleDB();

				scheduleDB.AddSchedule((int)UserPrivilege.Admin, "Schedule101", "Spring2023");

				scheduleDB.ViewSchedule((int)UserPrivilege.Instructor, "Schedule101");

				scheduleDB.RemoveSchedule((int)UserPrivilege.Admin, "Schedule101");

				userDB.ViewUser(301);

				userDB.EditUser(301);
			}
		}

		public enum UserPrivilege
		{
			Admin = 1,
			Instructor = 2,
			Student = 3
		}

}
