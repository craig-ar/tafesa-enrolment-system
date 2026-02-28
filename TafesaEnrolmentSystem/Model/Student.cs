using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafesaEnrolmentSystem.Model
{
    public class Student : Person
    {
        public string StudentID { get; set; }
        public string Program { get; set; }
        public DateTime? DateRegistered{ get; set; }

        public List<Enrollment> Enrollments { get; set; }


        // StudentID only constructor
        public Student(string studentID)
        {
            StudentID = studentID;
            Program = "No Program";
            DateRegistered = DateTime.Now;
            Enrollments = new List<Enrollment>();
        }

        // no-arg constructor
        public Student() : this("No ID")
        {
        }

        // all-arg constructor
        public Student(string studentID, string program, DateTime dateRegistered, Enrollment enrollment)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            Enrollments = new List<Enrollment>();

        }


        // ToString
        public override string ToString()
        {
            // get list of subjects student enrolled in (extract subject names from Enrollments)
            string subjectsEnrolled = "";
            foreach (Enrollment e in Enrollments)
            {
                subjectsEnrolled += e.Subject.SubjectName + ", ";
            }
            return $"StudentID: {StudentID}, Program: {Program} , Date Registered: {DateRegistered}, Enrollments: {subjectsEnrolled}";
        }

    }
}
