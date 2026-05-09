using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TafesaEnrolmentSystem.Model;
using NUnit.Framework;

namespace TafesaEnrolmentSystem.Tests
{
    public class SinglyLinkedListTests
    
    {
        private SinglyLinkedList<Student> list;

        [SetUp]
        public void Setup()
        {
            list = new SinglyLinkedList<Student>();
            list.AddLast(new Student("111222"));
            list.AddLast(new Student("111333"));
            list.AddLast(new Student("111444"));
        }

        [Test]
        public void AddStudentToHead()
        {
            //SinglyLinkedList<Student> list = new SinglyLinkedList<Student>();

            Student student1 = new Student("200100");

            list.AddFirst(student1);

            Assert.That(list.Head.Value, Is.EqualTo(student1));
        }

        [Test]
        public void AddStudentToTail()
        {
            Student student2 = new Student("300100");
            list.AddLast(student2);
            Assert.That(list.Tail.Value, Is.EqualTo(student2));

        }

        [Test]
        public void FindStudent()
        {
            Student target = new Student("111222");
            bool result = list.Contains(target);
            Assert.That(result, Is.True);
        }

        [Test]
        public void RemoveStudentFromEndOfList()
        {
            list.RemoveLast();
            Assert.That(list.Tail.Value.StudentID, Is.EqualTo("111333"));

        }
    }
}
