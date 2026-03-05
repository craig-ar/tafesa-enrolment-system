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
        public DateTime DateRegistered{ get; set; }

        // a list of enrollments is used so that a student can enrol in multiple subjects:
        public List<Enrollment> Enrollments { get; set; }


        // StudentID only constructor
        public Student(string studentID) :base()
        {
            StudentID = studentID;
            Program = "No Program";
            DateRegistered = DateTime.Now;
            // an empty list of enrollments is created
            Enrollments = new List<Enrollment>();
            
        }

        // no-arg constructor
        //  chains to StudentID only constructor
        public Student() : this("No ID")
        {
        }

        // all-arg constructor
        //   Enrolment is not passed through constructor
        //   (a student can exist without being enrolled in any subjects)
        
        public Student(string studentID, string program, DateTime dateRegistered, string name, string email, string phoneNumber, Address address )
            : base(name, email, phoneNumber, address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            // an empty list of enrollments is created
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
            }// prints student details in a logical order
            //   (student ID first, then name & address details, then program, date and enrolments
            return $"StudentID: {StudentID}, Name: {Name}, Email: {Email}, Phone Number: {PhoneNumber}, Address: {Address}, Program: {Program} , Date Registered: {DateRegistered}, Enrollments: {subjectsEnrolled}";
        }

    }
}
