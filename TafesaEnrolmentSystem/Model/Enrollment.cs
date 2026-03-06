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
        public const string DEFAULT_GRADE = "Not Graded";
        public const int DEFAULT_SEMESTER = 1;


        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public int Semester { get; set; }

        public Subject Subject { get; set; }


        // no-arg constructor
        public Enrollment() : this (DateTime.Now, DEFAULT_GRADE, DEFAULT_SEMESTER, new Subject())
        {

        }

        // all-arg constructor
        public Enrollment(DateTime dateEnrolled, string grade, int semester, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }

        // ToString
        public override string ToString()
        {
            return $"DateEnrolled: {DateEnrolled:dd/MM/yyyy}, Grade: {Grade}, Semester: {Semester}, Subject: {Subject}";
        }


        
    }
}
