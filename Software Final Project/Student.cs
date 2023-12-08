using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Final_Project
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }
        public string ProgramOfStudy { get; set; }
        public int CreditsEarned { get; set; }
        public DateTime DateAdded { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string SecondaryEmailAddress { get; set; }
        public int EmergencyContactNumber { get; set; }
        public string EmergencyContactName { get; set; }
        public int HealthCareNumber { get; set; }
        public int PrivilegeLevel { get; set; }
        public List<string> Scholarships { get; set; }
        public List<string> CoursesTaken { get; set; }
        public List<string> CoursesEnrolled { get; set; }
        public List<string> PreviousAcademicRecord { get; set; }

        // Constructor
        public Student(string firstName, string lastName, int studentID, string programOfStudy, int creditsEarned, DateTime dateAdded,
                       int phoneNumber, string emailAddress, string secondaryEmailAddress, int emergencyContactNumber,
                       string emergencyContactName, int healthCareNumber, int privilegeLevel)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = studentID;
            ProgramOfStudy = programOfStudy;
            CreditsEarned = creditsEarned;
            DateAdded = dateAdded;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            SecondaryEmailAddress = secondaryEmailAddress;
            EmergencyContactNumber = emergencyContactNumber;
            EmergencyContactName = emergencyContactName;
            HealthCareNumber = healthCareNumber;
            PrivilegeLevel = privilegeLevel;
            Scholarships = new List<string>();
            CoursesTaken = new List<string>();
            CoursesEnrolled = new List<string>();
            PreviousAcademicRecord = new List<string>();
        }
    }
}
