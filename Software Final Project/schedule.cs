using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Final_Project
{
    public class Schedule : ScheduleDB
    {
        private List<string> courses;
        private int currentUserPrivilege;
        private string ID;
        private string semesterID;

        public Schedule(List<string> courses, int currentUserPrivilege, string ID, string semesterID)
        {
            this.courses = courses;
            this.currentUserPrivilege = currentUserPrivilege;
            this.ID = ID;
            this.semesterID = semesterID;
        }

        public void DisplayScheduleDetails()
        {
            Console.WriteLine($"Schedule ID: {ID}");
            Console.WriteLine($"Semester ID: {semesterID}");
            Console.WriteLine($"Courses: {string.Join(", ", courses)}");
            Console.WriteLine($"Current User Privilege: {currentUserPrivilege}");
        }
    }
}
