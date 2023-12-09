using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Final_Project
{
public class CourseDB
	{
		public List<Course> Courses { get; set; }
		public UserPrivilege CurrentUserPrivilege { get; set; }
		public string NewAttribute3 { get; set; }
		public string NewAttribute4 { get; set; }

		public CourseDB()
		{
			Courses = new List<Course>();
		}

		public void CreateCourse(UserPrivilege currentUserPrivilege, string courseName, int courseId, string instructorId)
		{
			if (currentUserPrivilege == UserPrivilege.Admin || currentUserPrivilege == UserPrivilege.Instructor)
			{
				Course newCourse = new Course(courseName, courseId, instructorId);
				Courses.Add(newCourse);
				Console.WriteLine("Course created successfully!");
			}
			else
			{
				Console.WriteLine("Insufficient privilege to create a course.");
			}
		}

		public void DeleteCourse(UserPrivilege currentUserPrivilege, int courseId)
		{
			if (currentUserPrivilege == UserPrivilege.Admin || currentUserPrivilege == UserPrivilege.Instructor)
			{
				Course courseToDelete = Courses.Find(course => course.CourseID == courseId);
				if (courseToDelete != null)
				{
					Courses.Remove(courseToDelete);
					Console.WriteLine("Course deleted successfully!");
				}
				else
				{
					Console.WriteLine("Course not found.");
				}
			}
			else
			{
				Console.WriteLine("Insufficient privilege to delete a course.");
			}
		}

		internal void CreateCourse(Program.UserPrivilege admin, string v1, int v2, string v3)
		{
			throw new NotImplementedException();
		}
	}
}
