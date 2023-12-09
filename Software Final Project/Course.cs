using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Final_Project
{
	public class Course
	{
		public string CourseName { get; set; }
		public int CourseID { get; set; }
		public string InstructorID { get; set; }
		public List<string> Students { get; set; }
		public DateTime RegistrationDateStart { get; set; }
		public DateTime RegistrationDateEnd { get; set; }
		public string PreRequisites { get; set; }
		public string BlocksAvailable { get; set; }

		public Course(string courseName, int courseId, string instructorId)
		{
			CourseName = courseName;
			CourseID = courseId;
			InstructorID = instructorId;
			Students = new List<string>();
		}
	}
}
