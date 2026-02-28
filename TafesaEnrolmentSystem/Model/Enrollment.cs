using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TafesaEnrolmentSystem.Model
{
    public class Enrollment
    {
        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public int Semester { get; set; }

        public Subject Subject { get; set; }


        // no-arg constructor
        public Enrollment()
        {
            DateEnrolled = DateTime.Today;
            Grade = "Not Graded";
            Semester = 1;
            Subject = new Subject();
        }

        // ToString
        public override string ToString()
        {
            return $"DateEnrolled: {DateEnrolled}, Grade: {Grade}, Semester: {Semester}, Subject {Subject}";
        }


        // all-arg constructor
        public Enrollment(DateTime dateEnrolled, string grade, int semester, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }
    }
}
