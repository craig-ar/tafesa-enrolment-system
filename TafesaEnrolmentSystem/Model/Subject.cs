using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafesaEnrolmentSystem.Model
{
    public class Subject
    {
        public const string DEFAULT_SUBJECT_CODE = "No Code";
        public const string DEFAULT_SUBJECT_NAME = "No Name";
        public const decimal DEFAULT_SUBJECT_COST = 0;
        public string SubjectCode{ get; set; }
        public string SubjectName{ get; set; }
        public decimal Cost { get; set; }



        // no-arg constructor
        public Subject() : this (DEFAULT_SUBJECT_CODE, DEFAULT_SUBJECT_NAME, DEFAULT_SUBJECT_COST)
        {

        }

        // all-arg constructor
        public Subject(string subjectCode, string subjectName, decimal cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;

        }

        // ToString
        public override string ToString()
        {
            return $"Subject Code: {SubjectCode}, Subject Name: {SubjectName}, Cost: ${Cost}";
        }


       

    }
}
