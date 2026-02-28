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

        //public Enrollment Enrollment { get; set; }
        public List<Enrollment> Enrollments { get; set; }
       



        // no-arg constructor
        public Student()
        {
            StudentID = "No Code";
            Program = "No Name";
            DateRegistered = null;
            //Enrollment = Enrollment;
            Enrollments = new List<Enrollment>();

        }

        // ToString
        public override string ToString()
        {
            return $"StudentID: {StudentID}, Program: {Program}, Date Registered: {DateRegistered} , Enrollment: {Enrollment}";
        }


        // all-arg constructor
        public Student(string studentID, string program, DateTime dateRegistered, Enrollment enrollment)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            Enrollment = enrollment;

        }

    }
}
