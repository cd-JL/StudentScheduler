using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Final_Project
{
    using System;
    using System.Collections.Generic;

    public class ScheduleDB
    {
        private List<string> schedules;
        private int currentUserPrivilege;
        private List<string> courses;
        private List<string> waitlist;

        public ScheduleDB()
        {
            schedules = new List<string>();
            currentUserPrivilege = 0; // Default privilege level
            courses = new List<string>();
            waitlist = new List<string>();
        }

        public void AddSchedule(int currentUserPrivilege, string scheduleID)
        {
            if (CheckPrivilege(currentUserPrivilege))
            {
                schedules.Add(scheduleID);
                Console.WriteLine($"Schedule {scheduleID} added successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient privileges to add a schedule.");
            }
        }

        public void RemoveSchedule(int currentUserPrivilege, string scheduleID)
        {
            if (CheckPrivilege(currentUserPrivilege))
            {
                if (schedules.Contains(scheduleID))
                {
                    schedules.Remove(scheduleID);
                    Console.WriteLine($"Schedule {scheduleID} removed successfully.");
                }
                else
                {
                    Console.WriteLine($"Schedule {scheduleID} not found.");
                }
            }
            else
            {
                Console.WriteLine("Insufficient privileges to remove a schedule.");
            }
        }

        public void ViewSchedule(int currentUserPrivilege, string scheduleID)
        {
            if (CheckPrivilege(currentUserPrivilege))
            {
                if (schedules.Contains(scheduleID))
                {
                    Console.WriteLine($"Viewing details of schedule {scheduleID}.");
                    // Add code to display details
                }
                else
                {
                    Console.WriteLine($"Schedule {scheduleID} not found.");
                }
            }
            else
            {
                Console.WriteLine("Insufficient privileges to view a schedule.");
            }
        }

        public void EditSchedule(int currentUserPrivilege, string scheduleID)
        {
            if (CheckPrivilege(currentUserPrivilege))
            {
                if (schedules.Contains(scheduleID))
                {
                    Console.WriteLine($"Editing details of schedule {scheduleID}.");
                    // Add code to edit details
                }
                else
                {
                    Console.WriteLine($"Schedule {scheduleID} not found.");
                }
            }
            else
            {
                Console.WriteLine("Insufficient privileges to edit a schedule.");
            }
        }

        public void RemoveCourse(string courseID)
        {
            if (CheckPrivilege(2)) // Example: Require higher privilege level for this operation
            {
                if (courses.Contains(courseID))
                {
                    courses.Remove(courseID);
                    Console.WriteLine($"Course {courseID} removed successfully.");
                }
                else
                {
                    Console.WriteLine($"Course {courseID} not found.");
                }
            }
            else
            {
                Console.WriteLine("Insufficient privileges to remove a course.");
            }
        }

        public void AddCourse(string courseID)
        {
            if (CheckPrivilege(2)) // Example: Require higher privilege level for this operation
            {
                courses.Add(courseID);
                Console.WriteLine($"Course {courseID} added successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient privileges to add a course.");
            }
        }

        public void AddToWaitList(string courseID)
        {
            if (CheckPrivilege(1)) // Example: Require a certain privilege level for this operation
            {
                waitlist.Add(courseID);
                Console.WriteLine($"Added to waitlist: {courseID}");
            }
            else
            {
                Console.WriteLine("Insufficient privileges to add to the waitlist.");
            }
        }

        public void RemoveFromWaitList(string courseID)
        {
            if (CheckPrivilege(1)) // Example: Require a certain privilege level for this operation
            {
                if (waitlist.Contains(courseID))
                {
                    waitlist.Remove(courseID);
                    Console.WriteLine($"Removed from waitlist: {courseID}");
                }
                else
                {
                    Console.WriteLine($"Course {courseID} not found in the waitlist.");
                }
            }
            else
            {
                Console.WriteLine("Insufficient privileges to remove from the waitlist.");
            }
        }

        private bool CheckPrivilege(int requiredPrivilege)
        {
            return currentUserPrivilege >= requiredPrivilege;
        }
    }
}

