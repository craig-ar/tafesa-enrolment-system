using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafesaEnrolmentSystem.Model
{
    public class Subject
    {
        public string SubjectCode{ get; set; }
        public string SubjectName{ get; set; }
        public decimal Cost { get; set; }



        // no-arg constructor
        public Subject()
        {
            SubjectCode = "No Code";
            SubjectName = "No Name";
            Cost = 0;

        }

        // ToString
        public override string ToString()
        {
            return $"Subject Code: {SubjectCode}, Subject Name: {SubjectName}, Cost: ${Cost}";
        }


        // all-arg constructor
        public Subject(string subjectCode, string subjectName, decimal cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;

        }

    }
}
