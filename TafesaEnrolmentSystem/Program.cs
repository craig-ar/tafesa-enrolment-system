using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TafesaEnrolmentSystem.Model;

namespace TafesaEnrolmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEST ADDRESS CLASS");
            Console.WriteLine("");
            Console.WriteLine("Test no-arg constructor (address1):");
            Address address1 = new Address();
            Console.WriteLine(address1);
            Console.WriteLine("");
            Console.WriteLine("Test all-arg constructor (address2):");
            Address address2 = new Address("100", "Grenfell St", "Adelaide", "5000", "SA");
            Console.WriteLine(address2);
            Console.WriteLine("");
            Console.WriteLine("Test setters/getters (set new values for address1):");
            address1.StreetNum = "50";
            address1.StreetName= "Currie St";
            address1.Suburb = "Adelaide";
            address1.State = "SA";
            address1.Postcode = "5007";
            Console.WriteLine(address1);
            Console.WriteLine("(print postcode with getter): " + address1.Postcode);
            Console.WriteLine("");

            Console.WriteLine("----------------------------"); 
            Console.WriteLine("TEST SUBJECT CLASS:");
            Console.WriteLine("");
            Console.WriteLine("Test no-arg constructor (subject1)");
            Subject subject1 = new Subject();
            Console.WriteLine(subject1);
            Console.WriteLine("");
            Console.WriteLine("Test all-arg constructor (subject2): ");
            Subject subject2 = new Subject("IT_PHP02", "PHP", 570);
            Console.WriteLine(subject2);
            Console.WriteLine("");
            Console.WriteLine("Test setters/getters (change details of subject1):");
            subject1.Cost = 800;
            subject1.SubjectName = "JAVA";
            subject1.SubjectCode = "IT_JAVA02";
            Console.WriteLine(subject1);
            Console.WriteLine("(print subject code with getter): " + subject1.SubjectCode);
            Console.WriteLine("");

            Console.WriteLine("----------------------------"); 
            Console.WriteLine("TEST ENROLLMENT CLASS:");
            Console.WriteLine("");
            Console.WriteLine("Test no-arg constructor(enrollment1)");
            Enrollment enrollment1 = new Enrollment();
            Console.WriteLine(enrollment1);
            Console.WriteLine("");
            Console.WriteLine("Test all-arg constructor (enrollment2):");
            Enrollment enrollment2 = new Enrollment(new DateTime(2026, 2, 28), "PA", 1, subject2);
            Console.WriteLine(enrollment2);
            Console.WriteLine("");
            Console.WriteLine("Test setters/getters (set subject of enrollment1:");
            enrollment1.Subject = subject1;
            Console.WriteLine(enrollment1);
            Console.WriteLine("Print subject using getter: " + enrollment1.Subject);
            Console.WriteLine("");

            Console.WriteLine("----------------------------");
            Console.WriteLine("TEST PERSON CLASS:");
            Console.WriteLine("");
            Console.WriteLine("Test no-arg constructor (person1)");
            Person person1 = new Person();
            Console.WriteLine(person1);
            Console.WriteLine("");
            Console.WriteLine("Test all-arg constructor (person2)");
            Person person2 = new Person("Frank Smith", "fsmith@gmail.com", "0400 666 777", address2);
            Console.WriteLine(person2);
            Console.WriteLine("");
            Console.WriteLine("Test setters/getters (change details of person1):");
            person1.Name = "Danny Smithson";
            person1.Email = "DannyS@gmail.com";
            person1.PhoneNumber = "0411 222 333";
            person1.Address = address1;
            Console.WriteLine(person1);
            Console.WriteLine("print person1 email using getter: " + person1.Email);
            Console.WriteLine("");
            Console.WriteLine("----------------------------");

            Console.WriteLine("TEST STUDENT CLASS:");
            Console.WriteLine("");
            Console.WriteLine("Test no-arg constructor( student1):");
            Student student1 = new Student();
            Console.WriteLine(student1);
            Console.WriteLine("");
            Console.WriteLine("Test all-arg constructor [including adding two enrollments] (student2):");
            Student student2 = new Student("100600", "DiplomaIT", DateTime.Now, "Craig A", "craiga@gmail.com", "0444 555 999", address1);
            student2.Enrollments.Add(enrollment1);
            student2.Enrollments.Add(new Enrollment(DateTime.Now, "Not Graded", 1, subject2));
            Console.WriteLine(student2);
            Console.WriteLine("");
            Console.WriteLine("Test StudentID only constructor (student3):");
            Student student3 = new Student("100650");
            Console.WriteLine(student3);
            Console.WriteLine("");

            Console.WriteLine("Test setters/getters (change student1 details):");
            student1.StudentID = "999888";
            student1.Name = "Craig B";
            student1.Email = "craig_b@gmail.com";
            student1.PhoneNumber = "0449 000 111";
            student1.Address.StreetNum = "10";
            student1.Address.StreetName = "Rundle Street";
            student1.Address.Suburb = "Adelaide";
            student1.Address.Postcode = "5000";
            student1.Address.State = "SA";
            student1.Program = "Diploma IT";
            Console.WriteLine(student1);
            Console.WriteLine("Print studentID using getter: " + student1.StudentID);


            Console.WriteLine("");
            Console.WriteLine("Test Equals Method:");
            Student student4 = new Student("111111");
            Student student5 = new Student("111111");
            Student student6 = new Student("222222");
            Console.WriteLine("student4 ID = " + student4.StudentID);
            Console.WriteLine("student5 ID = " + student5.StudentID);
            Console.WriteLine("student6 ID = " + student6.StudentID);
            Console.WriteLine("  student4.Equals(student5) [should return True]: " + student4.Equals(student5));
            Console.WriteLine("  student4.Equals(student6) [should return False]: " + student4.Equals(student6));
            Console.WriteLine("  student4.equals(null) [Should return False]: " + student4.Equals(null));
            Console.WriteLine("  student4.Equals(person1) [should return False]: " + student4.Equals(person1));

            Console.WriteLine("  student4 == student5 [should return True]: " + (student4 == student5));
            Console.WriteLine("  student4 == student6 [should return False]: " + (student4 == student6));
            Console.WriteLine("  student4 != student6 [should return True]: " + (student4 != student6));
            Console.WriteLine("  student4 != student5 [should return False]: " + (student4 != student5));

            Console.WriteLine("");

            Console.WriteLine("Test HashCode Method:");
            Console.WriteLine("student4 HashCode = " + student4.GetHashCode());
            Console.WriteLine("student5 HashCode = " + student5.GetHashCode());
            Console.WriteLine("student6 HashCode = " + student6.GetHashCode());

            

        }
    }
}
