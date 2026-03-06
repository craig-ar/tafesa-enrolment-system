using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafesaEnrolmentSystem.Model
{
    public class Student : Person

    {
        // constants:
        public const string DEFAULT_STUDENT_ID = "No ID";
        public const string DEFAULT_PROGRAM = "No Program";

        public string StudentID { get; set; }
        public string Program { get; set; }
        public DateTime DateRegistered{ get; set; }

        // a list of enrollments is used so that a student can enrol in multiple subjects:
        public List<Enrollment> Enrollments { get; set; }


        // StudentID only constructor
        //   chains to all-arg constructor
        public Student(string studentID) : this(studentID, DEFAULT_PROGRAM, DateTime.Now, DEFAULT_NAME, DEFAULT_EMAIL, DEFAULT_PHONE, new Address())
        {

        }

        // no-arg constructor
        //  chains to all-arg constructor
        public Student() : this(DEFAULT_STUDENT_ID, DEFAULT_PROGRAM, DateTime.Now, DEFAULT_NAME, DEFAULT_EMAIL, DEFAULT_PHONE, new Address())
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
            }
            // print ToString from Person class and then print student details
            return base.ToString() + $", StudentID: {StudentID}, Date Registered: {DateRegistered:dd/MM/yyyy}, Enrollments: {subjectsEnrolled}";
        }

    }
}
