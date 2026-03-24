using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafesaEnrolmentSystem.Model
{
    public class Student : Person, IComparable<Student>

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
            return base.ToString() + $", StudentID: {StudentID}, Program {Program}, Date Registered: {DateRegistered:dd/MM/yyyy}, Enrollments: {subjectsEnrolled}";
        }

        /// <summary>
        /// determines whether two objects are equal by comparing their StudentID properties
        /// (overrides the default Equals method)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// True if StudentID's are the same, otherwise returns False
        /// </returns>
        public override bool Equals(object obj)
        {
            //check null object to avoid NullReferenceException
            if (obj == null)
                return false;
            // check that both objects are of the same type
            if (obj.GetType() != this.GetType())
                return false;
            Student student = (Student)obj;

            return this.StudentID == student.StudentID;
        }

        /// <summary>
        /// Checks if two Students objects are equal
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns>
        /// True if both Students are equal (same StudentID)
        /// Otherwise return False
        /// </returns>
        public static bool operator ==(Student student1, Student student2)
        {
            return object.Equals(student1, student2);
        }

        /// <summary>
        /// Checks if two Students objects are not equal
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns>
        /// True if the two students are not equal (different StudentID)
        /// Otherwise return False
        /// </returns>
        public static bool operator !=(Student student1, Student student2)
        {
            return !object.Equals(student1, student2);
        }

        /// <summary>
        /// Checks if student1 is less than student2 (based on StudentID)
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns>
        /// true if student1 is less than student 2
        /// otherwise return false
        /// </returns>
        public static bool operator <(Student student1, Student student2)
        {
            return student1.CompareTo(student2) < 0;
        }

        /// <summary>
        /// Checks if student1 is greater than student2 (based on StudentID)
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns>
        /// true if student1 is greater than student 2
        /// otherwise return false
        /// </returns>
        public static bool operator >(Student student1, Student student2)
        {
            return student1.CompareTo(student2) > 0;
        }


        /// <summary>
        /// Overrides hash code
        /// </summary>
        /// <returns>
        /// A hash code for a student based on their StudentID
        /// </returns>
        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }

        /// <summary>
        /// compares this student with another student (based on StudentID)
        /// </summary>
        /// <param name="other"></param>
        /// <returns>
        /// 0 if both students have same StudentID
        /// <0 if this.StudentID is less than other.StudentID
        /// >0 if this.StudentID is greater than other.StudentID 
        /// </returns>
        public int CompareTo(Student other)
        {
            // checks if other object being passed is null
            // null.StudentID would cause an exception
            // a non-null object is considered greater than a null object
            if (other == null)
                return 1;

            return this.StudentID.CompareTo(other.StudentID);
        }

        
    }
}
