using TafesaEnrolmentSystem.Model;

namespace TafesaEnrolmentSystem.Tests
{
    public class UtilityTests
    {
        public Student[] students;
        public Student[] ascendingArray;
        public Student[] descendingArray;

        [SetUp]
        public void Setup()
        {
            // array containing 10 students (StudentID only constructor)
            students = new Student[]
            {
                new Student("400100"),
                new Student("122444"),
                new Student("987665"),
                new Student("234567"),
                new Student("345678"),
                new Student("557890"),
                new Student("880022"),
                new Student("789012"),
                new Student("678900"),
                new Student("112233")
            };

            // expected sorted array - ascending:
            ascendingArray = new Student[]
            {
                new Student("112233"),
                new Student("122444"),
                new Student("234567"),
                new Student("345678"),
                new Student("400100"),
                new Student("557890"),
                new Student("678900"),
                new Student("789012"),
                new Student("880022"),
                new Student("987665")
            };


            //expected sorted array - decending:
            descendingArray = new Student[]
            {
                new Student("987665"),
                new Student("880022"),
                new Student("789012"),
                new Student("678900"),
                new Student("557890"),
                new Student("400100"),
                new Student("345678"),
                new Student("234567"),
                new Student("122444"),
                new Student("112233")
            };
        }

        [Test]
        public void LinearSearch_StudentFound_ReturnsCorrectIndex()
        {
            var target = new Student("345678");
            int result = Utility.LinearSearchArray(students, target);
            
            // student should be found in index 4
            Assert.That(result, Is.EqualTo(4));

        }

        [Test]
        public void LinearSearch_StudentNotFound_ReturnsMinusOne()
        {
            var target = new Student("999999");
            int result = Utility.LinearSearchArray(students, target);
            // should return -1 (student not found)
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void SelectionSortAssending_SortsStudentsAscendingByStudentID()
        {
            // makes copy of array for sorting (so that it doesn't affect other tests)
            var sortArray = students.ToArray();

            Utility.SelectionSortAscending(sortArray);

            // the actual sorted array should match the expected (pre-sorted) array 
            Assert.That(sortArray, Is.EqualTo(descendingArray));

        }

        [Test]
        public void SelectionSortDesending__SortsStudentsDescendingByStudentID()
        {
            var sortArray = students.ToArray();
            Utility.SelectionSortDescending(sortArray);
            
            // the actual sorted array should match the expected (pre-sorted) array 
            Assert.That(sortArray, Is.EqualTo(ascendingArray));
        }

        [Test]
        public void BinarySearchArray_StudentFound_ReturnsCorrectIndex()
        {
            //  [Note: through my testing I found that the array must be sorted by ascending order]
            //  [a binary search could be written in a way that acccepts descending order]

            //sort
            var sortArray = students.ToArray();
            Utility.SelectionSortAscending(sortArray);

            //search
            var target = new Student("345678");
            int result = Utility.BinarySearchArray(sortArray, target);
            //the target student should be found at index 3
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void BinarySearchArray_StudentNotFound_ReturnsMinusOne()
        {
            //sort
            var sortArray = students.ToArray();
            Utility.SelectionSortAscending(sortArray);

            //search
            var target = new Student("999999");
            int result = Utility.BinarySearchArray(sortArray, target);
            //the target student '999999' does not exist so should return -1
            Assert.That(result, Is.EqualTo(-1));
        }
    }

}